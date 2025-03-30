using System.Collections.Generic;
using System.Linq;

namespace Kodefabrikken.NorskeForhold
{
    /// <summary>
    /// Navn og nummer på norske fylker.
    /// </summary>
    public class Fylke
    {
        /// <summary>
        /// 03 Oslo
        /// </summary>
        public static readonly Fylke Oslo = new Fylke(3, "Oslo");

        /// <summary>
        /// 11 Rogaland
        /// </summary>
        public static readonly Fylke Rogaland = new Fylke(11, "Rogaland");

        /// <summary>
        /// 15 Møre og Romsdal
        /// </summary>
        public static readonly Fylke MøreOgRomsdal = new Fylke(15, "Møre og Romsdal");

        /// <summary>
        /// 18 Nordland - Nordlánnda
        /// </summary>
        public static readonly Fylke Nordland = new Fylke(18, "Nordland",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Lulesamisk, "Nordlánnda") });

        /// <summary>
        /// 31 Østfold
        /// </summary>
        public static readonly Fylke Østfold = new Fylke(31, "Østfold");

        /// <summary>
        /// 32 Akershus
        /// </summary>
        public static readonly Fylke Akershus = new Fylke(32, "Akershus");

        /// <summary>
        /// 33 Buskerud
        /// </summary>
        public static readonly Fylke Buskerud = new Fylke(33, "Buskerud");

        /// <summary>
        /// 34 Innlandet
        /// </summary>
        public static readonly Fylke Innlandet = new Fylke(34, "Innlandet");

        /// <summary>
        /// 39 Vestfold
        /// </summary>
        public static readonly Fylke Vestfold = new Fylke(39, "Vestfold");

        /// <summary>
        /// 40 Telemark
        /// </summary>
        public static readonly Fylke Telemark = new Fylke(40, "Telemark");

        /// <summary>
        /// 42 Agder
        /// </summary>
        public static readonly Fylke Agder = new Fylke(42, "Agder");

        /// <summary>
        /// 46 Vestland
        /// </summary>
        public static readonly Fylke Vestland = new Fylke(46, "Vestland");

        /// <summary>
        /// 50 Trøndelag - Trööndelage
        /// </summary>
        public static readonly Fylke Trøndelag = new Fylke(50, "Trøndelag",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Sørsamisk, "Trööndelage") });

        /// <summary>
        /// 55 Troms - Romsa - Tromssa
        /// </summary>
        public static readonly Fylke Troms = new Fylke(55, "Troms",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Nordsamisk, "Romsa"),
                                                    new KeyValuePair<Språk, string>(Språk.Kvensk, "Tromssa") });

        /// <summary>
        /// 56 Finnmark - Finnmárku - Finmarkku
        /// </summary>
        public static readonly Fylke Finnmark = new Fylke(56, "Finnmark",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Nordsamisk, "Finnmárku"),
                                                    new KeyValuePair<Språk, string>(Språk.Kvensk, "Finmarkku")});

        /// <summary>
        /// Alle Norges fylker
        /// </summary>
        public static readonly IEnumerable<Fylke> AlleFylker = new List<Fylke>
        {
            Oslo,
            Rogaland,
            MøreOgRomsdal,
            Nordland,
            Østfold,
            Akershus,
            Buskerud,
            Innlandet,
            Vestfold,
            Telemark,
            Agder,
            Vestland,
            Trøndelag,
            Troms,
            Finnmark
        };

        static readonly IEnumerable<KeyValuePair<Språk, string>> s_tom_språkliste = new List<KeyValuePair<Språk, string>>();

        Fylke(int nummer, string navn, IEnumerable<KeyValuePair<Språk, string>>
#if NET6_0_OR_GREATER
            ? 
#endif
            alternativeNavn = null)
        {
            Nummer = nummer;
            Navn = navn;
            AlternativeNavn = alternativeNavn ?? s_tom_språkliste;
        }

        /// <summary>
        /// Fylkesnummer, alltid to siffer.
        /// D2 format string.
        /// </summary>
        public int Nummer { get; }

        /// <summary>
        /// Fylkesnavn.
        /// </summary>
        public string Navn { get; }

        /// <summary>
        /// Fylkesnavn på andre offisielle språk i Norge.
        /// </summary>
        public IEnumerable<KeyValuePair<Språk, string>> AlternativeNavn { get; }

        /// <summary>
        /// Alle kommuner i fylket.
        /// </summary>
        public IEnumerable<Kommune> Kommuner => Kommune.AlleKommuner.Where(p => p.Nummer / 100 == Nummer);

        /// <summary>
        /// Konstruerer en tekststreng med nummer og alle offisielle navn på fylket.
        /// </summary>
        /// <returns>Navn på fylket inklusive nummer og alternative navn.</returns>
        public override string ToString()
        {
            var retval = $"{Nummer:D2} {Navn}";
            foreach (var item in AlternativeNavn)
            {
                retval += $" - {item.Value}";
            }

            return retval;
        }
    }
}
