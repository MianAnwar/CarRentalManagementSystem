using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
///////////////////////////////////
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
/// //////////////////////////////

namespace CRM
{
    public class User
    {
    /// Data Memebers ///
        public string cnic;

        public string username;
        public string pwd;

        public string age;
        public string email;
        public string address;

        public string name;
        public string phno;
        public string gender;

    /// Member Function
        public User()       // constructor
        {
            this.cnic = "";
            this.username = "";
            this.pwd = "";
            this.name = "";
            this.phno = "";
            this.gender = "";
        }

// about CNIC:
        public string Getcnic()
        {
            return this.cnic;
        }

        public void Setcnic(string un)
        {
            this.cnic = un;
        }
////////////:

// about username:
        public string Getusername()
        {
            return this.username;
        }

        public void Setusername(string un)
        {
            this.username = un;
        }
        ////////////:

// about address:
        public string Getadress()
        {
            return this.address;
        }

        public void Setaddress(string un)
        {
            this.address = un;
        }
////////////:

// about email:
        public string Getemail()
        {
            return this.email;
        }

        public void Setemail(string un)
        {
            this.email = un;
        }
////////////:

// about username:
        public string Getage()
        {
            return this.age;
        }

        public void Setage(string un)
        {
            this.age = un;
        }
////////////:


        // about password:
        public string Getpassword()
        {
            return this.pwd;
        }

        public void Setpassword(string un)
        {
            this.pwd = un;
        }
////////////:


// about name:
        public string Getname()
        {
            return this.name;
        }

        public void Setname(string un)
        {
            this.name = un;
        }
////////////:


// about phone no:
        public string Getphno()
        {
            return this.phno;
        }

        public void Setphno(string un)
        {
            this.phno = un;
        }
////////////:


// about gender:
        public string Getgender()
        {
            return this.gender;
        }

        public void Setgender(string un)
        {
            this.gender = un;
        }
////////////:
    }

    public class Vehical
    {
        /// Data Member
        public string model;
        public string company;
        public string reg_no;
        public string type;

        public string color;
        public string door;
        public string seats;
        public string condition;

        public string price;
        public string rent;
        public string available;

        /// member functions
    ///// GETTERS && SETTERS //////
        public string getModel()
        {
            return this.model;
        }
        public void SetModel(string m)
        {
            this.model = m;
        }

        public string getCompany()
        {
            return this.company;
        }
        public void SetCompany(string m)
        {
            this.company = m;
        }

        public string getReg_no()
        {
            return this.reg_no;
        }
        public void SetReg_no(string m)
        {
            this.reg_no = m;
        }

        public string gettype()
        {
            return this.type;
        }
        public void Settype(string m)
        {
            this.type = m;
        }

        public string getcolor()
        {
            return this.color;
        }
        public void Setcolor(string m)
        {
            this.color = m;
        }

        public string getdoor()
        {
            return this.door;
        }
        public void Setdoor(string m)
        {
            this.door = m;
        }

        public string getSeat()
        {
            return this.seats;
        }
        public void SetSeat(string m)
        {
            this.seats = m;
        }

        public string getCondition()
        {
            return this.condition;
        }
        public void SetCondition(string m)
        {
            this.condition = m;
        }

        public string getPrice()
        {
            return this.price;
        }
        public void SetPrice(string m)
        {
            this.price = m;
        }

        public string getRent()
        {
            return this.rent;
        }
        public void SetRent(string m)
        {
            this.rent = m;
        }

        public string getAvailable()
        {
            return this.available;
        }
        public void setAvailable(string a)
        {
            this.available = a;
        }
    }

    public class Customer
    {
        public string name;
        public string age;
        public string phno;
        public string email;
        public string address;
        public string nic;
        public string gender;


        public string getName()
        {
            return this.name;
        }
        public void setName(string n)
        {
            this.name = n;
        }

        public string getAge()
        {
            return this.age;
        }
        public void setAge(string n)
        {
            this.age = n;
        }

        public string getPhno()
        {
            return this.phno;
        }
        public void setPhno(string n)
        {
            this.phno = n;
        }

        public string getEmail()
        {
            return this.email;
        }
        public void setEmail(string n)
        {
            this.email = n;
        }

        public string getAddress()
        {
            return this.address;
        }
        public void setAddress(string n)
        {
            this.address = n;
        }

