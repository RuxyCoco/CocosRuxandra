using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_dad_cocos_ruxandra.Forms
{
    public partial class frmBalanta : Form
    {
        databaseEntites ctx = new databaseEntites();
        public frmBalanta()
        {
            InitializeComponent();
        }

        private void FrmBalanta_Load(object sender, EventArgs e)
        {
            ctx.vwBalantaDeVerificare.Load();
            bindingSource1.DataSource = ctx.vwBalantaDeVerificare.Local;

            this.reportViewer1.RefreshReport();
        }
    }
}
