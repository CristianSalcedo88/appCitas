using appCitas1010114049.Datos;
using appCitas1010114049.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCitas1010114049.Logica
{
    class clConsultorioL
    {
        public List<clConsultorioE> mtdEnviarC(int especialidad)
        {
            clConsultorioD objConsultorioD = new clConsultorioD();
            objConsultorioD.mtdEnviarC(especialidad);

            List<clConsultorioE> listarConsultorio = new List<clConsultorioE>();
            listarConsultorio = objConsultorioD.mtdEnviarC(especialidad);
            return listarConsultorio;
        }
    }
}
