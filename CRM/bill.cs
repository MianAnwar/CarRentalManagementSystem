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
    public partial class bill : Form
    {
        
        Customer custm = new Customer();
        Vehical vv;
        Booking bk = new Booking();
            Controller Cnt = Controller.Instance;
        Payment py = new Payment();
        

        int rent = 0;
        int amount = 0;
        public bill(Customer c, Vehical v, Booking b)
        {
            InitializeComponent();
            textBox11.Text = v.getReg_no();
            textBox12.Text = v.getCompany();
            textBox13.Text = v.getModel();
            textBox9.Text = v.getRent();
            rent = Convert.ToInt32(textBox9.Text);

            textBox1.Text = c.getCNIC();
            textBox2.Text = c.getName();
            textBox3.Text = c.getPhno();
            textBox4.Text = c.getAddress();

            dateTimePicker1.Text = b.getDate();
            textBox7.Text = b.getDay();
            int day = Convert.ToInt32(textBox7.Text);
            amount = rent * day;

            textBox9.Text = amount.ToString();

            custm = c;
            bk = b;
            vv = v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            py.setAmount(textBox9.Text);
            
            py.setVid(Cnt.getVid(textBox11.Text));
            py.setCid(Cnt.getCid(textBox1.Text));

            py.setBid( Cnt.getBid( dateTimePicker1.Text, textBox7.Text, py.getCid(), py.getVid()) );



            if (Cnt.savePaymentdata(py) == false)       // save the payment information
            {
                MessageBox.Show("While Registering new Payment error occurd due to some problem,\nwhile saving data to db Please contact MMA!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Cnt.saveBKdata(bk) == false)       // save the Booking information
            {
                MessageBox.Show("While Registering new Booking error occurd due to some problem,\nwhile saving data to db Please contact MMA!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Cnt.updateVehicleAvailabe(vv.getReg_no()) == false)       // save the Booking information
            {
                MessageBox.Show("While Updating new Vehical error occurd due to some problem,\nwhile accessing data to db Please contact MMA!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Enter Amount");
            }
            else if(textBox6.Text == "Insufficient Amount!")
            {
                MessageBox.Show("Please Enter Sufficient Amount");
            }
            else
            {
                MessageBox.Show("Thanks, Have a safe journey. \nSee you soon.");
            }

            MessageBox.Show("All necessary data has been saved successfully!", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch != 8 && ch!= 46)
            {
                e.Handled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox6.Text = "";
                if (textBox5.Text != "")
                {
                    int total = Convert.ToInt32(textBox9.Text);
                    int entered = Convert.ToInt32(textBox5.Text);

                    if (entered >= total)
                    {
                        int rem = entered - total;
                        textBox6.Text = rem.ToString();
                    }
                    else if (entered < total)
                    {
                        textBox6.Text = "Insufficient Amount!";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Illegal Data is entered!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
