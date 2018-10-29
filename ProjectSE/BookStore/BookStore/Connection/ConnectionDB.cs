using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

public class ConnectionDB
{
    public static string strcon;

    public static void connectsql()
    {
        /* Windows Authentacation
       strcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True";
       */

        // SQL Sever Authentacation
        strcon = "Data Source=.\\SQLEXPRESS;Initial Catalog=BookStore; User ID = Qwer; password=1234;";
        
        /* SQL IP
        strcon = "Data Source=10.5.50.35;Initial Catalog=BookStore;User ID=Qwer;Password=1234;";
        */
    }

    public static DataTable executsql(string sql)
    {
        SqlDataAdapter dtAdapter = default(SqlDataAdapter);
        SqlConnection objConn = new SqlConnection();
        DataTable dt = new DataTable();
        try
        {
            objConn.ConnectionString = strcon;
            objConn.Open();
            dtAdapter = new SqlDataAdapter(sql, objConn);
            dtAdapter.Fill(dt);
            objConn.Close();
            objConn = null;
            return dt;
        }
        catch (Exception exx)
        {
            Console.Write(exx.ToString());
            dt = null;
        }
        return dt;
    }

}
