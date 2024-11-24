using System.Collections.Generic;
using System.Linq;

namespace Kodefabrikken.NorskeForhold
{
    /// <summary>
    /// Navn og nummer på norsk kommuner.
    /// Bokmål er brukt som identifikator på alle kommuner. Første språkvariant i kommunens navn
    /// er brukt som <see cref="Kommune.Navn"/>, <see cref="Kommune.ToString"/> presenterer alle navn.
    /// </summary>
    public class Kommune
    {
        /// <summary>
        /// 0301 Oslo
        /// </summary>
        public static readonly Kommune Oslo = new Kommune(301, "Oslo");


        // Rogaland ----

        /// <summary>
        /// 1101 Eigersund
        /// </summary>
        public static readonly Kommune Eigersund = new Kommune(1101, "Eigersund");

        /// <summary>
        /// 1103 Stavanger
        /// </summary>
        public static readonly Kommune Stavanger = new Kommune(1103, "Stavanger");

        /// <summary>
        /// 1106 Haugesund
        /// </summary>
        public static readonly Kommune Haugesund = new Kommune(1106, "Haugesund");

        /// <summary>
        /// 1108 Sandnes
        /// </summary>
        public static readonly Kommune Sandnes = new Kommune(1108, "Sandnes");

        /// <summary>
        /// 1111 Sokndal
        /// </summary>
        public static readonly Kommune Sokndal = new Kommune(1111, "Sokndal");

        /// <summary>
        /// 1112 Lund
        /// </summary>
        public static readonly Kommune Lund = new Kommune(1112, "Lund");

        /// <summary>
        /// 1114 Bjerkreim
        /// </summary>
        public static readonly Kommune Bjerkreim = new Kommune(1114, "Bjerkreim");

        /// <summary>
        /// 1119 Hå
        /// </summary>
        public static readonly Kommune Hå = new Kommune(1119, "Hå");

        /// <summary>
        /// 1120 Klepp
        /// </summary>
        public static readonly Kommune Klepp = new Kommune(1120, "Klepp");

        /// <summary>
        /// 1121 Time
        /// </summary>
        public static readonly Kommune Time = new Kommune(1121, "Time");

        /// <summary>
        /// 1122 Gjesdal
        /// </summary>
        public static readonly Kommune Gjesdal = new Kommune(1122, "Gjesdal");

        /// <summary>
        /// 1124 Sola
        /// </summary>
        public static readonly Kommune Sola = new Kommune(1124, "Sola");

        /// <summary>
        /// 1127 Randaberg
        /// </summary>
        public static readonly Kommune Randaberg = new Kommune(1127, "Randaberg");

        /// <summary>
        /// 1130 Strand
        /// </summary>
        public static readonly Kommune Strand = new Kommune(1130, "Strand");

        /// <summary>
        /// 1133 Hjelmeland
        /// </summary>
        public static readonly Kommune Hjelmeland = new Kommune(1133, "Hjelmeland");

        /// <summary>
        /// 1134 Suldal
        /// </summary>
        public static readonly Kommune Suldal = new Kommune(1134, "Suldal");

        /// <summary>
        /// 1135 Sauda
        /// </summary>
        public static readonly Kommune Sauda = new Kommune(1135, "Sauda");

        /// <summary>
        /// 1144 Kvitsøy
        /// </summary>
        public static readonly Kommune Kvitsøy = new Kommune(1144, "Kvitsøy");

        /// <summary>
        /// 1145 Bokn
        /// </summary>
        public static readonly Kommune Bokn = new Kommune(1145, "Bokn");

        /// <summary>
        /// 1146 Tysvær
        /// </summary>
        public static readonly Kommune Tysvær = new Kommune(1146, "Tysvær");

        /// <summary>
        /// 1149 Karmøy
        /// </summary>
        public static readonly Kommune Karmøy = new Kommune(1149, "Karmøy");

        /// <summary>
        /// 1151 Utsira
        /// </summary>
        public static readonly Kommune Utsira = new Kommune(1151, "Utsira");

        /// <summary>
        /// 1160 Vindafjord
        /// </summary>
        public static readonly Kommune Vindafjord = new Kommune(1160, "Vindafjord");


        // Møre og Romsdal ----

        /// <summary>
        /// 1505 Kristiansund
        /// </summary>
        public static readonly Kommune Kristiansund = new Kommune(1505, "Kristiansund");

        /// <summary>
        /// 1506 Molde
        /// </summary>
        public static readonly Kommune Molde = new Kommune(1506, "Molde");

        /// <summary>
        /// 1508 Ålesund
        /// </summary>
        public static readonly Kommune Ålesund = new Kommune(1508, "Ålesund");

        /// <summary>
        /// 1511 Vanylven
        /// </summary>
        public static readonly Kommune Vanylven = new Kommune(1511, "Vanylven");

        /// <summary>
        /// 1514 Sande
        /// </summary>
        public static readonly Kommune Sande = new Kommune(1514, "Sande");

        /// <summary>
        /// 1515 Herøy (Møre og Romsdal)
        /// </summary>
        public static readonly Kommune HerøyMøreOgRomsdal = new Kommune(1515, "Herøy (Møre og Romsdal)");

        /// <summary>
        /// 1516 Ulstein
        /// </summary>
        public static readonly Kommune Ulstein = new Kommune(1516, "Ulstein");

        /// <summary>
        /// 1517 Hareid
        /// </summary>
        public static readonly Kommune Hareid = new Kommune(1517, "Hareid");

        /// <summary>
        /// 1520 Ørsta
        /// </summary>
        public static readonly Kommune Ørsta = new Kommune(1520, "Ørsta");

        /// <summary>
        /// 1525 Stranda
        /// </summary>
        public static readonly Kommune Stranda = new Kommune(1525, "Stranda");

        /// <summary>
        /// 1528 Sykkylven
        /// </summary>
        public static readonly Kommune Sykkylven = new Kommune(1528, "Sykkylven");

        /// <summary>
        /// 1531 Sula
        /// </summary>
        public static readonly Kommune Sula = new Kommune(1531, "Sula");

        /// <summary>
        /// 1532 Giske
        /// </summary>
        public static readonly Kommune Giske = new Kommune(1532, "Giske");

        /// <summary>
        /// 1535 Vestnes
        /// </summary>
        public static readonly Kommune Vestnes = new Kommune(1535, "Vestnes");

        /// <summary>
        /// 1539 Rauma
        /// </summary>
        public static readonly Kommune Rauma = new Kommune(1539, "Rauma");

        /// <summary>
        /// 1547 Aukra
        /// </summary>
        public static readonly Kommune Aukra = new Kommune(1547, "Aukra");

        /// <summary>
        /// 1554 Averøy
        /// </summary>
        public static readonly Kommune Averøy = new Kommune(1554, "Averøy");

        /// <summary>
        /// 1557 Gjemnes
        /// </summary>
        public static readonly Kommune Gjemnes = new Kommune(1557, "Gjemnes");

        /// <summary>
        /// 1560 Tingvoll
        /// </summary>
        public static readonly Kommune Tingvoll = new Kommune(1560, "Tingvoll");

        /// <summary>
        /// 1563 Sunndal
        /// </summary>
        public static readonly Kommune Sunndal = new Kommune(1563, "Sunndal");

        /// <summary>
        /// 1566 Surnadal
        /// </summary>
        public static readonly Kommune Surnadal = new Kommune(1566, "Surnadal");

        /// <summary>
        /// 1573 Smøla
        /// </summary>
        public static readonly Kommune Smøla = new Kommune(1573, "Smøla");

        /// <summary>
        /// 1576 Aure
        /// </summary>
        public static readonly Kommune Aure = new Kommune(1576, "Aure");

        /// <summary>
        /// 1577 Volda
        /// </summary>
        public static readonly Kommune Volda = new Kommune(1577, "Volda");

        /// <summary>
        /// 1578 Fjord
        /// </summary>
        public static readonly Kommune Fjord = new Kommune(1578, "Fjord");

        /// <summary>
        /// 1579 Hustadvika
        /// </summary>
        public static readonly Kommune Hustadvika = new Kommune(1579, "Hustadvika");

