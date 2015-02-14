using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.BackgroundAudio;
using System.IO;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Collections.ObjectModel;

namespace KVMR.WP8
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
            if (!App.ViewModel.AreSongsLoaded)
            {
                App.ViewModel.LoadSongs();
            }
        }

        private void playButton_Click(object sender, RoutedEventArgs e)
        {
            if (BackgroundAudioPlayer.Instance.PlayerState != PlayState.Playing)
            {
                BackgroundAudioPlayer.Instance.Play();
                playButton.Content = "Pause";
            }
            else
            {
                BackgroundAudioPlayer.Instance.Pause();
                playButton.Content = "Play";
            }
        }


    }
}