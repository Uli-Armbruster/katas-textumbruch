using System.Collections.Generic;
using System.IO;
using Textumbruch.Contracts;
using Textumbruch.Logik;

namespace Textumbruch.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var eingabe = ErmittleEingabe(args);
            var zeilen = new UmbruchOhneSilbentrennung().Umbrechen(eingabe);
            Ausgeben(zeilen);
        }

        private static TextumbruchKonfiguration ErmittleEingabe(IReadOnlyList<string> args)
        {
            var text = File.ReadAllText(args[0]);
            int.TryParse(args[1], out var breite);

            return new TextumbruchKonfiguration(breite, text);
        }

        private static void Ausgeben(IEnumerable<string> zeilen)
        {
            System.Console.Clear();

            foreach (var zeile in zeilen)
                System.Console.WriteLine($"{zeile}");

            System.Console.ReadLine();
        }
    }
}