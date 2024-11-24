using System;
using System.Linq;

namespace Kodefabrikken.NorskeForhold
{
    /// <summary>
    /// Hjelpeklasse for validering av organisasjonsnummer.
    /// </summary>
    public class Organisasjonsnummer
    {
        const int antallSifreEksKontrollsiffer = 8;

        /// <summary>
        /// Validerer organisasjonsnummer.
        /// </summary>
        /// <param name="organisasjonsnummer">Organisasjonsnummer, 9 siffer.</param>
        /// <exception cref="ArgumentException">Ugyldig format eller kontrollsiffer.</exception>
        public Organisasjonsnummer(uint organisasjonsnummer) : this(organisasjonsnummer.ToString()) { }

        /// <summary>
        /// Validerer organisasjonsnummer.
        /// </summary>
        /// <param name="organisasjonsnummer">Organisasjonsnummer, 9 siffer. Tillater mva angivelse.</param>
        /// <exception cref="ArgumentException">Ugyldig format eller kontrollsiffer.</exception>
        public Organisasjonsnummer(string organisasjonsnummer)
        {
            int pos = organisasjonsnummer.LastIndexOf("MVA"); // tillat MVA notasjon
            if (pos >= 0)
            {
                organisasjonsnummer = organisasjonsnummer.Substring(0, pos);
            }

            organisasjonsnummer = organisasjonsnummer.Trim();

            if (!organisasjonsnummer.All(
#if NET7_0_OR_GREATER
                char.IsAsciiDigit
#else
                p => p >= '0' && p <= '9'
#endif
                ))
            {
                throw new ArgumentException("Organisasjonsnummeret må kun inneholde tall.");
            }

            var k = Kontrollsiffer(int.Parse(organisasjonsnummer.Substring(0, antallSifreEksKontrollsiffer)));
            if (k != (organisasjonsnummer[antallSifreEksKontrollsiffer] - '0'))
            {
                throw new ArgumentException("Kontrollsiffer stemmer ikke.");
            }

            Value = organisasjonsnummer;
        }

        /// <summary>
        /// Validert organisasjonsnummer.
        /// </summary>
        public string Value { get; }

        static readonly byte[] faktorer = { 3, 2, 7, 6, 5, 4, 3, 2 };

        static byte Kontrollsiffer(int tall)
        {
            byte[] siffre = new byte[antallSifreEksKontrollsiffer];

            for (int i = 0; i < antallSifreEksKontrollsiffer; i++)
            {
                siffre[(antallSifreEksKontrollsiffer - 1) - i] = (byte)(tall % 10);
                tall /= 10;
            }

            int sum = 0;
            for (int i = 0; i < antallSifreEksKontrollsiffer; i++)
            {
                sum += (faktorer[i] * siffre[i]);
            }

            var k = 11 - (sum % 11);
            if (k == 11)
            {
                k = 0;
            }
            else
            {
                if (k == 10)
                {
                    throw new InvalidOperationException("Ugyldig kontrollsiffer");
                }
            }

            return (byte)k;
        }
    }
}
