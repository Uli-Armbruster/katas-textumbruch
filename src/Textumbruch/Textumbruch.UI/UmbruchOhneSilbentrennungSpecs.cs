using System.Linq;
using FluentAssertions;
using Xunit;

namespace Textumbruch.UI
{
    public class UmbruchOhneSilbentrennungSpecs
    {
        [Theory]
        [InlineData(1, "Hallo Welt", new[] {"Hallo", "Welt"})]
        [InlineData(8, "Hallo Welt", new[] {"Hallo", "Welt"})]
        [InlineData(3, "AB ist A B", new[] {"AB", "ist", "A B"})]
        [InlineData(11, "Hallo Welt. Mein Name ist Uli.", new[] {"Hallo Welt.", "Mein Name", "ist Uli."})]
        public void Bei_konfugrierter_Breite_wird_umgebrochen(int breite, string text, string[] erwarteterText)
        {
            var konfiguration = new TextumbruchKonfiguration(breite, text);
            var logik = new UmbruchOhneSilbentrennung();

            var umgebrochenerText = logik.Umbrechen(konfiguration).ToList();

            umgebrochenerText.Should().BeEquivalentTo(erwarteterText);
        }
    }
}