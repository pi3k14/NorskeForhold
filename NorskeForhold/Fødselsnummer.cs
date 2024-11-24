using System;
#if !NET6_0_OR_GREATER
using System.Globalization;
#endif
using System.Linq;

namespace Kodefabrikken.NorskeForhold
{
    /// <summary>
    /// Hjelpeklasse for validering og uthenting av informasjon fra fødselsnummer.
    /// </summary>
    public class Fødselsnummer
    {
        const int antallSifreEksKontrollsifre = 9;
        const int antallSifreEksSisteKontrollsiffer = 10;

        /// <summary>
        /// Biologisk kjønn.
        /// </summary>
        public enum BiologiskKjønn
        {
            /// <summary>
            /// Mann.
            /// </summary>
            Mann,
            /// <summary>
            /// Kvinne
            /// </summary>
            Kvinne
        }

        /// <summary>
        /// Validerer og finner informasjonen i et fødselsnummer.
        /// </summary>
        /// <param name="fødselsnummer">Fødselsnummer, 11 siffer.</param>
        /// <exception cref="ArgumentException">Ved feil format, ugyldige verdier eller kontrollsiffer.</exception>
        public Fødselsnummer(ulong fødselsnummer) : this(fødselsnummer.ToString()) { }

        /// <summary>
        /// Validerer og finner informasjonen i et fødselsnummer.
        /// </summary>
        /// <param name="fødselsnummer">Fødselsnummer, 11 siffer.</param>
        /// <exception cref="ArgumentException">Ved feil format, ugyldige verdier eller kontrollsiffer.</exception>
        public Fødselsnummer(string fødselsnummer)
        {
            fødselsnummer = fødselsnummer.Trim();

            if (fødselsnummer.Length != 11)
            {
                throw new ArgumentException("Fødselsnummer må være 11 tegn langt.");
            }

            if (!fødselsnummer.All(
#if NET7_0_OR_GREATER
                char.IsAsciiDigit
#else
                p => p >= '0' && p <= '9'
#endif
                ))
            {
                throw new ArgumentException("Fødselsnummer må kun inneholde tall.");
            }

            var dato = fødselsnummer.Substring(0, 6);
            if (!
#if NET6_0_OR_GREATER
                DateOnly.TryParseExact(dato, "ddMMyy", out var gyldigDato)
#else
                DateTime.TryParseExact(dato, "ddMMyy", new CultureInfo("nb-NO"), DateTimeStyles.None, out var gyldigDato)
#endif
                )
            {
                throw new ArgumentException("Første seks siffer må være en gyldig dato på ddmmyy format.");
            }
            var år_i_århundret = gyldigDato.Year % 100;
            int individsiffre = int.Parse(fødselsnummer.Substring(6, 3));
            // i >= 0 && i <= 499 kan være født 1900 - 1999, alle årstall i fødselsdato
            if (individsiffre >= 0 && individsiffre <= 499)
            {
                Dato = new
#if NET6_0_OR_GREATER
                    DateOnly(år_i_århundret + 1900, gyldigDato.Month, gyldigDato.Day);
#else
                    DateTime(år_i_århundret + 1900, gyldigDato.Month, gyldigDato.Day);
#endif
            }
            else
            {
                // i >= 500 && i <= 749 kan være født 1854 - 1899, år i fødselsdato >= 54
                if (individsiffre <= 749 && gyldigDato.Year >= 54)
                {
                    Dato = new
#if NET6_0_OR_GREATER
                        DateOnly(år_i_århundret + 1800, gyldigDato.Month, gyldigDato.Day);
#else
                        DateTime(år_i_århundret + 1800, gyldigDato.Month, gyldigDato.Day);
#endif
                }
                else
                {
                    // i >= 500 && i <= 999 kan være født 2000 - 2039, år i fødselsdato <= 39
                    if (gyldigDato.Year <= 39)
                    {
                        Dato = new
#if NET6_0_OR_GREATER
                            DateOnly(år_i_århundret + 2000, gyldigDato.Month, gyldigDato.Day);
#else
                            DateTime(år_i_århundret + 2000, gyldigDato.Month, gyldigDato.Day);
#endif
                    }
                    else
                    {
                        // i >= 900 && i <= 999 kan være født 1940 - 1999, år i fødselsdato >= 40
                        if (individsiffre >= 900)
                        {
                            Dato = new
#if NET6_0_OR_GREATER
                                DateOnly(år_i_århundret + 1900, gyldigDato.Month, gyldigDato.Day);
#else
                                DateTime(år_i_århundret + 1900, gyldigDato.Month, gyldigDato.Day);
#endif
                        }
                        else
                        {
                            // i >= 750 && i <= 999 brukt i særtilfeller før 2000
                            throw new ArgumentException("Ugyldig kombinasjon av årstall og individsiffre.");
                        }
                    }
                }
            }

            Kjønn = int.Parse(fødselsnummer.Substring(8, 1)) % 2 == 0 ? BiologiskKjønn.Kvinne : BiologiskKjønn.Mann;

            var k1 = Kontrollsiffer1(int.Parse(fødselsnummer.Substring(0, 9)));
            if (k1 != (fødselsnummer[9] - '0'))
            {
                throw new ArgumentException("Første kontrollsiffer stemmer ikke.");
            }

            var k2 = Kontrollsiffer2(long.Parse(fødselsnummer.Substring(0, 10)));
            if (k2 != (fødselsnummer[10] - '0'))
            {
                throw new ArgumentException("Andre kontrollsiffer stemmer ikke.");
            }

            Personnummer = int.Parse(fødselsnummer.Substring(6));

            Value = fødselsnummer;
        }

