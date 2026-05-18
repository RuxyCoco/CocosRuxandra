using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_dad_cocos_ruxandra.Forms
{
    public partial class frmRulaje : Form
    {
        public frmRulaje()
        {
            InitializeComponent();
        }
        databaseEntites dad = new databaseEntites();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmRulaje_Load(object sender, EventArgs e)
        {
            dad.Operatie.Include("Rulaje").Load();
            operatieBindingSource.DataSource = dad.Operatie.Local.ToBindingList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.operatieBindingSource.EndEdit();
                dad.SaveChanges();
                operatieBindingSource.ResetBindings(false);
                MessageBox.Show("Datele au fost salvate");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Datele nu pot fi salvate! {ex.Message}");
            }
        }
    }
}
