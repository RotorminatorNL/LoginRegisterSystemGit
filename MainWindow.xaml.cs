using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace LoginRegisterSystem
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

        private void bdrMinimize_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        [System.Obsolete]
        private void bdrMinimize_MouseEnter(object sender, MouseEventArgs e)
        {
            bdrMinimize.BitmapEffect = new DropShadowBitmapEffect
            {
                Color = Color.FromRgb(255,255,255),
                ShadowDepth = 0,
                Softness = 0
            };
        }

        [System.Obsolete]
        private void bdrMinimize_MouseLeave(object sender, MouseEventArgs e)
        {
            bdrMinimize.BitmapEffect = new DropShadowBitmapEffect
            {
                Color = Color.FromRgb(255, 255, 255),
                ShadowDepth = 0,
                Softness = 5
            };
        }

        private void bdrClose_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        [System.Obsolete]
        private void bdrClose_MouseEnter(object sender, MouseEventArgs e)
        {
            bdrClose.BitmapEffect = new DropShadowBitmapEffect
            {
                Color = Color.FromRgb(255, 255, 255),
                ShadowDepth = 0,
                Softness = 0
            };
        }

        [System.Obsolete]
        private void bdrClose_MouseLeave(object sender, MouseEventArgs e)
        {
            bdrClose.BitmapEffect = new DropShadowBitmapEffect
            {
                Color = Color.FromRgb(255, 255, 255),
                ShadowDepth = 0,
                Softness = 5
            };
        }
    }
}
