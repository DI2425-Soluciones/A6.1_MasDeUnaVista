using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Personas
{
    class DialogoNacionalidadVM : ObservableObject
    {
        private string _nacionalidad;

        public string Nacionalidad
        {
            get { return _nacionalidad; }
            set { SetProperty(ref _nacionalidad, value); }
        }


        public DialogoNacionalidadVM()
        {
            //Aquí incluiremos las propiedades y métodos necesarios para la vista de diálogo en caso necesario.
        }

        public void Aceptar()
        {
            //Aquí incluiremos la lógica necesaria cuando se pulse el botón aceptar
            MessageBox.Show("Código a completar en actividad A6.2", "Notificación", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
