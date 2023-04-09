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
using GuichetBanque_HelioBank.kernel;

namespace GuichetBanque_HelioBank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bool connected = Factory.setConnection("heliobank", "root", "");
            if (connected)
            {
                TextBlock textBlock = new TextBlock();
                textBlock.Text = "DataBase connected";
                textBlock.FontSize = 20;
                textBlock.TextAlignment = TextAlignment.Center;
                textBlock.Margin = new Thickness(10, 10, 10, 10);

                grdMain.Children.Add(textBlock);
            }
            else
            {
                TextBlock textBlock = new TextBlock();
                textBlock.Text = "Database not connected";
                textBlock.FontSize = 20;
                textBlock.TextAlignment = TextAlignment.Center;
                textBlock.Margin = new Thickness(10, 10, 10, 10);

                grdMain.Children.Add(textBlock);
            }
        }
    }
}