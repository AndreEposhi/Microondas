namespace Microondas.Views
{
    partial class frmPrograma
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
            this.lblNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxTempo = new System.Windows.Forms.TextBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.textBoxPot = new System.Windows.Forms.TextBox();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.textBoxCarAquec = new System.Windows.Forms.TextBox();
            this.lblCaracAquec = new System.Windows.Forms.Label();
            this.textBoxInstr = new System.Windows.Forms.TextBox();
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 29);
            this.textBoxNome.MaxLength = 20;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(236, 22);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxTempo
            // 
            this.textBoxTempo.Location = new System.Drawing.Point(12, 82);
            this.textBoxTempo.MaxLength = 3;
            this.textBoxTempo.Name = "textBoxTempo";
            this.textBoxTempo.Size = new System.Drawing.Size(236, 22);
            this.textBoxTempo.TabIndex = 3;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(9, 62);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(132, 17);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "Tempo (segundos):";
            // 
            // textBoxPot
            // 
            this.textBoxPot.Location = new System.Drawing.Point(12, 132);
            this.textBoxPot.MaxLength = 2;
            this.textBoxPot.Name = "textBoxPot";
            this.textBoxPot.Size = new System.Drawing.Size(236, 22);
            this.textBoxPot.TabIndex = 5;
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Location = new System.Drawing.Point(9, 112);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(121, 17);
            this.lblPotencia.TabIndex = 4;
            this.lblPotencia.Text = "Potência (1 à 10):";
            // 
            // textBoxCarAquec
            // 
            this.textBoxCarAquec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCarAquec.Location = new System.Drawing.Point(12, 181);
            this.textBoxCarAquec.MaxLength = 1;
            this.textBoxCarAquec.Name = "textBoxCarAquec";
            this.textBoxCarAquec.Size = new System.Drawing.Size(236, 22);
            this.textBoxCarAquec.TabIndex = 7;
            // 
            // lblCaracAquec
            // 
            this.lblCaracAquec.AutoSize = true;
            this.lblCaracAquec.Location = new System.Drawing.Point(9, 161);
            this.lblCaracAquec.Name = "lblCaracAquec";
            this.lblCaracAquec.Size = new System.Drawing.Size(229, 17);
            this.lblCaracAquec.TabIndex = 6;
            this.lblCaracAquec.Text = "Caractere de Aquecimento (letras):";
            // 
            // textBoxInstr
            // 
            this.textBoxInstr.Location = new System.Drawing.Point(12, 226);
            this.textBoxInstr.MaxLength = 100;
            this.textBoxInstr.Multiline = true;
            this.textBoxInstr.Name = "textBoxInstr";
            this.textBoxInstr.Size = new System.Drawing.Size(236, 71);
            this.textBoxInstr.TabIndex = 9;
            // 
            // lblInstrucao
            // 
            this.lblInstrucao.AutoSize = true;
            this.lblInstrucao.Location = new System.Drawing.Point(12, 206);
            this.lblInstrucao.Name = "lblInstrucao";
            this.lblInstrucao.Size = new System.Drawing.Size(70, 17);
            this.lblInstrucao.TabIndex = 8;
            this.lblInstrucao.Text = "Instrução:";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(173, 303);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 31);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // frmPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 346);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxInstr);
            this.Controls.Add(this.lblInstrucao);
            this.Controls.Add(this.textBoxCarAquec);
            this.Controls.Add(this.lblCaracAquec);
            this.Controls.Add(this.textBoxPot);
            this.Controls.Add(this.lblPotencia);
            this.Controls.Add(this.textBoxTempo);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxTempo;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.TextBox textBoxPot;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.TextBox textBoxCarAquec;
        private System.Windows.Forms.Label lblCaracAquec;
        private System.Windows.Forms.TextBox textBoxInstr;
        private System.Windows.Forms.Label lblInstrucao;
        private System.Windows.Forms.Button buttonSalvar;
    }
}