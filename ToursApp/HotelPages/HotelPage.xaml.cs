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

namespace ToursApp.HotelPades
{
    /// <summary>
    /// Логика взаимодействия для HotelPage.xaml
    /// </summary>
    public partial class HotelPage : Page
    {
        public HotelPage()
        {
            InitializeComponent();
            //DGridHotels.ItemsSource = Toursbase43PDSEntities.GetContext().Hotel.ToList(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AllPages.AddEditPage());
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AllPages.AddEditPage());
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
           // Manager.MainFrame.Navigate(new AllPages.ClientPage);
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Toursbase43PDSEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
               // DGridHotels.ItemsSource = Toursbase43PDSEntities.GetContext().Hotel.ToList();
            }
        }

        private void BtnUserPage_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
