using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Collections;


public partial class Pages_ManageProducts : System.Web.UI.Page
{

    DataClassesDataContext obj = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        

        if (!IsPostBack)
        {
            getimages();

            //
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                //cast the id 
                int id = Convert.ToInt32(Request.QueryString["id"]);
                //create method and pass the id of the row
                fillform(id);
            }
        }

       
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            // if the id is already in the gridview then update
            int id = Convert.ToInt32(Request.QueryString["id"]);
            update(id);
        }
        else
        {
            insert();
        }


    }

    
    private void fillform(int id)
    {
        //using linq to retive the data

        var rec = from s in obj.Products where s.Id == id select s;

        if (rec.Count()==0)
        {
            Label6.Text = "There is no product in the system";
        }
        else
        {
            foreach (var record in rec)
            {
                TextBox1.Text = record.Name;
                TextBox2.Text = record.Price.ToString();
                TextBox3.Text = record.Description;
                DropDownList1.SelectedValue = record.TypeId.ToString();
                DropDownList2.SelectedValue = record.Image;
                
                
            }
        }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    // creating a method to get the images

    private void getimages()
    {


        try
        {
            //first getting the file path
            string[] images = Directory.GetFiles(Server.MapPath("~/image2/"));

            //getting all files in that folder and adding to arraylist
            ArrayList imageList = new ArrayList();

            foreach (string image in images)
            {
                string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                imageList.Add(imageName);
            }

            // now add the names in the dropdownlist

            DropDownList2.DataSource = imageList;
            DropDownList2.AppendDataBoundItems = true;
            DropDownList2.DataBind();



        }catch(Exception e)
        {
            //giving default exception message
            Label6.Text = e.ToString();
        }
    }

    private void insert()
    {
        // if the id is not in the grideview insert
        try
        {

            Product pd = new Product();
            pd.Name = TextBox1.Text;
            pd.Price = Convert.ToInt32(TextBox2.Text);
            // product type is int because it will enter the integer value

            pd.TypeId = Convert.ToInt32(DropDownList1.SelectedValue);
            pd.Description = TextBox3.Text;
            pd.Image = DropDownList2.SelectedValue;

            obj.Products.InsertOnSubmit(pd);

            obj.SubmitChanges();

            Label6.Text = "**Product " + TextBox1.Text + " has been inserted to our System.**";

            // empty the textbox after the data has been inserted into database

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";

        }
        catch (FormatException)
        {
            Label6.Text = "Wrong Formate entered for input.";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
        catch (Exception ex)
        {
            Label6.Text = ex.ToString();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

    }

    private void update(int id)
    {

        var rec = from s in obj.Products where s.Id == id select s;

        foreach (var record in rec)
        {

            record.Name = TextBox1.Text;
             record.Price = Convert.ToInt32(TextBox2.Text);
             record.Description = TextBox3.Text;
             record.TypeId =   Convert.ToInt32(DropDownList1.SelectedValue);
             record.Image = DropDownList2.SelectedValue;
            
        }
        obj.SubmitChanges();

        Label6.Text = "**Update has been Successfull.**";

        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        
    }
  
}