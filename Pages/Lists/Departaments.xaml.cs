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
    /// Логика взаимодействия для Departaments.xaml
    /// </summary>
    public partial class Departaments : Page
    {
        public Departaments()
        {
            InitializeComponent();
        }

        private void AddDepartaments(object sender, RoutedEventArgs e)
        {

        }

        private void EmployeesGo(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPage(new Pages.Employees());
        }

        private void GoodsGo(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPage(new Pages.Goods());
        }
    }
}
