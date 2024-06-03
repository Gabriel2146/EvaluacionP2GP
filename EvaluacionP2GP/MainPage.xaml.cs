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
                        lbSeleccionGP.Text = $"Ha seleccionado una recarga de: ${_selectedAmount} dólares";
                    }
                }
            }
        }

        private async void OnRecargarClickedGP(object sender, EventArgs e)
        {
            if (txtNumeroTelefonicoGP != null)
            {
                bool confirm = await DisplayAlert("Confirmación", $"¿Desea recargar ${_selectedAmount} en el número {txtNumeroTelefonicoGP.Text}?", "Sí", "No");
                if (confirm)
                {
                    string fileName = $"{txtNumeroTelefonicoGP.Text}.txt";
                    string content = $"Se hizo una recarga de ${_selectedAmount} dólares en la siguiente fecha; {DateTime.Now:dd/MM/yyyy}";

                    string filePath = Path.Combine(FileSystem.AppDataDirectory, fileName);
                    await File.WriteAllTextAsync(filePath, content);

                    await DisplayAlert("Éxito", "Recarga realizada con éxito", "OK");
                }
            }
        }


    }
}