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
using ClassLibrary2;

namespace ST10102647_Lufuno_Student_Self_study_Program
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

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            //Hide Main window and display AddModules window
            this.Hide();
            AddModules add = new AddModules();
            add.Show();
        }

        private void btnexit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
