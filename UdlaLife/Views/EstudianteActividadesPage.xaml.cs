using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.IO;
using UdlaLife.Models;
using UdlaLife.ViewModel; // Aseg�rate de que el ViewModel est� referenciado
using Microsoft.Maui.Storage;

namespace UdlaLife.Views
{
    public partial class EstudianteActividadesPage : ContentPage
    {
        public EstudianteActividadesPage()
        {
            InitializeComponent();  
            BindingContext = new EstudianteActividadesViewModel();
        }
    }
}
