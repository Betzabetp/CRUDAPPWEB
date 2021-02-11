using FormularioConsultas.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioConsultas.Modelo
{
    class FormularioConsultasModelo: FormularioConsultadto
    {
       public List<FormularioConsultasModelo> getConsulta { get; set; }
    }
}
