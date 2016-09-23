using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Class_Maker.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MediaPlayer backgroundMusicPlayer = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();
            backgroundMusicPlayer.Open(new Uri(@"C:\Users\nerdi\Desktop\Class-Maker\Class-Maker\Sounds\mw2Theme.wav"));
            backgroundMusicPlayer.MediaEnded += new EventHandler(Media_Ended);
            backgroundMusicPlayer.Play();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
	private void Media_Ended(object sender, EventArgs e)
        {
            backgroundMusicPlayer.Position = TimeSpan.Zero;
            backgroundMusicPlayer.Play();
        }
        
    }
}
