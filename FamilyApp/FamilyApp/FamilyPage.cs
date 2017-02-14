using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FamilyApp
{
    public class FamilyPage : ContentPage
    {
        public FamilyPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "My mother's name is" },
                    new Label { Text = "Tammy Estrem", TextColor = Color.Green, FontAttributes = FontAttributes.Bold },
                    new Label { Text = "My father's name is" },
                    new Label { Text = "Joseph Estrem", TextColor = Color.Blue, FontAttributes = FontAttributes.Bold },
                    new Label { Text = "My brother's name is" },
                    new Label { Text = "Chad Estrem", TextColor = Color.Red, FontAttributes = FontAttributes.Bold },
                    new Label { Text = "My grandmother's name is" },
                    new Label { Text = "Barbara Ottenstroer", TextColor = Color.Aqua, FontAttributes = FontAttributes.Bold },
                    new Label { Text = "My grandfather's name is" },
                    new Label { Text = "Donald Ottenstroer", TextColor = Color.Yellow, FontAttributes = FontAttributes.Bold },
                    new Label { Text = "My roomate's name is" },
                    new Label { Text = "Austin", TextColor = Color.Purple, FontAttributes = FontAttributes.Bold, },
                }
            };
        }
    }
}
