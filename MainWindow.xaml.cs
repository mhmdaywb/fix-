using System;
using System.Windows;
using ZXing;

namespace RepairShop
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void BtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            string info = $"Device: {TxtDevice.Text} | Price: {TxtPrice.Text}$";
            var writer = new BarcodeWriter { Format = BarcodeFormat.QR_CODE };
            MessageBox.Show("تم إنشاء بيانات الباركود للمشروع!");
        }
    }
}
