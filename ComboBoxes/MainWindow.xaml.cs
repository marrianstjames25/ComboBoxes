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

namespace ComboBoxes
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

        private void cmbx__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ComboBox mybox = new ComboBox();
            mybox.Items.Add("Log In as Student");
            mybox.Items.Add("Log In as Teacher");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (cmbx_.SelectedIndex == cmbx_.Items.Count - 2) 
            {

                LogInStudent logInStudent = new LogInStudent();
                logInStudent.Show();
                this.Close();

            } 
            else
            {
                LogInTeacher lgt = new LogInTeacher();  
                lgt.Show();
                this.Close();

            }



        }
    }
}
