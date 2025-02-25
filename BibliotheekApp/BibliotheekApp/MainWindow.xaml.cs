using System.Windows;

namespace BibliotheekApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Member> members = new List<Member>() { new Member("1","John Doe"), new Member("2", "Hulk Hogan"), new Member("3", "Lionel Messi") };
        public List<Book> books = new List<Book>() { };

        public MainWindow()
        {
            InitializeComponent();
        }

        public void RefreshProperties()
        {
            booksListBox.ItemsSource = null;
            booksListBox.ItemsSource = books;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshProperties();
        }

        private void addBookButton_Click(object sender, RoutedEventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            bool? result = addBookForm.ShowDialog();

            if (result.Value)
            {
                books.Add(addBookForm.NewBook);
                RefreshProperties();
            }
        }

        private void editBookButton_Click(object sender, RoutedEventArgs e)
        {
            Book selectedBook = booksListBox.SelectedItem as Book;

            if (selectedBook != null)
            {
                EditBookForm editBookForm = new EditBookForm(selectedBook);
                editBookForm.ShowDialog();
                RefreshProperties();
            } else
            {
                MessageBox.Show("Er is geen boek geselecteerd.");
            }
        }

        private void deleteBookButton_Click(object sender, RoutedEventArgs e)
        {
            Book selectedBook = booksListBox.SelectedItem as Book;

            if (selectedBook != null)
            {
                MessageBoxResult result = MessageBox.Show("Weet u zeker dat u het boek wilt verwijderen?", "Verwijderen", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    books.Remove(selectedBook);
                    RefreshProperties();
                }
            }
            else
            {
                MessageBox.Show("Er is geen boek geselecteerd.");
            }
        }

        private void lendBookButton_Click(object sender, RoutedEventArgs e)
        {
            Book selectedBook = booksListBox.SelectedItem as Book;

            if (selectedBook != null)
            {
                LendBookForm lendBookForm = new LendBookForm(members, selectedBook);
                lendBookForm.ShowDialog();
                RefreshProperties();
            }
            else
            {
                MessageBox.Show("Er is geen boek geselecteerd.");
            }
        }
    }
}