        /// <summary>
        /// 1580 Haram
        /// </summary>
        public static readonly Kommune Haram = new Kommune(1580, "Haram");


        // Nordland ----

        /// <summary>
        /// 1804 Bodø
        /// </summary>
        public static readonly Kommune Bodø = new Kommune(1804, "Bodø");

        /// <summary>
        /// 1806 Narvik
        /// </summary>
        public static readonly Kommune Narvik = new Kommune(1806, "Narvik");

        /// <summary>
        /// 1811 Bindal
        /// </summary>
        public static readonly Kommune Bindal = new Kommune(1811, "Bindal");

        /// <summary>
        /// 1812 Sømna
        /// </summary>
        public static readonly Kommune Sømna = new Kommune(1812, "Sømna");

        /// <summary>
        /// 1813 Brønnøy
        /// </summary>
        public static readonly Kommune Brønnøy = new Kommune(1813, "Brønnøy");

        /// <summary>
        /// 1815 Vega
        /// </summary>
        public static readonly Kommune Vega = new Kommune(1815, "Vega");

        /// <summary>
        /// 1816 Vevelstad
        /// </summary>
        public static readonly Kommune Vevelstad = new Kommune(1816, "Vevelstad");

        /// <summary>
        /// 1818 Herøy (Nordland)
        /// </summary>
        public static readonly Kommune HerøyNordland = new Kommune(1818, "Herøy (Nordland)");

        /// <summary>
        /// 1820 Alstahaug
        /// </summary>
        public static readonly Kommune Alstahaug = new Kommune(1820, "Alstahaug");

        /// <summary>
        /// 1822 Leirfjord
        /// </summary>
        public static readonly Kommune Leirfjord = new Kommune(1822, "Leirfjord");

        /// <summary>
        /// 1824 Vefsn
        /// </summary>
        public static readonly Kommune Vefsn = new Kommune(1824, "Vefsn");

        /// <summary>
        /// 1825 Grane
        /// </summary>
        public static readonly Kommune Grane = new Kommune(1825, "Grane");

