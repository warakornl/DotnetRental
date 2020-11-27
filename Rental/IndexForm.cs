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
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(text_in_username.Text.Equals("admin") && text_in_password.Text.Equals("admin"))
            {
                var f = new AdminSystemForm();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("You are not authorized");
            }
           
        }
    }
}
