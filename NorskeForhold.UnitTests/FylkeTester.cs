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
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword - intentional (method to test has this name)
        public class ToString
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
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
