using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PeZetSpice
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
        private double scale = 1.0;
        private bool isPanning = false;
        private Point origin = new Point();
        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            scale = (e.Delta > 0 ? 1.1 : 0.9);
            var mouse = e.GetPosition(MyGrid);
            var matrix = MainPaperView.RenderTransform.Value;

            matrix.ScaleAt(scale, scale, mouse.X, mouse.Y);
            MainPaperView.RenderTransform = new MatrixTransform(matrix);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isPanning = true;
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isPanning = false;
        }

        private void Window_MouseLeave(object sender, MouseEventArgs e)
        {
            // isPanning = false;
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if(!Mouse.LeftButton.Equals(MouseButtonState.Pressed))
                isPanning = false;
            
            if (isPanning)
            {
                var mousePos = e.GetPosition(MyGrid);
                var offsetX = mousePos.X - origin.X;
                var offsetY = mousePos.Y - origin.Y;
                var matrix = MainPaperView.RenderTransform.Value;
                matrix.Translate(offsetX, offsetY);
                MainPaperView.RenderTransform = new MatrixTransform(matrix);
            }
            origin = e.GetPosition(MyGrid);
        }
    }
}