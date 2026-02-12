using SchematicSymbols.MVVM;
using SchematicSymbols.Symbols;
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

namespace SchematicSymbols.Elementary
{
    /// <summary>
    /// Interaction logic for RotableSymbol.xaml
    /// </summary>
    public partial class BasicSymbol : UserControl
    {
        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsSelected.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register("IsSelected", typeof(bool), typeof(BasicSymbol), new PropertyMetadata(false));

        public object InnerContent
        {
            get { return (object)GetValue(InnerContentProperty); }
            set { SetValue(InnerContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for InnerContent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InnerContentProperty =
            DependencyProperty.Register("InnerContent", typeof(object), typeof(BasicSymbol), new PropertyMetadata(null));

        public BasicSymbol()
        {
            InitializeComponent();
        }

        private void Root_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (DataContext is not Rotable_VM rvm)
                return;
            rvm.RotateClockwise();
        }
    }
}
