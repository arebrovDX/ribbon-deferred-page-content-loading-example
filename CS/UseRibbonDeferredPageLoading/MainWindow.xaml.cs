using DevExpress.Mvvm;
using DevExpress.Mvvm.UI;
using DevExpress.Xpf.Core;
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

namespace UseRibbonDeferredPageLoading
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
    public class MainWindowViewModel : ViewModelBase
    {
        public ICommand OpenCommand { get; set; }
        public MainWindowViewModel()
        {
            OpenCommand = new DelegateCommand(Open);
        }
        void Open()
        {
            OpenFileDialogService openFileDialogService = new OpenFileDialogService();
            if(openFileDialogService.ShowDialog())
            { 
                ThemedMessageBox.Show(openFileDialogService.GetFullFileName());
            }
        }
    }
}
