using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACKUP
{
    public class EventoBitacora
    {
        /*
         * La bitacora: Es el registro de eventos. Se necesita una entidad
         * que representa a la bitacora (con fecha-hora, usuario y tipo de evento.
         * una clase que guarde y lea estos eventos (en un xml, como todo lo demas).
         * 
         * El backup/restore: es una clase que copia esos XML a carpetas de backup
         * y que restaura.
         */

        public DateTime FechaHora { get; set; }
        public string Usuario { get; set; }
        public string Evento { get; set; }

        public EventoBitacora(DateTime fechaHora, string usuario, string evento)
        {
            this.FechaHora = fechaHora;
            this.Usuario = usuario;
            this.Evento = evento;
        }
    }
}
