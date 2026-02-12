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
    /// Interaction logic for ElementTerminal.xaml
    /// </summary>
    public partial class ElementTerminal : UserControl
    {


        public int TerminalNo
        {
            get { return (int)GetValue(TerminalNoProperty); }
            set { SetValue(TerminalNoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TerminalNo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TerminalNoProperty =
            DependencyProperty.Register("TerminalNo", typeof(int), typeof(ElementTerminal), new PropertyMetadata(-1));



        public string TerminalName
        {
            get { return (string)GetValue(TerminalNameProperty); }
            set { SetValue(TerminalNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TerminalName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TerminalNameProperty =
            DependencyProperty.Register("TerminalName", typeof(string), typeof(ElementTerminal), new PropertyMetadata("None"));


        public ElementTerminal()
        {
            InitializeComponent();
        }
    }
}
