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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            availableCars av = new availableCars();
            av.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewHistory vh = new viewHistory();
            vh.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bookedCars bc = new bookedCars();
            bc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cancelBooking cb = new cancelBooking();
            cb.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            settings st = new settings();
            st.Show();
        }
    }
}
