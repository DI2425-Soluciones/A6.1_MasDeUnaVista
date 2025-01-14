using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Personas
{
    class NavegaciónServicio
    {
        // Se instancia aquí el objeto para conservar los datos de la vista y no se resetee.
        private static readonly UserControl VistaListadoPersonas = new ListadoPersonasUserControl();

        public NavegaciónServicio()
        {
            
        }

        /* Métodos para abrir o cargar las vistas: dos USER-CONTROL y un DIÁLOGO (VENTANA) */
        public UserControl ObtenerNuevaPersona()
        {
            return new NuevaPersonaUserControl();
        }

        public UserControl ObtenerListadoPersonas()
        {
            return VistaListadoPersonas;
        }

        public bool? AbrirDialogoNacionalidad()
        {
            DialogoNacionalidad dialogo = new DialogoNacionalidad();
            return dialogo.ShowDialog();
        }
    }
}
