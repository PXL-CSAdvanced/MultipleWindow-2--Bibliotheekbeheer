using System.Windows;

namespace BibliotheekApp
{
    /// <summary>
    /// Interaction logic for EditBookForm.xaml
    /// </summary>
    public partial class EditBookForm : Window
    {
        Book bookToEdit;

        public EditBookForm(Book book)
        {
            InitializeComponent();
            bookToEdit = book;
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            bookToEdit.Title = titleTextBox.Text;
            bookToEdit.Author = authorTextBox.Text;

            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            isbnTextBox.Text = bookToEdit.ISBN;
            titleTextBox.Text = bookToEdit.Title;
            authorTextBox.Text = bookToEdit.Author;
        }
    }
}
