﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LifeofSi
{
    public partial class FeedPage : ContentPage
    {

        int clickTotal;

        public FeedPage()
        {
            InitializeComponent();
        }

        void ImageButton_Clicked(object sender, EventArgs e)
        {
            clickTotal += 1;
            leaves.Text = $"{clickTotal} /100";
        }

        async void LeafButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new FeedPage());
        }

        async void CocoonButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new CocoonPage());
        }

        async void SwatButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new FliesPage());
        }

        async void BasketButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MarketPage());
        }
    }
}