        public string getCNIC()
        {
            return this.nic;
        }
        public void setCNIC(string n)
        {
            this.nic = n;
        }

        public string getGender()
        {
            return this.gender;
        }
        public void setGender(string n)
        {
            this.gender = n;
        }

    }

    public class Booking
    {
        public string Date;
        public string Days;
        public string Cid;
        public string Vid;

        public void setDate(string d)
        {
            this.Date = d;
        }
        public string getDate()
        {
            return this.Date;
        }

        public void setDays(string d)
        {
            this.Days = d;
        }
        public string getDay()
        {
            return this.Days;
        }

        public void setCid(string d)
        {
            this.Cid = d;
        }
        public string getCid()
        {
            return this.Cid;
        }

        public void setVid(string d)
        {
            this.Vid = d;
        }
        public string getVid()
        {
            return this.Vid;
        }
    }

    public class Payment
    {

        public string bid;
        public string cid;
        public string vid;
        public string amount;

        public void setBid(string d)
        {
            this.bid = d;
        }
        public string getBid()
        {
            return this.bid;
        }

        public void setCid(string d)
        {
            this.cid = d;
        }
        public string getCid()
        {
            return this.cid;
        }

        public void setVid(string d)
        {
            this.vid = d;
        }
        public string getVid()
        {
            return this.vid;
        }

        public void setAmount(string d)
        {
            this.amount = d;
        }
        public string getAmount()
        {
            return this.amount;
        }
    }



    public class databaseHandler        // Design PAtter => Singleton Database_Handler 
    {
        private databaseHandler()
        {
            /// jjust to make this singleton
        }
        private static databaseHandler ins = null;
        public static databaseHandler Instance
        {
            get
            {
                if (ins == null)
                {
                    ins = new databaseHandler();
                }
                return ins;
            }
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CRM\CRM\crmdb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sda;
        DataTable dt;

        public void openConnection()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
        }
        public void closeConnection()
        {
            if (con.State != ConnectionState.Closed)
                con.Close();
        }

        // SAVE data to Database...
        public bool saveUserToDB(User u)
        {
            string nic = u.Getcnic();
            string name = u.Getname();
            string gender = u.Getgender();
            string age = u.Getage();
            string email = u.Getemail();
            string phno = u.Getphno();
            string address = u.Getadress();
            string username = u.Getusername();
            string pwd = u.Getpassword();

            bool flag = false;
            try
            {
                this.openConnection();

                string qry = "INSERT INTO Login (username, password, name, CNIC, phno, gender, age, email, address) VALUES ('" + username + "', '" + pwd + "', '" + name + "', '" + nic + "', '" + phno + "', '" + gender + "', '" + age + "', '" + email + "', '" + address + "')";
                sda = new SqlDataAdapter(qry, con);
                sda.SelectCommand.ExecuteNonQuery();

                this.closeConnection();

                flag = true;
            }
            catch
            {
                flag = false;       // nhi save hwa
                this.closeConnection();
            }

            return flag;
        }

        public bool saveCustomerToDB(Customer u)
        {
            string nic = u.getCNIC();
            string name = u.getName();
            string gender = u.getGender();
            string age = u.getAge();
            string email = u.getEmail();
            string phno = u.getPhno();
            string address = u.getAddress();

            bool flag = false;
            try
            {
                this.openConnection();
                string qry = "INSERT INTO Customer (Name, Age, Phno, Email, Address, CNIC, Gender) VALUES ('" + name + "', '" + age + "', '" + phno + "', '" + email + "', '" + address + "', '" + nic + "', '" + gender + "')";
                sda = new SqlDataAdapter(qry, con);
                sda.SelectCommand.ExecuteNonQuery();

                this.closeConnection();
                flag = true;
            }
            catch
            {
                flag = false;       // nhi save hwa
                this.closeConnection();
            }

            return flag;
        }

        public bool saveBookingdata(Booking b)
        {
            string cid = b.getCid();
            string vid = b.getVid();
            string date = b.getDate();
            string day = b.getDay();

            bool flag = false;
            try
            {
                this.openConnection();

                string qry = "INSERT INTO Booking (Date, Days, Cid, Vid) VALUES ('" + date + "', '" + day + "', '" + cid + "', '" + vid + "')";
                sda = new SqlDataAdapter(qry, con);
                sda.SelectCommand.ExecuteNonQuery();

                this.closeConnection();
                flag = true;
            }
            catch
            {
                flag = false;       // nhi save hwa
                this.closeConnection();
            }

            return flag;
        }

