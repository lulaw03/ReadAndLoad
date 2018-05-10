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

namespace inputdata
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            // 產生開啟讀存檔視窗工具
            Microsoft.Win32.OpenFileDialog dig = new Microsoft.Win32.OpenFileDialog();

            // 顯示視窗
            Nullable<bool> result = dig.ShowDialog();

            // 按下按鈕的事件
            if (result == true)
            {
                // 路徑string filename = dig.FileName;

                // 存檔案
                System.IO.File.WriteAllText(@"C:\temp\aaa.txt",TextArea.Text);
            }
        }

        private void TextArea_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            // 產生開啟讀存檔視窗工具
            Microsoft.Win32.OpenFileDialog dig = new Microsoft.Win32.OpenFileDialog();

            // 顯示視窗
            Nullable<bool> result = dig.ShowDialog();

            // 按下按鈕的事件
            if (result == true)
            {
                // 路徑string filename = dig.FileName;

                // 讀檔案
                string text = System.IO.File.ReadAllText(@"C:\temp\aaa.txt");
                TextArea.Text = text;
            }
        }
    }
}
