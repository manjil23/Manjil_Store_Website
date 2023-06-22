using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Product : System.Web.UI.Page
{

    DataClassesDataContext obj = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        Fillpage();
    }

    private void Fillpage()
    {
        // getting selected product data

        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);

            // fill the page created with the data using linq

            var rec = from s in obj.Products where s.Id==id select s;

            foreach (var records in rec)
            {
                lblprice.Text = "Price per unit: $ " + records.Price;
                lbltitle.Text = records.Name;
                lbldescription.Text = records.Description;
                lblitemnumber.Text = id.ToString();
                imageProduct.ImageUrl = "~/image2/" + records.Image;

            }

            // fill the drop down list with number 1 to 20

            int[] amount = Enumerable.Range(1, 20).ToArray();

            ddlamount.DataSource = amount;
            ddlamount.AppendDataBoundItems = true;
            ddlamount.DataBind();


        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
      if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
      {
          try
          {
              string clientId = "-1";
              int id = Convert.ToInt32(Request.QueryString["id"]);
              int amount = Convert.ToInt32(ddlamount.SelectedValue);

              Cart cart = new Cart();

              cart.Amount = amount;
              cart.ClientId = clientId;
              cart.DatePurchased = DateTime.Now;
              cart.IsInCart = true;
              cart.ProductID = id;

              obj.Carts.InsertOnSubmit(cart);

              obj.SubmitChanges();


              Label2.Text = amount + " product has been added successfully.";
          }catch(Exception ex)
          {
              Label2.Text = ex.Message;
          }
          
      }
    }


}