namespace Cardiologia.View
{
    partial class FrmCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipoMedico = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtTitulacao = new System.Windows.Forms.TextBox();
            this.lblTitulacao = new System.Windows.Forms.Label();
            this.mkAno = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(389, 168);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(177, 50);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(36, 69);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtCRM
            // 
            this.txtCRM.Location = new System.Drawing.Point(36, 133);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(100, 20);
            this.txtCRM.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CRM";
            // 
            // cbxTipoMedico
            // 
            this.cbxTipoMedico.FormattingEnabled = true;
            this.cbxTipoMedico.Items.AddRange(new object[] {
            "Residente",
            "Docente",
            "Padrão"});
            this.cbxTipoMedico.Location = new System.Drawing.Point(36, 203);
            this.cbxTipoMedico.Name = "cbxTipoMedico";
            this.cbxTipoMedico.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoMedico.TabIndex = 6;
            this.cbxTipoMedico.SelectedIndexChanged += new System.EventHandler(this.cbxTipoMedico_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de Médico";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(33, 265);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(97, 13);
            this.lblAno.TabIndex = 8;
            this.lblAno.Text = "Ano de Residência";
            // 
            // txtTitulacao
            // 
            this.txtTitulacao.Location = new System.Drawing.Point(187, 281);
            this.txtTitulacao.Name = "txtTitulacao";
            this.txtTitulacao.Size = new System.Drawing.Size(100, 20);
            this.txtTitulacao.TabIndex = 11;
            // 
            // lblTitulacao
            // 
            this.lblTitulacao.AutoSize = true;
            this.lblTitulacao.Location = new System.Drawing.Point(184, 265);
            this.lblTitulacao.Name = "lblTitulacao";
            this.lblTitulacao.Size = new System.Drawing.Size(51, 13);
            this.lblTitulacao.TabIndex = 10;
            this.lblTitulacao.Text = "Titulação";
            // 
            // mkAno
            // 
            this.mkAno.Location = new System.Drawing.Point(36, 281);
            this.mkAno.Mask = "00/00/0000";
            this.mkAno.Name = "mkAno";
            this.mkAno.Size = new System.Drawing.Size(100, 20);
            this.mkAno.TabIndex = 12;
            this.mkAno.ValidatingType = typeof(System.DateTime);
            // 
            // FrmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mkAno);
            this.Controls.Add(this.txtTitulacao);
            this.Controls.Add(this.lblTitulacao);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxTipoMedico);
            this.Controls.Add(this.txtCRM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastrar";
            this.Text = "FrmCadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtTitulacao;
        private System.Windows.Forms.Label lblTitulacao;
        private System.Windows.Forms.MaskedTextBox mkAno;
    }
}