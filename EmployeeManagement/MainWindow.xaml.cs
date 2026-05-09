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

namespace EmployeeManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List to store emloyees in memory
        private List<Employee> employees = new List<Employee>();

        //this will track which employee is selected in the listbox
        private int selectedindex = -1;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnadd_click(object sender, RoutedEventArgs e)
        {
            //validate input first
            if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtage.Text) ||
                string.IsNullOrWhiteSpace(txtdepartment.Text) || string.IsNullOrWhiteSpace(txtposition.Text) )
            {
                MessageBox.Show("please fill all the fields");
                return;
            }
            //validate age
            if (!int.TryParse(txtage.Text, out int age))
            {
                MessageBox.Show("please please enter a valid age");
                return;
            }
            //create new employee object
            Employee employee = new Employee()
            {
                name = txtname.Text,
                age = age,
                department = txtdepartment.Text,
                position = txtposition.Text,
            };

            //add employee to list
            employees.Add(employee);

            //refresh the listbox
            //refreshemployeelist()

            //clear inputs
            //Clearfields();

            MessageBox.Show("employee added successfully");
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
