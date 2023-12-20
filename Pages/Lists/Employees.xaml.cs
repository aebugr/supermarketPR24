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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SupermarketBugrina.Pages
{
    /// <summary>
    /// Логика взаимодействия для Employees.xaml
    /// </summary>
    public partial class Employees : Page
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void AddEmployees(object sender, RoutedEventArgs e)
        {

        }

        private void GoodsGo(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPage(new Pages.Goods());
        }

        private void DepartamentsGo(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPage(new Pages.Departaments());
        }
    }
}
