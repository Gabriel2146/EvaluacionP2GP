using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;


namespace EvaluacionP2GP
{
    public partial class MainPage : ContentPage
    {
        private string _selectedAmount = 5;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
