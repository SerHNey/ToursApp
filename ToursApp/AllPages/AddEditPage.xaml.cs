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

namespace ToursApp.AllPages
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Hotel currentHotel = new Hotel();
        public AddEditPage(Hotel selectHotel)
        {

            InitializeComponent();

            if (selectHotel != null)
            {
                currentHotel = selectHotel; 
            }
            DataContext = currentHotel;
            ComboCountries.ItemsSource = ToursbaseEntity.GetContext().Country.ToList();

        }

        private void BtdSave_Click(object sender, RoutedEventArgs e)
        {

            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentHotel.Name))
                errors.AppendLine("Укажите название отеля");
            if (currentHotel.CountOfStars < 1 || currentHotel.CountOfStars > 5)
                errors.AppendLine("Количество звезд - число от 1 до 5");
            if (currentHotel.Country == null)
                errors.AppendLine("Выберите страну");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (currentHotel.id == 0)
                ToursbaseEntity.GetContext().Hotel.Add(currentHotel);
            try
            {
                ToursbaseEntity.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
