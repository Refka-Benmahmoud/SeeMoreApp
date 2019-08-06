using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeeMoreApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LargeTextLabel : ContentView
	{
		public LargeTextLabel ()
		{
			InitializeComponent ();
            Content.BindingContext = this;
		}

        #region Text
        public static BindableProperty TextProperty = BindableProperty.Create(
                                                        propertyName: nameof(Text),
                                                        returnType: typeof(string),
                                                        declaringType: typeof(LargeTextLabel),
                                                        defaultValue: string.Empty,
                                                        defaultBindingMode: BindingMode.Default,
                                                        propertyChanged: TextPropertyChanged);

        public string Text
        {
            get { return base.GetValue(TextProperty).ToString(); }
            set { base.SetValue(TextProperty, value); }
        }

        private static void TextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (LargeTextLabel)bindable;
            if (control == null) return;
            if ((string)newValue != null)
            {
                var actualNewValue = (string)newValue;
                control.SmallLabel.Text = actualNewValue;
                control.FullLabel.Text = actualNewValue;
            }
            control.OnPropertyChanged(nameof(control.Text));
        }
        #endregion Text

        private bool textExpanded;
        public bool TextExpanded
        {
            get { return textExpanded; }
            set { textExpanded = value; OnPropertyChanged(); }
        }
        private void ExpandContractButton_Clicked(object sender, EventArgs e)
        {
            if (TextExpanded)
            {
                TextExpanded = false;
                SmallLabel.IsVisible = true;
                FullLabel.IsVisible = false;

            }
            else
            {
                TextExpanded = true;
                FullLabel.IsVisible = true;
                SmallLabel.IsVisible = false;
            }
            ExpandContractButton.Text = TextExpanded ? "See Less" : "See More";
        }
    }
}