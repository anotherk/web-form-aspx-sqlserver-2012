using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page
{
    SqlConnection cnx = new SqlConnection("Server=Edgar-PC\\SQLEXPRESS;Database=Diccionario;Trusted_Connection=True");
    DataSet dst = new DataSet();

    //int posicion = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        //string cadCnx = "Server=Edgar-PC\\SQLEXPRESS;Database=Diccionario;Trusted_Connection=True";
        //SqlConnection cnx = new SqlConnection(cadCnx);
        SqlCommand cmd = new SqlCommand("", cnx);
        SqlDataAdapter adp = new SqlDataAdapter("", cnx);

        try
        {
            cmd.CommandText = "Select * From Palabras";
            adp.SelectCommand = cmd;
            adp.Fill(dst);
            //lblResult.Text = "DataSet rellenado!";
            //Response.Write("<script languaje = javascript>alert('Dataset Rellenado');</script>");
            cnx.Open();
            cnx.Close();

        }
        catch (Exception ex)
        {

        }
       
        txtLetraA.Text = dst.Tables[0].Rows[0][0].ToString();
        txtLetraB.Text = dst.Tables[0].Rows[0][1].ToString();

    }
    protected void btnGenerar_Click(object sender, EventArgs e)
    {

        cnx.Open();
        DataTable dt = new DataTable();
        DataSet dst = new DataSet();
        dst.Tables.Add(dt);
        SqlDataAdapter adp = new SqlDataAdapter("SELECT TOP 2 letraA, letraB FROM Palabras ORDER BY NEWID()", cnx);
        adp.Fill(dt);

        txtLetraA.Text = dst.Tables[0].Rows[0][0].ToString();
        txtLetraB.Text = dst.Tables[0].Rows[0][1].ToString();

        cnx.Close();
        
    }
}
