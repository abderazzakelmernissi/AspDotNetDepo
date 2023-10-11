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
    public partial class WebForm1 : System.Web.UI.Page
    {
        public SqlConnection cn = new SqlConnection("Data Source=USER6EB4;Initial Catalog=depot;Integrated Security=True");
            
        
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from journal where codeJ =" + TextBox1.Text;
            cmd.Connection = cn;
            cn.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TextBox2.Text = dr[1].ToString();
                TextBox3.Text = dr[2].ToString();
                TextBox4.Text = dr[3].ToString();
                TextBox5.Text = dr[4].ToString();
                TextBox6.Text = dr[5].ToString();
            }
            else {
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
            }

            dr.Close();
            cn.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update journal set titre='" + TextBox2.Text + "',Prix=" + TextBox3.Text + ",typeJ='" + TextBox4.Text + "',periode='" + TextBox5.Text + "',villeJ='" + TextBox6.Text + "' where codeJ =" + TextBox1.Text;
            cmd.Connection = cn;
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from journal where codeJ =" + TextBox1.Text;
            cmd.Connection = cn;
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";

            //SqlCommand cmd = new SqlCommand();
            ////cmd.CommandType = CommandType.Text;
            //cmd.Connection = cn;
            //cmd.CommandText = "insert into journal values(@a,@b,@c,@d,@e,@f)";

            ////cmd.CommandText = "insert into journal values("+int.Parse(TextBox1.Text)+",'"+TextBox2.Text+"',"+int.Parse(TextBox3.Text)+",'"+TextBox4.Text+"','"+TextBox5.Text+"','"+TextBox6.Text+"')";
            //cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@a", int.Parse(TextBox1.Text));
            //cmd.Parameters.AddWithValue("@b", TextBox2.Text);
            //cmd.Parameters.AddWithValue("@c", int.Parse(TextBox3.Text));
            //cmd.Parameters.AddWithValue("@d", TextBox4.Text);
            //cmd.Parameters.AddWithValue("@e", TextBox5.Text);
            //cmd.Parameters.AddWithValue("@f", TextBox6.Text);
            
            //cn.Open();
            //cmd.ExecuteNonQuery();
            //cn.Close();
        }
    }
}