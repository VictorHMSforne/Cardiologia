using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cardiologia.Controller;
using Cardiologia.Model;
using Cardiologia.View;

namespace Cardiologia
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FrmCadastrar cadastrar = new FrmCadastrar();
            cadastrar.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPaciente paciente = new FrmPaciente();
            paciente.Show();
        }
    }
}
