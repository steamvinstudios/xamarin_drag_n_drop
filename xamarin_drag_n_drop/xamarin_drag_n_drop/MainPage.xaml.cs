using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarin_drag_n_drop
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        {
            var label = (sender as Element)?.Parent as Label;
            e.Data.Properties.Add("Text", label.Text);
        }

        private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
        {
            var data = e.Data.Properties["Text"].ToString();
            //e.Data.GetTextAsync();
            var frame = (sender as Element)?.Parent as Frame;
            frame.Content = new Label
            {
                Text = data
            };
        }
    }
}
