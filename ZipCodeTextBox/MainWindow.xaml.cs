using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ZipCodeTextBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] canada = new string[] { "A", "B", "C" };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void uxTextEnter_TextChanged(object sender, TextChangedEventArgs e)
        {
            string parse = uxTextEnter.ToString();
            char[] textEntered = uxTextEnter.Text.ToCharArray();
            bool IsDigitsOnly(string str)
            {
                foreach (char c in textEntered)
                {
                    if (c < '0' || c > '9')
                        return false;
                }

                return true;
            }
            bool IsCanadianZip()
            {

                if (textEntered.Length == 6 
                    && Char.IsLetter(textEntered[0])
                    && Char.IsNumber(textEntered[1]) 
                    && Char.IsLetter(textEntered[2])
                    && Char.IsNumber(textEntered[3]) 
                    && Char.IsLetter(textEntered[4])
                    && Char.IsNumber(textEntered[5]))
                {
                    return true;
                }
                    return false;
            }

            if (IsCanadianZip() == true)
            {
                uxSubmit.IsEnabled = true;
            }
            else if(textEntered.Length ==10 && textEntered[5].Equals('-'))
            {
                uxSubmit.IsEnabled = true;
            }
            else if(textEntered.Length == 5 && IsDigitsOnly(parse)==true)
            {
                uxSubmit.IsEnabled = true;
            }
            else
            {
                uxSubmit.IsEnabled = false;
            }
        }
    }
}
