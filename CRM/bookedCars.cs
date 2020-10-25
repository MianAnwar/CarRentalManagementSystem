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
    public partial class bookedCars : Form
    {
        Controller contlr = Controller.Instance;
        Vehical v;

        public bookedCars()
        {
            InitializeComponent();
        }

        private void bookedCars_Load(object sender, EventArgs e)
        {
            DataTable dt = contlr.getBookVehical();
            dataGridView1.DataSource = dt;
        }
    }
}
