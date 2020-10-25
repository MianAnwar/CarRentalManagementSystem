using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class availableCars : Form
    {
        public availableCars()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            audiCars ac = new audiCars();
            ac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bmwCars bc = new bmwCars();
            bc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mercedesCars mc = new mercedesCars();
            mc.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            jaguarCars jc = new jaguarCars();
            jc.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ferrariCars fc = new ferrariCars();
            fc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lexusCars lc = new lexusCars();
            lc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hondaCars hc = new hondaCars();
            hc.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mazdaCars mc = new mazdaCars();
            mc.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            volvoCars vc = new volvoCars();
            vc.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hyundaiCars hc = new hyundaiCars();
            hc.Show();
        }
    }
}
