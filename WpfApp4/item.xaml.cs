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

namespace WpfApp4
{
    /// <summary>
    /// item.xaml 的互動邏輯
    /// </summary>
    public partial class item : UserControl
    {
        public item()
        {
            InitializeComponent();
        }
        // 屬性
        public int itemPriceValue
        {
            get
            {
                //除錯
                try
                {
                    return int.Parse(itemPrice.Text);
                }

                catch
                {
                    MessageBox.Show("請輸入數字");
                    return 0;
                }
            }
            set
            {
                itemPrice.Text = value.ToString();
            }
        }

        private void itemName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void itemPrice_MouseDown(object sender, MouseButtonEventArgs e)
        {
            itemPrice.Text = "";
        }

        private void date_MouseDown(object sender, MouseButtonEventArgs e)
        {
            date.Text = "";
        }

        private void itemName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            itemName.Text = "";
        }
    }
}
