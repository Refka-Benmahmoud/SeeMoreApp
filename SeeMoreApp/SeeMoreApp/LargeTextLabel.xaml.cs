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
        #region Expanded
        public static readonly BindableProperty ExpandedProperty = BindableProperty.Create(
                        nameof(Expanded),
            typeof(bool),
            typeof(LargeTextLabel),
            false,
            BindingMode.OneWay,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                if (newValue != null && bindable is LargeTextLabel control)
                {
                    var actualNewValue = (bool)newValue;
                    control.SmallLabel.IsVisible = !actualNewValue;
                    control.FullLabel.IsVisible = actualNewValue;
                    control.ExpandContractButton.Text = actualNewValue ? "See Less" : "See More";
                }
            });

        public bool Expanded { get; set; }
        #endregion Expanded

        #region Text
        public static BindableProperty TextProperty = BindableProperty.Create(
                                                        propertyName: nameof(Text),
                                                        returnType: typeof(string),
                                                        declaringType: typeof(LargeTextLabel),
                                                        defaultValue: string.Empty,
                                                        defaultBindingMode: BindingMode.OneWay,
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

        #region Command
        //public static readonly BindableProperty CommandProperty = BindableProperty.Create(
        //                nameof(Command),
        //    typeof(ICommand),
        //    typeof(LargeTextLabel),
        //    default(Command),
        //    BindingMode.OneWay,
        //    propertyChanged: (bindable, oldValue, newValue) =>
        //    {
        //        if (newValue != null && bindable is LargeTextLabel control)
        //        {
        //            var actualNewValue = (ICommand)newValue;
        //            control.ExpandContractButton.Command = actualNewValue;
        //        }
        //    });

        //public ICommand Command { get; set; }


        public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command),
                                                                          typeof(ICommand),
                                                                          typeof(LargeTextLabel),
                                                                          default(ICommand));
        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }
        #endregion Command
    }
}