﻿using System;
using System.Collections.Generic;
using System.Timers;
using Xamarin.Forms;

namespace LifeofSi
{

    public partial class CocoonPage : ContentPage
    {


        //int timeLeft;
        int tapCount;

        public CocoonPage(string parameter)
        {
            InitializeComponent();
            userName.Text = parameter;
            Setup();

            //Device.StartTimer(TimeSpan.FromSeconds(x), update_data); //replace x with required seconds

            //public bool update_data()
            //{
            //    //Code to run frequently
            //    return true;
            //}


            //Timer T = new Timer();
            //int Minutes = 5;
            //int Seconds = 0;

            //Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            //{
            //    // Do something
            //    DisplayAlert("Warning " + userName.Text + "!", "Si is full. Come back again in 5 minutes", "Ok");

            //    return true; // True = Repeat again, False = Stop the timer
            //});

        }


        //public Fivemintimer()
        //{
        //    T.Interval = 1000;
        //    T.Tick += new EventHandler(T_Tick);
        //}

        private void Setup()
        {
            //AllEvents = GetEvents();
            //eventList.ItemsSource = AllEvents;

            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
                //foreach (var evt in AllEvents)
                //{
                //    var timespan = evt.Date - DateTime.Now;
                //    evt.Timespan = timespan;
                //}

                //eventList.ItemsSource = null;
                //eventList.ItemsSource = AllEvents;

                return true;
            });
        }

        void OnSwiped(object sender, SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Left:
                    //transformImage.Source = Image.Source = stage_2;

                    break;
                case SwipeDirection.Right:
                    // Handle the swipe
                    break;
            }
        }

        async void LeafButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void CocoonButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new CocoonPage(userName.Text));
        }

        async void SwatButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new FliesPage());
        }

        async void BasketButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MarketPage());
        }

        void transformImage_Clicked(System.Object sender, System.EventArgs e)
        {
            (sender as ImageButton).Source = ImageSource.FromFile("stage_2.png");
        }

        void OnTapGestureRecognizerTapped(object sender, EventArgs args)

        {
            tapCount++;
            var imageSender = (Image)sender;


            if (tapCount % 2 == 1)
            {
                imageSender.Source = "moth.png";
                timerUpdate.Text = "Si is now a moth.";
                percentage.Text = "50%";
                mainProgressBar.Progress = 0.5;
            }
            else if (tapCount % 2 == 0)
            {
                imageSender.Source = "stage_3.png";
                timerUpdate.Text = "Yay! Si has evolved into a butterfly.";
                percentage.Text = "100%";
                mainProgressBar.Progress = 1;
            }

        }

    }
}
