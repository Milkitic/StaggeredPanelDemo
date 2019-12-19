using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using Path = System.IO.Path;

namespace StaggeredPanelDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVm _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = (MainWindowVm)DataContext;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var di = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pics"));
            var allFiles = di.GetFiles().Select(k => new GalleryVm() { ImagePath = k.FullName });
            _viewModel.ImageList = new ObservableCollection<GalleryVm>(allFiles);
        }
    }
}