        public bool savePaymentdata(Payment p)
        {
            string bid = p.getBid();
            string cid = p.getCid();
            string vid = p.getVid();
            string payment = p.getAmount();

            bool flag = false;
            try
            {
                this.openConnection();

                string qry = "INSERT INTO Payments (Bid, Cid, Vid, Amount) VALUES ('" + bid + "', '" + cid + "', '" + vid + "', '" + payment + "')";
                sda = new SqlDataAdapter(qry, con);
                sda.SelectCommand.ExecuteNonQuery();

                this.closeConnection();
                flag = true;
            }
            catch
            {
                flag = false;       // nhi save hwa
                this.closeConnection();
            }
            return flag;
        }

        public bool decreaseCount(string reg)
        {
            string vid = this.getDataWhereReg("Vid" ,reg);
            string available = this.getDataWhereVid("AvailableCount", vid);
            int availC = (Convert.ToInt32(available)) - 1;
            string newAvail = availC.ToString();
            bool flag = false;
            try
            {
                this.openConnection();

                string qry = "UPDATE Vehicle SET AvailableCount = '" + newAvail + "' WHERE Vid = '" + vid + "'";
                sda = new SqlDataAdapter(qry, con);
                sda.SelectCommand.ExecuteNonQuery();

                this.closeConnection();
                flag = true;
            }
            catch
            {
                flag = false;       // nhi save hwa
                this.closeConnection();
            }
            return flag;
        }