        /// <summary>
        /// Validert fødselsnummer.
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// Dato i fødselsnummer med riktig århundre. Kan være fødsesldato, antatt fødselsår eller registrert dato.
        /// </summary>
        public
#if NET6_0_OR_GREATER
            DateOnly 
#else
            DateTime
#endif
            Dato { get; }

        /// <summary>
        /// Personummeret, dvs. de siste fem siffre i fødselsnummeret.
        /// </summary>
        public int Personnummer { get; }

        /// <summary>
        /// Personens biologiske kjønn.
        /// </summary>
        public BiologiskKjønn Kjønn { get; }

        static readonly byte[] faktorerK1 = { 3, 7, 6, 1, 8, 9, 4, 5, 2 };

        static byte Kontrollsiffer1(int tall)
        {
            byte[] siffre = new byte[antallSifreEksKontrollsifre];

            for (int i = 0; i < antallSifreEksKontrollsifre; i++)
            {
                siffre[(antallSifreEksKontrollsifre - 1) - i] = (byte)(tall % 10);
                tall /= 10;
            }

            int sum = 0;
            for (int i = 0; i < antallSifreEksKontrollsifre; i++)
            {
                sum += (faktorerK1[i] * siffre[i]);
            }

            var k1 = 11 - (sum % 11);
            if (k1 == 11)
            {
                k1 = 0;
            }
            else
            {
                if (k1 == 10)
                {
                    throw new InvalidOperationException("Ugyldig kontrollsiffer");
                }
            }
            return (byte)k1;
        }

        static readonly byte[] faktorerK2 = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };

        static byte Kontrollsiffer2(long tall)
        {
            byte[] siffre = new byte[antallSifreEksSisteKontrollsiffer];

            for (int i = 0; i < antallSifreEksSisteKontrollsiffer; i++)
            {
                siffre[(antallSifreEksSisteKontrollsiffer - 1) - i] = (byte)(tall % 10);
                tall /= 10;
            }

            int sum = 0;
            for (int i = 0; i < antallSifreEksSisteKontrollsiffer; i++)
            {
                sum += (faktorerK2[i] * siffre[i]);
            }

            var k2 = 11 - (sum % 11);
            if (k2 == 11)
            {
                k2 = 0;
            }
            else
            {
                if (k2 == 10)
                {
                    throw new InvalidOperationException("Ugyldig kontrollsiffer");
                }
            }

            return (byte)k2;
        }
    }
}
