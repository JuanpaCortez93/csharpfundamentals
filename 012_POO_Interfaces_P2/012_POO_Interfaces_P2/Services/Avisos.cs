using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_POO_Interfaces_P2.Services
{
    class Avisos : IAvisos
    {

        public Avisos() 
        {
            _remitente = "General";
            _mensaje = "Sanción cometida. Pague en tres días y se beneficiará de una reducción en la sanción";
            _fecha = DateTime.Now;
        }

        public Avisos(string remitente, string mensaje)
        {
            _remitente = remitente;
            _mensaje = mensaje;
            _fecha = DateTime.Now;
        }

        public DateTime GetFecha() => _fecha;
        public void ShowAlert() => Console.WriteLine($"Remitente: {_remitente}\nMensaje: {_mensaje}\nFecha: {_fecha}");

        private string _remitente;
        private string _mensaje;
        private DateTime _fecha = DateTime.Now;
    }
}
