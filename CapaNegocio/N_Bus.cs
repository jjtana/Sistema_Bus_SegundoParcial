using Capa_Datos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class N_Bus
    {
        private readonly D_Bus datosBus = new D_Bus();

        // Método para agregar un autobús
        public bool AgregarBus(E_Bus bus)
        {
            return datosBus.InsertarBus(bus);
        }

        // Método para obtener todos los autobuses
        public List<E_Bus> ObtenerBuses()
        {
            return datosBus.ObtenerListaBuses();
        }

        // Método para actualizar un autobús
        public bool ActualizarBus(E_Bus bus)
        {
            return datosBus.ActualizarBus(bus);
        }

        // Método para eliminar un autobús
        public bool EliminarBus(int autobusID)
        {
            return datosBus.EliminarBus(autobusID);
        }
    }
}