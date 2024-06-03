using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;


namespace EvaluacionP2GP
{
    public partial class MainPage : ContentPage
    {
        private string _selectedAmount = "5";

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCheckedChangedGP(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                var radioButton = sender as RadioButton;
                if (radioButton != null)
                {
                    _selectedAmount = radioButton.Value.ToString();
                    if (lbSeleccionGP != null)
                    {
                        lbSeleccionGP.Text = $"Ha seleccionado una recarga de: ${_selectedAmount} USD";
                    }
                }
            }
        }

    }

}
