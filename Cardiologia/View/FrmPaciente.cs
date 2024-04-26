using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cardiologia.Controller;

namespace Cardiologia.View
{
    public partial class FrmPaciente : Form
    {
        public FrmPaciente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConPaciente paciente = new MySqlConPaciente();

                string dataString = mkDataNasc.Text;
                DateTime data = DateTime.ParseExact(dataString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                paciente.Inserir(Convert.ToInt32(txtRegistro.Text), txtNome.Text, txtSexo.Text, txtCor.Text, data);
                MessageBox.Show("Cadastro concluído", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
