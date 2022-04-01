using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class ModeloPaciente
    {
        private int pacienteId;
        private string pacienteNombre;
        private string pacienteApellido;
        private int pacienteEdad;
        private string pacienteMotivoDeConsulta;


        public int PacienteId
        {
            get { return pacienteId; }
            set { pacienteId = value; }
        }
        public string PacienteNombre
        {
            get { return pacienteNombre; }
            set { pacienteNombre = value; }
        }

        public string PacienteApellido
        {
            get { return pacienteApellido; }
            set { pacienteApellido = value; }
        }

        public int PacienteEdad
        {
            get { return pacienteEdad; }
            set { pacienteEdad = value; }
        }

        public string PacienteMotivoDeConsulta
        {
            get { return pacienteMotivoDeConsulta; }
            set { pacienteMotivoDeConsulta = value; }
        }

        override
        public String ToString()
        {
            return string.Format("El id del juego es:{0}\n" + "El nombre del juego es:{1}\n" + "Descripción:{2}\n" + "Año de lanzamiento:{3}", GameId, GameName, GameDescription, ReleaseYear);

        }

    }
}
