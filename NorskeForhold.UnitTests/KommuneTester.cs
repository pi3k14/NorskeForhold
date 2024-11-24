using System.Linq;

using FluentAssertions;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Kodefabrikken.NorskeForhold.Enhetstester
{
    public class KommuneTester
    {
        [TestClass]
        public class AlleKommuner
        {
            [TestMethod]
            public void Det_er_357_kommuner_i_Norge()
            {
               Kommune.AlleKommuner.Count().Should().Be(357);
            }
        }

        [TestClass]
        public class Fylke
        {
            [TestMethod]
            public void Trondheim_er_i_Trøndelag_fylke()
            {
                var sut = Kommune.Trondheim;

                sut.Fylke.Should().Be(NorskeForhold.Fylke.Trøndelag);
            }
        }
    }
}
