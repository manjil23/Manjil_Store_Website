using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Data;

public partial class Management_Management : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void grdproducts_RowEditing(object sender, GridViewEditEventArgs e)
    {
        // first get the selected row
        GridViewRow row = grdproducts.Rows[e.NewEditIndex];

        //get the id of the selected row
        int rowid = Convert.ToInt32(row.Cells[1].Text);

        //redirect the user to manageproduct with the selected id
        Response.Redirect("~/Pages/Management/ManageProducts.aspx?id=" + rowid);
    }
    protected void grdproductstype_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void grdproductstype_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
      

    }
    protected void grdproductstype_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        if (e.Exception!=null)
        {
            Label1.Text = "**Product Type is associated with Product, please delete product first.**";
            e.ExceptionHandled = true;
        }

        if (!IsPostBack)
        {
            Label1.Text = "";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       // string filename = Path.GetFileName(FileUpload1.)
    }
}