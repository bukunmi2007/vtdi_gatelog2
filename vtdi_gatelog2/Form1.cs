using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtdi_gatelog2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Button Clicked");
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogIn login = new FrmLogIn();
            login.MdiParent = this;
            login.Show();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Management Button Clicked");
        }

        private void schedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scheduling Button Clicked");
        }

        private void gateLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gate Logs Button Clicked");
        }

        private void guestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guest List Button Clicked");
        }

        private void gateInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGateInOut gateinout = new FrmGateInOut();
            gateinout.MdiParent = this;
            gateinout.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports Button Clicked");
        }

        private void gatesReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gate Reports Button Clicked");
        }

        private void userLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Logs Button Clicked");
        }
    }
}
