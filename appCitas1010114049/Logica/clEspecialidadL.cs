using appCitas1010114049.Datos;
using appCitas1010114049.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCitas1010114049.Logica
{
    class clEspecialidadL
    {
        public List<clEspecialidadE> mtdListarEspecialidad()
        {
            clEspecialidadD objEspecialidadD = new clEspecialidadD();
            List<clEspecialidadE> listarEspecialidad = new List<clEspecialidadE>();
            listarEspecialidad = objEspecialidadD.mtdListarEspecialidad();
            return listarEspecialidad;

        }
    }
}
