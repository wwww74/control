using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace TextXAMLProject.Controls.Custom
{
    public class MediaCustomControl : Control
    {
        DispatcherTimer timer;
        MediaPlayer mediaPlayer = new MediaPlayer();
        bool isPaused = true;
        bool isFirstStart = true;

        static MediaCustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MediaCustomControl), new FrameworkPropertyMetadata(typeof(MediaCustomControl)));
        }
        
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            Button openTrackBtn = GetTemplateChild("OpenTrackBTN") as Button;
            Button startPauseBtn = GetTemplateChild("StartPauseBTN") as Button;
            Slider volumeSlider = GetTemplateChild("VolumeSlider") as Slider;
            Slider timeSlider = GetTemplateChild("TimeSlider") as Slider;

            openTrackBtn.Click += OpenDialog;
            startPauseBtn.Click += StartPauseBTN_Click;
            volumeSlider.ValueChanged += VolumeSlider_ValueChanged;
            timeSlider.ValueChanged += TimeSlider_ValueChanged;
        }

        public static readonly DependencyProperty TrackTimeProperty = DependencyProperty.Register("TrackTime", typeof(string), typeof(MediaCustomControl), new PropertyMetadata("00:00"));
        public static readonly DependencyProperty NameTrackProperty = DependencyProperty.Register("NameTrack", typeof(string), typeof(MediaCustomControl), new PropertyMetadata("Name Track"));
        public static readonly DependencyProperty CurrentTimeProperty = DependencyProperty.Register("CurrentTime", typeof(string), typeof(MediaCustomControl), new PropertyMetadata("00:00"));

        public string TrackTime
        {
            get { return (string)GetValue(TrackTimeProperty); }
            set { SetValue(TrackTimeProperty, value); }
        }
        public string CurrentTime
        {
            get { return (string)GetValue(CurrentTimeProperty); }
            set { SetValue(CurrentTimeProperty, value); }
        }
        public string NameTrack
        {
            get { return (string)GetValue(NameTrackProperty); }
            set { SetValue(NameTrackProperty, value); }
        }

        [System.ComponentModel.Bindable(true)]
        public double SliderValue { get; set; }

        [System.ComponentModel.Bindable(true)]
        public double VolumeValue { get; set; }

        [System.ComponentModel.Bindable(true)]
        public double SliderMax { get; set; }

        #region MediaMethods
        private void OpenDialog(object sender, RoutedEventArgs e)
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
                NameTrack = track_name.Substring(0, track_name.Length - 4);

                mediaPlayer.Open(new Uri(dialog.FileName, UriKind.RelativeOrAbsolute));
            }

            isPaused = true;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            SliderValue = mediaPlayer.Position.TotalSeconds;

            double current_minute = mediaPlayer.Position.Minutes;
            double current_second = mediaPlayer.Position.Seconds;
            string time = "";

            if (current_minute < 10)
                time = "0" + current_minute.ToString();

            CurrentTime = $"{time}:{current_second}";
        }
        private void StartPauseBTN_Click(object sender, RoutedEventArgs e)
        {
            if (isFirstStart)
            {
                isFirstStart = false;

                timer = new DispatcherTimer(TimeSpan.FromMilliseconds(100), DispatcherPriority.Input, Timer_Tick, Dispatcher);
                mediaPlayer.Volume = 0.5;
                VolumeValue = 0.5;

                TrackTime = mediaPlayer.NaturalDuration.ToString().Substring(3, 5);

                if (mediaPlayer.NaturalDuration.HasTimeSpan)
                {
                    SliderMax = mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
                    SliderValue = 0;
                    timer.Start();
                }
            }

            if (isPaused)
            {
                isPaused = false;
                mediaPlayer.Play();
                timer.Start();

            }
            else
            {
                isPaused = true;
                mediaPlayer.Pause();
                timer.Stop();
            }
        }
        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) => mediaPlayer.Volume = e.NewValue;
        private void TimeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) => mediaPlayer.Position = TimeSpan.FromSeconds(SliderValue);
        #endregion
    }
}
