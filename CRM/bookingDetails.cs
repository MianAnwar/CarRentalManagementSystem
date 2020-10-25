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
    public partial class bookingDetails : Form
    {
        Booking bk = new Booking();
        Customer custm = new Customer();
        Controller Cnt = Controller.Instance;
        Vehical x;
        int rent;

        public bookingDetails(Vehical v)
        {
            InitializeComponent();
            textBox14.Text = v.getReg_no();
            textBox13.Text = v.getCompany();
            textBox12.Text = v.getModel();
            textBox9.Text = v.getRent();
            rent = Convert.ToInt32(textBox9.Text);
            x = v;
        }

        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                int count = Convert.ToInt32(textBox7.Text);
                if (count >= 0)
                {
                    int i = rent * count;
                    textBox9.Text = i.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Must Fill the CNIC field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ////////////////
            if (Cnt.CheckExistenceInDatabase("CNIC", textBox1.Text, "Customer") == true)
            {
                // get data from database... and show below...
                MessageBox.Show("The user with '" + textBox1.Text + " is already registed!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                custm = Cnt.getCustomerWhereNIC(textBox1.Text);

                textBox2.Text = custm.getName();
                textBox3.Text = custm.getPhno();
                comboBox1.Text = custm.getGender();
                textBox5.Text = custm.getAge();
                textBox6.Text = custm.getAddress();

                return;
            }
            else
            {
                MessageBox.Show("New User, Welcome", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // if not already exists in database then it must be a new customer then store it in DB
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Must Enter the customer details", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return; 
            }

            

            ///////////////////////////////////////////////////////////////
            string date = dateTimePicker1.Text;
            string days = textBox7.Text;
            string Cid = Cnt.getCid(textBox1.Text);
            string Vid = Cnt.getVid(textBox14.Text);

            bk.setCid(Cid);
            bk.setVid(Vid);
            bk.setDate(date);
            bk.setDays(days);

    ///////////////////////////////////////////////////////////////
            custm.setCNIC(textBox1.Text);
            custm.setName(textBox2.Text);
            custm.setPhno(textBox3.Text);
            custm.setGender(comboBox1.Text);
            custm.setAge(textBox5.Text);
            custm.setAddress(textBox6.Text);

// save the Customer information
            if (Cnt.saveCustomerToDB(custm) == false)   // agr save nhi hota tu ye msg show kr
            {
                MessageBox.Show("While Registering new Customer error occurd due to some problem,\nwhile saving data to db Please contact MMA!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bill b = new bill(custm, x, bk);
            b.Show();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46 && ch!=' ')
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch!=8 && ch !=46)
            {
                e.Handled = true;
            }
        }
    }
}
