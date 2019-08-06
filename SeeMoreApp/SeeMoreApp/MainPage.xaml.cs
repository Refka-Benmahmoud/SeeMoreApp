using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SeeMoreApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MainPageModel.ItemsSource = new ObservableCollection<MainPageModel>()
            {
                new MainPageModel() { LabelText = "Hello how are you?\nText Long Text To test the see more and see less. Test Test Test Test Test Test Test Test Test Test Test Test .\n\nThanks in advance."},
                new MainPageModel() { LabelText = "Hello how are you?\nText Long Text To test the see more and see less. Test Test Test Test Test Test Test Test Test Test Test Test .\n\nThanks in advance."},
                new MainPageModel() { LabelText = "Hello how are you?\nText Long Text To test the see more and see less. Test Test Test Test Test Test Test Test Test Test Test Test .\n\nThanks in advance."},
                new MainPageModel() { LabelText = "Hello how are you?\nText Long Text To test the see more and see less. Test Test Test Test Test Test Test Test Test Test Test Test .\n\nThanks in advance."},
                new MainPageModel() { LabelText = "Hello how are you?\nText Long Text To test the see more and see less. Test Test Test Test Test Test Test Test Test Test Test Test .\n\nThanks in advance."},
                new MainPageModel() { LabelText = "Hello how are you?\nText Long Text To test the see more and see less. Test Test Test Test Test Test Test Test Test Test Test Test .\n\nThanks in advance."},
                new MainPageModel() { LabelText = "Hello how are you?\nText Long Text To test the see more and see less. Test Test Test Test Test Test Test Test Test Test Test Test .\n\nThanks in advance."},
                new MainPageModel() { LabelText = "Hello how are you?\nText Long Text To test the see more and see less. Test Test Test Test Test Test Test Test Test Test Test Test .\n\nThanks in advance."},
                new MainPageModel() { LabelText = "Hello how are you?\nText Long Text To test the see more and see less. Test Test Test Test Test Test Test Test Test Test Test Test .\n\nThanks in advance."},
            };
        }
    }
}
