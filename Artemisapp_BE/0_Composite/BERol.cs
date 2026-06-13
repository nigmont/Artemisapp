using System;
using System.Collections.Generic;

namespace Artemisapp_BE.Composite
{
    public class BERol : BEComposite
    {
        #region Propiedades
        public List<BEComposite> ListaDePermisos { get; set; }
        #endregion

        #region Constructor
        public BERol(long pId, string pNombre) : base(pId, pNombre)
        {
            ListaDePermisos = new List<BEComposite>();
        }
        #endregion

        #region Metodos
        // Agrega un permiso a este rol
        public override void Agregar(BEComposite oBEComposite)
        {
            try
            {
                if (oBEComposite != null)
                {
                    ListaDePermisos.Add(oBEComposite);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Devuelve todos los permisos de este rol
        public override IList<BEComposite> ObtenerHijos()
        {
            try
            {
                return ListaDePermisos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}