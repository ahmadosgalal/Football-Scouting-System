﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Scouting_System.FA
{
    public partial class AddStaffForm : Form
    {
        private FAHomeScreen ParentForm_;
        Controller controllerobj;
        int FA_ID;

        public AddStaffForm(FAHomeScreen _ParentForm)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm;
            controllerobj = new Controller();
            FA_ID = ParentForm_.GetFA_ID();
        }

        private void AddStaffForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }

        private void addManagerBtn_Click(object sender, EventArgs e)
        {
            AddManagerForm amf = new AddManagerForm(this);
            this.Hide();
            amf.Show();
        }

        private void addCoachBtn_Click(object sender, EventArgs e)
        {
            AddCoachForm acf = new AddCoachForm(this);
            this.Hide();
            acf.Show();
        }

        private void addAgentBtn_Click(object sender, EventArgs e)
        {
            AddAgentForm agf = new AddAgentForm(this);
            this.Hide();
            agf.Show();
        }

        private void addJournalistBtn_Click(object sender, EventArgs e)
        {
            AddJournalistForm ajf = new AddJournalistForm(this);
            this.Hide();
            ajf.Show();
        }

        private void addScoutBtn_Click(object sender, EventArgs e)
        {
            AddScoutForm asf = new AddScoutForm(this);
            this.Hide();
            asf.Show();
        }

        //Getters
        public int GetFA_ID()
        {
            return FA_ID;
        }
    }
}
