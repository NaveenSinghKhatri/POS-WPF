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
        
        POS db = new POS();

        public AddProduct()
        {
            InitializeComponent();

            // Show Categories List in  comboCategories box
           
            var categorylist = db.Categories.ToList();
            
            this.comboCategories.ItemsSource = categorylist;
            this.comboCategories.DisplayMemberPath = "ProductCategory";
            this.comboCategories.SelectedValuePath = "ID";
        }
        

       
        public void btnOk_Click(object sender, RoutedEventArgs e)
        {

            var p = new Product();
            //add product id, product name, desc, barcode, ProductCategory, costprice, selling price,
            //stock on hand, 
                p.ID = Convert.ToInt32(txtProductID.Text);
                p.Name = txtProductName.Text;
                p.Description = txtProductDescription.Text;
                p.Barcode = txtProductBarcode.Text;
                p.Category = Convert.ToInt32(comboCategories.SelectedValue);
                p.CostPrice = Convert.ToInt32(txtCostPrice.Text);
                p.SellingPrice = Convert.ToInt32(txtSellingPrice.Text);
                p.SOH = Convert.ToInt32(txtSOH.Text);
                db.Products.Add(p);
                db.SaveChanges();
            ClearWindow();
         }

        public void ClearWindow()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtProductDescription.Clear();
            txtProductBarcode.Clear();
            txtCostPrice.Clear();
            txtSellingPrice.Clear();
            txtSOH.Clear();
                        

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
            

        }

        private void txtProductID_TextChanged(object sender, TextChangedEventArgs e)
        {
          
                
         }

        private void comboCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }

        private void AddProduct_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Window3 Win3 = new Window3();
            Win3.Show();
            
        }
    }
    }

