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
    public partial class FrmCadastrar : Form
    {
        public FrmCadastrar()
        {
            InitializeComponent();
            mkAno.Enabled = false;
            mkAno.Visible = false;
            lblAno.Visible = false;
            //
            txtTitulacao.Enabled = false;
            txtTitulacao.Visible = false;
            lblTitulacao.Visible = false;
        }

        private void cbxTipoMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoMedico.SelectedItem.ToString() == "Docente")
            {
                txtTitulacao.Enabled = true;
                txtTitulacao.Visible = true;
                lblTitulacao.Visible = true;
                //
                mkAno.Enabled = false;
                mkAno.Visible = false;
                lblAno.Visible = false;
            }
            else if (cbxTipoMedico.SelectedItem.ToString() == "Residente")
            {
                mkAno.Enabled = true;
                mkAno.Visible = true;
                lblAno.Visible = true;
                //
                txtTitulacao.Enabled = false;
                txtTitulacao.Visible = false;
                lblTitulacao.Visible = false;
            }
            else
            {
                mkAno.Enabled = false;
                mkAno.Visible = false;
                lblAno.Visible = false;
                //
                txtTitulacao.Enabled = false;
                txtTitulacao.Visible = false;
                lblTitulacao.Visible = false;
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCon inserir = new MySqlCon();
                string dataString = mkAno.Text;
                if (cbxTipoMedico.SelectedItem.ToString() == "Padrão")
                {

                    inserir.Inserir(txtNome.Text, Convert.ToInt32(txtCRM.Text), cbxTipoMedico.Text, null, txtTitulacao.Text);
                    MessageBox.Show("Medico Cadastrado com Sucesso!", "Inserção Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTitulacao.Text = "";
                    mkAno.Text = "";
                }
                else if (cbxTipoMedico.SelectedItem.ToString() == "Docente")
                {
                    inserir.Inserir(txtNome.Text, Convert.ToInt32(txtCRM.Text), cbxTipoMedico.Text, null, txtTitulacao.Text);
                    MessageBox.Show("Medico Cadastrado com Sucesso!", "Inserção Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTitulacao.Text = "";
                    mkAno.Text = "";
                }
                else
                {
                    DateTime data = DateTime.ParseExact(dataString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    inserir.Inserir(txtNome.Text, Convert.ToInt32(txtCRM.Text), cbxTipoMedico.Text, data, txtTitulacao.Text);
                    MessageBox.Show("Medico Cadastrado com Sucesso!", "Inserção Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTitulacao.Text = "";
                    mkAno.Text = "";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
