﻿using ChoreBoard.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChoreBoard.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : Base.BaseView<MenuViewModel>
    {
        public MenuView()
        {
            Title = "ChoreBoard Test";
            InitializeComponent();
        }
    }
}