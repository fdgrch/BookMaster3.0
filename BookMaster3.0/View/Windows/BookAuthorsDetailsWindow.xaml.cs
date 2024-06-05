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

namespace BookMaster3._0.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для BookAuthorsDetailsWindow.xaml
    /// </summary>
    public partial class BookAuthorsDetailsWindow : Window
    {
        public BookAuthorsDetailsWindow(BookAuthor seleselectedBookAuthor)
        {
            InitializeComponent();
            AuthorsCmb.ItemsSource = App.context.Author.ToList();
            AuthorsCmb.SelectedItem = seleselectedBookAuthor.Author;
            AuthorsCmb.DisplayMemberPath = "FullName";
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void AuthorCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BookAuthor selectedBookAuthor = AuthorsCmb.SelectedItem as BookAuthor;
            AuthorsGrid.DataContext = selectedBookAuthor;

        }

        private void CloseBtn_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void AuthorsCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}