        // Check Existence of _____ in Database...
        public bool CEInDBofuser(string u_n, string p_wd)
        {
            bool flag = false;
            try
            {
                this.openConnection();
                string sqe = "SELECT count(*) FROM Login WHERE username = \'" + u_n + "\' AND password = \'" + p_wd + "\';";
                sda = new SqlDataAdapter(sqe, con);
                dt = new DataTable();
                sda.Fill(dt);
                this.closeConnection();

                if (dt.Rows[0][0].ToString() == "1")
                {
                    flag = true;   // ok hai
                }
                else
                {
                    flag = false;
                }
            }
            catch
            {
                this.closeConnection();
                flag = false;
                MessageBox.Show("Not Accessing DAta due to some problem.\n Please contact MMA. While checkexistence", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return flag;
        }

        public bool CEInDBof(string fieldname, string value, string tablename)
        {
            bool flag = false;
            try
            {
                this.openConnection();
                string sqe = "SELECT COUNT(*) FROM " + tablename + " WHERE " + fieldname + " = '" + value + "'";       // select count(cnic) from login 
                sda = new SqlDataAdapter(sqe, con);
                dt = new DataTable();
                sda.Fill(dt);
                this.closeConnection();

                if (dt.Rows[0][0].ToString() == "0")
                {
                    flag = false;   // nhi hai
                }
                else
                {
                    flag = true;
                }
            }
            catch
            {
                this.closeConnection();
                flag = false;
                MessageBox.Show("Not Accessing DAta due to some problem.\n Please contact MMA. While checkexistence", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return flag;
        }


        // Get __data__ Where __id__
        public string getDataWhereVid(string field, string vid)
        {
            string data = "";
            try
            {
                this.openConnection();             // SELECT Price FROM Vehical Where Model = 'i8'"
                string sql_statement = "SELECT " + field + " FROM Vehicle WHERE Vid = '" + vid + "'";
                sda = new SqlDataAdapter(sql_statement, con);
                dt = new DataTable();
                sda.Fill(dt);
                data = dt.Rows[0][0].ToString();
                this.closeConnection();
            }
            catch
            {
                this.closeConnection();
                return "";
            }
            return data;
        }

        public string getDataWhereReg(string field, string reg)
        {
            string data = "";
            try
            {
                this.openConnection();             // SELECT Price FROM Vehical Where Model = 'i8'"
                string sql_statement = "SELECT " + field + " FROM Vehicle WHERE Reg_No = '" + reg + "'";
                sda = new SqlDataAdapter(sql_statement, con);
                dt = new DataTable();
                sda.Fill(dt);
                data = dt.Rows[0][0].ToString();
                this.closeConnection();
            }
            catch
            {
                this.closeConnection();
                return "";
            }
            return data;
        }

        public string getDataWhereCid(string field, string cid)
        {
            string data = "";
            try
            {
                this.openConnection();             // SELECT Price FROM Vehical Where Model = 'i8'"
                string sql_statement = "SELECT " + field + " FROM Customer WHERE Cid = '" + cid + "'";
                sda = new SqlDataAdapter(sql_statement, con);
                dt = new DataTable();
                sda.Fill(dt);
                data = dt.Rows[0][0].ToString();
                this.closeConnection();
            }
            catch
            {
                return "";
                this.closeConnection();
            }
            return data;
        }

        public string getDataWhereNIC(string field, string nic)
        {
            string data = "";
            try
            {
                this.openConnection();             // SELECT Price FROM Vehical Where Model = 'i8'"
                string sql_statement = "SELECT " + field + " FROM Customer WHERE CNIC = '" + nic + "'";
                sda = new SqlDataAdapter(sql_statement, con);
                dt = new DataTable();
                sda.Fill(dt);
                data = dt.Rows[0][0].ToString();
                this.closeConnection();
            }
            catch
            {
                return "";
                this.closeConnection();
            }
            return data;
        }

        public string getBidWhere(string date, string days, string cid, string vid)
        {
            string data = "";
            try
            {
                this.openConnection();             // SELECT Price FROM Vehical Where Model = 'i8'"
                string sql_statement = "SELECT Bid FROM Booking WHERE  Date = '" + date + "' AND Days = '" + days + "' AND Cid = '" + cid + "' AND Vid = '" + vid + "'";
                sda = new SqlDataAdapter(sql_statement, con);
                dt = new DataTable();
                sda.Fill(dt);
                data = dt.Rows[0][0].ToString();
                this.closeConnection();
            }
            catch
            {
                return "";
                this.closeConnection();
            }
            return data;
        }


        // Get data from Database....
        public Vehical getVehicalOf(string c, string m, string clr)
        {
            Vehical v = new Vehical();

            this.openConnection();             // SELECT Price FROM Vehical Where Model = 'i8'"
            string sql_statement = "SELECT Vid FROM Vehicle WHERE Companyy = '" + c + "' AND Model = '" + m + "' AND Color = '" + clr + "'";
            sda = new SqlDataAdapter(sql_statement, con);
            dt = new DataTable();
            sda.Fill(dt);
            string Vid = dt.Rows[0][0].ToString();
            this.closeConnection();


            string reg = this.getDataWhereVid("Reg_No", Vid);
            string p = this.getDataWhereVid("Price", Vid);
            string Cond = this.getDataWhereVid("Condition", Vid);
            string type = this.getDataWhereVid("Type", Vid);
            string dr = this.getDataWhereVid("Door", Vid);
            string St = this.getDataWhereVid("Seat", Vid);
            string rnt = this.getDataWhereVid("Rent", Vid);
            string avl = this.getDataWhereVid("AvailableCount", Vid);

            v.SetCompany(c);
            v.SetModel(m);
            v.Setcolor(clr);

            v.SetReg_no(reg);
            v.SetPrice(p);
            v.SetCondition(Cond);
            v.Settype(type);
            v.Setdoor(dr);
            v.SetSeat(St);
            v.SetRent(rnt);
            v.setAvailable(avl);

            return v;
        }

        public Customer getCustomerWhereCNIC(string nic)
        {
            Customer c = new Customer();

                string Cid = this.getDataWhereNIC("Cid", nic);

            string name = this.getDataWhereCid("Name", Cid);
            string age = this.getDataWhereCid("Age", Cid);
            string phno = this.getDataWhereCid("Phno", Cid);
            string email = this.getDataWhereCid("Email", Cid);
            string adr = this.getDataWhereCid("Address", Cid);
            string cnc = this.getDataWhereCid("CNIC", Cid);
            string gndr = this.getDataWhereCid("Gender", Cid);


            c.setName(name);
            c.setAge(age);
            c.setPhno(phno);
            c.setEmail(email);

            c.setAddress(adr);
            c.setCNIC(cnc);
            c.setGender(gndr);

            return c;
        }

        public DataTable GetBookedVehical()
        {

            this.openConnection();

            string sqe = "SELECT Booking.Bid AS 'Booking No', Customer.Name, Phno, Vehicle.Reg_No, Vehicle.Companyy, Booking.Date FROM Booking, Customer, Vehicle WHERE Booking.Cid = Customer.Cid AND Booking.Vid = Vehicle.Vid";
            dt = new DataTable();
            sda = new SqlDataAdapter(sqe, con);
            sda.Fill(dt);

            this.closeConnection();

            return dt;
        }

        public DataTable GetBookedVehical2()
        {

            this.openConnection();

            string sqe = "SELECT Booking.Bid, Vehicle.Reg_No, Vehicle.Companyy, Vehicle.Model FROM Booking, Customer, Vehicle WHERE Booking.Cid = Customer.Cid AND Booking.Vid = Vehicle.Vid";
            dt = new DataTable();
            sda = new SqlDataAdapter(sqe, con);
            sda.Fill(dt);

            this.closeConnection();

            return dt;
        }


        // remove data from datbase
        public bool cancel_booking_of(string bid, string reg)
        {
            string vid = this.getDataWhereReg("Vid", reg);
            string available = this.getDataWhereVid("AvailableCount", vid);
            long availC = (Convert.ToInt32(available)) + 1;
            string newAvail = availC.ToString();
            bool flag = false;
            try
            {
                this.openConnection();

                string qry = "UPDATE Vehicle SET AvailableCount = '" + newAvail + "' WHERE Vid = '" + vid + "'";
                sda = new SqlDataAdapter(qry, con);
                sda.SelectCommand.ExecuteNonQuery();

                qry = "DELETE FROM Booking WHERE Bid = '" + bid + "'";
                sda = new SqlDataAdapter(qry, con);
                sda.SelectCommand.ExecuteNonQuery();

                this.closeConnection();
                flag = true;
            }
            catch
            {
                flag = false;       // nhi save hwa
                this.closeConnection();
            }
            return flag;
        }
    }



    public sealed class Controller     // Design PAtter => Singleton Controller 
    {
    private Controller()    // controller
        {
            // just to implement the constructor as private:
        }
    private static Controller ins = null;
    public static Controller Instance
    {
        get
        {
            if (ins == null)
            {
                ins = new Controller();
            }
            return ins;
        }
    }

    databaseHandler dbh = databaseHandler.Instance;


        // to save data
        public bool SaveToDatabase(User u)
        {
            return dbh.saveUserToDB(u);
        }

        public bool saveBKdata(Booking b)
        {
            return dbh.saveBookingdata(b);
        }

        public bool saveCustomerToDB(Customer u)
        {
            return dbh.saveCustomerToDB(u);
        }


        // Check Existence
        public bool CheckExistenceInDatabase(string u_n, string p_wd)
        {
            return dbh.CEInDBofuser(u_n, p_wd);
        }

        public bool CheckExistenceInDatabase(string fieldname, string value, string tablename)
        {
            return dbh.CEInDBof(fieldname, value, tablename);
        }

        // Get Data 
        public string getDataWhereVid(string field, string vid)
        {
            return dbh.getDataWhereVid(field, vid);
        }

        public Vehical getData(string c, string m, string clr)
        {
            return dbh.getVehicalOf(c, m, clr);
        }

        public string getDataWhereCid(string field, string cid)
        {
            return dbh.getDataWhereCid(field, cid);
        }

        public Customer getCustomerWhereNIC(string nic)
        {
            return dbh.getCustomerWhereCNIC(nic);
        }
        
        public string getCid(string nic)
        {
            return dbh.getDataWhereNIC("Cid", nic);
        }

        public string getVid(string reg)
        {
            return dbh.getDataWhereReg("Vid",reg);
        }
        
        public string getBid(string date, string days, string cid, string vid)
        {
            return dbh.getBidWhere(date, days, cid, vid);
        }

        public bool savePaymentdata(Payment p)
        {
            return dbh.savePaymentdata(p);
        }

        public bool updateVehicleAvailabe(string reg)
        {
            return dbh.decreaseCount(reg);
        }


        public DataTable getBookVehical()
        {
            return dbh.GetBookedVehical();
        }

        public DataTable getBookVehical2()
        {
            return dbh.GetBookedVehical2();
        }

        public bool cancel_booking(string bd, string reg)
        {
            return dbh.cancel_booking_of(bd, reg);
        }
    }







 

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
