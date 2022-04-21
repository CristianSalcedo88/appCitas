using appCitas1010114049.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCitas1010114049.Datos
{
    class clConsultorioD
    {
        public List<clConsultorioE> mtdEnviarC(int especialidad)
        {
            string sql = "select * from consultorio where idEspecialidad = '" + especialidad + "'";
            clConexion objConexion = new clConexion();
            DataTable tblConsultorio = new DataTable();
            tblConsultorio = objConexion.mtdDesconectado(sql);

            List<clConsultorioE> listarConsultorio = new List<clConsultorioE>();

            for (int i = 0; i < tblConsultorio.Rows.Count; i++)
            {
                clConsultorioE objDatosConsultorio = new clConsultorioE();
                objDatosConsultorio.idConsultorio = int.Parse(tblConsultorio.Rows[i]["idConsultorio"].ToString());
                objDatosConsultorio.nombreConsultorio = tblConsultorio.Rows[i]["nombreConsultorio"].ToString();
                objDatosConsultorio.numeroConsultorio = int.Parse(tblConsultorio.Rows[i]["numeroConsultorio"].ToString());
                objDatosConsultorio.piso = int.Parse(tblConsultorio.Rows[i]["piso"].ToString());
                objDatosConsultorio.idEspecialidad = int.Parse(tblConsultorio.Rows[i]["idEspecialidad"].ToString());
                listarConsultorio.Add(objDatosConsultorio);

            }
            return listarConsultorio;
        }
    }
}
