using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monthkalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTermin_Click(object sender, EventArgs e)
        {
            TimeSpan period = moncalKalendar.SelectionEnd
                - moncalKalendar.SelectionStart;
            if (period.Days < 1)
            {

                MessageBox.Show("Niste odabrali bla bla, Pritisnite SHIFT da odaberete bla bla bla"
                    , "GREŠKA!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Rezervirali ste period od " + moncalKalendar.SelectionStart.ToShortDateString() +
                    " do " + moncalKalendar.SelectionEnd.ToShortDateString()
                    + " dana", "Rezervacija",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void moncalKalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
