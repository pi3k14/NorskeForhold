using System.Collections.Generic;

namespace Kodefabrikken.NorskeForhold
{
    /// <summary>
    /// Offisielle språk i Norge
    /// </summary>
    public class Språk
    {
        /// <summary>
        /// nb, Bokmål
        /// </summary>
        public static readonly Språk Bokmål = new Språk("nb", "Bokmål");

        /// <summary>
        /// nn, Nynorsk
        /// </summary>
        public static readonly Språk Nynorsk = new Språk("nn", "Nynorsk");

        /// <summary>
        /// se, Nordsamisk
        /// </summary>
        public static readonly Språk Nordsamisk = new Språk("se", "Nordsamisk", "Davvisámegiella");

        /// <summary>
        /// smj, Lulesamisk
        /// </summary>
        public static readonly Språk Lulesamisk = new Språk("smj", "Lulesamisk", "Julevsámegiella");

        /// <summary>
        /// sma, Sørsamisk
        /// </summary>
        public static readonly Språk Sørsamisk = new Språk("sma", "Sørsamisk", "Åarjelsaemien");

        /// <summary>
        /// fi, Finsk
        /// </summary>
        public static readonly Språk Finsk = new Språk("fi", "Finsk", "Suomi");

        /// <summary>
        /// fkv, Kvensk
        /// </summary>
        public static readonly Språk Kvensk = new Språk("fkv", "Kvensk", "Kvääni");

        /// <summary>
        /// Alle offisielle språk i Norge
        /// </summary>
        public static readonly IEnumerable<Språk> LovbestemteSpråk = new List<Språk>
        {
            Bokmål,
            Nynorsk,
            Nordsamisk,
            Lulesamisk,
            Sørsamisk,
            Finsk,
            Kvensk
        };

        Språk(string kode, string navn, string
#if NET8_0_OR_GREATER
            ? 
#endif
            innfødtNavn = null)
        {
            Kode = kode;
            Navn = navn;
            InnfødtNavn = innfødtNavn ?? navn;
        }

        /// <summary>
        /// ISO 639 (1, 2 eller 3) kode for språket.
        /// </summary>
        public string Kode { get; }

        /// <summary>
        /// Språkets navn på norsk bokmål.
        /// </summary>
        public string Navn { get; }

        /// <summary>
        /// Språkets navn på eget språk.
        /// </summary>
        public string InnfødtNavn { get; }
    }
}
