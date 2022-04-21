using appCitas1010114049.Entidad;
using appCitas1010114049.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCitas1010114049.Presentacion
{
    public partial class frmCita : Form
    {

        string documento;
        int especialidad;
        public frmCita()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            clPacienteL objPacienteL = new clPacienteL();
            documento = txtDocumento.Text;
            objPacienteL.mtdEnviar(documento);
            dgvCitas.DataSource = objPacienteL.mtdEnviar(documento);

        }

        private void frmCita_Load(object sender, EventArgs e)
        {
            //Mostrar Especialidad
            clEspecialidadL objEspecialidadL = new clEspecialidadL();
            cmbEspecialidadC.DataSource = objEspecialidadL.mtdListarEspecialidad();
            cmbEspecialidadC.DisplayMember = "especialidad";
            cmbEspecialidadC.ValueMember = "idEspecialidad";
        }

        private void cmbEspecialidadC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                especialidad = int.Parse(cmbEspecialidadC.SelectedValue.ToString());

                clMedicoL objMedicoL = new clMedicoL();
                objMedicoL.mtdEnviarM(especialidad);
                dgvMedicosC.DataSource = objMedicoL.mtdEnviarM(especialidad);

                clConsultorioL objConsultorioL = new clConsultorioL();
                objConsultorioL.mtdEnviarC(especialidad);
                dgvConsultorioC.DataSource = objConsultorioL.mtdEnviarC(especialidad);
            }
            catch (Exception)
            {

                
            }



        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

     

        private void dgvMedicosC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             txtMedico.Text = dgvMedicosC.CurrentRow.Cells[0].Value.ToString();
        
            
        }

        private void dgvConsultorioC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtConsultorio.Text = dgvConsultorioC.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPaciente.Text = dgvCitas.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
