using System.Windows;

namespace BibliotheekApp
{
    /// <summary>
    /// Interaction logic for AddBookForm.xaml
    /// </summary>
    public partial class AddBookForm : Window
    {
        public Book NewBook;

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string isbn = isbnTextBox.Text;
            string title = titleTextBox.Text;
            string author = authorTextBox.Text;

            if (string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
            {
                MessageBox.Show("De velden zijn verplicht. Gelieve deze in te vullen.");
                return;
            }

            NewBook = new Book();
            NewBook.ISBN = isbn;
            NewBook.Title = title;
            NewBook.Author = author;

            DialogResult = true;
            this.Close();
        }
    }
}
