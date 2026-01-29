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

namespace PeZetSpice.Views
{
    /// <summary>
    /// Interaction logic for PaperView.xaml
    /// </summary>
    public partial class PaperView : UserControl
    {
        public PaperView()
        {
            InitializeComponent();
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var w = PaperBorder.ActualWidth;
            var h = PaperBorder.ActualHeight;


            var nx = (int)w / 50 + 1;
            var ny = (int)h / 50 + 1;
            var xs = Enumerable.Range(0, nx).Select(k => k * 50).ToList();
            var ys = Enumerable.Range(0, ny).Select(k => k * 50).ToList();

            foreach(var x in xs)
            {
                var tb = new TextBlock { Text = x.ToString(), Foreground = new SolidColorBrush(Colors.DarkGray), FontSize = 8 };
                Canvas.SetLeft(tb, x);
                TopCanvas.Children.Add(tb);
            }

            foreach (var x in xs)
            {
                var tb = new TextBlock { Text = x.ToString(), Foreground = new SolidColorBrush(Colors.DarkGray), FontSize = 8 };
                Canvas.SetLeft(tb, x);
                BottomCanvas.Children.Add(tb);
            }

            foreach (var y in ys)
            {
                var tb = new TextBlock { Text = y.ToString(), Foreground = new SolidColorBrush(Colors.DarkGray), FontSize = 8 };
                Canvas.SetTop(tb, h - y);
                LeftCanvas.Children.Add(tb);
            }

            foreach(var y in ys)
            {
                var tb = new TextBlock { Text = y.ToString(), Foreground = new SolidColorBrush(Colors.DarkGray), FontSize = 8 };
                Canvas.SetTop(tb, h - y);
                RightCanvas.Children.Add(tb);
            }

        }
    }
}
