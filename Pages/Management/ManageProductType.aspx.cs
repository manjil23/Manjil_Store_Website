using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Text;
using System.IO;


public partial class Pages_ManageProductType : System.Web.UI.Page
{

    // this object will help to communicate between data and the front-end
    DataClassesDataContext obj = new DataClassesDataContext();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ProductType ptype = new ProductType();
        ptype.Name = TextBox1.Text;

        //this command will insert the producttpe on submit

        obj.ProductTypes.InsertOnSubmit(ptype);

        obj.SubmitChanges();

        //this event is to upload the image
        //this will collect the filename
        string filename = Path.GetFileName(FileUpload1.FileName);
        //save the file name in image2 folder
        FileUpload1.SaveAs(Server.MapPath("~/image2/") + filename);
        //display the message
        Label2.Text = "** " + TextBox1.Text + " has been inserted and the file has been uploaded. **";
        TextBox1.Text = "";
        

    }
}