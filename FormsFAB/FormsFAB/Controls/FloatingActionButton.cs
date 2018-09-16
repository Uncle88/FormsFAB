using System;
using Xamarin.Forms;

namespace FormsFAB.Controls
{
    public class FloatingActionButton : Button
    {
        public FloatingActionButton(){}

        public static BindableProperty ButtonColorProperty = BindableProperty.Create(nameof(ButtonColor), 
                                                                                     typeof(Color), 
                                                                                     typeof(FloatingActionButton), 
                                                                                     Color.Accent);
        public Color ButtonColor
        {
            get
            {
                return (Color)GetValue(ButtonColorProperty);
            }
            set
            {
                SetValue(ButtonColorProperty, value);
            }
        }
    }
}
