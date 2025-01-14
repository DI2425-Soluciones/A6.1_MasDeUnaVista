using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

namespace Personas
{
    class NuevaPersonaUserControlVM : ObservableObject
    {
        private readonly NavegaciónServicio navegacion;

        private Persona _nuevaPersona;
        public Persona NuevaPersona
        {
            get { return _nuevaPersona; }
            set { SetProperty(ref _nuevaPersona, value); }
        }

        private ObservableCollection<string> _listaNacionalidades;
        public ObservableCollection<string> ListaNacionalidades
        {
            get { return _listaNacionalidades; }
            set { SetProperty(ref _listaNacionalidades, value); }
        }

        public RelayCommand AceptarNuevaPersonaCommand { get; }
        public RelayCommand NuevaNacionalidadCommand { get; }

        public NuevaPersonaUserControlVM()
        {
            navegacion = new NavegaciónServicio();
            NuevaPersona = new Persona("",0,"Española");
            ListaNacionalidades = DatosServicio.ObtenerNacionalidades();
            AceptarNuevaPersonaCommand = new RelayCommand(AñadirPersona);
            NuevaNacionalidadCommand = new RelayCommand(AñadirNacionalidad);
        }

        private void AñadirNacionalidad()
        {
            bool? resultado = navegacion.AbrirDialogoNacionalidad();
            // Si el resultado es true, recargamos la lista de nacionalidades.
        }

        private void AñadirPersona()
        {
            MessageBox.Show("Código a completar en actividad A6.2", "Notificación", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
