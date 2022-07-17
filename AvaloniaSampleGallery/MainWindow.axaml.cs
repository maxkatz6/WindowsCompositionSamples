using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaSampleGallery
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Renderer.DrawFps = true;
        }
    }
}
