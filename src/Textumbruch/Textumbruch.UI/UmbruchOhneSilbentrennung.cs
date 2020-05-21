using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Textumbruch.UI
{
    public class UmbruchOhneSilbentrennung
    {
        public IEnumerable<string> Umbrechen(TextumbruchKonfiguration konfiguration)
        {
            var wörter = TrenneWörter(konfiguration);
            return Umbrechen(konfiguration.Breite, wörter);
        }

        private static IEnumerable<string> Umbrechen(int zeilenbreite, Queue<string> wörter)
        {
            var zeile = new StringBuilder();

            while (wörter.Count > 0)
            {
                var wort = wörter.Dequeue();

                if (zeile.Length + wort.Length > zeilenbreite)
                {
                    if (zeile.Length > 0)
                        yield return zeile.ToString().Trim();
                    
                    zeile.Clear();
                }

                zeile.Append($"{wort} ");
            }

            if (zeile.Length > 0)
                yield return zeile.ToString().Trim();
        }

        private static Queue<string> TrenneWörter(TextumbruchKonfiguration konfiguration)
        {
            var wörter = new Queue<string>();

            konfiguration
                .Text
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(wort => wörter.Enqueue(wort));
            return wörter;
        }
    }
}