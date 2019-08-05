using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace SeeMoreApp
{
    internal class MainPageModel : INotifyPropertyChanged
    {
        public MainPageModel()
    {
        Title = "Main Page";
        LabelText = "Hello how are you?\nText Long Text To test the see more and see less. Test Test Test .\n\nThanks in advance.";
    }

    #region Bound Properties

        private bool textExpanded;
        public bool TextExpanded
        {
            get { return textExpanded; }
            set { textExpanded = value; OnPropertyChanged(); }
        }
        private string labelText;
        public string LabelText
        {
            get { return labelText; }
            set { labelText = value; OnPropertyChanged(); }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged(); }
        }
        #endregion Bound Properties

        #region Commands
        private ICommand _ExpandContractCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ExpandContractCommand
    {
        get
        {
            if (_ExpandContractCommand == null)
            {
                _ExpandContractCommand = new Xamarin.Forms.Command(() => {
                    TextExpanded = !TextExpanded;
                });
            }

            return _ExpandContractCommand;
        }
    }
        #endregion Commands
        protected void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            var changed = PropertyChanged;
            changed?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
