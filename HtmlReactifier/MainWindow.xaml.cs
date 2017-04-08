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

namespace HtmlReactifier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.V)txtInput.Text = transformHtml(txtInput.Text);
            Clipboard.SetText(txtInput.Text);
        }
        private string transformHtml(string html)
        {
            html = html
                .Replace("class", "className")
                .Replace("=\"", "={'")
                .Replace("\">", "'}>")
                .Replace("\"/>", "'}/>")
                .Replace("\" ", "'} ");
            return html;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            txtInput.Clear();
        }
    }
}
