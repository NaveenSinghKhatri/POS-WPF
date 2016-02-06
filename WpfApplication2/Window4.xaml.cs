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
using System.IO;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }
        //<<Add Categories >> 

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            FileStream Stream = new FileStream(Convert.ToString(lblFilename.Content), FileMode.Open, FileAccess.Read);
            StreamReader Reader = new StreamReader(Stream);
            Byte[] ImgData = new Byte[Stream.Length - 1];
            Stream.Read(ImgData, 0, (int)Stream.Length - 1);
            using (var details = new POS())
            {
                //-- add image to table-- 
                var c = new Category();

                /// DONE PARTS DONT DELETE 
                c.ID = Convert.ToInt32(txtCategoryID.Text);
                c.ProductCategory = txtCategoryName.Text;
                c.CategoryImage = ImgData;
                details.Categories.Add(c); 
                details.SaveChanges(); 
                ClearWindow();

                //-- -------------------------->>>>>>>>>>>>>>>>>>>
                
            }
        
                       
        }
        //Convert BitmapImage to byte[] array
       
        public void ClearWindow()
        {
            txtCategoryID.Clear();
            txtCategoryName.Clear();
            imgCategoryImage.Source = null;

        }
        //<< --------------------------   >>//
        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".jpg";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                lblFilename.Content = filename;
                imgCategoryImage.Source = new BitmapImage(new Uri(filename));
            }

        }
       
    }
}
