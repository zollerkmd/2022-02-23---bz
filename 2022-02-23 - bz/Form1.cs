using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_02_23___bz
{
    public partial class Form1 : Form
    {
        static int tsz = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFelvisz_Click(object sender, EventArgs e)
        {
            string nev = tbNev.Text;
            string darab = tbDarab.Text;
            string ar = tbAr.Text;
            string sor = nev + ";" + darab + ";" + ar;
            listBox1.Items.Add(sor);
            tsz = tsz + 1;
            lblKiir.Text = Convert.ToString(tsz);
            tbNev.Text = "";
            tbDarab.Text = "";
            tbAr.Text = "";
        }

        private void btnAlma_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Alma;12;1300");
            int mennyi = listBox1.Items.Count;
            lblMennyi.Text = Convert.ToString(mennyi);
            tsz = tsz + 1;
            lblKiir.Text = Convert.ToString(tsz);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lblSorkiir.Text = listBox1.SelectedItem.ToString();
            lblKivalasztottElem.Text = "Kiválasztott elem: " + Convert.ToString(listBox1.SelectedIndex);
        }

        private void btnKijelol_Click(object sender, EventArgs e)
        {
            String[] adat = new String[3];
            adat = listBox1.SelectedItem.ToString().Split(';');
            tbNev.Text = adat[0];
            tbDarab.Text = adat[1];
            tbAr.Text = adat[2];
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            string sor = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(sor);
        }
    }
}
