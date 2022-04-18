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
using SaleLibrary;

namespace WPF_EX2022.FolderPage
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        List<OrderTable> orderTables = new List<OrderTable>();
        List<BookMarket> bookMarkets = FolderClass.BD.Data.BookMarket.ToList();

        public MainPage()
        {
            InitializeComponent();
            LVmarket.ItemsSource = FolderClass.BD.Data.BookMarket.ToList();          
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            int ind = Convert.ToInt32(B.Uid);

            OrderTable UsOrder = new OrderTable();
            List<OrderTable> orders = FolderClass.BD.Data.OrderTable.ToList();

            UsOrder.BookId = ind;
            int MaxCount = bookMarkets[ind-1].CountInMarket + bookMarkets[ind-1].CountInStock;
            int UsCount = 0;

            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].BookId == ind)
                {
                    UsCount++;
                }
            }
            if (UsCount >= MaxCount)
            {
                MessageBox.Show("Информация", "Больше заказать нельзя", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                FolderClass.BD.Data.OrderTable.Add(UsOrder);
                FolderClass.BD.Data.SaveChanges();
                orderTables = FolderClass.BD.Data.OrderTable.ToList();
                MessageBox.Show("Добавление", "Данные добавлены в корзину", MessageBoxButton.OK, MessageBoxImage.Information);
                int sale = Class1.SaleCalc(orderTables.Count, CalcCost(orderTables));

                if (sale>0)
                {
                    TBOXCostWithoutSale.Text = CalcCost(orderTables) + "";                  
                }
                TBOXSale.Text = sale + " %";
                double Dsale = sale;
                double cost = CalcCost(orderTables)*( 1 -(Dsale / 100));
                TBOXCost.Text = cost + "";

                TBOXCountBook.Text = "Колличество выбранных книг: "+ orderTables.Count+"";
            }           
        }

        public float CalcCost(List<OrderTable> list)
        {
            double Coast = 0;
            for (int i = 0; i < list.Count; i++)
            {
                Coast += (double)bookMarkets[list[i].BookId-1].Cost;
            }
            return (float)Coast;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FolderClass.PageSwitch.frame.Navigate(new BasketPage(orderTables));
        }
    }
}
