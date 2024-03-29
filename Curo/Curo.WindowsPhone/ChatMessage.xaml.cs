﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Curo.DAL;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Curo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChatMessage : Page
    {

        ObservableCollection<Message> allmessages;
  
        public ChatMessage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            allmessages = new ObservableCollection<Message>();
            allmessages.Add(new Message { TextMessage = "Hello David,how are you?", Time = DateTime.Now.ToString(), Status = "Sent", tofrom = true });
            allmessages.Add(new Message { TextMessage = "Everything is great at my end.Where are you?I heard it's so cold out there.Are you coming to India soon?", Time = DateTime.Now.ToString(), Status = "Sent", tofrom = false });
            allmessages.Add(new Message { TextMessage = "I'm in Australia these days", Time = DateTime.Now.ToString(), Status = "Sent", tofrom = true});
            allmessages.Add(new Message { TextMessage = "Great!", Time = DateTime.Now.ToString(), Status = "Sent", tofrom =false });
            allmessages.Add(new Message { TextMessage = "I am leaving my hometown in 2-3 days", Time = DateTime.Now.ToString(), Status = "Failed", tofrom = true });

            this.myChat.ItemsSource = allmessages;
            System.Diagnostics.Debug.WriteLine(allmessages.Count);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void meClick_Click(object sender, RoutedEventArgs e)
        {

            Message mm = new Message { TextMessage = "This is an extra YOU bubble", Time = DateTime.Now.ToString(), Status = "Sent", tofrom = false };
            allmessages.Add(mm);
            this.myChat.ScrollIntoView(mm);

        }
    }
}
