using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace CalculatorProject
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double value;
        double savedValue;
        string operation;

        double resultado;

        string campoTotal;

        public MainWindow()
        {
            InitializeComponent();

            

        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            Campo.Text = "0";
            campoTotal = "";
            UpperCamp.Text = "";
        }
        private void Button_Igual(object sender, RoutedEventArgs e)
        {
            try { value = double.Parse(Campo.Text); } catch { }
            


            switch (operation)
            {
                case "+":
                    resultado = savedValue + value;
                    Campo.Text = resultado.ToString();
                    UpperCamp.Text = savedValue + " + " + value;
                    campoTotal = Campo.Text;
                    break;
                case "-":
                    resultado = savedValue - value;
                    Campo.Text = resultado.ToString();
                    UpperCamp.Text = savedValue + " - " + value;
                    campoTotal = Campo.Text;
                    break;
                case "*":
                    resultado = savedValue * value;
                    Campo.Text = resultado.ToString();
                    UpperCamp.Text = savedValue + " x " + value;
                    campoTotal = Campo.Text;
                    break;
                case "/":
                    resultado = savedValue / value;
                    Campo.Text = resultado.ToString();
                    UpperCamp.Text = savedValue + " / " + value;
                    campoTotal = Campo.Text;
                    break;
            }
        }

        private void Button_Sumar(object sender, RoutedEventArgs e)
        {
            
            try
            {
                savedValue = double.Parse(Campo.Text);
                UpperCamp.Text = campoTotal + " + ";

                operation = "+";
                Campo.Text = "+";
                campoTotal = "";
            }
            catch { }
            
            
        }

        private void Button_Restar(object sender, RoutedEventArgs e)
        {
            try
            {
                savedValue = double.Parse(Campo.Text);
                UpperCamp.Text = campoTotal + " - ";

                operation = "-";
                Campo.Text = "-";
                campoTotal = "";
            }
            catch { }

            
        }

        private void Button_Mult(object sender, RoutedEventArgs e)
        {
           
            try
            {
                savedValue = double.Parse(Campo.Text);
                UpperCamp.Text = campoTotal + " x ";

                operation = "*";
                Campo.Text = "x";
                campoTotal = "";

            } catch { }
        }

        private void Button_Div(object sender, RoutedEventArgs e)
        {
            try
            {
                savedValue = double.Parse(Campo.Text);
                UpperCamp.Text = campoTotal + " / ";

                operation = "/";
                Campo.Text = "/";
                campoTotal = "";
            }
            catch { }
            
        }

        private void Button_0(object sender, RoutedEventArgs e)
        {
            campoTotal += "0"; 
            Campo.Text = campoTotal;
            
        }

        private void Button_1(object sender, RoutedEventArgs e)
        {
            campoTotal += "1";
            Campo.Text = campoTotal;

        }

        private void Button_2(object sender, RoutedEventArgs e)
        {
            campoTotal += "2";
            Campo.Text = campoTotal;

        }

        private void Button_3(object sender, RoutedEventArgs e)
        {
            campoTotal += "3";
            Campo.Text = campoTotal;
        }
        private void Button_4(object sender, RoutedEventArgs e)
        {
            campoTotal += "4";
            Campo.Text = campoTotal;
        }

        private void Button_5(object sender, RoutedEventArgs e)
        {
            campoTotal += "5";
            Campo.Text = campoTotal;
        }

        private void Button_6(object sender, RoutedEventArgs e)
        {
            campoTotal += "6";
            Campo.Text = campoTotal;
        }

        private void Button_7(object sender, RoutedEventArgs e)
        {
            campoTotal += "7";
            Campo.Text = campoTotal;
        }

        private void Button_8(object sender, RoutedEventArgs e)
        {
            campoTotal += "8";
            Campo.Text = campoTotal;
        }

        private void Button_9(object sender, RoutedEventArgs e)
        {
            campoTotal += "9";
            Campo.Text = campoTotal;
        }


    }

    
}
