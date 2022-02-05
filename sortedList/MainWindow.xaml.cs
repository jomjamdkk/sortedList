using System.Collections;
using System.Windows;

namespace sortedList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
        }
        SortedList list = new SortedList();
     
        private void AddBtn_click(object sender, RoutedEventArgs e)
        {
            list.Add(Keytxt.Text,Valuetxt.Text);
        }

        private void ShowBtn_Click(object sender, RoutedEventArgs e)
        {
            ICollection collection = list.Keys;
            string allValue = "All Value :\n";
            foreach (string key in collection)
            {
                allValue = allValue + "   " + list[key] + "\n";
            }
            MessageBox.Show(allValue);
        }
    }
}
