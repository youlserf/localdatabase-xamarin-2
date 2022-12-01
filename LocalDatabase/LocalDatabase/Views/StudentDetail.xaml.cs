using LocalDatabase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalDatabase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentDetail : ContentPage
    {
        public StudentDetail()
        {
            InitializeComponent();
            this.BindingContext = new StudentViewModel();
        }
    }
}