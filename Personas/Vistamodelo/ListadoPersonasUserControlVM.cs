using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Personas
{
    class ListadoPersonasUserControlVM : ObservableObject
    {
        private ObservableCollection<Persona> _listaPersonas;
        public ObservableCollection<Persona> ListaPersonas
        {
            get { return _listaPersonas; }
            set { SetProperty(ref _listaPersonas, value); }
        }

        public ListadoPersonasUserControlVM()
        {
            ListaPersonas = DatosServicio.ObtenerPersonas();
        }
    }
}
