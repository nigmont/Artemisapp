using System;
using System.Collections.Generic;

namespace Artemisapp_BE.Composite
{
    public abstract class BEComposite
    {
        #region Propiedades
        public long Id { get; set; }
        public string Nombre { get; set; }
        #endregion

        #region Constructor
        public BEComposite(long pId, string pNombre)
        {
            Id = pId;
            Nombre = pNombre;
        }
        #endregion

        #region Metodos
        // Agregar un hijo (un permiso dentro de un rol)
        public abstract void Agregar(BEComposite oBEComposite);

        // Obtener todos los hijos
        public abstract IList<BEComposite> ObtenerHijos();
        #endregion
    }
}
