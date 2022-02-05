using System;
using System.Collections;
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
