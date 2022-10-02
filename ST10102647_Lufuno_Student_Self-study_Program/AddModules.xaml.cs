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
using ClassLibrary2;


namespace ST10102647_Lufuno_Student_Self_study_Program
{
    /// <summary>
    /// Interaction logic for AddModules.xaml
    /// </summary>
    public partial class AddModules : Window
    {
        //initialize a list
        List<CourseData> course = new List<CourseData>() { };

        public AddModules()
        {
            InitializeComponent();
        }

        private void btnexit1_Click(object sender, RoutedEventArgs e)
        {
            //Hide Add Module window and display Main window
            this.Hide();
            MainWindow myPage = new MainWindow();
            myPage.Show();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //if nothing is inputted
            if (txtCode.Text.Equals("") || txtCredits.Text.Equals("") || txteeklyclasshours.Text.Equals("") ||
                txtTotalsemesterweeks.Text.Equals("") || txtSpecificDateHours.Text.Equals("") || txtName.Text.Equals(""))
            {
                MessageBox.Show("Please make sure to fill in all textboxes");
            }

            //try catch will check for errors
            try
            {
                course.Add(new CourseData(SemesterStart.DisplayDate,
                    txtCode.Text, txtName.Text, int.Parse(txtCredits.Text),
                    int.Parse(txteeklyclasshours.Text), int.Parse(txtTotalsemesterweeks.Text), Chosendate.DisplayDate,
                    int.Parse(txtSpecificDateHours.Text)));
                

                //Linq
                var Course_Info = from item in course
                                select item;

                couseSaved.Visibility = Visibility.Visible;

                //Add each of the modules with accompnying data to the list
                foreach (var items in Course_Info)
                {
                    _ = couseSaved.Items.Add(
                           "Module Code= " + items.ModuleCode
                        + "\nModule Name= " + items.ModuleName
                        + "\nModule Credits= " + items.ModuleCredits
                        + "\nSelf Study Hours= " + items.StudyHours()
                        + "\nRecorded Hours= " + items.Hours
                        + "\nChosen Date =" + items.SpecificDate
                        + "\nRemaining Self Study Hours =" + items.Remaining_hours()
                        + "\n---------------------");
                }
                SemesterStart.IsEnabled = false;
                lblname.Visibility = Visibility.Hidden;
                txtName.Visibility = Visibility.Hidden;
                btnName.Visibility = Visibility.Hidden;
                lblcredits.Visibility = Visibility.Hidden;
                txtCredits.Visibility = Visibility.Hidden;
                btnCredits.Visibility = Visibility.Hidden;
                lblclasshours.Visibility = Visibility.Hidden;
                txteeklyclasshours.Visibility = Visibility.Hidden;

                btnweekly.Visibility = Visibility.Hidden;
                lblsemesterweeks.Visibility = Visibility.Hidden;
                txtTotalsemesterweeks.Visibility = Visibility.Hidden;
                btnsemsweeks.Visibility = Visibility.Hidden;
                lbldatechosen.Visibility = Visibility.Hidden;
                Chosendate.Visibility = Visibility.Hidden;
                btndatechosen.Visibility = Visibility.Hidden;
                lblspecific.Visibility = Visibility.Hidden;
                txtSpecificDateHours.Visibility = Visibility.Hidden;
                btnSave.Visibility = Visibility.Hidden;
                txtCode.Text = "";
                txtCredits.Text = "";
                txteeklyclasshours.Text = "";

                txtTotalsemesterweeks.Text = "";
                txtSpecificDateHours.Text = "";
                txtName.Text = "";

            }
            catch
            {
                //null
            }
        }

        private void btnsemstart_Click(object sender, RoutedEventArgs e)
        {
            lblcode.Visibility = Visibility.Visible;
            txtCode.Visibility = Visibility.Visible;
            btncode.Visibility = Visibility.Visible;
        }

        private void btncode_Click(object sender, RoutedEventArgs e)
        {
            lblname.Visibility = Visibility.Visible;
            txtName.Visibility = Visibility.Visible;
            btnName.Visibility = Visibility.Visible;
        }

        private void btnName_Click(object sender, RoutedEventArgs e)
        {
            lblcredits.Visibility = Visibility.Visible;
            txtCredits.Visibility = Visibility.Visible;
            btnCredits.Visibility = Visibility.Visible;
        }

        private void btnClass_Click(object sender, RoutedEventArgs e)
        {
            lblclasshours.Visibility = Visibility.Visible;
            txteeklyclasshours.Visibility = Visibility.Visible;

            btnweekly.Visibility = Visibility.Visible;
        }

        private void btnweekly_Click(object sender, RoutedEventArgs e)
        {
            lblsemesterweeks.Visibility = Visibility.Visible;
            txtTotalsemesterweeks.Visibility = Visibility.Visible;
            btnsemsweeks.Visibility = Visibility.Visible;
        }

        private void btnsemsweeks_Click(object sender, RoutedEventArgs e)
        {
            lbldatechosen.Visibility = Visibility.Visible;
            Chosendate.Visibility = Visibility.Visible;
            btndatechosen.Visibility = Visibility.Visible;
        }

        private void btndatechosen_Click(object sender, RoutedEventArgs e)
        {
            lblspecific.Visibility = Visibility.Visible;
            txtSpecificDateHours.Visibility = Visibility.Visible;
            btnSave.Visibility = Visibility.Visible;
        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            ////Clearing the list
            couseSaved.Items.Clear();
        }
    }
}
