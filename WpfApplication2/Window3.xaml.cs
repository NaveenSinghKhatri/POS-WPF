﻿using System;
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
        public Window3()
        {
            InitializeComponent();

            //Display Products List in the List Box
            var ProductList = db.Products.ToList();
            this.listBox.ItemsSource = ProductList;
            this.listBox.DisplayMemberPath = "Name";
            this.listBox.SelectedValuePath = "ID";

        } 

        private void Add_Categories_Click(object sender, RoutedEventArgs e)
        {
            Window4 addCategories = new Window4();
            addCategories.Show();

        }

        private void Add_Product_Click(object sender, RoutedEventArgs e)
        {
            AddProduct newProduct = new AddProduct();
            newProduct.Show();
        }

       
    }
}
