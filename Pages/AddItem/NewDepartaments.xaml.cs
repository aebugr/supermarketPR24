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

namespace SupermarketBugrina.Pages.AddItem
{
    /// <summary>
    /// Логика взаимодействия для NewDepartaments.xaml
    /// </summary>
    public partial class NewDepartaments : Page
    {
        public NewDepartaments()
        {
            InitializeComponent();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPage(new Pages.Departaments());
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPage(new Pages.Departaments());
        }
    }
}
