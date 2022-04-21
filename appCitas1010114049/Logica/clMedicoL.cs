using appCitas1010114049.Datos;
using appCitas1010114049.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace appCitas1010114049.Logica
{
    class clMedicoL
    {
        public List<clMedicoE> mtdListarMedico()
        {
            clMedicoD objMedicoD = new clMedicoD();
            List<clMedicoE> listarMedicos = new List<clMedicoE>();
            listarMedicos = objMedicoD.mtdListar();
            return listarMedicos;

        }
        public int mtdRegistrarMedico(clMedicoE objDatosMedico)
        {
            clMedicoD objMedicoD = new clMedicoD();
            int result = objMedicoD.mtdRegistrarMedico(objDatosMedico);
            return result;
        }

        public void mtdEliminarMedico(int idMedico)
        {
            clMedicoD objMedicoD = new clMedicoD();
            objMedicoD.mtdEliminarMedico(idMedico);
            
        }
        public void mtdEditarDatos(clMedicoE objDatosEditar)
        {
            clMedicoD objMedicoD = new clMedicoD();
            objMedicoD.mtdEditarDatos(objDatosEditar);
            
        }
        public List<clMedicoE> mtdEnviarM(int especialidad)
        {
            clMedicoD objMedicoD = new clMedicoD();
            objMedicoD.mtdEnviarM(especialidad);

            List<clMedicoE> listarMedicos = new List<clMedicoE>();
            listarMedicos = objMedicoD.mtdEnviarM(especialidad);
            return listarMedicos;
        }

    }
}
