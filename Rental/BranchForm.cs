using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Rental
{
    public partial class BranchForm : Form
    {
        public BranchForm()
        {
            InitializeComponent();
            List<Dictionary<string, string>> data = GetAllData();
            text_in_branch_code.Text = (string) data["Branch_Code"];
            text_in_branch.Text = (string)data["Branch_name"];
            text_in_manager = (string)data["Branch_name"];
            text_in_address = (string)data["Branch_name"];
            text_in_suburb = (string)data["Branch_name"];
            text_in_state = (string)data["Branch_name"];
            text_in_post_code = (string)data["Branch_name"];
            text_in_phone = (string)data["Branch_name"];
            text_in_fax = (string)data["Branch_name"];
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
                "','" + text_in_address.Text + "" +
                "','" + text_in_suburb.Text + "" +
                "','" + text_in_state.Text + "" +
                "','" + text_in_post_code.Text + "" +
                "','" + text_in_phone + "" +
                "','" + text_in_fax.Text + "');";
            cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added " + text_in_manager.Text + " Successfully");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(StaticWord.connectionString);
            MySqlCommand cmd = null;
            con.Open();

            string sql = "UPDATE mavis.m_branch SET " +
                "Branch_name = '" + text_in_branch.Text + "'" +
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

        private List<Dictionary<string,string>> GetAllData()
        {
            List<Dictionary<string, string>> resultList = new List<Dictionary<string, string>>();
            Dictionary<string, string> hash = new Dictionary<string, string>();
            MySqlConnection con = new MySqlConnection(StaticWord.connectionString);
            MySqlCommand cmd = null;
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM User", con);
            DataTable data = new DataTable();
            adapter.Fill(data);
            foreach (DataRow row in data.Rows)
            {
                hash.Add("Branch_Code", (string)row["Branch_Code"]);
                hash.Add("Branch_name", (string)row["Branch_name"]);
                hash.Add("Manager", (string)row["Manager"]);
                hash.Add("Branch_Address", (string)row["Branch_Address"]);
                hash.Add("Suburb", (string)row["Suburb"]);
                hash.Add("State", (string)row["State"]);
                hash.Add("Post_code", (string)row["Post_code"]);
                hash.Add("Phone", (string)row["Phone"]);
                hash.Add("Fax", (string)row["Fax"]);
                resultList.Add(hash);
            }
            return resultList;
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {

        }

        private void btl_next_Click(object sender, EventArgs e)
        {

        }
    }
}
