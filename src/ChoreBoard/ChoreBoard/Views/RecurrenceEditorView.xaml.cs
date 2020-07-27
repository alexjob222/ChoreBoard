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
    public partial class RecurrenceEditorView : Base.BaseView<RecurrenceEditorViewModel>
    {
        public RecurrenceEditorView()
        {
            InitializeComponent();
        }
    }
}