using AwsomeApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MorseCodeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var halfScreenWidth = Convert.ToInt32(Math.Round(DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density * 0.5));
            StackLayoutOutput1.WidthRequest = halfScreenWidth;
            StackLayoutOutput2.WidthRequest = halfScreenWidth;
        }

        public string[] currentMorseSequence = new string[2];
        public string[] currentWord = new string[2]; 

        public int GetButtonIndex(Button button)
        {
            return int.Parse(button.ClassId);
        }

        public void SetLabelMorseOutput(string text, int index)
        {
            if (index == 0)
            {
                LabelMorseOutput1.Text = text;
            } else
            {
                LabelMorseOutput2.Text = text;
            }
        }

        public void SetLabelWordOutput(string text, int index)
        {
            if (index == 0)
            {
                LabelWordOutput1.Text = text;
            } else
            {
                LabelWordOutput2.Text = text;
            }
        }

        public void OnClickPeriod(object sender, EventArgs args)
        {
            int index = GetButtonIndex(sender as Button);
            currentMorseSequence[index] += ".";
            SetLabelMorseOutput(currentMorseSequence[index], index); 
        }

        public void OnClickDash(object sender, EventArgs args)
        {
            int index = GetButtonIndex(sender as Button);
            currentMorseSequence[index] += "-";
            SetLabelMorseOutput(currentMorseSequence[index], index);
        }

        public void OnClickSpace(object sender, EventArgs args)
        {
            int index = GetButtonIndex(sender as Button); currentWord[index] += Morse.MorseCoder(currentMorseSequence[index]);
            currentMorseSequence[index] = "";
            SetLabelMorseOutput("", index);
            SetLabelWordOutput(currentWord[index], index);
        }

        public void ClearWord(object sender, EventArgs args)
        {
            int index = GetButtonIndex(sender as Button); currentMorseSequence[index] = "";
            currentWord[index] = "";
            SetLabelMorseOutput("", index);
            SetLabelWordOutput("", index);
        }
    }
}
