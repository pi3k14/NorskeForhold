using System.Linq;

using FluentAssertions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kodefabrikken.NorskeForhold.Enhetstester
{
    public class FylkeTester
    {
        [TestClass]
        public class AlleFylker
        {
            [TestMethod]
            public void Det_er_15_fylker_i_Norge()
            {
                Fylke.AlleFylker.Count().Should().Be(15);
            }
        }

        [TestClass]
        public class ToString
        {
            [TestMethod]
            public void Finnmark_presenteres_fullstendig()
            {
                var sut = Fylke.Finnmark;

                sut.ToString().Should().Be("56 Finnmark - Finnmárku - Finmarkku");
            }
        }
    }
}
