﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Appoinment : Form
    {
        public Appoinment()
        {
            InitializeComponent();
        }

        // Create the connection to the Database
        // SqlConnection conn_vinuri = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\DATABASE Servers\Project.mdf';Integrated Security=True;Connect Timeout=30");
        SqlConnection conn_ravindu = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\Project.mdf;Integrated Security=True;Connect Timeout=30");

        private void Appoinment_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            // The user must enter all the text fields to store data in the database
            if (guna2TextBox1.Text == "" || guna2TextBox2.Text == "" || guna2TextBox3.Text == "" || guna2TextBox4.Text == "" || guna2TextBox5.Text == "" || guna2TextBox6.Text == "")
            {
                MessageBox.Show("Please Fill All the Fields", "Appoinment Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Assign the values to the variables from the textboxes
                string fullname = guna2TextBox1.Text;
                int phonenumber = Convert.ToInt32(guna2TextBox2.Text);
                string department = guna2TextBox3.Text;
                int age = Convert.ToInt32(guna2TextBox4.Text);
                string appointmentdate = guna2TextBox5.Text;
                string doctor = guna2TextBox6.Text;

                try
                {
                    conn_ravindu.Open();

                    string sql = "INSERT INTO appointment (Fullname,Phonenumber,Department,Age,Appointment_date,Doctor) VALUES ('" + fullname + "', '" + phonenumber + "', '" + department + "', '" + age + "', '" + appointmentdate + "', '" + doctor + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn_ravindu);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appoinment Placed Successfully", "Appoinment Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conn_ravindu.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Appoinment Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    guna2TextBox1.Text = "";
                    guna2TextBox2.Text = "";
                    guna2TextBox3.Text = "";
                    guna2TextBox4.Text = "";
                    guna2TextBox5.Text = "";
                    guna2TextBox6.Text = "";
                }

            }
        }

        private void Appoinment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1_home = new Form1();

            this.Hide();
            form1_home.Show();
        }
    }
}