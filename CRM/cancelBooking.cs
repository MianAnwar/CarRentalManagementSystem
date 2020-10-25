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
    public partial class cancelBooking : Form
    {

        Controller contlr = Controller.Instance;
        public cancelBooking()
        {
            InitializeComponent();
        }

        private void cancelBooking_Load(object sender, EventArgs e)
        {
            DataTable dt = contlr.getBookVehical2();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[i];

            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            textBox2.Text = selectedRow.Cells[1].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string bid = textBox1.Text;
            string reg = textBox2.Text;

            if (contlr.cancel_booking(bid, reg) == false)
            {
                MessageBox.Show("Must Enter the customer details", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }
    }
}
