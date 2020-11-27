using MySql.Data.MySqlClient;
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
    public partial class BranchForm : Form
    {
        public BranchForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(StaticWord.connectionString);
            MySqlCommand cmd = null;
            con.Open();
            string sql = "INSERT INTO mavis.m_branch " +
                "(Branch_Code, Branch_name, Manager, Branch_Address, Suburb, State, Post_code, Phone, Fax)" +
                "VALUES('" + text_in_branch_code.Text + "'" +
                ",'" + text_in_branch.Text + "" +
                "','" + text_in_manager.Text + "" +
                "','"+text_in_address.Text+"" +
                "','"+text_in_suburb.Text+"" +
                "','"+text_in_state.Text+"" +
                "','"+text_in_post_code.Text+"" +
                "','"+text_in_phone+"" +
                "','"+text_in_fax.Text+"');";
            cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added "+text_in_manager.Text+ " Successfully");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(StaticWord.connectionString);
            MySqlCommand cmd = null;
            con.Open();

            string sql = "UPDATE mavis.m_branch SET " +
                "Branch_name = '" + text_in_branch.Text + "'"+
                ",Manager = '" + text_in_manager.Text + "'" +
                ",Branch_Address = '" + text_in_address.Text + "'" +
                ",Suburb = '" + text_in_suburb.Text + "'" +
                ",State = '" + text_in_state.Text + "'" +
                ",Post_code = '" + text_in_post_code.Text + "'" +
                ",Phone = '" + text_in_branch.Text + "'" +
                ",Fax = '" + text_in_fax.Text + "'" +
                " WHERE Branch_Code = '" + text_in_branch.Text + "'";
            Console.WriteLine(sql);
            cmd = new MySqlCommand(sql, con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Updated " + text_in_branch.Text + " Successfully");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(StaticWord.connectionString);
            MySqlCommand cmd = null;
            con.Open();

            string sql = "DELETE FROM mavis.m_branch " +
                " WHERE Branch_Code = '" + text_in_branch.Text + "'";
            Console.WriteLine(sql);
            cmd = new MySqlCommand(sql, con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Deleted " + text_in_branch.Text + " Successfully");
        }
    }
}
