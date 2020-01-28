namespace Microondas.Views
{
    partial class frmPesqPrograma
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
            this.groupBoxPesq = new System.Windows.Forms.GroupBox();
            this.dataGridViewProg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxPesq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPesq
            // 
            this.groupBoxPesq.Controls.Add(this.dataGridViewProg);
            this.groupBoxPesq.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPesq.Name = "groupBoxPesq";
            this.groupBoxPesq.Size = new System.Drawing.Size(588, 315);
            this.groupBoxPesq.TabIndex = 0;
            this.groupBoxPesq.TabStop = false;
            this.groupBoxPesq.Text = "Programas:";
            // 
            // dataGridViewProg
            // 
            this.dataGridViewProg.AllowUserToAddRows = false;
            this.dataGridViewProg.AllowUserToDeleteRows = false;
            this.dataGridViewProg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewProg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProg.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewProg.Name = "dataGridViewProg";
            this.dataGridViewProg.ReadOnly = true;
            this.dataGridViewProg.RowHeadersWidth = 51;
            this.dataGridViewProg.RowTemplate.Height = 24;
            this.dataGridViewProg.Size = new System.Drawing.Size(582, 294);
            this.dataGridViewProg.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tempo";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Potência";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Aquecimento";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Instrução";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // frmPesqPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 332);
            this.Controls.Add(this.groupBoxPesq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesqPrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programas";
            this.groupBoxPesq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPesq;
        private System.Windows.Forms.DataGridView dataGridViewProg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}