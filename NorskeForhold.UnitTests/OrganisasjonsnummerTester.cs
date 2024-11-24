using FluentAssertions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kodefabrikken.NorskeForhold.Enhetstester
{
    public class OrganisasjonsnummerTester
    {
        [TestClass]
        public class Ctor
        {
            [TestMethod]
            public void Organisasjonsnummer_er_godkjent()
            {
                var sut = new Organisasjonsnummer("256991144");

                sut.Should().NotBeNull();
            }
        }
    }
}
