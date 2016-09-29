using System;
using System.IO;
using System.Media;
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
        private readonly MediaPlayer _backgroundMusicPlayer = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();
            StartBackgroundMusic();
            //SoundPlayer soundPlayer = new SoundPlayer(@"..\..\Sounds\mw2theme.wav");
            //     soundPlayer.PlayLooping();
        }

        private void StartBackgroundMusic()
        {
            Uri uri = new Uri(@"..\..\Sounds\mw2Theme.wav", UriKind.Relative);
            _backgroundMusicPlayer.Open(uri);
            _backgroundMusicPlayer.MediaEnded += new EventHandler(Media_Ended);
            _backgroundMusicPlayer.Play();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

	private void Media_Ended(object sender, EventArgs e)
        {
            _backgroundMusicPlayer.Position = TimeSpan.Zero;
            _backgroundMusicPlayer.Play();
        }
        
    }
}
