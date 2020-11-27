using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental
{
    public partial class AdminSystemForm : Form
    {
        public AdminSystemForm()
        {
            InitializeComponent();
        }

        private void btn_branch_Click(object sender, EventArgs e)
        {
            var f = new BranchForm();
            f.ShowDialog();
        }
    }
}
