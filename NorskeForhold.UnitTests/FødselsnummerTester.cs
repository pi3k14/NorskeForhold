using FluentAssertions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kodefabrikken.NorskeForhold.Enhetstester
{
    public class FødselsnummerTester
    {
        [TestClass]
        public sealed class Ctor
        {
            [TestMethod]
            public void Fødselsnummer_er_godkjent_og_riktig_tolket()
            {
                var sut = new Fødselsnummer("23057796111");

                sut.Should().NotBeNull();
                sut.Dato.Year.Should().Be(1977);
                sut.Dato.Month.Should().Be(5);
                sut.Dato.Day.Should().Be(23);
#if NET8_0_OR_GREATER // below net8 is only available via netstandard
                sut.Dato.GetType().Name.Should().Be("DateOnly");
#else
                sut.Dato.TimeOfDay.Ticks.Should().Be(0);
#endif
                sut.Kjønn.Should().Be(Fødselsnummer.BiologiskKjønn.Mann);
                sut.Personnummer.Should().Be(96111);
            }
        }
    }
}
