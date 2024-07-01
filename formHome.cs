using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSystem
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formEmployee fe = new formEmployee();
            fe.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            formSetting fs = new formSetting();
            fs.ShowDialog();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            formSalary formSalary = new formSalary();
            formSalary.ShowDialog();
        }
    }
}