        /// <summary>
        /// 1826 Aarborte - Hattfjelldal
        /// </summary>
        public static readonly Kommune Hattfjelldal = new Kommune(1826, "Aarborte",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Bokmål, "Hattfjelldal") })
            { SpråkKode = Språk.Sørsamisk };

        /// <summary>
        /// 1827 Dønna
        /// </summary>
        public static readonly Kommune Dønna = new Kommune(1827, "Dønna");

        /// <summary>
        /// 1828 Nesna
        /// </summary>
        public static readonly Kommune Nesna = new Kommune(1828, "Nesna");

        /// <summary>
        /// 1832 Hemnes
        /// </summary>
        public static readonly Kommune Hemnes = new Kommune(1832, "Hemnes");

        /// <summary>
        /// 1833 Rana
        /// </summary>
        public static readonly Kommune Rana = new Kommune(1833, "Rana");

        /// <summary>
        /// 1834 Lurøy
        /// </summary>
        public static readonly Kommune Lurøy = new Kommune(1834, "Lurøy");

        /// <summary>
        /// 1835 Træna
        /// </summary>
        public static readonly Kommune Træna = new Kommune(1835, "Træna");

        /// <summary>
        /// 1836 Rødøy
        /// </summary>
        public static readonly Kommune Rødøy = new Kommune(1836, "Rødøy");

        /// <summary>
        /// 1837 Meløy
        /// </summary>
        public static readonly Kommune Meløy = new Kommune(1837, "Meløy");

        /// <summary>
        /// 1838 Gildeskål
        /// </summary>
        public static readonly Kommune Gildeskål = new Kommune(1838, "Gildeskål");

        /// <summary>
        /// 1839 Beiarn
        /// </summary>
        public static readonly Kommune Beiarn = new Kommune(1839, "Beiarn");

        /// <summary>
        /// 1840 Saltdal
        /// </summary>
        public static readonly Kommune Saltdal = new Kommune(1840, "Saltdal");

        /// <summary>
        /// 1841 Fauske - Fuosko
        /// </summary>
        public static readonly Kommune Fauske = new Kommune(1841, "Fauske",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Lulesamisk, "Fuosko") });
        // eller Fuossko (det siste er bynavnet sier de som kan språket, men SSB insisterer)

        /// <summary>
        /// 1845 Sørfold
        /// </summary>
        public static readonly Kommune Sørfold = new Kommune(1845, "Sørfold");

        /// <summary>
        /// 1848 Steigen
        /// </summary>
        public static readonly Kommune Steigen = new Kommune(1848, "Steigen");

        /// <summary>
        /// 1851 Lødingen
        /// </summary>
        public static readonly Kommune Lødingen = new Kommune(1851, "Lødingen");

        /// <summary>
        /// 1853 Evenes - Evenášši
        /// </summary>
        public static readonly Kommune Evenes = new Kommune(1853, "Evenes",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Nordsamisk, "Evenášši") });

        /// <summary>
        /// 1856 Røst
        /// </summary>
        public static readonly Kommune Røst = new Kommune(1856, "Røst");

        /// <summary>
        /// 1857 Værøy
        /// </summary>
        public static readonly Kommune Værøy = new Kommune(1857, "Værøy");

        /// <summary>
        /// 1859 Flakstad
        /// </summary>
        public static readonly Kommune Flakstad = new Kommune(1859, "Flakstad");

        /// <summary>
        /// 1860 Vestvågøy
        /// </summary>
        public static readonly Kommune Vestvågøy = new Kommune(1860, "Vestvågøy");

        /// <summary>
        /// 1865 Vågan
        /// </summary>
        public static readonly Kommune Vågan = new Kommune(1865, "Vågan");

        /// <summary>
        /// 1866 Bø
        /// </summary>
        public static readonly Kommune Bø = new Kommune(1866, "Bø");

        /// <summary>
        /// 1867 Hadsel
        /// </summary>
        public static readonly Kommune Hadsel = new Kommune(1867, "Hadsel");

        /// <summary>
        /// 1868 Øksnes
        /// </summary>
        public static readonly Kommune Øksnes = new Kommune(1868, "Øksnes");

        /// <summary>
        /// 1870 Sortland - Suortá
        /// </summary>
        public static readonly Kommune Sortland = new Kommune(1870, "Sortland",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Nordsamisk, "Suortá") });

        /// <summary>
        /// 1871 Andøy
        /// </summary>
        public static readonly Kommune Andøy = new Kommune(1871, "Andøy");

        /// <summary>
        /// 1874 Moskenes
        /// </summary>
        public static readonly Kommune Moskenes = new Kommune(1874, "Moskenes");

        /// <summary>
        /// 1875 Hábmer - Hamarøy
        /// </summary>
        public static readonly Kommune Hamarøy = new Kommune(1875, "Hábmer",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Bokmål, "Hamarøy") })
            { SpråkKode = Språk.Lulesamisk };


        // Østfold ----

        /// <summary>
        /// 3101 Halden
        /// </summary>
        public static readonly Kommune Halden = new Kommune(3101, "Halden");

        /// <summary>
        /// 3103 Moss
        /// </summary>
        public static readonly Kommune Moss = new Kommune(3103, "Moss");

        /// <summary>
        /// 3105 Sarpsborg
        /// </summary>
        public static readonly Kommune Sarpsborg = new Kommune(3105, "Sarpsborg");

        /// <summary>
        /// 3107 Fredrikstad
        /// </summary>
        public static readonly Kommune Fredrikstad = new Kommune(3107, "Fredrikstad");

        /// <summary>
        /// 3110 Hvaler
        /// </summary>
        public static readonly Kommune Hvaler = new Kommune(3110, "Hvaler");

        /// <summary>
        /// 3112 Råde
        /// </summary>
        public static readonly Kommune Råde = new Kommune(3112, "Råde");

        /// <summary>
        /// 3114 Våler
        /// </summary>
        public static readonly Kommune Våler = new Kommune(3114, "Våler");

        /// <summary>
        /// 3116 Skiptvet
        /// </summary>
        public static readonly Kommune Skiptvet = new Kommune(3116, "Skiptvet");

        /// <summary>
        /// 3118 Indre Østfold
        /// </summary>
        public static readonly Kommune IndreØstfold = new Kommune(3118, "Indre Østfold");

        /// <summary>
        /// 3120 Rakkestad
        /// </summary>
        public static readonly Kommune Rakkestad = new Kommune(3120, "Rakkestad");

        /// <summary>
        /// 3122 Marker
        /// </summary>
        public static readonly Kommune Marker = new Kommune(3122, "Marker");

        /// <summary>
        /// 3124 Aremark
        /// </summary>
        public static readonly Kommune Aremark = new Kommune(3124, "Aremark");


        // Akershus ----

        /// <summary>
        /// 3201 Bærum
        /// </summary>
        public static readonly Kommune Bærum = new Kommune(3201, "Bærum");

        /// <summary>
        /// 3203 Asker
        /// </summary>
        public static readonly Kommune Asker = new Kommune(3203, "Asker");

        /// <summary>
        /// 3205 Lillestrøm
        /// </summary>
        public static readonly Kommune Lillestrøm = new Kommune(3205, "Lillestrøm");

        /// <summary>
        /// 3207 Nodre Follo
        /// </summary>
        public static readonly Kommune NordreFollo = new Kommune(3207, "Nordre Follo");

        /// <summary>
        /// 3209 Ullensaker
        /// </summary>
        public static readonly Kommune Ullensaker = new Kommune(3209, "Ullensaker");

        /// <summary>
        /// 3212 Nesodden
        /// </summary>
        public static readonly Kommune Nesodden = new Kommune(3212, "Nesodden");

        /// <summary>
        /// 3214 Frogn
        /// </summary>
        public static readonly Kommune Frogn = new Kommune(3214, "Frogn");

        /// <summary>
        /// 3216 Vestby
        /// </summary>
        public static readonly Kommune Vestby = new Kommune(3216, "Vestby");

        /// <summary>
        /// 3218 Ås
        /// </summary>
        public static readonly Kommune Ås = new Kommune(3218, "Ås");

        /// <summary>
        /// 3220 Enebakk
        /// </summary>
        public static readonly Kommune Enebakk = new Kommune(3220, "Enebakk");

        /// <summary>
        /// 3222 Lørenskog
        /// </summary>
        public static readonly Kommune Lørenskog = new Kommune(3222, "Lørenskog");

        /// <summary>
        /// 3224 Rælingen
        /// </summary>
        public static readonly Kommune Rælingen = new Kommune(3224, "Rælingen");

        /// <summary>
        /// 3226 Aurskog-Høland
        /// </summary>
        public static readonly Kommune AurskogHøland = new Kommune(3226, "Aurskog-Høland");

        /// <summary>
        /// 3228 Nes
        /// </summary>
        public static readonly Kommune Nes = new Kommune(3228, "Nes");

        /// <summary>
        /// 3230 Gjerdrum
        /// </summary>
        public static readonly Kommune Gjerdrum = new Kommune(3230, "Gjerdrum");

        /// <summary>
        /// 3232 Nittedal
        /// </summary>
        public static readonly Kommune Nittedal = new Kommune(3232, "Nittedal");

        /// <summary>
        /// 3234 Lunner
        /// </summary>
        public static readonly Kommune Lunner = new Kommune(3234, "Lunner");

        /// <summary>
        /// 3236 Jevnaker
        /// </summary>
        public static readonly Kommune Jevnaker = new Kommune(3236, "Jevnaker");

        /// <summary>
        /// 3238 Nannestad
        /// </summary>
        public static readonly Kommune Nannestad = new Kommune(3238, "Nannestad");

        /// <summary>
        /// 3240 Eidsvoll
        /// </summary>
        public static readonly Kommune Eidsvoll = new Kommune(3240, "Eidsvoll");

        /// <summary>
        /// 3242 Hurdal
        /// </summary>
        public static readonly Kommune Hurdal = new Kommune(3242, "Hurdal");


        // Buskerud ----

        /// <summary>
        /// 3301 Drammen
        /// </summary>
        public static readonly Kommune Drammen = new Kommune(3301, "Drammen");

        /// <summary>
        /// 3303 Kongsberg
        /// </summary>
        public static readonly Kommune Kongsberg = new Kommune(3303, "Kongsberg");

        /// <summary>
        /// 3305 Ringerike
        /// </summary>
        public static readonly Kommune Ringerike = new Kommune(3305, "Ringerike");

        /// <summary>
        /// 3310 Hole
        /// </summary>
        public static readonly Kommune Hole = new Kommune(3310, "Hole");

        /// <summary>
        /// 3312 Lier
        /// </summary>
        public static readonly Kommune Lier = new Kommune(3312, "Lier");

        /// <summary>
        /// 3314 Øvre Eiker
        /// </summary>
        public static readonly Kommune ØvreEiker = new Kommune(3314, "Øvre Eiker");

        /// <summary>
        /// 3316 Modum
        /// </summary>
        public static readonly Kommune Modum = new Kommune(3316, "Modum");

        /// <summary>
        /// 3318 Krødsherad
        /// </summary>
        public static readonly Kommune Krødsherad = new Kommune(3318, "Krødsherad");

        /// <summary>
        /// 3320 Flå
        /// </summary>
        public static readonly Kommune Flå = new Kommune(3320, "Flå");

        /// <summary>
        /// 3322 Nesbyen
        /// </summary>
        public static readonly Kommune Nesbyen = new Kommune(3322, "Nesbyen");

        /// <summary>
        /// 3324 Gol
        /// </summary>
        public static readonly Kommune Gol = new Kommune(3324, "Gol");

        /// <summary>
        /// 3326 Hemsedal
        /// </summary>
        public static readonly Kommune Hemsedal = new Kommune(3326, "Hemsedal");

        /// <summary>
        /// 3328 Ål
        /// </summary>
        public static readonly Kommune Ål = new Kommune(3328, "Ål");

        /// <summary>
        /// 3330 Hol
        /// </summary>
        public static readonly Kommune Hol = new Kommune(3330, "Hol");

        /// <summary>
        /// 3332 Sigdal
        /// </summary>
        public static readonly Kommune Sigdal = new Kommune(3332, "Sigdal");

        /// <summary>
        /// 3334 Flesberg
        /// </summary>
        public static readonly Kommune Flesberg = new Kommune(3334, "Flesberg");

        /// <summary>
        /// 3336 Rollag
        /// </summary>
        public static readonly Kommune Rollag = new Kommune(3336, "Rollag");

        /// <summary>
        /// 3338 Nore og Uvdal
        /// </summary>
        public static readonly Kommune NoreOgUvdal = new Kommune(3338, "Nore og Uvdal");


        // Innlandet ----

        /// <summary>
        /// 3401 Kongsvinger
        /// </summary>
        public static readonly Kommune Kongsvinger = new Kommune(3401, "Kongsvinger");

        /// <summary>
        /// 3403 Hamar
        /// </summary>
        public static readonly Kommune Hamar = new Kommune(3403, "Hamar");

        /// <summary>
        /// 3405 Lillehammer
        /// </summary>
        public static readonly Kommune Lillehammer = new Kommune(3405, "Lillehammer");

        /// <summary>
        /// 3407 Gjøvik
        /// </summary>
        public static readonly Kommune Gjøvik = new Kommune(3407, "Gjøvik");

        /// <summary>
        /// 3411 Ringsaker
        /// </summary>
        public static readonly Kommune Ringsaker = new Kommune(3411, "Ringsaker");

        /// <summary>
        /// 3412 Løten
        /// </summary>
        public static readonly Kommune Løten = new Kommune(3412, "Løten");

        /// <summary>
        /// 3413 Stange
        /// </summary>
        public static readonly Kommune Stange = new Kommune(3413, "Stange");

        /// <summary>
        /// 3414 Nord-Odal
        /// </summary>
        public static readonly Kommune NordOdal = new Kommune(3414, "Nord-Odal");

        /// <summary>
        /// 3415 Sør-Odal
        /// </summary>
        public static readonly Kommune SørOdal = new Kommune(3415, "Sør-Odal");

        /// <summary>
        /// 3416 Eidskog
        /// </summary>
        public static readonly Kommune Eidskog = new Kommune(3416, "Eidskog");

        /// <summary>
        /// 3417 Grue
        /// </summary>
        public static readonly Kommune Grue = new Kommune(3417, "Grue");

        /// <summary>
        /// 3418 Åsnes
        /// </summary>
        public static readonly Kommune Åsnes = new Kommune(3418, "Åsnes");

        /// <summary>
        /// 3419 Våler (Innlandet)
        /// </summary>
        public static readonly Kommune VålerInnlandet = new Kommune(3419, "Våler (Innlandet)");

        /// <summary>
        /// 3420 Elverum
        /// </summary>
        public static readonly Kommune Elverum = new Kommune(3420, "Elverum");

        /// <summary>
        /// 3421 Trysil
        /// </summary>
        public static readonly Kommune Trysil = new Kommune(3421, "Trysil");

        /// <summary>
        /// 3422 Åmot
        /// </summary>
        public static readonly Kommune Åmot = new Kommune(3422, "Åmot");

        /// <summary>
        /// 3423 Stor-Elvdal
        /// </summary>
        public static readonly Kommune StorElvdal = new Kommune(3423, "Stor-Elvdal");

        /// <summary>
        /// 3424 Rendalen
        /// </summary>
        public static readonly Kommune Rendalen = new Kommune(3424, "Rendalen");

        /// <summary>
        /// 3425 Engerdal
        /// </summary>
        public static readonly Kommune Engerdal = new Kommune(3425, "Engerdal");

        /// <summary>
        /// 3426 Tolga
        /// </summary>
        public static readonly Kommune Tolga = new Kommune(3426, "Tolga");

        /// <summary>
        /// 3427 Tynset
        /// </summary>
        public static readonly Kommune Tynset = new Kommune(3427, "Tynset");

        /// <summary>
        /// 3428 Alvdal
        /// </summary>
        public static readonly Kommune Alvdal = new Kommune(3428, "Alvdal");

        /// <summary>
        /// 3429 Folldal
        /// </summary>
        public static readonly Kommune Folldal = new Kommune(3429, "Folldal");

        /// <summary>
        /// 3430 Os
        /// </summary>
        public static readonly Kommune Os = new Kommune(3430, "Os");

        /// <summary>
        /// 3431 Dovre
        /// </summary>
        public static readonly Kommune Dovre = new Kommune(3431, "Dovre");

        /// <summary>
        /// 3432 Lesja
        /// </summary>
        public static readonly Kommune Lesja = new Kommune(3432, "Lesja");

        /// <summary>
        /// 3433 Skjåk
        /// </summary>
        public static readonly Kommune Skjåk = new Kommune(3433, "Skjåk");

        /// <summary>
        /// 3434 Lom
        /// </summary>
        public static readonly Kommune Lom = new Kommune(3434, "Lom");

        /// <summary>
        /// 3435 Vågå
        /// </summary>
        public static readonly Kommune Vågå = new Kommune(3435, "Vågå");

        /// <summary>
        /// 3436 Nord-Fron
        /// </summary>
        public static readonly Kommune NordFron = new Kommune(3436, "Nord-Fron");

        /// <summary>
        /// 3437 Sel
        /// </summary>
        public static readonly Kommune Sel = new Kommune(3437, "Sel");

        /// <summary>
        /// 3438 Sør-Fron
        /// </summary>
        public static readonly Kommune SørFron = new Kommune(3438, "Sør-Fron");

        /// <summary>
        /// 3439 Ringebu
        /// </summary>
        public static readonly Kommune Ringebu = new Kommune(3439, "Ringebu");

        /// <summary>
        /// 3440 Øyer
        /// </summary>
        public static readonly Kommune Øyer = new Kommune(3440, "Øyer");

        /// <summary>
        /// 3441 Gausdal
        /// </summary>
        public static readonly Kommune Gausdal = new Kommune(3441, "Gausdal");

        /// <summary>
        /// 3442 Østre Toten
        /// </summary>
        public static readonly Kommune ØstreToten = new Kommune(3442, "Østre Toten");

        /// <summary>
        /// 3443 Vestre Toten
        /// </summary>
        public static readonly Kommune VestreToten = new Kommune(3443, "Vestre Toten");

        /// <summary>
        /// 3446 Gran
        /// </summary>
        public static readonly Kommune Gran = new Kommune(3446, "Gran");

        /// <summary>
        /// 3447 Søndre Land
        /// </summary>
        public static readonly Kommune SøndreLand = new Kommune(3447, "Søndre Land");

        /// <summary>
        /// 3448 Nordre Land
        /// </summary>
        public static readonly Kommune NordreLand = new Kommune(3448, "Nordre Land");

        /// <summary>
        /// 3449 Sør-Aurdal
        /// </summary>
        public static readonly Kommune SørAurdal = new Kommune(3449, "Sør-Aurdal");

        /// <summary>
        /// 3450 Etnedal
        /// </summary>
        public static readonly Kommune Etnedal = new Kommune(3450, "Etnedal");

        /// <summary>
        /// 3451 Nord-Aurdal
        /// </summary>
        public static readonly Kommune NordAurdal = new Kommune(3451, "Nord-Aurdal");

        /// <summary>
        /// 3452 Vestre Slidre
        /// </summary>
        public static readonly Kommune VestreSlidre = new Kommune(3452, "Vestre Slidre");

        /// <summary>
        /// 3453 Øystre Slidre
        /// </summary>
        public static readonly Kommune ØystreSlidre = new Kommune(3453, "Øystre Slidre");

        /// <summary>
        /// 3454 Vang
        /// </summary>
        public static readonly Kommune Vang = new Kommune(3454, "Vang");


        // Vestfold ----

        /// <summary>
        /// 3901 Horten
        /// </summary>
        public static readonly Kommune Horten = new Kommune(3901, "Horten");

        /// <summary>
        /// 3903 Holmestrand
        /// </summary>
        public static readonly Kommune Holmestrand = new Kommune(3903, "Holmestrand");

        /// <summary>
        /// 3905 Tønsberg
        /// </summary>
        public static readonly Kommune Tønsberg = new Kommune(3905, "Tønsberg");

        /// <summary>
        /// 3907 Sandefjord
        /// </summary>
        public static readonly Kommune Sandefjord = new Kommune(3907, "Sandefjord");

        /// <summary>
        /// 3909 Larvik
        /// </summary>
        public static readonly Kommune Larvik = new Kommune(3909, "Larvik");

        /// <summary>
        /// 3911 Færder
        /// </summary>
        public static readonly Kommune Færder = new Kommune(3911, "Færder");


        // Telemark ----

        /// <summary>
        /// 4001 Porsgrunn
        /// </summary>
        public static readonly Kommune Porsgrunn = new Kommune(4001, "Porsgrunn");

        /// <summary>
        /// 4003 Skien
        /// </summary>
        public static readonly Kommune Skien = new Kommune(4003, "Skien");

        /// <summary>
        /// 4005 Notodden
        /// </summary>
        public static readonly Kommune Notodden = new Kommune(4005, "Notodden");

        /// <summary>
        /// 4010 Siljan
        /// </summary>
        public static readonly Kommune Siljan = new Kommune(4010, "Siljan");

        /// <summary>
        /// 4012 Bamble
        /// </summary>
        public static readonly Kommune Bamble = new Kommune(4012, "Bamble");

        /// <summary>
        /// 4014 Kragerø
        /// </summary>
        public static readonly Kommune Kragerø = new Kommune(4014, "Kragerø");

        /// <summary>
        /// 4016 Drangedal
        /// </summary>
        public static readonly Kommune Drangedal = new Kommune(4016, "Drangedal");

        /// <summary>
        /// 4018 Nome
        /// </summary>
        public static readonly Kommune Nome = new Kommune(4018, "Nome");

        /// <summary>
        /// 4020 Midt-Telemark
        /// </summary>
        public static readonly Kommune MidtTelemark = new Kommune(4020, "Midt-Telemark");

        /// <summary>
        /// 4022 Seljord
        /// </summary>
        public static readonly Kommune Seljord = new Kommune(4022, "Seljord");

        /// <summary>
        /// 4024 Hjartdal
        /// </summary>
        public static readonly Kommune Hjartdal = new Kommune(4024, "Hjartdal");

        /// <summary>
        /// 4026 Tinn
        /// </summary>
        public static readonly Kommune Tinn = new Kommune(4026, "Tinn");

        /// <summary>
        /// 4028 Kviteseid
        /// </summary>
        public static readonly Kommune Kviteseid = new Kommune(4028, "Kviteseid");

        /// <summary>
        /// 4030 Nissedal
        /// </summary>
        public static readonly Kommune Nissedal = new Kommune(4030, "Nissedal");

        /// <summary>
        /// 4032 Fyresdal
        /// </summary>
        public static readonly Kommune Fyresdal = new Kommune(4032, "Fyresdal");

        /// <summary>
        /// 4034 Tokke
        /// </summary>
        public static readonly Kommune Tokke = new Kommune(4034, "Tokke");

        /// <summary>
        /// 4036 Vinje
        /// </summary>
        public static readonly Kommune Vinje = new Kommune(4036, "Vinje");


        // Agder ----

        /// <summary>
        /// 4012 Risør
        /// </summary>
        public static readonly Kommune Risør = new Kommune(4201, "Risør");

        /// <summary>
        /// 4202 Grimstad
        /// </summary>
        public static readonly Kommune Grimstad = new Kommune(4202, "Grimstad");

        /// <summary>
        /// 4203 Arendal
        /// </summary>
        public static readonly Kommune Arendal = new Kommune(4203, "Arendal");

        /// <summary>
        /// 4204 Kristiansand
        /// </summary>
        public static readonly Kommune Kristiansand = new Kommune(4204, "Kristiansand");

        /// <summary>
        /// 4205 Lindesnes
        /// </summary>
        public static readonly Kommune Lindesnes = new Kommune(4205, "Lindesnes");

        /// <summary>
        /// 4206 Farsund
        /// </summary>
        public static readonly Kommune Farsund = new Kommune(4206, "Farsund");

        /// <summary>
        /// 4207 Flekkefjord
        /// </summary>
        public static readonly Kommune Flekkefjord = new Kommune(4207, "Flekkefjord");

        /// <summary>
        /// 4211 Gjerstad
        /// </summary>
        public static readonly Kommune Gjerstad = new Kommune(4211, "Gjerstad");

        /// <summary>
        /// 4212 Vegårshei
        /// </summary>
        public static readonly Kommune Vegårshei = new Kommune(4212, "Vegårshei");

        /// <summary>
        /// 4213 Tvedestrand
        /// </summary>
        public static readonly Kommune Tvedestrand = new Kommune(4213, "Tvedestrand");

        /// <summary>
        /// 4214 Froland
        /// </summary>
        public static readonly Kommune Froland = new Kommune(4214, "Froland");

        /// <summary>
        /// 4215 Lillesand
        /// </summary>
        public static readonly Kommune Lillesand = new Kommune(4215, "Lillesand");

        /// <summary>
        /// 4216 Birkenes
        /// </summary>
        public static readonly Kommune Birkenes = new Kommune(4216, "Birkenes");

        /// <summary>
        /// 4217 Åmli
        /// </summary>
        public static readonly Kommune Åmli = new Kommune(4217, "Åmli");

        /// <summary>
        /// 4218 Iveland
        /// </summary>
        public static readonly Kommune Iveland = new Kommune(4218, "Iveland");

        /// <summary>
        /// 4219 Evje og Hornnes
        /// </summary>
        public static readonly Kommune EvjeOgHornnes = new Kommune(4219, "Evje og Hornnes");

        /// <summary>
        /// 4220 Bygland
        /// </summary>
        public static readonly Kommune Bygland = new Kommune(4220, "Bygland");

        /// <summary>
        /// 4221 Valle
        /// </summary>
        public static readonly Kommune Valle = new Kommune(4221, "Valle");

        /// <summary>
        /// 4222 Bykle
        /// </summary>
        public static readonly Kommune Bykle = new Kommune(4222, "Bykle");

        /// <summary>
        /// 4223 Vennesla
        /// </summary>
        public static readonly Kommune Vennesla = new Kommune(4223, "Vennesla");

        /// <summary>
        /// 4224 Åseral
        /// </summary>
        public static readonly Kommune Åseral = new Kommune(4224, "Åseral");

        /// <summary>
        /// 4225 Lyngdal
        /// </summary>
        public static readonly Kommune Lyngdal = new Kommune(4225, "Lyngdal");

        /// <summary>
        /// 4236 Hægbostad
        /// </summary>
        public static readonly Kommune Hægebostad = new Kommune(4236, "Hægebostad");

        /// <summary>
        /// 4227 Kvinesdal
        /// </summary>
        public static readonly Kommune Kvinesdal = new Kommune(4227, "Kvinesdal");

        /// <summary>
        /// 4228 Sirdal
        /// </summary>
        public static readonly Kommune Sirdal = new Kommune(4228, "Sirdal");


        // Vestland ----

        /// <summary>
        /// 4601 Bergen
        /// </summary>
        public static readonly Kommune Bergen = new Kommune(4601, "Bergen");

        /// <summary>
        /// 4602 Kinn
        /// </summary>
        public static readonly Kommune Kinn = new Kommune(4602, "Kinn");

        /// <summary>
        /// 4611 Etne
        /// </summary>
        public static readonly Kommune Etne = new Kommune(4611, "Etne");

        /// <summary>
        /// 4612 Sveio
        /// </summary>
        public static readonly Kommune Sveio = new Kommune(4612, "Sveio");

        /// <summary>
        /// 4613 Bømlo
        /// </summary>
        public static readonly Kommune Bømlo = new Kommune(4613, "Bømlo");

        /// <summary>
        /// 4614 Stord
        /// </summary>
        public static readonly Kommune Stord = new Kommune(4614, "Stord");

        /// <summary>
        /// 4615 Fitjar
        /// </summary>
        public static readonly Kommune Fitjar = new Kommune(4615, "Fitjar");

        /// <summary>
        /// 4616 Tysnes
        /// </summary>
        public static readonly Kommune Tysnes = new Kommune(4616, "Tysnes");

        /// <summary>
        /// 4617 Kvinnherad
        /// </summary>
        public static readonly Kommune Kvinnherad = new Kommune(4617, "Kvinnherad");

        /// <summary>
        /// 4618 Ullensvang
        /// </summary>
        public static readonly Kommune Ullensvang = new Kommune(4618, "Ullensvang");

        /// <summary>
        /// 4619 Eidfjord
        /// </summary>
        public static readonly Kommune Eidfjord = new Kommune(4619, "Eidfjord");

        /// <summary>
        /// 4620 Ulvik
        /// </summary>
        public static readonly Kommune Ulvik = new Kommune(4620, "Ulvik");

        /// <summary>
        /// 4621 Voss
        /// </summary>
        public static readonly Kommune Voss = new Kommune(4621, "Voss");

        /// <summary>
        /// 4622 Kvam
        /// </summary>
        public static readonly Kommune Kvam = new Kommune(4622, "Kvam");

        /// <summary>
        /// 4623 Samnanger
        /// </summary>
        public static readonly Kommune Samnanger = new Kommune(4623, "Samnanger");

        /// <summary>
        /// 4624 Bjørnafjorden
        /// </summary>
        public static readonly Kommune Bjørnafjorden = new Kommune(4624, "Bjørnafjorden");

        /// <summary>
        /// 4625 Austevoll
        /// </summary>
        public static readonly Kommune Austevoll = new Kommune(4625, "Austevoll");

        /// <summary>
        /// 4626 Øygarden
        /// </summary>
        public static readonly Kommune Øygarden = new Kommune(4626, "Øygarden");

        /// <summary>
        /// 4627 Askøy
        /// </summary>
        public static readonly Kommune Askøy = new Kommune(4627, "Askøy");

        /// <summary>
        /// 4628 Vaksdal
        /// </summary>
        public static readonly Kommune Vaksdal = new Kommune(4628, "Vaksdal");

        /// <summary>
        /// 4629 Modalen
        /// </summary>
        public static readonly Kommune Modalen = new Kommune(4629, "Modalen");

        /// <summary>
        /// 4630 Osterøy
        /// </summary>
        public static readonly Kommune Osterøy = new Kommune(4630, "Osterøy");

        /// <summary>
        /// 4631 Alver
        /// </summary>
        public static readonly Kommune Alver = new Kommune(4631, "Alver");

        /// <summary>
        /// 4632 Austrheim
        /// </summary>
        public static readonly Kommune Austrheim = new Kommune(4632, "Austrheim");

        /// <summary>
        /// 4633 Fedje
        /// </summary>
        public static readonly Kommune Fedje = new Kommune(4633, "Fedje");

        /// <summary>
        /// 4634 Masfjorden
        /// </summary>
        public static readonly Kommune Masfjorden = new Kommune(4634, "Masfjorden");

        /// <summary>
        /// 4635 Gulen
        /// </summary>
        public static readonly Kommune Gulen = new Kommune(4635, "Gulen");

        /// <summary>
        /// 4636 Solund
        /// </summary>
        public static readonly Kommune Solund = new Kommune(4636, "Solund");

        /// <summary>
        /// 4637 Hyllestad
        /// </summary>
        public static readonly Kommune Hyllestad = new Kommune(4637, "Hyllestad");

        /// <summary>
        /// 4638 Høyanger
        /// </summary>
        public static readonly Kommune Høyanger = new Kommune(4638, "Høyanger");

        /// <summary>
        /// 4639 Vik
        /// </summary>
        public static readonly Kommune Vik = new Kommune(4639, "Vik");

        /// <summary>
        /// 4640 Sogndal
        /// </summary>
        public static readonly Kommune Sogndal = new Kommune(4640, "Sogndal");

        /// <summary>
        /// 4641 Aurland
        /// </summary>
        public static readonly Kommune Aurland = new Kommune(4641, "Aurland");

        /// <summary>
        /// 4642 Lærdal
        /// </summary>
        public static readonly Kommune Lærdal = new Kommune(4642, "Lærdal");

        /// <summary>
        /// 4643 Årdal
        /// </summary>
        public static readonly Kommune Årdal = new Kommune(4643, "Årdal");

        /// <summary>
        /// 4644 Luster
        /// </summary>
        public static readonly Kommune Luster = new Kommune(4644, "Luster");

        /// <summary>
        /// 4645 Askvoll
        /// </summary>
        public static readonly Kommune Askvoll = new Kommune(4645, "Askvoll");

        /// <summary>
        /// 4646 Fjaler
        /// </summary>
        public static readonly Kommune Fjaler = new Kommune(4646, "Fjaler");

        /// <summary>
        /// 4647 Sunnfjord
        /// </summary>
        public static readonly Kommune Sunnfjord = new Kommune(4647, "Sunnfjord");

        /// <summary>
        /// 4648 Bremanger
        /// </summary>
        public static readonly Kommune Bremanger = new Kommune(4648, "Bremanger");

        /// <summary>
        /// 4649 Stad
        /// </summary>
        public static readonly Kommune Stad = new Kommune(4649, "Stad");

        /// <summary>
        /// 4650 Gloppen
        /// </summary>
        public static readonly Kommune Gloppen = new Kommune(4650, "Gloppen");

        /// <summary>
        /// 4651 Stryn
        /// </summary>
        public static readonly Kommune Stryn = new Kommune(4651, "Stryn");


        // Trøndelag ----

        /// <summary>
        /// 5001 Trondheim - Tråante
        /// </summary>
        public static readonly Kommune Trondheim = new Kommune(5001, "Trondheim",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Sørsamisk, "Tråante") });

        /// <summary>
        /// 5006 Steinkjer
        /// </summary>
        public static readonly Kommune Steinkjer = new Kommune(5006, "Steinkjer");

        /// <summary>
        /// 5007 Namsos
        /// </summary>
        public static readonly Kommune Namsos = new Kommune(5007, "Namsos",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Sørsamisk, "Nåavmesjenjaelmie") });

        /// <summary>
        /// 5014 Frøya
        /// </summary>
        public static readonly Kommune Frøya = new Kommune(5014, "Frøya");

        /// <summary>
        /// 5020 Osen
        /// </summary>
        public static readonly Kommune Osen = new Kommune(5020, "Osen");

        /// <summary>
        /// 5021 Oppdal
        /// </summary>
        public static readonly Kommune Oppdal = new Kommune(5021, "Oppdal");

        /// <summary>
        /// 5022 Rennebu
        /// </summary>
        public static readonly Kommune Rennebu = new Kommune(5022, "Rennebu");

        /// <summary>
        /// 5025 Rosse - Røros
        /// </summary>
        public static readonly Kommune Røros = new Kommune(5025, "Rosse",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Bokmål, "Røros") })
            { SpråkKode = Språk.Sørsamisk };

        /// <summary>
        /// 5026 Holtålen
        /// </summary>
        public static readonly Kommune Holtålen = new Kommune(5026, "Holtålen");

        /// <summary>
        /// 5027 Midtre Gauldal
        /// </summary>
        public static readonly Kommune MidtreGauldal = new Kommune(5027, "Midtre Gauldal");

        /// <summary>
        /// 5028 Melhus
        /// </summary>
        public static readonly Kommune Melhus = new Kommune(5028, "Melhus");

        /// <summary>
        /// 5029 Skaun
        /// </summary>
        public static readonly Kommune Skaun = new Kommune(5029, "Skaun");

        /// <summary>
        /// 5031 Malvik
        /// </summary>
        public static readonly Kommune Malvik = new Kommune(5031, "Malvik");

        /// <summary>
        /// 5032 Selbu
        /// </summary>
        public static readonly Kommune Selbu = new Kommune(5032, "Selbu");

        /// <summary>
        /// 5033 Tydal
        /// </summary>
        public static readonly Kommune Tydal = new Kommune(5033, "Tydal");

        /// <summary>
        /// 5034 Meråker
        /// </summary>
        public static readonly Kommune Meråker = new Kommune(5034, "Meråker");

        /// <summary>
        /// 5035 Stjørdal
        /// </summary>
        public static readonly Kommune Stjørdal = new Kommune(5035, "Stjørdal");

        /// <summary>
        /// 5036 Frosta
        /// </summary>
        public static readonly Kommune Frosta = new Kommune(5036, "Frosta");

        /// <summary>
        /// 5037 Levanger
        /// </summary>
        public static readonly Kommune Levanger = new Kommune(5037, "Levanger");

        /// <summary>
        /// 5038 Verdal
        /// </summary>
        public static readonly Kommune Verdal = new Kommune(5038, "Verdal");

        /// <summary>
        /// 5041 Snåase - Snåsa
        /// </summary>
        public static readonly Kommune Snåsa = new Kommune(5041, "Snåase",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Bokmål, "Snåsa") })
            { SpråkKode = Språk.Sørsamisk };

        /// <summary>
        /// 5042 Lierne
        /// </summary>
        public static readonly Kommune Lierne = new Kommune(5042, "Lierne");

        /// <summary>
        /// 5043 Raarvihke - Røyrvik
        /// </summary>
        public static readonly Kommune Røyrvik = new Kommune(5043, "Raarvihke",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Bokmål, "Røyrvik") })
            { SpråkKode = Språk.Sørsamisk };

        /// <summary>
        /// 5044 Namsskogan
        /// </summary>
        public static readonly Kommune Namsskogan = new Kommune(5044, "Namsskogan");

        /// <summary>
        /// 5045 Grong
        /// </summary>
        public static readonly Kommune Grong = new Kommune(5045, "Grong");

        /// <summary>
        /// 5046 Høylandet
        /// </summary>
        public static readonly Kommune Høylandet = new Kommune(5046, "Høylandet");

        /// <summary>
        /// 5047 Overhalla
        /// </summary>
        public static readonly Kommune Overhalla = new Kommune(5047, "Overhalla");

        /// <summary>
        /// 5049 Flatanger
        /// </summary>
        public static readonly Kommune Flatanger = new Kommune(5049, "Flatanger");

        /// <summary>
        /// 5052 Leka
        /// </summary>
        public static readonly Kommune Leka = new Kommune(5052, "Leka");

        /// <summary>
        /// 5053 Inderøy
        /// </summary>
        public static readonly Kommune Inderøy = new Kommune(5053, "Inderøy");

        /// <summary>
        /// 5054 Indre Fosen
        /// </summary>
        public static readonly Kommune IndreFosen = new Kommune(5054, "Indre Fosen");

        /// <summary>
        /// 5055 Heim
        /// </summary>
        public static readonly Kommune Heim = new Kommune(5055, "Heim");

        /// <summary>
        /// 5056 Hitra
        /// </summary>
        public static readonly Kommune Hitra = new Kommune(5056, "Hitra");

        /// <summary>
        /// 5057 Ørland
        /// </summary>
        public static readonly Kommune Ørland = new Kommune(5057, "Ørland");

        /// <summary>
        /// 5058 Åfjord
        /// </summary>
        public static readonly Kommune Åfjord = new Kommune(5058, "Åfjord");

        /// <summary>
        /// 5059 Orkland
        /// </summary>
        public static readonly Kommune Orkland = new Kommune(5059, "Orkland");

        /// <summary>
        /// 5060 Nærøysund
        /// </summary>
        public static readonly Kommune Nærøysund = new Kommune(5060, "Nærøysund");

        /// <summary>
        /// 5061 Rindal
        /// </summary>
        public static readonly Kommune Rindal = new Kommune(5061, "Rindal");


        // Troms ----

        /// <summary>
        /// 5501 Tromsø
        /// </summary>
        public static readonly Kommune Tromsø = new Kommune(5501, "Tromsø");

        /// <summary>
        /// 5503 Harstad
        /// </summary>
        public static readonly Kommune Harstad = new Kommune(5503, "Harstad",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Nordsamisk, "Hárstták") });

        /// <summary>
        /// 5510 Kvæfjord
        /// </summary>
        public static readonly Kommune Kvæfjord = new Kommune(5510, "Kvæfjord");

        /// <summary>
        /// 5512 Tjeldsund - Dielddanuorri
        /// </summary>
        public static readonly Kommune Tjeldsund = new Kommune(5512, "Tjeldsund",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Nordsamisk, "Dielddanuorri") });

        /// <summary>
        /// 5514 Ibestad
        /// </summary>
        public static readonly Kommune Ibestad = new Kommune(5514, "Ibestad");

        /// <summary>
        /// 5516 Gratangen
        /// </summary>
        public static readonly Kommune Gratangen = new Kommune(5516, "Gratangen");

        /// <summary>
        /// 5518 Loabák - Lavangen
        /// </summary>
        public static readonly Kommune Lavangen = new Kommune(5518, "Loabák",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Bokmål, "Lavangen") })
            { SpråkKode = Språk.Nordsamisk };

        /// <summary>
        /// 5520 Bardu
        /// </summary>
        public static readonly Kommune Bardu = new Kommune(5520, "Bardu");

        /// <summary>
        /// 5522 Salangen
        /// </summary>
        public static readonly Kommune Salangen = new Kommune(5522, "Salangen");

        /// <summary>
        /// 5524 Målselv
        /// </summary>
        public static readonly Kommune Målselv = new Kommune(5524, "Målselv");

        /// <summary>
        /// 5526 Sørreisa
        /// </summary>
        public static readonly Kommune Sørreisa = new Kommune(5526, "Sørreisa");

        /// <summary>
        /// 5528 Dyrøy
        /// </summary>
        public static readonly Kommune Dyrøy = new Kommune(5528, "Dyrøy");

        /// <summary>
        /// 5530 Senja
        /// </summary>
        public static readonly Kommune Senja = new Kommune(5530, "Senja");

        /// <summary>
        /// 5532 Balsfjord
        /// </summary>
        public static readonly Kommune Balsfjord = new Kommune(5532, "Balsfjord");

        /// <summary>
        /// 5534 Karlsøy
        /// </summary>
        public static readonly Kommune Karlsøy = new Kommune(5534, "Karlsøy");

        /// <summary>
        /// 5536 Lyngen
        /// </summary>
        public static readonly Kommune Lyngen = new Kommune(5536, "Lyngen");

        /// <summary>
        /// 5538 Storfjord - Omasvuotna - Omasvuono
        /// </summary>
        public static readonly Kommune Storfjord = new Kommune(5538, "Storfjord",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Nordsamisk, "Omasvuotna"),
                                                    new KeyValuePair<Språk, string>(Språk.Kvensk, "Omasvuono")});

        /// <summary>
        /// 5540 Gáivuotna - Kåfjord - Kaivuono
        /// </summary>
        public static readonly Kommune Kåfjord = new Kommune(5540, "Gáivuotna",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Bokmål, "Kåfjord"),
                                                    new KeyValuePair<Språk, string>(Språk.Kvensk, "Kaivuono")})
            { SpråkKode = Språk.Nordsamisk };

        /// <summary>
        /// 5542 Skjervøy
        /// </summary>
        public static readonly Kommune Skjervøy = new Kommune(5542, "Skjervøy");

        /// <summary>
        /// 5544 Nordreisa - Ráisa - Raisi
        /// </summary>
        public static readonly Kommune Nordreisa = new Kommune(5544, "Nordreisa",
             new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Nordsamisk, "Ráisa"),
                                                    new KeyValuePair<Språk, string>(Språk.Kvensk, "Raisi")});

        /// <summary>
        /// 5546 Kvænangen
        /// </summary>
        public static readonly Kommune Kvænangen = new Kommune(5546, "Kvænangen");


        // Finnmark ----

        /// <summary>
        /// 5601 Alta
        /// </summary>
        public static readonly Kommune Alta = new Kommune(5601, "Alta");

        /// <summary>
        /// 5603 Hammerfest - Hámmerfeasta
        /// </summary>
        public static readonly Kommune Hammerfest = new Kommune(5603, "Hammerfest",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Nordsamisk, "Hámmerfeasta") });

        /// <summary>
        /// 5605 Sør-Varanger
        /// </summary>
        public static readonly Kommune SørVaranger = new Kommune(5605, "Sør-Varanger");

        /// <summary>
        /// 5607 Vadsø
        /// </summary>
        public static readonly Kommune Vadsø = new Kommune(5607, "Vadsø");

        /// <summary>
        /// 5610 Kárásjohka - Karasjok
        /// </summary>
        public static readonly Kommune Karasjok = new Kommune(5610, "Kárásjohka",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Bokmål, "Karasjok") })
            { SpråkKode = Språk.Nordsamisk };

        /// <summary>
        /// 5612 Guovdageaidnu - Kautokeino
        /// </summary>
        public static readonly Kommune Kautokeino = new Kommune(5612, "Guovdageaidnu",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Bokmål, "Kautokeino") })
            { SpråkKode = Språk.Nordsamisk };

        /// <summary>
        /// 5614 Loppa
        /// </summary>
        public static readonly Kommune Loppa = new Kommune(5614, "Loppa");

        /// <summary>
        /// 5616 Hasvik
        /// </summary>
        public static readonly Kommune Hasvik = new Kommune(5616, "Hasvik");

        /// <summary>
        /// 5618 Måsøy
        /// </summary>
        public static readonly Kommune Måsøy = new Kommune(5618, "Måsøy");

        /// <summary>
        /// 5620 Nordkapp
        /// </summary>
        public static readonly Kommune Nordkapp = new Kommune(5620, "Nordkapp");

        /// <summary>
        /// 5622 Porsanger - Porsáŋgu - Porsanki
        /// </summary>
        public static readonly Kommune Porsanger = new Kommune(5622, "Porsanger",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Nordsamisk, "Porsáŋgu"),
                                                    new KeyValuePair<Språk, string>(Språk.Kvensk, "Porsanki") });

        /// <summary>
        /// 5624 Lebesby
        /// </summary>
        public static readonly Kommune Lebesby = new Kommune(5624, "Lebesby");

        /// <summary>
        /// 5626 Gamvik
        /// </summary>
        public static readonly Kommune Gamvik = new Kommune(5626, "Gamvik");

        /// <summary>
        /// 5628 Deatnu - Tana
        /// </summary>
        public static readonly Kommune Tana = new Kommune(5628, "Deatnu",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Bokmål, "Tana") })
            { SpråkKode = Språk.Nordsamisk };

        /// <summary>
        /// 5630 Berlevåg
        /// </summary>
        public static readonly Kommune Berlevåg = new Kommune(5630, "Berlevåg");

        /// <summary>
        /// 5632 Båtsfjord
        /// </summary>
        public static readonly Kommune Båtsfjord = new Kommune(5632, "Båtsfjord");

        /// <summary>
        /// 5634 Vardø
        /// </summary>
        public static readonly Kommune Vardø = new Kommune(5634, "Vardø");

        /// <summary>
        /// 5636 Unjárga - Nesseby
        /// </summary>
        public static readonly Kommune Nesseby = new Kommune(5636, "Unjárga",
            new List<KeyValuePair<Språk, string>> { new KeyValuePair<Språk, string>(Språk.Bokmål, "Nesseby") })
            { SpråkKode = Språk.Nordsamisk };


        /// <summary>
        /// Alle Norges kommuner
        /// </summary>
        public static readonly IEnumerable<Kommune> AlleKommuner = new List<Kommune>
        {
            Oslo,

            // Rogaland
            Eigersund, Stavanger, Haugesund, Sandnes, Sokndal, Lund, Bjerkreim, Hå, Klepp,
            Time, Gjesdal, Sola, Randaberg, Strand, Hjelmeland, Suldal, Sauda, Kvitsøy,
            Bokn, Tysvær, Karmøy, Utsira, Vindafjord,

            // Møre og Romsdal
            Kristiansund, Molde, Ålesund, Vanylven, Sande, HerøyMøreOgRomsdal, Ulstein,
            Hareid, Ørsta, Stranda, Sykkylven, Sula, Giske, Vestnes, Rauma, Aukra, Averøy,
            Gjemnes, Tingvoll, Sunndal, Surnadal, Smøla, Aure, Volda, Fjord, Hustadvika,
            Haram,

            // Nordland
            Bodø, Narvik, Bindal, Sømna, Brønnøy, Vega, Vevelstad, HerøyNordland, Alstahaug,
            Leirfjord, Vefsn, Grane, Hattfjelldal, Dønna, Hemnes, Nesna, Rana, Lurøy, Træna, Rødøy,
            Meløy, Gildeskål, Beiarn, Saltdal, Fauske, Sørfold, Steigen, Lødingen, Evenes,
            Røst, Værøy, Flakstad, Vestvågøy, Vågan, Hadsel, Bø, Øksnes, Sortland, Andøy,
            Moskenes, Hamarøy,

            // Østfold
            Halden, Moss, Sarpsborg, Fredrikstad, Hvaler, Råde, Våler, Skiptvet, IndreØstfold,
            Rakkestad, Marker, Aremark,               
            
            // Akershus
            Bærum, Asker, Lillestrøm, NordreFollo, Ullensaker, Nesodden, Frogn, Vestby, Ås,
            Enebakk, Lørenskog, Rælingen, AurskogHøland, Nes, Gjerdrum, Nittedal, Lunner,
            Jevnaker, Nannestad, Eidsvoll, Hurdal,

            // Buskerud
            Drammen, Kongsberg, Ringerike, Hole, Lier, ØvreEiker, Modum, Krødsherad, Flå,
            Nesbyen, Gol, Hemsedal, Ål, Hol, Sigdal, Flesberg, Rollag, NoreOgUvdal,

            // Innlandet
            Kongsvinger, Hamar, Lillehammer, Gjøvik, Ringsaker, Løten, Stange, NordOdal,
            SørOdal, Eidskog, Grue, Åsnes, Våler, Elverum, Trysil, Åmot, StorElvdal, Rendalen,
            Engerdal, Tolga, Tynset, Alvdal, Folldal, Os, Dovre, Lesja, Skjåk, Lom, Vågå,
            NordFron, Sel, SørFron, Ringebu, Øyer, Gausdal, ØstreToten, VestreToten, Gran,
            SøndreLand, NordreLand, SørAurdal, Etnedal, NordAurdal, VestreSlidre, ØystreSlidre,
            Vang,

            // Vestfold
            Horten, Holmestrand, Tønsberg, Sandefjord, Larvik, Færder, 

            // Telemark
            Porsgrunn, Skien, Notodden, Siljan, Bamble, Kragerø, Drangedal, Nome, MidtTelemark,
            Seljord, Hjartdal, Tinn, Kviteseid, Nissedal, Fyresdal, Tokke, Vinje,

            // Agder
            Risør, Grimstad, Arendal, Kristiansand, Lindesnes, Farsund, Flekkefjord, Gjerstad,
            Vegårshei, Tvedestrand, Froland, Lillesand, Birkenes, Åmli, Iveland, EvjeOgHornnes,
            Bygland, Valle, Bykle, Vennesla, Åseral, Lyngdal, Hægebostad, Kvinesdal, Sirdal,

            // Vestland
            Bergen, Kinn, Etne, Sveio, Bømlo, Stord, Fitjar, Tysnes, Kvinnherad, Ullensvang,
            Eidfjord, Ulvik, Voss, Kvam, Samnanger, Bjørnafjorden, Austevoll, Øygarden, Askøy,
            Vaksdal, Modalen, Osterøy, Alver, Austrheim, Fedje, Masfjorden, Gulen, Solund,
            Hyllestad, Høyanger, Vik, Sogndal, Aurland, Lærdal, Årdal, Luster, Askvoll, Fjaler,
            Sunnfjord, Bremanger, Stad, Gloppen, Stryn,

            // Trøndelag
            Trondheim, Steinkjer, Namsos, Frøya, Osen, Oppdal, Rennebu, Røros, Holtålen,
            MidtreGauldal, Melhus, Skaun, Malvik, Selbu, Tydal, Meråker, Stjørdal, Frosta,
            Levanger, Verdal, Snåsa, Lierne, Røyrvik, Namsskogan, Grong, Høylandet, Overhalla,
            Flatanger, Leka, Inderøy, IndreFosen, Heim, Hitra, Ørland, Åfjord, Orkland, Nærøysund,
            Rindal,

            // Troms
            Tromsø, Harstad, Kvæfjord, Tjeldsund, Ibestad, Gratangen, Lavangen, Bardu, Salangen,
            Målselv, Sørreisa, Dyrøy, Senja, Balsfjord, Karlsøy, Lyngen, Storfjord, Kåfjord,
            Skjervøy, Nordreisa, Kvænangen, 

            // Finnmark
            Alta, Hammerfest, SørVaranger, Vadsø, Karasjok, Kautokeino, Loppa, Hasvik, Måsøy,
            Nordkapp, Porsanger, Lebesby, Gamvik, Tana, Berlevåg, Båtsfjord, Vardø, Nesseby
        };

        static readonly IEnumerable<KeyValuePair<Språk, string>> s_tom_språkliste = new List<KeyValuePair<Språk, string>>();

        Kommune(int nummer, string navn, IEnumerable<KeyValuePair<Språk, string>>
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
        /// Kommunenummer, alltid med fire siffre. Første to siffre er fylkesnummer.
        /// D4 format string.
        /// </summary>
        public int Nummer { get; }

        /// <summary>
        /// Kommunenavn
        /// </summary>
        public string Navn { get; }

        /// <summary>
        /// Språk for kommunens primære navn.
        /// </summary>
        public Språk SpråkKode { get; private
#if NET5_0_OR_GREATER
                init
#else
                set
#endif
                    ; } = Språk.Bokmål;

        /// <summary>
        /// Kommunenavn på andre Norske offisielle språk
        /// </summary>
        public IEnumerable<KeyValuePair<Språk, string>> AlternativeNavn { get; }

        /// <summary>
        /// Fylket kommunen tilhører.
        /// </summary>
        public Fylke Fylke => Fylke.AlleFylker.Single(p => p.Nummer == Nummer / 100);

        /// <summary>
        /// Konstruerer en tekststreng med nummer og alle offisielle navn på kommunen.
        /// </summary>
        /// <returns>Navn på kommunen inklusive nummer og alternative navn.</returns>
        public override string ToString()
        {
            var retval = $"{Nummer:D4} {Navn}";
            foreach (var item in AlternativeNavn)
            {
                retval += $" - {item.Value}";
            }

            return retval;
        }
    }
}
