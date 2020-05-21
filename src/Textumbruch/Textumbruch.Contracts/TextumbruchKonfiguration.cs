using System;

namespace Textumbruch.Contracts
{
    public class TextumbruchKonfiguration
    {
        public int Breite { get;  }
        public string Text { get; }

        public TextumbruchKonfiguration(int breite, string text)
        {
            if (breite < 1)
                throw new ArgumentOutOfRangeException(nameof(breite), "Breite muss mind. 1 sein");
            Breite = breite;
            
            if (string.IsNullOrEmpty(text))
                throw new ArgumentOutOfRangeException(nameof(text), "Text muss mind. 1 Zeichen haben");
            Text = text;
        }
    }
}