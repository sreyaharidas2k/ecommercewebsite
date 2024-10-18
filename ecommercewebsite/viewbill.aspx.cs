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
    public partial class viewbill : System.Web.UI.Page
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
                string sel = "SELECT dbo.Order_tb.Order_Id, dbo.Order_tb.Product_Id, dbo.Product_tb.Product_Name, dbo.Order_tb.Quantity, dbo.Order_tb.Total_Price FROM dbo.Order_tb INNER JOIN dbo.Product_tb ON dbo.Order_tb.Product_Id = dbo.Product_tb.Product_Id and dbo.Order_tb.User_Id="+Session["uid"]+"";
                DataSet ds = obj.fn_dataset(sel);
                GridView1.DataSource = ds;
                GridView1.DataBind();

                string grand = "select sum(Total_Price) from Order_tb";
                string s = obj.fn_scalar(grand);
                Label13.Text = s;

            string user= "select User_Name,User_Address from User_tb where User_Id=" + Session["uid"] + "";
            SqlDataReader dr = obj.fn_reader(user);
            while(dr.Read())
            {
                Label4.Text = dr["User_Name"].ToString();
                Label14.Text = dr["User_Address"].ToString();
            }

            string billid= "select Bill_Id from Bill_tb where User_Id=" + Session["uid"] + "";
            SqlDataReader dr1 = obj.fn_reader(billid);
            while (dr1.Read())
            {
                Label6.Text = dr1["Bill_Id"].ToString();
                Label11.Text = DateTime.Now.ToString("MM/dd/yyyy");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string ins = "insert into Account_tb values(" + Session["uid"] + ",'" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "','" + TextBox4.Text + "'," + TextBox5.Text + ")";
            int insert = obj.fn_nonquery(ins);

            Session["Account_No"] = TextBox2.Text;

            PaymentService.ServiceClient ob = new PaymentService.ServiceClient();
            int bal = ob.balamtchk(Convert.ToInt32(Session["Account_No"]));
            TextBox7.Text = bal.ToString();

            string grand = "select sum(Total_Price) from Order_tb";
            string s = obj.fn_scalar(grand);
            int grndtot = Convert.ToInt32(s);
            if (grndtot > bal)
            {
                Label23.Text = "insufficient amount";
            }
            else
            {
                int remamt = bal - grndtot;
                string upd = "update Account_tb set Balance_Amt=" + remamt + " where Account_No=" + Session["Account_No"] + "";
                int up = obj.fn_nonquery(upd);
                Label23.Text = "Successfully Paid";
                string upd1 = "update Bill_tb set Order_Status='Paid' where  User_Id=" + Session["uid"] + "";
                int up1 = obj.fn_nonquery(upd1);
                string upd2 = "update Order_tb set Order_Status='Paid' where  User_Id=" + Session["uid"] + "";
                int up2 = obj.fn_nonquery(upd2);
            }


            string sel = "select Product_Id from Order_tb where Order_Status='Paid' and User_Id=" + Session["uid"] + "";
            List<int> list_Of_ProducId = new List<int>();
            SqlDataReader dr1 = obj.fn_reader(sel);
            while (dr1.Read())
            {
                list_Of_ProducId.Add(Convert.ToInt32(dr1["Product_Id"]));

            }
            foreach (int i in list_Of_ProducId)
            {
                string selstockquan = "select Product_tb.Product_Stock,Order_tb.Quantity from Product_tb INNER JOIN Order_tb ON  Product_tb.Product_Id =" + i + "";
                SqlDataReader dr = obj.fn_reader(selstockquan);
                int st=0;
                int q = 0;
                while (dr.Read())
                {
                     st = Convert.ToInt32(dr["Product_Stock"].ToString());
                    q = Convert.ToInt32(dr["Quantity"].ToString());

                }
                //string selquan = "select Quantity from Order_tb where Product_Id=" + i + "";
                //SqlDataReader dr3 = obj.fn_reader(selquan);
                //int q=0;
                //while (dr3.Read())
                //{
                //     q = Convert.ToInt32(dr["Quantity"].ToString());
                   
                //}
                int stkup = st - q;

                string updstk = "update Product_tb set Product_Stock=" + stkup + " where Product_Id=" + i + "";
                int up = obj.fn_nonquery(updstk);
                
            }
        }

      
    }
    
}