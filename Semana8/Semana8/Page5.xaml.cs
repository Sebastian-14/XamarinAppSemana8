using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            InitializeComponent();
            DatePicker datePicker = new DatePicker
            {
                MinimumDate = new DateTime(2018, 1, 1),
                MaximumDate = new DateTime(2018, 12, 31),
                Date = new DateTime(2018, 6, 21)
            };
        }
    }
}