using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public AddProduct()
        {
            InitializeComponent();
            //trial
            FillCategoriesComboBox();
            // xx


    }

        // << --              Bind COMBOBOX     Trial & Error                   -- >>    //
       











        // << --                 XXXXXXXXXXXXXXXXXXXXXXX             -- >>    //
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            using (var details = new POS())
            {
                var p = new Product();
                //add product id, product name, desc, barcode, costprice, selling price,
                //stock on hand 
                p.ID = Convert.ToInt32(txtProductID.Text);
                p.Name = txtProductName.Text;
                p.Description = txtProductDescription.Text;
                p.Barcode = txtProductBarcode.Text;

                p.CostPrice = Convert.ToInt32(txtCostPrice.Text);
                p.SellingPrice = Convert.ToInt32(txtSellingPrice.Text);
                p.SOH = Convert.ToInt32(txtSOH.Text);
                details.Products.Add(p);
                details.SaveChanges();
                Close();

            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }

        private void txtProductID_TextChanged(object sender, TextChangedEventArgs e)
        {
          
                
         }

        }
    }

