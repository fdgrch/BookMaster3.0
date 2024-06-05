using BookMaster3._0;
using BookMaster3._0.View.Windows;
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
using System.Windows.Shapes;

namespace Bookmaster.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для BrowseCatalogWindow.xaml
    /// </summary>
    public partial class BrowseCatalogWindow : Window
    {
        public BrowseCatalogWindow()
        {
            InitializeComponent();
            BookAuthorsLv.ItemsSource = App.context.BookAuthor.ToList();

            CountOfPagesTbl.DataContext = App.context.Book.ToList();

            BookAuthorsLv.SelectedIndex = 0;
        }

        private void ExitMi_Click(object sender, RoutedEventArgs e)
        {
           Close();
        }
        //Событие BookAuthorsLv_SelectionChanged отслеживает изменение выбора элемента в списке
        private void BookAuthorsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Передача информации из выбранного элемента
            //1) Добавляем в контекст данныых выбранный элемент из списка ListView
            BookDetailsGrid.DataContext = BookAuthorsLv.SelectedItem as BookAuthor;
            //2) B Xaml - коде реализуем привяхку данных
        }

        private void LoginMi_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            LogoutMi.Visibility = Visibility.Visible;
            LoginMi.Visibility = Visibility.Collapsed;
            LibraryMi.Visibility = Visibility.Visible;
        }

        private void LogoutMi_Click(object sender, RoutedEventArgs e)
        {
            LogoutMi.Visibility = Visibility.Collapsed;  
            LoginMi.Visibility = Visibility.Visible;
            LibraryMi.Visibility = Visibility.Collapsed;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
       


        }

        private void ReportsMi_Click(object sender, RoutedEventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }

        private void CirculationMi_Click(object sender, RoutedEventArgs e)
        {
            Circulation circulation = new Circulation();
            circulation.Show();
           
        }

        private void ManageMi_Click(object sender, RoutedEventArgs e)
        {
            ManageCutomers manageCutomers = new ManageCutomers();
            manageCutomers.Show();

        }

        private void LibraryMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            BookAuthorsLv.ItemsSource = App.context.BookAuthor.Where(ba => ba.Book.Title.Contains(titleTb.Text) && ba.Author.LastName.Contains(AuthorTb.Text)).ToList()     ;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            BookAuthorsDetailsWindow bookauthdw = new BookAuthorsDetailsWindow(BookAuthorsLv.SelectedItem as BookAuthor);
            bookauthdw.Show();
        }
    }
}
