using appCitas1010114049.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCitas1010114049
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            frmMedico objMedico = new frmMedico();
            objMedico.Show();

        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPaciente objPaciente = new frmPaciente();
            objPaciente.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            frmCita objCita = new frmCita();
            objCita.Show();
        }
    }
}
