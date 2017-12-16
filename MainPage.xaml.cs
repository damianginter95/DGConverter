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
            double euro, usDollar, pound, yen, rupees, polishZloty, australianDollar, canadianDollar;

            // Converting from euro to us dollar
            if ((from_ComboBox.SelectionBoxItem.ToString() == "Euro") && (to_ComboBox.SelectionBoxItem.ToString() == "US Dollar"))
            {
                euro = int.Parse(amount_box.Text);
                usDollar = (euro * 1.18);
                converted_Amount.Text = "Converted Amount: " + usDollar;
            }

            // Converting from euro to pound
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Euro") && (to_ComboBox.SelectionBoxItem.ToString() == "Pound"))
            {
                
                euro = double.Parse(amount_box.Text);
                pound = (euro * 0.88);
                converted_Amount.Text = "Converted Amount: " + pound;
            }

            // Converting from euro to yen
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Euro") && (to_ComboBox.SelectionBoxItem.ToString() == "Yen"))
                {
                euro = double.Parse(amount_box.Text);
                yen = (euro * 133.23);
                converted_Amount.Text = "Converted Amount: " + yen;
            }

            // Converting from euro to rupees
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Euro") && (to_ComboBox.SelectionBoxItem.ToString() == "Rupees"))
            {
                euro = double.Parse(amount_box.Text);
                rupees = (euro * 75.69);
                converted_Amount.Text = "Converted Amount: " + rupees;
            }

            // Converting from euro to polish zloty
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Euro") && (to_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty"))
            {
                euro = double.Parse(amount_box.Text);
                polishZloty = (euro * 4.20);
                converted_Amount.Text = "Converted Amount: " + polishZloty;
            }

            // Converting from euro to canadian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Euro") && (to_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar"))
            {
                euro = double.Parse(amount_box.Text);
                canadianDollar = (euro * 1.51);
                converted_Amount.Text = "Converted Amount: " + canadianDollar;
            }

            // Converting from euro to australian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Euro") && (to_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar"))
            {
                euro = double.Parse(amount_box.Text);
                australianDollar = (euro * 1.56);
                converted_Amount.Text = "Converted Amount: " + australianDollar;
            }

            //**********************************************************************************************************************************

            // Converting from us dollar to euro
            if ((from_ComboBox.SelectionBoxItem.ToString() == "US Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Euro"))
            {
                usDollar = double.Parse(amount_box.Text);
                euro = (usDollar * 0.85);
                converted_Amount.Text = "Converted Amount: " + euro;
            }

            // Converting from us dollar to pound
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "US Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Pound"))
            {
                usDollar = double.Parse(amount_box.Text);
                pound = (usDollar * 0.74);
                converted_Amount.Text = "Converted Amount: " + pound;
            }

            // Converting from us dollar to yen
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "US Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Yen"))
            {
                usDollar = double.Parse(amount_box.Text);
                yen = (usDollar * 113.57);
                converted_Amount.Text = "Converted Amount: " + yen;
            }

            // Converting from us dollar to rupees
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "US Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Rupees"))
            {
                usDollar = double.Parse(amount_box.Text);
                rupees = (usDollar * 64.47);
                converted_Amount.Text = "Converted Amount: " + rupees;
            }

            // Converting from us dollar to polish zloty
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "US Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty"))
            {
                usDollar = double.Parse(amount_box.Text);
                polishZloty = (usDollar * 3.58);
                converted_Amount.Text = "Converted Amount: " + polishZloty;
            }

            // Converting from us dollar to canadian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "US Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar"))
            {
                usDollar = double.Parse(amount_box.Text);
                canadianDollar = (usDollar * 1.29);
                converted_Amount.Text = "Converted Amount: " + canadianDollar;
            }

            // Converting from us dollar to australian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "US Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar"))
            {
                usDollar = double.Parse(amount_box.Text);
                australianDollar = (usDollar * 1.33);
                converted_Amount.Text = "Converted Amount: " + australianDollar;
            }

            //*************************************************************************************************************************************

            // Converting from pound to us dollar
            if ((from_ComboBox.SelectionBoxItem.ToString() == "Pound") && (to_ComboBox.SelectionBoxItem.ToString() == "US Dollar"))
            {
                pound = double.Parse(amount_box.Text);
                usDollar = (pound * 1.35);
                converted_Amount.Text = "Converted Amount: " + usDollar;
            }

            // Converting from pound to euro
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Pound") && (to_ComboBox.SelectionBoxItem.ToString() == "Euro"))
            {
                pound = double.Parse(amount_box.Text);
                euro = (pound * 1.15);
                converted_Amount.Text = "Converted Amount: " + euro;
            }

            // Converting from pound to yen
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Pound") && (to_ComboBox.SelectionBoxItem.ToString() == "Yen"))
            {
                pound = double.Parse(amount_box.Text);
                yen = (pound * 152.99);
                converted_Amount.Text = "Converted Amount: " + yen;
            }

            // Converting from pound to rupees
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Pound") && (to_ComboBox.SelectionBoxItem.ToString() == "Rupees"))
            {
                pound = double.Parse(amount_box.Text);
                rupees = (pound * 86.92);
                converted_Amount.Text = "Converted Amount: " + rupees;
            }

            // Converting from pound to polish zloty
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Pound") && (to_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty"))
            {
                pound = double.Parse(amount_box.Text);
                polishZloty = (pound * 4.82);
                converted_Amount.Text = "Converted Amount: " + polishZloty;
            }

            // Converting from pound to canadian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Pound") && (to_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar"))
            {
                pound = double.Parse(amount_box.Text);
                canadianDollar = (pound * 1.73);
                converted_Amount.Text = "Converted Amount: " + canadianDollar;
            }

            // Converting from pound to australian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Pound") && (to_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar"))
            {
                pound = double.Parse(amount_box.Text);
                australianDollar = (pound * 1.79);
                converted_Amount.Text = "Converted Amount: " + australianDollar;
            }

            //*************************************************************************************************************************************

            // Converting from yen to euro
            if ((from_ComboBox.SelectionBoxItem.ToString() == "Yen") && (to_ComboBox.SelectionBoxItem.ToString() == "Euro"))
            {
                yen = double.Parse(amount_box.Text);
                euro = (yen * 0.0076);
                converted_Amount.Text = "Converted Amount: " + euro;
            }

            // Converting from yen to us dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yen") && (to_ComboBox.SelectionBoxItem.ToString() == "US Dollar"))
            {
                yen = double.Parse(amount_box.Text);
                usDollar = (yen * 0.0089);
                converted_Amount.Text = "Converted Amount: " + usDollar;
            }

            // Converting from yen to pound
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yen") && (to_ComboBox.SelectionBoxItem.ToString() == "Pound"))
            {
                yen = double.Parse(amount_box.Text);
                pound = (yen * 0.0067);
                converted_Amount.Text = "Converted Amount: " + pound;
            }

            // Converting from yen to rupees
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yen") && (to_ComboBox.SelectionBoxItem.ToString() == "Rupees"))
            {
                yen = double.Parse(amount_box.Text);
                rupees = (yen * 0.57);
                converted_Amount.Text = "Converted Amount: " + rupees;
            }

            // Converting from yen to polish zloty
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yen") && (to_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty"))
            {
                yen = double.Parse(amount_box.Text);
                polishZloty = (yen * 0.032);
                converted_Amount.Text = "Converted Amount: " + polishZloty;
            }

            // Converting from yen to canadian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yen") && (to_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar"))
            {
                yen = double.Parse(amount_box.Text);
                canadianDollar = (yen * 0.011);
                converted_Amount.Text = "Converted Amount: " + canadianDollar;
            }

            // Converting from yen to australian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yen") && (to_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar"))
            {
                yen = double.Parse(amount_box.Text);
                australianDollar = (yen * 0.012);
                converted_Amount.Text = "Converted Amount: " + australianDollar;
            }

            //*************************************************************************************************************************************

            // Converting from rupees to euro
            if ((from_ComboBox.SelectionBoxItem.ToString() == "Rupees") && (to_ComboBox.SelectionBoxItem.ToString() == "Euro"))
            {
                rupees = double.Parse(amount_box.Text);
                euro = (rupees * 0.013);
                converted_Amount.Text = "Converted Amount: " + euro;
            }

            // Converting from rupees to us dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Rupees") && (to_ComboBox.SelectionBoxItem.ToString() == "US Dollar"))
            {
                rupees = double.Parse(amount_box.Text);
                usDollar = (rupees * 0.016);
                converted_Amount.Text = "Converted Amount: " + usDollar;
            }

            // Converting from rupees to pound
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Rupees") && (to_ComboBox.SelectionBoxItem.ToString() == "Pound"))
            {
                rupees = double.Parse(amount_box.Text);
                pound = (rupees * 0.012);
                converted_Amount.Text = "Converted Amount: " + pound;
            }

            // Converting from rupees to yen
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Rupees") && (to_ComboBox.SelectionBoxItem.ToString() == "Yen"))
            {
                rupees = double.Parse(amount_box.Text);
                yen = (rupees * 1.76);
                converted_Amount.Text = "Converted Amount: " + yen;
            }

            // Converting from rupees to polish zloty
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Rupees") && (to_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty"))
            {
                rupees = double.Parse(amount_box.Text);
                polishZloty = (rupees * 0.056);
                converted_Amount.Text = "Converted Amount: " + polishZloty;
            }

            // Converting from rupees to canadian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Rupees") && (to_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar"))
            {
                rupees = double.Parse(amount_box.Text);
                canadianDollar = (rupees * 0.020);
                converted_Amount.Text = "Converted Amount: " + canadianDollar;
            }

            // Converting from rupees to australian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Rupees") && (to_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar"))
            {
                rupees = double.Parse(amount_box.Text);
                australianDollar = (rupees * 0.020);
                converted_Amount.Text = "Converted Amount: " + australianDollar;
            }

            //*************************************************************************************************************************************

            // Converting from polish zloty to euro
            if ((from_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty") && (to_ComboBox.SelectionBoxItem.ToString() == "Euro"))
            {
                polishZloty = double.Parse(amount_box.Text);
                euro = (polishZloty * 0.24);
                converted_Amount.Text = "Converted Amount: " + euro;
            }

            // Converting from polish zloty to us dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty") && (to_ComboBox.SelectionBoxItem.ToString() == "US Dollar"))
            {
                polishZloty = double.Parse(amount_box.Text);
                usDollar = (polishZloty * 0.28);
                converted_Amount.Text = "Converted Amount: " + usDollar;
            }

            // Converting from polish zloty to pound
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty") && (to_ComboBox.SelectionBoxItem.ToString() == "Pound"))
            {
                polishZloty = double.Parse(amount_box.Text);
                pound = (polishZloty * 0.21);
                converted_Amount.Text = "Converted Amount: " + pound;
            }

            // Converting from polish zloty to yen
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty") && (to_ComboBox.SelectionBoxItem.ToString() == "Yen"))
            {
                polishZloty = double.Parse(amount_box.Text);
                yen = (polishZloty * 31.46);
                converted_Amount.Text = "Converted Amount: " + yen;
            }

            // Converting from polish zloty to rupees
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty") && (to_ComboBox.SelectionBoxItem.ToString() == "Rupees"))
            {
                polishZloty = double.Parse(amount_box.Text);
                rupees = (polishZloty * 17.90);
                converted_Amount.Text = "Converted Amount: " + rupees;
            }

            // Converting from polish zloty to canadian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty") && (to_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar"))
            {
                polishZloty = double.Parse(amount_box.Text);
                canadianDollar = (polishZloty * 0.36);
                converted_Amount.Text = "Converted Amount: " + canadianDollar;
            }

            // Converting from polish zloty to australian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty") && (to_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar"))
            {
                polishZloty = double.Parse(amount_box.Text);
                australianDollar = (polishZloty * 0.37);
                converted_Amount.Text = "Converted Amount: " + australianDollar;
            }

            //*************************************************************************************************************************************

            // Converting from canadian dollar to euro
            if ((from_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Euro"))
            {
                canadianDollar = double.Parse(amount_box.Text);
                euro = (canadianDollar * 0.66);
                converted_Amount.Text = "Converted Amount: " + euro;
            }

            // Converting from canadian dollar to us dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "US Dollar"))
            {
                canadianDollar = double.Parse(amount_box.Text);
                usDollar = (canadianDollar * 0.78);
                converted_Amount.Text = "Converted Amount: " + usDollar;
            }

            // Converting from canadian dollar to pound
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Pound"))
            {
                canadianDollar = double.Parse(amount_box.Text);
                pound = (canadianDollar * 0.58);
                converted_Amount.Text = "Converted Amount: " + pound;
            }

            // Converting from canadian dollar to yen
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Yen"))
            {
                canadianDollar = double.Parse(amount_box.Text);
                yen = (canadianDollar * 87.51);
                converted_Amount.Text = "Converted Amount: " + yen;
            }

            // Converting from canadian dollar to rupees
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Rupees"))
            {
                canadianDollar = double.Parse(amount_box.Text);
                rupees = (canadianDollar * 49.81);
                converted_Amount.Text = "Converted Amount: " + rupees;
            }

            // Converting from canadian dollar to polish zloty
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty"))
            {
                canadianDollar = double.Parse(amount_box.Text);
                polishZloty = (canadianDollar * 2.78);
                converted_Amount.Text = "Converted Amount: " + polishZloty;
            }

            // Converting from canadian dollar to australian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar"))
            {
                canadianDollar = double.Parse(amount_box.Text);
                australianDollar = (canadianDollar * 1.02);
                converted_Amount.Text = "Converted Amount: " + australianDollar;
            }

            //*************************************************************************************************************************************

            // Converting from australian dollar to euro
            if ((from_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Euro"))
            {
                australianDollar = double.Parse(amount_box.Text);
                euro = (australianDollar * 0.65);
                converted_Amount.Text = "Converted Amount: " + euro;
            }

            // Converting from australian dollar to us dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "US Dollar"))
            {
                australianDollar = double.Parse(amount_box.Text);
                usDollar = (australianDollar * 0.76);
                converted_Amount.Text = "Converted Amount: " + usDollar;
            }

            // Converting from australian dollar to pound
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Pound"))
            {
                australianDollar = double.Parse(amount_box.Text);
                pound = (australianDollar * 0.57);
                converted_Amount.Text = "Converted Amount: " + pound;
            }

            // Converting from australian dollar to yen
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Yen"))
            {
                australianDollar = double.Parse(amount_box.Text);
                yen = (australianDollar * 86.07);
                converted_Amount.Text = "Converted Amount: " + yen;
            }

            // Converting from australian dollar to rupees
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Rupees"))
            {
                australianDollar = double.Parse(amount_box.Text);
                rupees = (australianDollar * 48.98);
                converted_Amount.Text = "Converted Amount: " + rupees;
            }

            // Converting from australian dollar to polish zloty
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty"))
            {
                australianDollar = double.Parse(amount_box.Text);
                polishZloty = (australianDollar * 2.74);
                converted_Amount.Text = "Converted Amount: " + polishZloty;
            }

            // Converting from australian dollar to canadian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar"))
            {
                australianDollar = double.Parse(amount_box.Text);
                canadianDollar = (australianDollar * 0.98);
                converted_Amount.Text = "Converted Amount: " + canadianDollar;
            }

            //**********************************************************************************************************************************
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            amount_box.Text = "0.00";

        }

        private void amount_box_GotFocus(object sender, RoutedEventArgs e)
        {
            amount_box.SelectAll();
        }
    }
    
}
