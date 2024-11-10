using System.Collections.Generic;
using Capa_Datos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Chofer
    {
        private readonly D_Chofer datosChofer = new D_Chofer();

        public bool AgregarChofer(E_Chofer chofer)
        {
            return datosChofer.InsertarChofer(chofer);
        }

        public List<E_Chofer> ObtenerChoferes()
        {
            return datosChofer.ObtenerChoferes();
        }
    }
}