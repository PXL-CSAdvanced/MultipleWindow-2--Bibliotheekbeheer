using System.Windows;

namespace BibliotheekApp
{
    /// <summary>
    /// Interaction logic for LendBookForm.xaml
    /// </summary>
    public partial class LendBookForm : Window
    {
        public Member selectedMember;
        public Book selectedBook;

        public LendBookForm(List<Member> members, Book book)
        {
            InitializeComponent();
            membersComboBox.ItemsSource = members;
            selectedBook = book;
        }

        private void lendBookButton_Click(object sender, RoutedEventArgs e)
        {
            selectedMember = membersComboBox.SelectedItem as Member;

            if (selectedMember != null)
            {
                selectedBook.IsAvailable = false;
                selectedBook.Member = selectedMember;

                DialogResult = true;
                this.Close();
            } else
            {
                MessageBox.Show("Geen uitlener geselecteerd.");
            }
            
        }
    }
}
