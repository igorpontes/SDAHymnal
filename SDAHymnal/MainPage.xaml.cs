using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Navigation;
using System.IO;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Tasks;

namespace SDAHymnal
{
    public partial class MainPage : PhoneApplicationPage
    {
        bool enterNumber;
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded +=new RoutedEventHandler(MainPage_Loaded);
            enterNumber = false;
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            if (!enterNumber)
            {
                textbox_number.Text = "0";
                enterNumber = true;
            }
            else
            {
                textbox_number.Text += "0";
            }
            
        }

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            if (!enterNumber)
            {
                textbox_number.Text = "1";
                enterNumber = true;
            }
            else
            {
                textbox_number.Text += "1";
            }
            
        }

        private void button_2_Click(object sender, RoutedEventArgs e)
        {
            if (!enterNumber)
            {
                textbox_number.Text = "2";
                enterNumber = true;
            }
            else
            {
                textbox_number.Text += "2";
            }
            
        }

        private void button_3_Click(object sender, RoutedEventArgs e)
        {
            if (!enterNumber)
            {
                textbox_number.Text = "3";
                enterNumber = true;
            }
            else
            {
                textbox_number.Text += "3";
            }
            
        }

        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            if (!enterNumber)
            {
                textbox_number.Text = "4";
                enterNumber = true;
            }
            else
            {
                textbox_number.Text += "4";
            }
            
        }

        private void button_5_Click(object sender, RoutedEventArgs e)
        {
            if (!enterNumber)
            {
                textbox_number.Text = "5";
                enterNumber = true;
            }
            else
            {
                textbox_number.Text += "5";
            }
            
        }

        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            if (!enterNumber)
            {
                textbox_number.Text = "6";
                enterNumber = true;
            }
            else
            {
                textbox_number.Text += "6";
            }
            
        }

        private void button_7_Click(object sender, RoutedEventArgs e)
        {
            if (!enterNumber)
            {
                textbox_number.Text = "7";
                enterNumber = true;
            }
            else
            {
                textbox_number.Text += "7";
            }
            
        }

        private void button_8_Click(object sender, RoutedEventArgs e)
        {
            if (!enterNumber)
            {
                textbox_number.Text = "8";
                enterNumber = true;
            }
            else
            {
                textbox_number.Text += "8";
            }
            
        }

        private void button_9_Click(object sender, RoutedEventArgs e)
        {
            if (!enterNumber)
            {
                textbox_number.Text = "9";
                enterNumber = true;
            }
            else
            {
                textbox_number.Text += "9";
            }
            
        }

        private void ok_button_Click(object sender, RoutedEventArgs e)
        {
            pivot.SelectedIndex = 1;
            string hymn = textbox_number.Text.ToString();
            textBlock_Hymn.Text = returnHymn(hymn);
            textbox_number.Text = "Enter a number";
            enterNumber = false;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textbox_number.Text = "Enter a number";
            enterNumber = false;
        }

        public string returnHymn(string path)
        {
            string prePath = @"Archive/";
            string extention = ".txt";

            var ResrouceStream = Application.GetResourceStream(new Uri(prePath + path + extention, UriKind.Relative));
            if (ResrouceStream != null)
            {
                Stream myFileStream = ResrouceStream.Stream;
                if (myFileStream.CanRead)
                {
                    StreamReader myStreamReader = new StreamReader(myFileStream);
                    //read the content here
                    return myStreamReader.ReadToEnd();
                }

            }
            return "Hymn not found!";

           
        }

        private void hyperlinkButton1_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask wbt = new WebBrowserTask();
            wbt.URL = "http://about.me/igorpontes";
            wbt.Show();
        }
    }
}