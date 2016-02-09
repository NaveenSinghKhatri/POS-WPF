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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        POS db = new POS();
        int activegrid = 0;
        
        public Window3()
        {
            InitializeComponent();
            Add_Categories.IsEnabled = true;
            DisplayProductsList();
            LoadCategories();
            
        }



        //Display Products List in the List Box
        public void DisplayProductsList()
        {
            var ProductList = db.Products.ToList();

            this.listBox.ItemsSource = ProductList;
            this.listBox.DisplayMemberPath = "Name";
            this.listBox.SelectedValuePath = "ID";

            //                    ---xxx---    
        }





        public void LoadCategories()
        {
            var clist = db.Categories.ToList();



            //Display Category image and name in the  list



            //label list
            Label[] labels = new Label[] { c0, c1, c2, c3,c4,c5,c6,c7,c8,c9,c10,c11,c12,c13,c14,c15,c16,c17,c18,c19,c20,c21,c22,c23,c24,c25,c26,c27,c28,c29,c30,c31,c32,c33,c34,c35,c36,c37,c38,c39 };
            //image list

            Image[] images = new Image[] { image0, image1, image2, image3, image4,image5,image6, image7,image8,image9,image10,image11,image12, image13,image14,image15,image16,image17,image18,image19,image20,image21,image22,image23,image24,image25,image26,image27,image28,image29,image30,image31,image32,image33,image34,image35,image36,image37,image38,image39 };

           
            //gridlist
            Grid[] grids = new Grid[] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10 };
            int NumOfGrids = (clist.Count() / 4);
            NumOfGrids += 1;

            //make sure first Grid of Categories (g1) is visible
            grids[activegrid].Visibility = System.Windows.Visibility.Visible;


            for (int i = 0; i != clist.Count(); i++)
            {

                labels[i].Content = clist[i].ProductCategory;
                labels[i].Foreground = new SolidColorBrush(Colors.White);



                //Call Byte to image converter by sending the Array files into the function and return with the actual file


                images[i].Source = ByteImageConverter.ByteToImage(clist[i].CategoryImage);
                



                //               --- xxxx ----------- 

            }
        }
        
        // Convert binaries to images
        public class ByteImageConverter
        {
            public static ImageSource ByteToImage(byte[] imageData)
            {
                BitmapImage biImg = new BitmapImage();
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageData);
                biImg.BeginInit();
                biImg.StreamSource = ms;
                biImg.EndInit();

                ImageSource imgSrc = biImg as ImageSource;

                return imgSrc;
            }
        }




        
        private void Add_Product_Click(object sender, RoutedEventArgs e)
        {

            AddProduct newProduct = new AddProduct();
            newProduct.Show();
            Close();
        }

        private void Add_Categories_Click_1(object sender, RoutedEventArgs e)
        {
            Window4 AddaCategory = new Window4();
            AddaCategory.Show();
            this.Hide();
        }

        public void btnNext_Click(object sender, RoutedEventArgs e)
        {
        
        nextGrid();

        }

       public void nextGrid()
        {
            var clist = db.Categories.ToList();
            int NumberOfGrids = (clist.Count / 4) + 1;
            Grid[] grids = new Grid[] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10 };
            grids[activegrid].Visibility = System.Windows.Visibility.Hidden;
            activegrid += 1;
            if (activegrid == NumberOfGrids)
            {
                activegrid = 0;
                grids[activegrid].Visibility = System.Windows.Visibility.Visible;
                
            }
            else
            {
                
                grids[activegrid].Visibility = System.Windows.Visibility.Visible;
                
            };
            
           
            
 }

        public void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            prevgrid();
        }

        public void prevgrid()
        {
            var clist = db.Categories.ToList();
            int NumberOfGrids = (clist.Count / 4) + 1;
            Grid[] grids = new Grid[] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10 };
            grids[activegrid].Visibility = System.Windows.Visibility.Hidden;
            
            if (activegrid == 0)
            {
                activegrid = NumberOfGrids- 1; 
                grids[activegrid].Visibility = System.Windows.Visibility.Visible;
                
            }
            else
	        {
                activegrid -= 1;
                grids[activegrid].Visibility = System.Windows.Visibility.Visible;
            };
            
        }
    }
}

    