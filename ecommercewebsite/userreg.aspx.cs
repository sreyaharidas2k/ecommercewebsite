using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ecommercewebsite
{
    public partial class userreg1 : System.Web.UI.Page
    {
        concls obj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select max(Reg_Id) from Login_tb";
            string id = obj.fn_scalar(s);
            int reg_id = 0;
            if (id == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(id);
                reg_id = newregid + 1;
            }
            string ins = "insert into User_tb values(" + reg_id + ",'" + txtusername.Text + "','" + txtuseraddress.Text + "','" + txtuseremail.Text + "','" + txtuserphone.Text + "','" + txtuserpincode.Text + "','" + ddluserstate.SelectedItem.Text + "','" + ddluserdistrict.SelectedItem.Text + "','Active')";
            int i = obj.fn_nonquery(ins);
            if (i == 1)
            {
                string inslog = "insert into Login_tb values(" + reg_id + ",'" + txtuserusername.Text + "','" + txtuserpwd.Text + "','User','Active')";
                int j = obj.fn_nonquery(inslog);
            }
        }

        protected void txtuserusername_TextChanged(object sender, EventArgs e)
        {
            string sel = "select count(Reg_Id) from Login_tb where Username='" + txtuserusername.Text + "'";
            string id = obj.fn_scalar(sel);
            if (id == "1")
            {
                Label1.Visible = true;
                Label1.Text = "username already exists";
            }
            else
            {
                Label1.Visible = false;
            }
        }

        protected void txtuserpwd_TextChanged(object sender, EventArgs e)
        {
            string sel = "select count(Reg_Id) from Login_tb where Password='" + txtuserpwd.Text + "'";
            string id = obj.fn_scalar(sel);
            if (id == "1")
            {
                Label2.Visible = true;
                Label2.Text = "Password already exists";
            }
            else
            {
                Label2.Visible = false;
            }
        }
    }
}