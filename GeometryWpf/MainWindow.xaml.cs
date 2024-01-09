using Geometry.Model;
using Geometry.Observer;
using GeometryObservable.Observers;
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

namespace GeometryWpf
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FormManager _formManager;
        private FileLogger _fileLogger;

        public MainWindow()
        {
            InitializeComponent();
            _formManager = new FormManager();
            _formManager.Subscribe(new ConsoleLogger());
            _fileLogger = new FileLogger("C:\\L\\log_forms.txt");
            _formManager.Subscribe(_fileLogger);
        }

        private void AddCircleButtonClicked(object sender, RoutedEventArgs e)
        {
            // minimum code here
            var name = NameField.Text;
            var x = Int32.Parse(XField.Text);
            var y = Int32.Parse(YField.Text);
            var radius = Int32.Parse(RadiusField.Text);
            // call receiver
            _formManager.AddCircle(name, x, y, radius);
        }

        private void AddPointButtonClicked(object sender, RoutedEventArgs e)
        {
            var name = NameField.Text;
            var x = Int32.Parse(XField.Text);
            var y = Int32.Parse(YField.Text);
            _formManager.AddPoint(name, x, y);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _fileLogger.Dispose();
        }
    }
}
