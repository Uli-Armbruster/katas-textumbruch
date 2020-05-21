using System;
using System.Collections.Generic;
using System.Linq;
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
            var zeilen = Umbrechen(eingabe);
            Ausgeben(zeilen);
        }

        private void Ausgeben(IEnumerable<string> zeilen)
        {
            ctrl_Ausgabe.AppendText(zeilen.First());

            foreach (var zeile in zeilen.Skip(1))
                ctrl_Ausgabe.AppendText(Environment.NewLine + zeile);
        }

        private IEnumerable<string> Umbrechen(Tuple<string, int> eingabe)
        {
            return eingabe.Item1.Split(new[] {' '}, StringSplitOptions.None);
        }

        private Tuple<string, int> ErmittleEingabe()
        {
            int.TryParse(ctrl_BreiteInZeichen.Text, out var breite);
            return new Tuple<string, int>(ctrl_Eingabe.Text, breite);
        }
    }
}