using System;
using System.Collections.Generic;

namespace Artemisapp_BE.Composite
{
    public class BEPermiso : BEComposite
    {
        #region Constructor
        public BEPermiso(long pId, string pNombre) : base(pId, pNombre)
        {
        }
        #endregion

        #region Metodos
        // Un permiso NO puede agregar hijos
        public override void Agregar(BEComposite oBEComposite)
        {
            try
            {
                throw new Exception("No se puede agregar un permiso a otro permiso.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Un permiso NO tiene hijos
        public override IList<BEComposite> ObtenerHijos()
        {
            try
            {
                throw new Exception("Error: No se puede listar los permisos de un permiso en sí.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
