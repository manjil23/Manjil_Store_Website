using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    DataClassesDataContext obj = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    private void FillPage()
    {
        //getting all the products from database

        var rec = from s in obj.Products select s;

        if (rec.Count() != null)
        {
            foreach (var record in rec)
            {
                // creating the object in the panel with image button
                //two labels
                Panel productpanel = new Panel();
                ImageButton imagebutton = new ImageButton();
                Label lblName = new Label();
                Label lblPrice = new Label();

                // set childcontrol properties
                imagebutton.ImageUrl = "~/image2/" + record.Image;
                imagebutton.CssClass = "productImage";
                imagebutton.PostBackUrl = "~/Pages/Product.aspx?id=" + record.Id;

                // display productname
                lblName.Text = record.Name;
                lblName.CssClass = "productName";

                //display price

                lblPrice.Text = "$" + record.Price;
                lblPrice.CssClass = "productPrice";

                //Add child controls to panel
                productpanel.Controls.Add(imagebutton);
                productpanel.Controls.Add(new Literal { Text = "<br/>" });
                productpanel.Controls.Add(lblName);
                productpanel.Controls.Add(new Literal { Text = "<br/>" });
                productpanel.Controls.Add(lblPrice);

                //add dynamic panels to static parent panel
                pnlproduct.Controls.Add(productpanel);

            }

        }else
        {
            //if the panel is not found
            pnlproduct.Controls.Add(new Literal { Text = "Product is not Found" });
        }
        
    }
}