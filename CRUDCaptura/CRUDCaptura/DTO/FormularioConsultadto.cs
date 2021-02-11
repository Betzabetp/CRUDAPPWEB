using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioConsultas.dto
{
    class FormularioConsultadto
    {
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string  ApeidoPaterno {get; set;}
        public string  ApeidoMaterno {get; set;}
        public string  Empresa {get; set;}
        public string  RFC {get; set;}
        public string  Direccion {get; set;}
        public string NumeroExt {get; set;}
        public string NumeroInt {get; set;}
        public string  Colonia {get; set;}
        public string  CiudadRespuestaAyuda {get; set;}
        public string  EstadoRespuestaAyuda {get; set;}
        public string CodigoPostal {get; set;}
        public string TelefonoCasa {get; set;}
        public string Celular {get; set;}
        public string  Correo1 {get; set;}
        public string  Correo2 {get; set;}
        public string  AyudaSolicitada {get; set;}
        public string  Respuesta {get; set;}
        public string  CiudadInteres {get; set;}
        public string  MontoInvercion  {get; set;}
        public string ComoLlegoMensaje{ get; set; }
        public string Seguimiento { get; set; }
    }
}
