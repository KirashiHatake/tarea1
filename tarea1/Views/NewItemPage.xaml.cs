using System;
using System.Collections.Generic;
using System.ComponentModel;
using tarea1.Models;
using tarea1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tarea1.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}