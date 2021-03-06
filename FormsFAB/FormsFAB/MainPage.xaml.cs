﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsFAB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new SecondPage());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("FAB Clicked!", "Congrats on creating your FAB!", "Thanks!");
        }
    }
}
