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
    public partial class jaguarCars : Form
    {
        public jaguarCars()
        {
            InitializeComponent();
        }

        Vehical v = new Vehical();
        Controller cntlr = Controller.Instance;

        private void jaguarCars_Load(object sender, EventArgs e)
        {
            button5.Visible = false;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            string company = "Jaguar";
            string model = "Cruiser";
            string color = "Blue";
            textBox10.Text = company;
            textBox11.Text = model;
            textBox12.Text = color;

            v = cntlr.getData(company, model, color);

            textBox1.Text = v.getReg_no();
            textBox2.Text = v.getPrice();
            textBox3.Text = v.getCondition();
            textBox4.Text = v.gettype();
            textBox5.Text = v.getdoor();
            textBox6.Text = v.getSeat();
            textBox7.Text = v.getRent();
            textBox8.Text = v.getAvailable();

            if (Convert.ToInt32(textBox8.Text) < 1)
                button5.Visible = false;
            else
                button5.Visible = true;


            return;
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            string company = "Jaguar";
            string model = "CX75";
            string color = "Orange";
            textBox10.Text = company;
            textBox11.Text = model;
            textBox12.Text = color;

            v = cntlr.getData(company, model, color);

            textBox1.Text = v.getReg_no();
            textBox2.Text = v.getPrice();
            textBox3.Text = v.getCondition();
            textBox4.Text = v.gettype();
            textBox5.Text = v.getdoor();
            textBox6.Text = v.getSeat();
            textBox7.Text = v.getRent();
            textBox8.Text = v.getAvailable();

            if (Convert.ToInt32(textBox8.Text) < 1)
                button5.Visible = false;
            else
                button5.Visible = true;


            return;
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            string company = "Jaguar";
            string model = "F-Type";
            string color = "Red";
            textBox10.Text = company;
            textBox11.Text = model;
            textBox12.Text = color;

            v = cntlr.getData(company, model, color);

            textBox1.Text = v.getReg_no();
            textBox2.Text = v.getPrice();
            textBox3.Text = v.getCondition();
            textBox4.Text = v.gettype();
            textBox5.Text = v.getdoor();
            textBox6.Text = v.getSeat();
            textBox7.Text = v.getRent();
            textBox8.Text = v.getAvailable();

            if (Convert.ToInt32(textBox8.Text) < 1)
                button5.Visible = false;
            else
                button5.Visible = true;


            return;
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            string company = "Jaguar";
            string model = "XF2";
            string color = "White";
            textBox10.Text = company;
            textBox11.Text = model;
            textBox12.Text = color;

            v = cntlr.getData(company, model, color);

            textBox1.Text = v.getReg_no();
            textBox2.Text = v.getPrice();
            textBox3.Text = v.getCondition();
            textBox4.Text = v.gettype();
            textBox5.Text = v.getdoor();
            textBox6.Text = v.getSeat();
            textBox7.Text = v.getRent();
            textBox8.Text = v.getAvailable();

            if (Convert.ToInt32(textBox8.Text) < 1)
                button5.Visible = false;
            else
                button5.Visible = true;


            return;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bookingDetails bd = new bookingDetails(v);
            bd.Show();
        }
    }
}
