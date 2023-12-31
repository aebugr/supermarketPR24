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

namespace SupermarketBugrina.Pages
{
    /// <summary>
    /// Логика взаимодействия для Goods.xaml
    /// </summary>
    public partial class Goods : Page
    {
        public Goods()
        {
            InitializeComponent();
        }

        private void AddGoods(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPage(new Pages.AddItem.NewGoods());
        }

        private void EmployeesGo(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPage(new Pages.Employees());
        }

        private void DepartamentsGo(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPage(new Pages.Departaments());
        }
    }
}
