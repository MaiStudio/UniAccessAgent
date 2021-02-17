using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniAccessAgent
{
    public partial class frmSafeAssistant : Form
    {
        public frmSafeAssistant()
        {
            InitializeComponent();
        }

        private void frmSafeAssistant_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
