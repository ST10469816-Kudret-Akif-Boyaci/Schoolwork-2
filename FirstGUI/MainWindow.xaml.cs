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

namespace FirstGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// introducing the GUI development with 2 sections
    /// 1. front devilopment - edit the XAML file to display on the user interface
    /// 2. back end development - edit the related C# class file
    /// for thisexample - the same calculator app we did with the console
    /// operations on the back end of the app - C# classes
    /// operations: - + / *
    /// present the results on the user interface - be in the XAML
    /// use the results on the user interface _be in the XAML
    /// use the events with evet holders to then link th operation results to UI
    /// Click a button - perform an event: this event will have its own event holder to then relate the results
    /// </summary>
    public partial class MainWindow : Window
    {

        private string Currentnumber = string.Empty;
        private string selectedoperator = string.Empty;
        private double result = 0;
        private bool isnewnumber = true;

        public MainWindow() // entry point of the application - similarly to console: main method
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Content.ToString();

            if (isnewnumber)
            {
                txtOutput.Text = number;
                isnewnumber = false;
            }
            else
            {
                if (txtOutput.Text == "0")
                {
                    txtOutput.Text = number;
                }
                else
                {
                    txtOutput.Text += number;
                }
            }
            Currentnumber = txtOutput.Text;
        }
        //add a method to check if our variables are null or empty
        private void operator_click(object sender, RoutedEventArgs e)
        {
            Button button = ( Button )sender;
            string newoperator = button.Content.ToString();

            if(!string.IsNullOrEmpty(selectedoperator))
            {
                //if there is already an operator selected, calculate the immediate result
                CalculateResult();
            }
            else
            {
                //first operator pressed, just store the number
                result = double.Parse(Currentnumber);
            }
            selectedoperator = newoperator;
            isnewnumber = true;
        }
        private void CalculateResult()
        {
            if(!string.IsNullOrEmpty (Currentnumber) && !string.IsNullOrEmpty(selectedoperator))
            {
                double number = double.Parse (Currentnumber);

                switch (selectedoperator)
                {
                    case "+":
                        result += number;
                        break;
                    case "-":
                        result -= number;
                        break;
                    case "*":
                        result *= number;
                        break;
                    case "/":
                        if (number != 0)
                            result /= number;
                        else
                            MessageBox.Show("cannot be divided by 0");
                        break;
                }
                txtOutput.Text = result.ToString();
                Currentnumber = result.ToString ();
                selectedoperator = string.Empty;
            }
        }
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            CalculateResult ();
            isnewnumber = true;
        }
    }
}
