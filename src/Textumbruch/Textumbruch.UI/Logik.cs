using System;
using System.Collections.Generic;

namespace Textumbruch.UI
{
    public class Logik
    {
        public IEnumerable<string> Umbrechen(TextumbruchKonfiguration konfiguration)
        {
            return konfiguration.Text.Split(new[] { ' ' }, StringSplitOptions.None);
        }
    }
}