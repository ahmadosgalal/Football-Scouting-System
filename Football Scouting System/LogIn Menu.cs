﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Scouting_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            //TODO: The function should be implemented, now for testing purposes
            // just enter 1 in username to sign in as FA, 2 to sign in as club, 3 to sign in as scout, 4 to sign in as Journalist, 5 to sign in as guest
            if(userNameTxtbox.Text=="1")
            {
                //NOTE : As FAHomeScreen is in another folder, it must be accessed by typing "FolderName"."FormName" 
                //As it treats it as if it was in another namespace.
                FA.FAHomeScreen f = new FA.FAHomeScreen(this);
                f.Show();
                this.Hide();
            }

        }
    }
}
