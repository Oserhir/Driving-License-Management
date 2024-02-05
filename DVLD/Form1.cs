using DVLD.Applications.Application_Types;
using DVLD.Global_Classes;
using DVLD.Login;
using DVLD.People;
using DVLD.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Form1 : Form
    {
        frmLogin _frmLogin;

        public Form1(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmListPeople = new frmListPeople();
            frmListPeople.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUsers frm = new frmListUsers();
            frm.ShowDialog();
        }

        private void adaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void adadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void adadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;

            _frmLogin.Show();
            this.Close();
        }

        private void managesApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListApplicationTypes frm = new frmListApplicationTypes();
            frm.ShowDialog();
        }
    }
}
