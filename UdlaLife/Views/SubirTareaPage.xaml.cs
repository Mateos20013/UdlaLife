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

        // Método para seleccionar el archivo PDF
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
                    // Aquí puedes mostrar el nombre del archivo seleccionado
                    // ArchivoSeleccionadoLabel.Text = $"Archivo seleccionado: {fileResult.FileName}";
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"No se pudo seleccionar el archivo: {ex.Message}", "OK");
            }
        }

        // Método para subir la tarea
        private async void OnSubirTareaClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_archivoRuta))
            {
                await DisplayAlert("Error", "Por favor selecciona un archivo primero.", "OK");
                return;
            }

            // Aquí puedes implementar la lógica para subir el archivo a tu base de datos o servidor.
            await DisplayAlert("Éxito", "Tarea subida correctamente.", "OK");
        }
    }
}
