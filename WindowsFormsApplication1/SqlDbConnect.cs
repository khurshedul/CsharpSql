using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
public class SqlDbConnect
{
    private SqlConnection con;
    public SqlCommand Cmd;
    private SqlDataAdapter sda;
    public DataTable dta;

    public SqlDbConnect()
    {
        con = new SqlConnection(@"Data Source=SAYEM-PC;Initial Catalog=sayem;Integrated Security=True;Pooling=False");
        con.Open();
    }

    public void SqlQuery(string queryText)
    {
        Cmd = new SqlCommand(queryText, con);
    }

    public DataTable QueryEx()
    {
        sda = new SqlDataAdapter(Cmd);
        dta = new DataTable();
        sda.Fill(dta);
        return dta;
    }

    public void NonQueryEx()
    {
        try
        {
            Cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}