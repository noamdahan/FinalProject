using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class invites : Form
    {
        public invites()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 2;
            Change change = new Change();
            change.Show();
            this.Close();
        }

        private void invites_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Close();
        }
    }
}
