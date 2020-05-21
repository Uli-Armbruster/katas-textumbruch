using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Textumbruch.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Umbrechen_Click(object sender, EventArgs e)
        {
            var eingabe = ErmittleEingabe();
            var zeilen = new UmbruchOhneSilbentrennung().Umbrechen(eingabe);
            Ausgeben(zeilen);
        }

        private void Ausgeben(IEnumerable<string> zeilen)
        {
            ctrl_Ausgabe.Clear();

            foreach (var zeile in zeilen) 
                ctrl_Ausgabe.AppendText($"{zeile}{Environment.NewLine}");
        }

        private TextumbruchKonfiguration ErmittleEingabe()
        {
            int.TryParse(ctrl_BreiteInZeichen.Text, out var breite);
            return new TextumbruchKonfiguration(breite, ctrl_Eingabe.Text);
        }
    }
}