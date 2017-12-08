using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DG_Converter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void convert_button_Click(object sender, RoutedEventArgs e)
        {
            int i = int.Parse(amount_box.Text);
            if (from_ComboBox.SelectedItem.ToString() == "Euro" && to_ComboBox.SelectedItem.ToString() == "US Dollar") ;
            {
                double euro, usDollar;
                euro = double.Parse(amount_box.Text);
                usDollar = (euro / 1.18);
                converted_Amount.Text = "Converted Amount: " + usDollar;
            }

            if (from_ComboBox.SelectedItem.ToString() == "Euro" && to_ComboBox.SelectedItem.ToString() == "Pound") ;
            {
                double euro, pound;
                euro = double.Parse(amount_box.Text);
                pound = (euro / 0.88);
                converted_Amount.Text = "Converted Amount: " + pound;
            }
        
    }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           // amount_box = ClearValue;

        }
    }
    
}
