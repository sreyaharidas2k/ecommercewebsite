using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	SqlConnection con = new SqlConnection(@"server=DESKTOP-N5FGT72\SQLEXPRESS;database=ecommerce1;integrated security=true");

	public int balamtchk(int accno)
    {
		string bal = "";
		string s = "select Balance_Amt from Account_tb where Account_No='" + accno + "'";
		SqlCommand cmd = new SqlCommand(s, con);
		con.Open();
		SqlDataReader dr = cmd.ExecuteReader();
		while (dr.Read())
		{
			bal = dr["Balance_Amt"].ToString();

		}
		int b = Convert.ToInt32(bal);
		
		return b;

	}
	public string GetData(int value)
    {
        return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}

	
}
