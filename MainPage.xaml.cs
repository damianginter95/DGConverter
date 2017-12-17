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
            double euro, usDollar, pound, yen, yuan, rupees, ruble, mexicanPeso, swissFranc, swedishKrona, polishZloty, australianDollar, canadianDollar;

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

            // Converting from euro to yuan
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Euro") && (to_ComboBox.SelectionBoxItem.ToString() == "Yuan"))
            {

                euro = double.Parse(amount_box.Text);
                yuan = (euro * 7.76);
                converted_Amount.Text = "Converted Amount: " + yuan;
            }

            // Converting from euro to ruble
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Euro") && (to_ComboBox.SelectionBoxItem.ToString() == "Ruble"))
            {
                euro = double.Parse(amount_box.Text);
                ruble = (euro * 69.16);
                converted_Amount.Text = "Converted Amount: " + ruble;
            }

            // Converting from euro to mexican peso
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Euro") && (to_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso"))
            {
                euro = double.Parse(amount_box.Text);
                mexicanPeso = (euro * 22.48);
                converted_Amount.Text = "Converted Amount: " + mexicanPeso;
            }

            // Converting from euro to swiss franc
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Euro") && (to_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc"))
            {
                euro = double.Parse(amount_box.Text);
                swissFranc = (euro * 1.16);
                converted_Amount.Text = "Converted Amount: " + swissFranc;
            }

            // Converting from euro to swedish krona
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Euro") && (to_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona"))
            {
                euro = double.Parse(amount_box.Text);
                swedishKrona = (euro * 10.00);
                converted_Amount.Text = "Converted Amount: " + swedishKrona;
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

            // Converting from us dollar to yuan
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "US Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Yuan"))
            {

                usDollar = double.Parse(amount_box.Text);
                yuan = (usDollar * 6.60);
                converted_Amount.Text = "Converted Amount: " + yuan;
            }

            // Converting from us dollar to ruble
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "US Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Ruble"))
            {
                usDollar = double.Parse(amount_box.Text);
                ruble = (usDollar * 58.84);
                converted_Amount.Text = "Converted Amount: " + ruble;
            }

            // Converting from us dollar to mexican peso
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "US Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso"))
            {
                usDollar = double.Parse(amount_box.Text);
                mexicanPeso = (usDollar * 19.12);
                converted_Amount.Text = "Converted Amount: " + mexicanPeso;
            }

            // Converting from us dollar to swiss franc
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "US Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc"))
            {
                usDollar = double.Parse(amount_box.Text);
                swissFranc = (usDollar * 0.99);
                converted_Amount.Text = "Converted Amount: " + swissFranc;
            }

            // Converting from us dollar to swedish krona
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "US Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona"))
            {
                usDollar = double.Parse(amount_box.Text);
                swedishKrona = (usDollar * 8.50);
                converted_Amount.Text = "Converted Amount: " + swedishKrona;
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

            // Converting from pound to yuan
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Pound") && (to_ComboBox.SelectionBoxItem.ToString() == "Yuan"))
            {

                pound = double.Parse(amount_box.Text);
                yuan = (pound * 8.80);
                converted_Amount.Text = "Converted Amount: " + yuan;
            }

            // Converting from pound to ruble
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Pound") && (to_ComboBox.SelectionBoxItem.ToString() == "Ruble"))
            {
                pound = double.Parse(amount_box.Text);
                ruble = (pound * 78.39);
                converted_Amount.Text = "Converted Amount: " + ruble;
            }

            // Converting from pound to mexican peso
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Pound") && (to_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso"))
            {
                pound = double.Parse(amount_box.Text);
                mexicanPeso = (pound * 25.48);
                converted_Amount.Text = "Converted Amount: " + mexicanPeso;
            }

            // Converting from pound to swiss franc
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Pound") && (to_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc"))
            {
                pound = double.Parse(amount_box.Text);
                swissFranc = (pound * 1.32);
                converted_Amount.Text = "Converted Amount: " + swissFranc;
            }

            // Converting from pound to swedish krona
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Pound") && (to_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona"))
            {
                pound = double.Parse(amount_box.Text);
                swedishKrona = (pound * 11.33);
                converted_Amount.Text = "Converted Amount: " + swedishKrona;
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

            // Converting from yen to yuan
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yen") && (to_ComboBox.SelectionBoxItem.ToString() == "Yuan"))
            {

                yen = double.Parse(amount_box.Text);
                yuan = (yen * 0.059);
                converted_Amount.Text = "Converted Amount: " + yuan;
            }

            // Converting from yen to ruble
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yen") && (to_ComboBox.SelectionBoxItem.ToString() == "Ruble"))
            {
                yen = double.Parse(amount_box.Text);
                ruble = (yen * 0.52);
                converted_Amount.Text = "Converted Amount: " + ruble;
            }

            // Converting from yen to mexican peso
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yen") && (to_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso"))
            {
                yen = double.Parse(amount_box.Text);
                mexicanPeso = (yen * 0.17);
                converted_Amount.Text = "Converted Amount: " + mexicanPeso;
            }

            // Converting from yen to swiss franc
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yen") && (to_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc"))
            {
                yen = double.Parse(amount_box.Text);
                swissFranc = (yen * 0.0088);
                converted_Amount.Text = "Converted Amount: " + swissFranc;
            }

            // Converting from yen to swedish krona
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yen") && (to_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona"))
            {
                yen = double.Parse(amount_box.Text);
                swedishKrona = (yen * 0.076);
                converted_Amount.Text = "Converted Amount: " + swedishKrona;
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

            // Converting from rupees to yuan
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Rupees") && (to_ComboBox.SelectionBoxItem.ToString() == "Yuan"))
            {

                rupees = double.Parse(amount_box.Text);
                yuan = (rupees * 0.10);
                converted_Amount.Text = "Converted Amount: " + yuan;
            }

            // Converting from rupees to ruble
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Rupees") && (to_ComboBox.SelectionBoxItem.ToString() == "Ruble"))
            {
                rupees = double.Parse(amount_box.Text);
                ruble = (rupees * 0.92);
                converted_Amount.Text = "Converted Amount: " + ruble;
            }

            // Converting from rupees to mexican peso
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Rupees") && (to_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso"))
            {
                rupees = double.Parse(amount_box.Text);
                mexicanPeso = (rupees * 0.30);
                converted_Amount.Text = "Converted Amount: " + mexicanPeso;
            }

            // Converting from rupees to swiss franc
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Rupees") && (to_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc"))
            {
                rupees = double.Parse(amount_box.Text);
                swissFranc = (rupees * 0.015);
                converted_Amount.Text = "Converted Amount: " + swissFranc;
            }

            // Converting from rupees to swedish krona
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Rupees") && (to_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona"))
            {
                rupees = double.Parse(amount_box.Text);
                swedishKrona = (rupees * 0.13);
                converted_Amount.Text = "Converted Amount: " + swedishKrona;
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

            // Converting from polish zloty to yuan
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty") && (to_ComboBox.SelectionBoxItem.ToString() == "Yuan"))
            {

                polishZloty = double.Parse(amount_box.Text);
                yuan = (polishZloty * 1.84);
                converted_Amount.Text = "Converted Amount: " + yuan;
            }

            // Converting from polish zloty to ruble
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty") && (to_ComboBox.SelectionBoxItem.ToString() == "Ruble"))
            {
                polishZloty = double.Parse(amount_box.Text);
                ruble = (polishZloty * 16.43);
                converted_Amount.Text = "Converted Amount: " + ruble;
            }

            // Converting from polish zloty to mexican peso
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty") && (to_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso"))
            {
                polishZloty = double.Parse(amount_box.Text);
                mexicanPeso = (polishZloty * 5.34);
                converted_Amount.Text = "Converted Amount: " + mexicanPeso;
            }

            // Converting from polish zloty to swiss franc
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty") && (to_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc"))
            {
                polishZloty = double.Parse(amount_box.Text);
                swissFranc = (polishZloty * 0.28);
                converted_Amount.Text = "Converted Amount: " + swissFranc;
            }

            // Converting from polish zloty to swedish krona
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty") && (to_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona"))
            {
                polishZloty = double.Parse(amount_box.Text);
                swedishKrona = (polishZloty * 2.38);
                converted_Amount.Text = "Converted Amount: " + swedishKrona;
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

            // Converting from canadian dollar to yuan
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Yuan"))
            {

                canadianDollar = double.Parse(amount_box.Text);
                yuan = (canadianDollar * 5.13);
                converted_Amount.Text = "Converted Amount: " + yuan;
            }

            // Converting from canadian dollar to ruble
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Ruble"))
            {
                canadianDollar = double.Parse(amount_box.Text);
                ruble = (canadianDollar * 45.73);
                converted_Amount.Text = "Converted Amount: " + ruble;
            }

            // Converting from canadian dollar to mexican peso
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso"))
            {
                canadianDollar = double.Parse(amount_box.Text);
                mexicanPeso = (canadianDollar * 14.87);
                converted_Amount.Text = "Converted Amount: " + mexicanPeso;
            }

            // Converting from canadian dollar to swiss franc
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc"))
            {
                canadianDollar = double.Parse(amount_box.Text);
                swissFranc = (canadianDollar * 0.77);
                converted_Amount.Text = "Converted Amount: " + swissFranc;
            }

            // Converting from canadian dollar to swedish krona
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona"))
            {
                canadianDollar = double.Parse(amount_box.Text);
                swedishKrona = (canadianDollar * 6.61);
                converted_Amount.Text = "Converted Amount: " + swedishKrona;
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

            // Converting from australian dollar to yuan
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Yuan"))
            {

                australianDollar = double.Parse(amount_box.Text);
                yuan = (australianDollar * 5.05);
                converted_Amount.Text = "Converted Amount: " + yuan;
            }

            // Converting from australian dollar to ruble
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Ruble"))
            {
                australianDollar = double.Parse(amount_box.Text);
                ruble = (australianDollar * 44.99);
                converted_Amount.Text = "Converted Amount: " + ruble;
            }

            // Converting from australian dollar to mexican peso
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso"))
            {
                australianDollar = double.Parse(amount_box.Text);
                mexicanPeso = (australianDollar * 14.62);
                converted_Amount.Text = "Converted Amount: " + mexicanPeso;
            }

            // Converting from australian dollar to swiss franc
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc"))
            {
                australianDollar = double.Parse(amount_box.Text);
                swissFranc = (australianDollar * 0.76);
                converted_Amount.Text = "Converted Amount: " + swissFranc;
            }

            // Converting from australian dollar to swedish krona
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar") && (to_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona"))
            {
                australianDollar = double.Parse(amount_box.Text);
                swedishKrona = (australianDollar * 6.50);
                converted_Amount.Text = "Converted Amount: " + swedishKrona;
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

            //*************************************************************************************************************************************

            // Converting from yuan to euro
            if ((from_ComboBox.SelectionBoxItem.ToString() == "Yuan") && (to_ComboBox.SelectionBoxItem.ToString() == "Euro"))
            {
                yuan = double.Parse(amount_box.Text);
                euro = (yuan * 0.13);
                converted_Amount.Text = "Converted Amount: " + euro;
            }

            // Converting from yuan to us dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yuan") && (to_ComboBox.SelectionBoxItem.ToString() == "US Dollar"))
            {
                yuan = double.Parse(amount_box.Text);
                usDollar = (yuan * 0.15);
                converted_Amount.Text = "Converted Amount: " + usDollar;
            }

            // Converting from yuan to pound
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yuan") && (to_ComboBox.SelectionBoxItem.ToString() == "Pound"))
            {
                yuan = double.Parse(amount_box.Text);
                pound = (yuan * 0.11);
                converted_Amount.Text = "Converted Amount: " + pound;
            }

            // Converting from yuan to yen
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yuan") && (to_ComboBox.SelectionBoxItem.ToString() == "Yen"))
            {
                yuan = double.Parse(amount_box.Text);
                yen = (yuan * 17.04);
                converted_Amount.Text = "Converted Amount: " + yen;
            }

            // Converting from yuan to australian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yuan") && (to_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar"))
            {

                yuan = double.Parse(amount_box.Text);
                australianDollar = (yuan * 0.20);
                converted_Amount.Text = "Converted Amount: " + australianDollar;
            }

            // Converting from yuan to ruble
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yuan") && (to_ComboBox.SelectionBoxItem.ToString() == "Ruble"))
            {
                yuan = double.Parse(amount_box.Text);
                ruble = (yuan * 8.92);
                converted_Amount.Text = "Converted Amount: " + ruble;
            }

            // Converting from yuan to mexican peso
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yuan") && (to_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso"))
            {
                yuan = double.Parse(amount_box.Text);
                mexicanPeso = (yuan * 2.90);
                converted_Amount.Text = "Converted Amount: " + mexicanPeso;
            }

            // Converting from yuan to swiss franc
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yuan") && (to_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc"))
            {
                yuan = double.Parse(amount_box.Text);
                swissFranc = (yuan * 0.15);
                converted_Amount.Text = "Converted Amount: " + swissFranc;
            }

            // Converting from yuan to swedish krona
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yuan") && (to_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona"))
            {
                yuan = double.Parse(amount_box.Text);
                swedishKrona = (yuan * 1.29);
                converted_Amount.Text = "Converted Amount: " + swedishKrona;
            }

            // Converting from yuan to rupees
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yuan") && (to_ComboBox.SelectionBoxItem.ToString() == "Rupees"))
            {
                yuan = double.Parse(amount_box.Text);
                rupees = (yuan * 9.70);
                converted_Amount.Text = "Converted Amount: " + rupees;
            }

            // Converting from yuan to polish zloty
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yuan") && (to_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty"))
            {
                yuan = double.Parse(amount_box.Text);
                polishZloty = (yuan * 0.54);
                converted_Amount.Text = "Converted Amount: " + polishZloty;
            }

            // Converting from yuan to canadian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Yuan") && (to_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar"))
            {
                yuan = double.Parse(amount_box.Text);
                canadianDollar = (yuan * 0.19);
                converted_Amount.Text = "Converted Amount: " + canadianDollar;
            }

            //*************************************************************************************************************************************

            // Converting from ruble to euro
            if ((from_ComboBox.SelectionBoxItem.ToString() == "Ruble") && (to_ComboBox.SelectionBoxItem.ToString() == "Euro"))
            {
                ruble = double.Parse(amount_box.Text);
                euro = (ruble * 0.014);
                converted_Amount.Text = "Converted Amount: " + euro;
            }

            // Converting from ruble to us dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Ruble") && (to_ComboBox.SelectionBoxItem.ToString() == "US Dollar"))
            {
                ruble = double.Parse(amount_box.Text);
                usDollar = (ruble * 0.017);
                converted_Amount.Text = "Converted Amount: " + usDollar;
            }

            // Converting from ruble to pound
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Ruble") && (to_ComboBox.SelectionBoxItem.ToString() == "Pound"))
            {
                ruble = double.Parse(amount_box.Text);
                pound = (ruble * 0.013);
                converted_Amount.Text = "Converted Amount: " + pound;
            }

            // Converting from ruble to yen
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Ruble") && (to_ComboBox.SelectionBoxItem.ToString() == "Yen"))
            {
                ruble = double.Parse(amount_box.Text);
                yen = (ruble * 1.91);
                converted_Amount.Text = "Converted Amount: " + yen;
            }

            // Converting from ruble to australian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Ruble") && (to_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar"))
            {

                ruble = double.Parse(amount_box.Text);
                australianDollar = (ruble * 0.022);
                converted_Amount.Text = "Converted Amount: " + australianDollar;
            }

            // Converting from ruble to yuan
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Ruble") && (to_ComboBox.SelectionBoxItem.ToString() == "Yuan"))
            {
                ruble = double.Parse(amount_box.Text);
                yuan = (ruble * 0.11);
                converted_Amount.Text = "Converted Amount: " + yuan;
            }

            // Converting from ruble to mexican peso
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Ruble") && (to_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso"))
            {
                ruble = double.Parse(amount_box.Text);
                mexicanPeso = (ruble * 0.33);
                converted_Amount.Text = "Converted Amount: " + mexicanPeso;
            }

            // Converting from ruble to swiss franc
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Ruble") && (to_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc"))
            {
                ruble = double.Parse(amount_box.Text);
                swissFranc = (ruble * 0.017);
                converted_Amount.Text = "Converted Amount: " + swissFranc;
            }

            // Converting from ruble to swedish krona
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Ruble") && (to_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona"))
            {
                ruble = double.Parse(amount_box.Text);
                swedishKrona = (ruble * 0.14);
                converted_Amount.Text = "Converted Amount: " + swedishKrona;
            }

            // Converting from ruble to rupees
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Ruble") && (to_ComboBox.SelectionBoxItem.ToString() == "Rupees"))
            {
                ruble = double.Parse(amount_box.Text);
                rupees = (ruble * 1.09);
                converted_Amount.Text = "Converted Amount: " + rupees;
            }

            // Converting from ruble to polish zloty
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Ruble") && (to_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty"))
            {
                ruble = double.Parse(amount_box.Text);
                polishZloty = (ruble * 0.061);
                converted_Amount.Text = "Converted Amount: " + polishZloty;
            }

            // Converting from ruble to canadian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Ruble") && (to_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar"))
            {
                ruble = double.Parse(amount_box.Text);
                canadianDollar = (ruble * 0.022);
                converted_Amount.Text = "Converted Amount: " + canadianDollar;
            }

            //*************************************************************************************************************************************

            // Converting from mexican peso to euro
            if ((from_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso") && (to_ComboBox.SelectionBoxItem.ToString() == "Euro"))
            {
                mexicanPeso = double.Parse(amount_box.Text);
                euro = (mexicanPeso * 0.044);
                converted_Amount.Text = "Converted Amount: " + euro;
            }

            // Converting from mexican peso to us dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso") && (to_ComboBox.SelectionBoxItem.ToString() == "US Dollar"))
            {
                mexicanPeso = double.Parse(amount_box.Text);
                usDollar = (mexicanPeso * 0.052);
                converted_Amount.Text = "Converted Amount: " + usDollar;
            }

            // Converting from mexican peso to pound
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso") && (to_ComboBox.SelectionBoxItem.ToString() == "Pound"))
            {
                mexicanPeso = double.Parse(amount_box.Text);
                pound = (mexicanPeso * 0.039);
                converted_Amount.Text = "Converted Amount: " + pound;
            }

            // Converting from mexican peso to yen
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso") && (to_ComboBox.SelectionBoxItem.ToString() == "Yen"))
            {
                mexicanPeso = double.Parse(amount_box.Text);
                yen = (mexicanPeso * 5.89);
                converted_Amount.Text = "Converted Amount: " + yen;
            }

            // Converting from mexican peso to australian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso") && (to_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar"))
            {
                mexicanPeso = double.Parse(amount_box.Text);
                australianDollar = (mexicanPeso * 0.068);
                converted_Amount.Text = "Converted Amount: " + australianDollar;
            }

            // Converting from mexican peso to yuan
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso") && (to_ComboBox.SelectionBoxItem.ToString() == "Yuan"))
            {
                mexicanPeso = double.Parse(amount_box.Text);
                yuan = (mexicanPeso * 0.35);
                converted_Amount.Text = "Converted Amount: " + yuan;
            }

            // Converting from mexican peso to ruble
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso") && (to_ComboBox.SelectionBoxItem.ToString() == "Ruble"))
            {
                mexicanPeso = double.Parse(amount_box.Text);
                ruble = (mexicanPeso * 3.08);
                converted_Amount.Text = "Converted Amount: " + ruble;
            }

            // Converting from mexican peso to swiss franc
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso") && (to_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc"))
            {
                mexicanPeso = double.Parse(amount_box.Text);
                swissFranc = (mexicanPeso * 0.052);
                converted_Amount.Text = "Converted Amount: " + swissFranc;
            }

            // Converting from mexican peso to swedish krona
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso") && (to_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona"))
            {
                mexicanPeso = double.Parse(amount_box.Text);
                swedishKrona = (mexicanPeso * 0.44);
                converted_Amount.Text = "Converted Amount: " + swedishKrona;
            }

            // Converting from mexican peso to rupees
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso") && (to_ComboBox.SelectionBoxItem.ToString() == "Rupees"))
            {
                mexicanPeso = double.Parse(amount_box.Text);
                rupees = (mexicanPeso * 3.35);
                converted_Amount.Text = "Converted Amount: " + rupees;
            }

            // Converting from mexican peso to polish zloty
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso") && (to_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty"))
            {
                mexicanPeso = double.Parse(amount_box.Text);
                polishZloty = (mexicanPeso * 0.19);
                converted_Amount.Text = "Converted Amount: " + polishZloty;
            }

            // Converting from mexican peso to canadian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso") && (to_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar"))
            {
                mexicanPeso = double.Parse(amount_box.Text);
                canadianDollar = (mexicanPeso * 0.067);
                converted_Amount.Text = "Converted Amount: " + canadianDollar;
            }

            //*************************************************************************************************************************************

            // Converting from swiss franc to euro
            if ((from_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc") && (to_ComboBox.SelectionBoxItem.ToString() == "Euro"))
            {
                swissFranc = double.Parse(amount_box.Text);
                euro = (swissFranc * 0.86);
                converted_Amount.Text = "Converted Amount: " + euro;
            }

            // Converting from swiss franc to us dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc") && (to_ComboBox.SelectionBoxItem.ToString() == "US Dollar"))
            {
                swissFranc = double.Parse(amount_box.Text);
                usDollar = (swissFranc * 1.01);
                converted_Amount.Text = "Converted Amount: " + usDollar;
            }

            // Converting from swiss franc to pound
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc") && (to_ComboBox.SelectionBoxItem.ToString() == "Pound"))
            {
                swissFranc = double.Parse(amount_box.Text);
                pound = (swissFranc * 0.76);
                converted_Amount.Text = "Converted Amount: " + pound;
            }

            // Converting from swiss franc to yen
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc") && (to_ComboBox.SelectionBoxItem.ToString() == "Yen"))
            {
                swissFranc = double.Parse(amount_box.Text);
                yen = (swissFranc * 113.67);
                converted_Amount.Text = "Converted Amount: " + yen;
            }

            // Converting from swiss franc to australian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc") && (to_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar"))
            {
                swissFranc = double.Parse(amount_box.Text);
                australianDollar = (swissFranc * 1.32);
                converted_Amount.Text = "Converted Amount: " + australianDollar;
            }

            // Converting from swiss franc to yuan
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc") && (to_ComboBox.SelectionBoxItem.ToString() == "Yuan"))
            {
                swissFranc = double.Parse(amount_box.Text);
                yuan = (swissFranc * 6.66);
                converted_Amount.Text = "Converted Amount: " + yuan;
            }

            // Converting from swiss franc to ruble
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc") && (to_ComboBox.SelectionBoxItem.ToString() == "Ruble"))
            {
                swissFranc = double.Parse(amount_box.Text);
                ruble = (swissFranc * 59.41);
                converted_Amount.Text = "Converted Amount: " + ruble;
            }

            // Converting from swiss franc to mexican peso
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc") && (to_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso"))
            {
                swissFranc = double.Parse(amount_box.Text);
                mexicanPeso = (swissFranc * 19.31);
                converted_Amount.Text = "Converted Amount: " + mexicanPeso;
            }

            // Converting from swiss franc to swedish krona
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc") && (to_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona"))
            {
                swissFranc = double.Parse(amount_box.Text);
                swedishKrona = (swissFranc * 8.59);
                converted_Amount.Text = "Converted Amount: " + swedishKrona;
            }

            // Converting from swiss franc to rupees
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc") && (to_ComboBox.SelectionBoxItem.ToString() == "Rupees"))
            {
                swissFranc = double.Parse(amount_box.Text);
                rupees = (swissFranc * 64.70);
                converted_Amount.Text = "Converted Amount: " + rupees;
            }

            // Converting from swiss franc to polish zloty
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc") && (to_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty"))
            {
                swissFranc = double.Parse(amount_box.Text);
                polishZloty = (swissFranc * 3.61);
                converted_Amount.Text = "Converted Amount: " + polishZloty;
            }

            // Converting from swiss franc to canadian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc") && (to_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar"))
            {
                swissFranc = double.Parse(amount_box.Text);
                canadianDollar = (swissFranc * 1.30);
                converted_Amount.Text = "Converted Amount: " + canadianDollar;
            }

            //*************************************************************************************************************************************

            // Converting from swedish krona to euro
            if ((from_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona") && (to_ComboBox.SelectionBoxItem.ToString() == "Euro"))
            {
                swedishKrona = double.Parse(amount_box.Text);
                euro = (swedishKrona * 0.10);
                converted_Amount.Text = "Converted Amount: " + euro;
            }

            // Converting from swedish krona to us dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona") && (to_ComboBox.SelectionBoxItem.ToString() == "US Dollar"))
            {
                swedishKrona = double.Parse(amount_box.Text);
                usDollar = (swedishKrona * 0.12);
                converted_Amount.Text = "Converted Amount: " + usDollar;
            }

            // Converting from swedish krona to pound
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona") && (to_ComboBox.SelectionBoxItem.ToString() == "Pound"))
            {
                swedishKrona = double.Parse(amount_box.Text);
                pound = (swedishKrona * 0.088);
                converted_Amount.Text = "Converted Amount: " + pound;
            }

            // Converting from swedish krona to yen
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona") && (to_ComboBox.SelectionBoxItem.ToString() == "Yen"))
            {
                swedishKrona = double.Parse(amount_box.Text);
                yen = (swedishKrona * 13.24);
                converted_Amount.Text = "Converted Amount: " + yen;
            }

            // Converting from swedish krona to australian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona") && (to_ComboBox.SelectionBoxItem.ToString() == "Australian Dollar"))
            {
                swedishKrona = double.Parse(amount_box.Text);
                australianDollar = (swedishKrona * 0.15);
                converted_Amount.Text = "Converted Amount: " + australianDollar;
            }

            // Converting from swedish krona to yuan
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona") && (to_ComboBox.SelectionBoxItem.ToString() == "Yuan"))
            {
                swedishKrona = double.Parse(amount_box.Text);
                yuan = (swedishKrona * 0.78);
                converted_Amount.Text = "Converted Amount: " + yuan;
            }

            // Converting from swedish krona to ruble
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona") && (to_ComboBox.SelectionBoxItem.ToString() == "Ruble"))
            {
                swedishKrona = double.Parse(amount_box.Text);
                ruble = (swedishKrona * 6.92);
                converted_Amount.Text = "Converted Amount: " + ruble;
            }

            // Converting from swedish krona to mexican peso
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona") && (to_ComboBox.SelectionBoxItem.ToString() == "Mexican Peso"))
            {
                swedishKrona = double.Parse(amount_box.Text);
                mexicanPeso = (swedishKrona * 2.25);
                converted_Amount.Text = "Converted Amount: " + mexicanPeso;
            }

            // Converting from swedish krona to swiss franc
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona") && (to_ComboBox.SelectionBoxItem.ToString() == "Swiss Franc"))
            {
                swedishKrona = double.Parse(amount_box.Text);
                swissFranc = (swedishKrona * 0.12);
                converted_Amount.Text = "Converted Amount: " + swissFranc;
            }

            // Converting from swedish krona to rupees
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona") && (to_ComboBox.SelectionBoxItem.ToString() == "Rupees"))
            {
                swedishKrona = double.Parse(amount_box.Text);
                rupees = (swedishKrona * 7.53);
                converted_Amount.Text = "Converted Amount: " + rupees;
            }

            // Converting from swedish krona to polish zloty
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona") && (to_ComboBox.SelectionBoxItem.ToString() == "Polish Złoty"))
            {
                swedishKrona = double.Parse(amount_box.Text);
                polishZloty = (swedishKrona * 0.42);
                converted_Amount.Text = "Converted Amount: " + polishZloty;
            }

            // Converting from swedish krona to canadian dollar
            else if ((from_ComboBox.SelectionBoxItem.ToString() == "Swedish Krona") && (to_ComboBox.SelectionBoxItem.ToString() == "Canadian Dollar"))
            {
                swedishKrona = double.Parse(amount_box.Text);
                canadianDollar = (swedishKrona * 0.15);
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