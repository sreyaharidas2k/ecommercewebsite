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
    public partial class viewcart : System.Web.UI.Page
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
                string sel = "Select Product_tb.Product_Name,Product_tb.Product_Image,Cart_tb.Product_Id,Cart_tb.Quantity,Cart_tb.Total_Price from  Product_tb join Cart_tb on Product_tb.Product_Id=Cart_tb.Product_Id";
                DataSet ds = obj.fn_dataset(sel);
                GridView1.DataSource = ds;
                GridView1.DataBind();

            string grand = "select sum(Total_Price) from Cart_tb";
            string s = obj.fn_scalar(grand);
            Label2.Text = s;
            }
        

       

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
           
            string del = "delete from Cart_tb where Product_Id=" + getid + "";
            int j = obj.fn_nonquery(del);
            fn_grid();
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
            TextBox quantity = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];
            

            string sel = "select Product_Price from Product_tb where Product_Id=" + getid + "";

            SqlDataReader dr = obj.fn_reader(sel);
            while(dr.Read())
            {
                string price1 = dr["Product_Price"].ToString();
                price1 = price1.TrimStart('$');
                Session["price"] = price1;
            }


            int quan = Convert.ToInt32(quantity.Text);
            decimal price = Convert.ToDecimal(Session["price"]);
            decimal totalprice = price * quan;
            string upd = "update Cart_tb set Quantity='"+quantity.Text+"', Total_Price=" + "$"+totalprice + " where Product_Id="+getid+"";

           
            int up = obj.fn_nonquery(upd);

            GridView1.EditIndex = -1;
            fn_grid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select Cart_Id from Cart_tb where User_Id="+Session["uid"]+"";
            List<int> list_Of_CartId = new List<int>();
            SqlDataReader dr1 = obj.fn_reader(sel);
           while(dr1.Read())
            {
                list_Of_CartId.Add(Convert.ToInt32(dr1["Cart_Id"]));
               
            }
            foreach(int i in list_Of_CartId)
            {
                string seli = "select * from Cart_tb where Cart_Id=" + i + "and User_Id="+Session["uid"]+"";
                SqlDataReader dr = obj.fn_reader(seli);
                int pid = 0;
                int quantity = 0;
                decimal tot_price = 0;
                while(dr.Read())
                {
                    pid = Convert.ToInt32(dr["Product_Id"].ToString());
                    quantity= Convert.ToInt32(dr["Quantity"].ToString());
                    tot_price= Convert.ToInt32(dr["Total_Price"].ToString());
                }
                
                string insert="insert into Order_tb values("+pid+","+Session["uid"]+","+quantity+","+"$"+tot_price+ ",'" + DateTime.Now.ToString("MM/dd/yyyy") + "','Order')";
                int insorder = obj.fn_nonquery(insert);
                string del = "delete from Cart_tb where Product_Id=" + pid + "and User_Id=" + Session["uid"] + "";
                int delcart = obj.fn_nonquery(del);
            }
            string sum = "select sum(Total_Price) from Order_tb";
            string tprice = obj.fn_scalar(sum);
            string ins = "insert into Bill_tb values(" + Session["uid"] + ", " + "$" + tprice + ",'" + DateTime.Now.ToString("MM/dd/yyyy") + "','Order')";
            int insertbill = obj.fn_nonquery(ins);

            Response.Redirect("viewbill.aspx");
        }
    }
}