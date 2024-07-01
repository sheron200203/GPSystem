using GPSystem.DB;
using GPSystem.Models;
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
    public partial class formSetting : Form
    {
        public formSetting()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void Display()
        {
            SettingDBServices.DisplayAndSearch("SELECT ID, month, beginDate, endDate, salaryCycleDateRange, leaves, tax, holidays FROM setting", dataGridView1);
        }

        public void Clear()
        {
            txtId.Text = txtscDateRange.Text = txtLeaves.Text = txtTax.Text = txtHolidays.Text = string.Empty;
            comboBox1.SelectedItem = null;
            btnSave.Text = "Save";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((comboBox1.SelectedItem == null) || (dateTimePicker2.Text == string.Empty) || (dateTimePicker3.Text == string.Empty) || (scDateRange.Text == string.Empty) || (leaves.Text == string.Empty) || (tax.Text == string.Empty) || (Holidays.Text == string.Empty))
            {
                MessageBox.Show("Missing required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnSave.Text == "Save")
            {
                Setting setting = new Setting(comboBox1.SelectedItem.ToString(), dateTimePicker2.Value, dateTimePicker3.Value, int.Parse(txtscDateRange.Text.Trim()), int.Parse(txtLeaves.Text.Trim()), decimal.Parse(txtTax.Text.Trim()), int.Parse(txtHolidays.Text.Trim()));
                SettingDBServices.AddSetting(setting);
            }
            if (btnSave.Text == "Update")
            {
                Setting setting = new Setting(comboBox1.SelectedItem.ToString(), dateTimePicker2.Value, dateTimePicker3.Value, int.Parse(txtscDateRange.Text.Trim()), int.Parse(txtLeaves.Text.Trim()), decimal.Parse(txtTax.Text.Trim()), int.Parse(txtHolidays.Text.Trim()));
                SettingDBServices.UpdateSetting(setting, txtId.Text);
            }
            Clear();
            Display();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                comboBox1.SelectedItem = row.Cells[1].Value.ToString();
                dateTimePicker2.Text = row.Cells[2].Value.ToString();
                dateTimePicker3.Text = row.Cells[3].Value.ToString();
                txtscDateRange.Text = row.Cells[4].Value.ToString();
                txtLeaves.Text = row.Cells[5].Value.ToString();
                txtTax.Text = row.Cells[6].Value.ToString();
                txtHolidays.Text = row.Cells[7].Value.ToString();
                btnSave.Text = "Update";
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((txtId.Text != string.Empty))
            {
                SettingDBServices.DeleteSetting(txtId.Text);
            }
            Clear();
            Display();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void formSetting_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null)
            {
                dateTimePicker2.Value = new DateTime(DateTime.Now.Year, comboBox1.SelectedIndex + 1, 1);
                int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, comboBox1.SelectedIndex + 1);
                dateTimePicker3.Value = new DateTime(DateTime.Now.Year, comboBox1.SelectedIndex + 1, daysInMonth);
            }
        }
    }

}
