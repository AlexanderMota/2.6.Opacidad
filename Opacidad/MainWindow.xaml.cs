using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Opacidad
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();
        private void img_MouseEnter(object sender, MouseEventArgs e)
            => ((Image)sender).Opacity = 1;
        private void img_MouseLeave(object sender, MouseEventArgs e)
            => ((Image)sender).Opacity = 0.5;
    }
}
