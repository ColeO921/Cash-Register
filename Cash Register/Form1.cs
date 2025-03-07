using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace Cash_Register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //global variables
        int apple;
        int tesla;
        int shopify;
        double applePrice = 250.73;
        double shopifyPrice = 123.42;
        double teslaPrice = 273.78;
        double subtotal;
        double tax = 0.13;
        double taxAmount;
        double total;
        double tendered;
        double change;



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                apple = Convert.ToInt32(appleInput.Text);
                shopify = Convert.ToInt32(shopifyInput.Text);
                tesla = Convert.ToInt32(teslaInput.Text);
                subtotal = (apple * applePrice) + (shopify * shopifyPrice) + (teslaPrice * tesla);
                taxAmount = tax * subtotal;
                total = taxAmount + subtotal;


                //prints the tax and other totals
                subtotalOutput.Text = $"{subtotal.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{total.ToString("C")}";


            }
            catch
            {
                totalOutput.Text = "ERROR";
            }



        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);
                change = tendered - total;

                changeOutput.Text = $"{change.ToString("C")}";
            }
            catch
            {
                changeOutput.Text = "ERROR!";
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            //checks too see if the person paid
            if (tendered < subtotal)
            {
                receipt.Text = "";
                receipt.Text += "           TOO EXPENSIVE!";
                Refresh();
                Thread.Sleep(500);
                receipt.Text = "";
                receipt.Text += "-------------------------------------------------------";
                receipt.Text += "\n           TOO EXPENSIVE!";
                Refresh();
            }
            else
            {
                //clears old receipt
                receipt.Text = "";
                //prints new receipt with animation 
                receipt.Text += $"Change {change.ToString("C")}";
                Thread.Sleep(400);
                Refresh();
                //
                receipt.Text = "";
                receipt.Text += $"Tendered {tendered.ToString("C")}";
                receipt.Text += $"\n\nChange {change.ToString("C")}";
                Thread.Sleep(400);
                Refresh();
                //
                receipt.Text = "";
                receipt.Text += $"Total {total.ToString("C")}";
                receipt.Text += $"\n\nTendered {tendered.ToString("C")}";
                receipt.Text += $"\n\nChange {change.ToString("C")}";
                Thread.Sleep(400);
                Refresh();
                //
                receipt.Text = "";
                receipt.Text += $"Tax Amount {taxAmount.ToString("C")}";
                receipt.Text += $"\n\nTotal {total.ToString("C")}";
                receipt.Text += $"\n\nTendered {tendered.ToString("C")}";
                receipt.Text += $"\n\nChange {change.ToString("C")}";
                Thread.Sleep(400);
                Refresh();
                //
                receipt.Text = "";
                receipt.Text += $"Subtotal   {subtotal.ToString("C")}";
                receipt.Text += $"\n\nTax Amount {taxAmount.ToString("C")}";
                receipt.Text += $"\n\nTotal {total.ToString("C")}";
                receipt.Text += $"\n\nTendered {tendered.ToString("C")}";
                receipt.Text += $"\n\nChange {change.ToString("C")}";
                Thread.Sleep(400);
                Refresh();
                //
                receipt.Text = "";
                receipt.Text += $"Shopify ------------------------------- x{shopify}";
                receipt.Text += $"\n\nSubtotal   {subtotal.ToString("C")}";
                receipt.Text += $"\n\nTax Amount {taxAmount.ToString("C")}";
                receipt.Text += $"\n\nTotal {total.ToString("C")}";
                receipt.Text += $"\n\nTendered {tendered.ToString("C")}";
                receipt.Text += $"\n\nChange {change.ToString("C")}";
                Thread.Sleep(400);
                Refresh();
                //
                receipt.Text = "";
                receipt.Text += $"Tesla ---------------------------------- x{tesla}";
                receipt.Text += $"\n\nShopify ------------------------------- x{shopify}";
                receipt.Text += $"\n\nSubtotal   {subtotal.ToString("C")}";
                receipt.Text += $"\n\nTax Amount {taxAmount.ToString("C")}";
                receipt.Text += $"\n\nTotal {total.ToString("C")}";
                receipt.Text += $"\n\nTendered {tendered.ToString("C")}";
                receipt.Text += $"\n\nChange {change.ToString("C")}";
                Thread.Sleep(400);
                Refresh();
                //
                receipt.Text = "";
                receipt.Text += $"Apple -----------------------------------x{apple}";
                receipt.Text += $"\n\nTesla ---------------------------------- x{tesla}";
                receipt.Text += $"\n\nShopify ------------------------------- x{shopify}";
                receipt.Text += $"\n\nSubtotal   {subtotal.ToString("C")}";
                receipt.Text += $"\n\nTax Amount {taxAmount.ToString("C")}";
                receipt.Text += $"\n\nTotal {total.ToString("C")}";
                receipt.Text += $"\n\nTendered {tendered.ToString("C")}";
                receipt.Text += $"\n\nChange {change.ToString("C")}";
                Thread.Sleep(400);
                Refresh();
                //
                receipt.Text = "";
                receipt.Text += $"      Thanks for buying stock (:";
                receipt.Text += $"\n\nApple -----------------------------------x{apple}";
                receipt.Text += $"\n\nTesla ---------------------------------- x{tesla}";
                receipt.Text += $"\n\nShopify ------------------------------- x{shopify}";
                receipt.Text += $"\n\nSubtotal   {subtotal.ToString("C")}";
                receipt.Text += $"\n\nTax Amount {taxAmount.ToString("C")}";
                receipt.Text += $"\n\nTotal {total.ToString("C")}";
                receipt.Text += $"\n\nTendered {tendered.ToString("C")}";
                receipt.Text += $"\n\nChange {change.ToString("C")}";
                Thread.Sleep(400);
                Refresh();
                //
                receipt.Text = "";
                receipt.Text += $"\n      Thanks for buying stock (:";
                receipt.Text += $"\n\nApple -----------------------------------x{apple}";
                receipt.Text += $"\n\nTesla ---------------------------------- x{tesla}";
                receipt.Text += $"\n\nShopify ------------------------------- x{shopify}";
                receipt.Text += $"\n\nSubtotal   {subtotal.ToString("C")}";
                receipt.Text += $"\n\nTax Amount {taxAmount.ToString("C")}";
                receipt.Text += $"\n\nTotal {total.ToString("C")}";
                receipt.Text += $"\n\nTendered {tendered.ToString("C")}";
                receipt.Text += $"\n\nChange {change.ToString("C")}";
                Thread.Sleep(400);
                Refresh();
            }
        }
        private void purchaseButton_Click(object sender, EventArgs e)
        {
            //resets all text boxes and labels
            receipt.Text = "";
            appleInput.Text = "0";
            shopifyInput.Text = "0";
            teslaInput.Text = "0";
            tenderedInput.Text = "0";
            taxOutput.Text = "";
            subtotalOutput.Text = "";
            totalOutput.Text = "";
            changeOutput.Text = "";
        }
    }
}
