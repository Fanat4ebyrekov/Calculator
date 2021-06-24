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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double number1;
        public double number2;
        string operation = "";
        public char c;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                txtDisp.Text = number2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                txtDisp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                txtDisp.Text = number2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                txtDisp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                txtDisp.Text = number2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                txtDisp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                txtDisp.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                txtDisp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                txtDisp.Text = number2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                txtDisp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                txtDisp.Text = number2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                txtDisp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                txtDisp.Text = number2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                txtDisp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                txtDisp.Text = number2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                txtDisp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                txtDisp.Text = number2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                txtDisp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                txtDisp.Text = number2.ToString();
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisp.Text = "+";
        }

        private void bntMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisp.Text = "-";
        }

        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDisp.Text = "*";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisp.Text = "/";
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation) 
            {
                case "+":
                    txtDisp.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    txtDisp.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    txtDisp.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    txtDisp.Text = (number1 / number2).ToString();
                    break;
                


            }       
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
                
            }
            else
            {
                number2 = 0;
            }

            txtDisp.Text = "0";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            txtDisp.Text = "0";
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number1 = (number1 / 10);
                txtDisp.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                txtDisp.Text = number2.ToString();
            }

        }

        private void btnPosNeg_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number1 *= -1;
                txtDisp.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                txtDisp.Text = number2.ToString();
            }

        }

        
    }
}
