using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ecommercewebsite
{
    public partial class editcategory : System.Web.UI.Page
    {
        concls obj = new concls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fn_grid();
            }
        }
        public void fn_grid()
        {
            string sel = "select * from Category_tb";
            DataSet ds = obj.fn_dataset(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            fn_grid();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            fn_grid();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox catname = (TextBox)GridView1.Rows[i].Cells[2].Controls[0];
            TextBox catdesc = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];
            TextBox catstatus = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];

            string update = "update Category_tb set Cat_Name='" + catname.Text + "',Cat_Desc='" + catdesc.Text + "',Cat_Status='" + catstatus.Text + "'";
            int up = obj.fn_nonquery(update);

            GridView1.EditIndex = -1;
            fn_grid();
        }
        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow rw = GridView1.Rows[e.NewSelectedIndex];
            Session["catid"] = rw.Cells[2].Text;
            Image1.ImageUrl = rw.Cells[5].Text;

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/photos/addcategory/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            string up = "update Category_tb set Cat_Image='" + p + "' where Cat_Id=" + Session["catid"] + "";
            int upd = obj.fn_nonquery(up);
            if (upd == 1)
            {
                Label2.Visible = true;
                Label2.Text = "edited successfully";
            }
        }

        //protected void LinkButton1_Command(object sender, CommandEventArgs e)
        //{
        //    int getid = Convert.ToInt32(e.CommandArgument);
        //    string sel = "select Cat_Image from Category_tb where Cat_Id=" + getid + "";
        //    SqlDataReader i = obj.fn_reader(sel);
        //    while(i.Read())
        //    {
        //        Image1.ImageUrl = i["Cat_Image"].ToString();
        //    }


        //    Session["catid"] = getid;
   // }
          
        
    }
}