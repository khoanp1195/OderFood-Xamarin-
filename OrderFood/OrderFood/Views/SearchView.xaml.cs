﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrderFood.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchView : ContentPage
    {
        public SearchView()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            grFilter.TranslationX = 200;
            grFilter.Opacity = 0;
            grFilter.IsVisible = true;

            grFilter.FadeTo(1, 400);
            grFilter.TranslateTo(0, 0, 700, Easing.SinInOut);

        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            grFilter.TranslationX = 0;
            grFilter.Opacity = 1;
           

           await grFilter.FadeTo(0, 400);
           await grFilter.TranslateTo(600, 0,700, Easing.SinInOut);
            grFilter.IsVisible = false;
        }
    }
}