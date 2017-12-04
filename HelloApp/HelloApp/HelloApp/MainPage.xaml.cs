using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloApp
{
    public partial class MainPage : ContentPage
    {
        int count = 1;
        public MainPage()
        {
            InitializeComponent();

            this.Button1.Clicked += delegate { this.Button1.Text = $"Хуяксов: {count++}"; };
        }
    }
}
