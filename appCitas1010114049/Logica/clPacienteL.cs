using appCitas1010114049.Datos;
using appCitas1010114049.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCitas1010114049.Logica
{
    class clPacienteL
    {
        public List<clPacienteE> mtdListarPaciente()
        {
            clPacienteD objPacienteD = new clPacienteD();
            List<clPacienteE> listarPacientes = new List<clPacienteE>();
            listarPacientes = objPacienteD.mtdListar();
            return listarPacientes;

        }
        public int mtdRegistrarPaciente(clPacienteE objDatosPaciente)
        {
            clPacienteD objPacienteD = new clPacienteD();
            int result = objPacienteD.mtdRegistrarPaciente(objDatosPaciente);
            return result;
        }
        public void mtdEliminarPaciente(int idPaciente)
        {
            clPacienteD objPacienteD = new clPacienteD();
            objPacienteD.mtdEliminarPaciente(idPaciente);

        }
        public void mtdEditarDatos(clPacienteE objDatosEditar)
        {
            clPacienteD objPacienteD = new clPacienteD();
            objPacienteD.mtdEditarDatos(objDatosEditar);

        }
        public List<clPacienteE> mtdEnviar(string documento)
        {
            clPacienteD objPacienteD = new clPacienteD();
            objPacienteD.mtdEnviar(documento);
   
            List<clPacienteE> listarPacientes = new List<clPacienteE>();
            listarPacientes = objPacienteD.mtdEnviar(documento);
            return listarPacientes;
        }
    }
}
