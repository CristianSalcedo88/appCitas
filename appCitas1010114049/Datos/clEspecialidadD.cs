using appCitas1010114049.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCitas1010114049.Datos
{
    class clEspecialidadD
    {
        public List<clEspecialidadE> mtdListarEspecialidad()
        {
            string sql = "select * from especialidad";
            clConexion objConexion = new clConexion();
            DataTable tblEspecialidad = new DataTable();
            tblEspecialidad = objConexion.mtdDesconectado(sql);

            List<clEspecialidadE> listarEspecialidad = new List<clEspecialidadE>();

            for (int i = 0; i < tblEspecialidad.Rows.Count; i++)
            {
                clEspecialidadE objDatosEspecialidad = new clEspecialidadE();
                objDatosEspecialidad.idEspecialidad = int.Parse(tblEspecialidad.Rows[i]["idEspecialidad"].ToString());
                objDatosEspecialidad.especialidad = tblEspecialidad.Rows[i]["especialidad"].ToString();

                listarEspecialidad.Add(objDatosEspecialidad);

            }
            return listarEspecialidad;
        }
    }
}
