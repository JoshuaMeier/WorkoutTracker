﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorkoutTracker
{
    public partial class NewUser : Form
    {
        private int userIdNumber = 0;
        private Boolean passwardMatch = false;
        String[] userNameAndPassword = new String[4];
        private UserAccount Account;
         
        public NewUser(UserAccount account)
        {
            InitializeComponent();
            this.Account = account;
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
        
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.label5, "Passwords do not match");
            
        }
        private void getUserIdNumber()
        {
            // SqlCommand comm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(passwardMatch == true)
            {
                Account.newUser(textBox4.Text, textBox3.Text);
                textBox4.Clear();
                textBox3.Clear();
                textBox1.Clear();
                textBox2.Clear();
               // addDataUsrPswd(textBox4.Text, textBox3.Text);
                //pass on the username && pwd to database
                this.Close();
            }
        }

        //Username textbox
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            userNameAndPassword[0] = textBox4.Text;
        }
        
        //Password textbox
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            userNameAndPassword[1] = textBox3.Text;
            ComparePassword();
        }

        //Confirm-password textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userNameAndPassword[2] = textBox1.Text;
            ComparePassword();
        }

        //Email textbox
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            userNameAndPassword[3] = textBox2.Text;
        }

        private void ComparePassword()
        {
            if (userNameAndPassword[1] == userNameAndPassword[2])
            {
                passwardMatch = true;
                label5.Visible = false;

            }
            else
            {
                passwardMatch = false;
                label5.Visible = true;
            }
        }

        
    }
}
