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

namespace WPF_EX2022.FolderPage
{
    /// <summary>
    /// Логика взаимодействия для BasketPage.xaml
    /// </summary>
    public partial class BasketPage : Page
    {
        List<OrderTable> orderTables = new List<OrderTable>();
        public BasketPage(List<OrderTable> orderTables)
        {
            InitializeComponent();
            this.orderTables = orderTables;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FolderClass.PageSwitch.frame.Navigate(new MainPage());
        }
    }
}
