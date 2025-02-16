using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using Microsoft.Win32;

namespace TextXAMLProject.Controls.User
{
    public partial class MediaControl : UserControl
    {
        DispatcherTimer timer;
        MediaPlayer mediaPlayer = new MediaPlayer();
        bool isPaused = true;
        public MediaControl()
        {
            InitializeComponent();

            mediaPlayer.MediaOpened += MediaPlayer_MediaOpened;
            mediaPlayer.MediaEnded += MediaPlayer_MediaEnded;
            timer = new DispatcherTimer(TimeSpan.FromMilliseconds(100), DispatcherPriority.Input, Timer_Tick, Dispatcher);

            mediaPlayer.Volume = 0.5;
            VolumeSlider.Value = 0.5;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSlider.Value = mediaPlayer.Position.TotalSeconds;

            double current_minute = mediaPlayer.Position.Minutes;
            double current_second = mediaPlayer.Position.Seconds;
            string time = "";

            if (current_minute < 10)
                time = "0" + current_minute.ToString();

            CurrentLBL.Content = $"{time}:{current_second}";
        }
        private void MediaPlayer_MediaEnded(object sender, EventArgs e) => timer.Stop();
        private void MediaPlayer_MediaOpened(object sender, EventArgs e)
        {
            TrackTimeLBL.Content = mediaPlayer.NaturalDuration.ToString().Substring(3, 5);

            if (mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                TimeSlider.Maximum = mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
                TimeSlider.Value = 0;
                timer.Start();
            }
        }

        private void OpenTrackBTN_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                FileName = "Music",
                DefaultExt = ".mp3",
                Filter = "Music Files (*.mp3) | *.mp3",
            };

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                string track_name = dialog.SafeFileName;
                NameTrackLBL.Content = track_name.Substring(0, track_name.Length - 4);

                mediaPlayer.Open(new Uri(dialog.FileName, UriKind.RelativeOrAbsolute));
            }

            isPaused = true;
        }

        private void StartPauseBTN_Click(object sender, RoutedEventArgs e)
        {
            if (isPaused)
            {
                isPaused = false;
                StartPauseBTN.Content = "||";
                mediaPlayer.Play();
                timer.Start();

            }
            else
            {
                isPaused = true;
                StartPauseBTN.Content = "▶";
                mediaPlayer.Pause();
                timer.Stop();
            }
        }
        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) => mediaPlayer.Volume = e.NewValue;
        private void TimeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) => mediaPlayer.Position = TimeSpan.FromSeconds(TimeSlider.Value);
    }
}
