using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage; // Necesario para FilePicker

namespace UdlaLife.Views
{
    public partial class SubirTareaPage : ContentPage
    {
        private string _archivoRuta;

        public SubirTareaPage()
        {
            InitializeComponent();
        }

        // M�todo para seleccionar el archivo PDF
        private async void OnSeleccionarArchivoClicked(object sender, EventArgs e)
        {
            try
            {
                var fileResult = await FilePicker.Default.PickAsync(new PickOptions
                {
                    PickerTitle = "Selecciona el archivo PDF",
                    FileTypes = FilePickerFileType.Pdf
                });

                if (fileResult != null)
                {
                    _archivoRuta = fileResult.FullPath;
                    // Aqu� puedes mostrar el nombre del archivo seleccionado
                    // ArchivoSeleccionadoLabel.Text = $"Archivo seleccionado: {fileResult.FileName}";
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"No se pudo seleccionar el archivo: {ex.Message}", "OK");
            }
        }

        // M�todo para subir la tarea
        private async void OnSubirTareaClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_archivoRuta))
            {
                await DisplayAlert("Error", "Por favor selecciona un archivo primero.", "OK");
                return;
            }

            // Aqu� puedes implementar la l�gica para subir el archivo a tu base de datos o servidor.
            await DisplayAlert("�xito", "Tarea subida correctamente.", "OK");
        }
    }
}
