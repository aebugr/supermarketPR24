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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SupermarketBugrina.Pages.AddItem
{
    /// <summary>
    /// Логика взаимодействия для NewGoods.xaml
    /// </summary>
    public partial class NewGoods : Page
    {
        public NewGoods()
        {
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPage(new Pages.Goods());
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPage(new Pages.Goods());
        }
    }
}
