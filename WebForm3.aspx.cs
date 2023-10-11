using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ASPTPDEPOT1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        public SqlConnection cn = new SqlConnection("Data Source=USER6EB4;Initial Catalog=depot;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                cmd.CommandText = "select distinct prix from journal";
                cn.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                DropDownList1.Items.Add("choisir un PRIX");
                while (dr.Read())
                {
                    DropDownList1.Items.Add(dr[0].ToString());
                }
                cn.Close();

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex > 0)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;


                cmd.CommandText = "select * from journal where prix= " + DropDownList1.SelectedItem;
                cn.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                ListBox1.Items.Clear();
                while (dr.Read())
                {
                    ListBox1.Items.Add(dr[0].ToString() + "|" + dr[1].ToString() + "|" + dr[2].ToString() + "|" + dr[3].ToString() + "|" + dr[4].ToString() + "|" + dr[5].ToString());
                }
                dr.Close();

                cn.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string stg = ListBox1.SelectedItem.ToString();
            string [] sp = stg.Split('|');
            ListBox1.Items.Remove(ListBox1.SelectedValue);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from journal where codeJ =" + sp[0].ToString();
            cmd.Connection = cn;
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();


            //Label2.Text = sp[2].ToString();

            
            if (ListBox1.Items.Count == 0)
            {
                DropDownList1.Items.Remove(sp[2].ToString());
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Visible = true;
            TextBox1.Visible = true;
            Button3.Visible = true;

            

            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
             string stg = ListBox1.SelectedItem.ToString();
            string[] sp = stg.Split('|');
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update journal set prix=" + int.Parse(TextBox1.Text) +"where prix="+ int.Parse(sp[2].ToString());
            cmd.Connection = cn;
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            //if(DropDownList1.Items.Contains(TextBox1.Text))
            
            DropDownList1.Items.Add(TextBox1.Text);


            DropDownList1.Items.Remove(sp[2].ToString());
        }
    }
}