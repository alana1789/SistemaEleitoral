namespace UITerminalWindows
{
    partial class FormCadastroEleicao
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
            this.buttonCancelar2 = new System.Windows.Forms.Button();
            this.buttonSalvar2 = new System.Windows.Forms.Button();
            this.textBoxTurno2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxAno2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelar2
            // 
            this.buttonCancelar2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCancelar2.Location = new System.Drawing.Point(699, 477);
            this.buttonCancelar2.Name = "buttonCancelar2";
            this.buttonCancelar2.Size = new System.Drawing.Size(108, 34);
            this.buttonCancelar2.TabIndex = 11;
            this.buttonCancelar2.Text = "Cancelar";
            this.buttonCancelar2.UseVisualStyleBackColor = false;
            this.buttonCancelar2.Click += new System.EventHandler(this.buttonCancelar2_Click);
            // 
            // buttonSalvar2
            // 
            this.buttonSalvar2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSalvar2.ForeColor = System.Drawing.Color.Black;
            this.buttonSalvar2.Location = new System.Drawing.Point(584, 477);
            this.buttonSalvar2.Name = "buttonSalvar2";
            this.buttonSalvar2.Size = new System.Drawing.Size(108, 34);
            this.buttonSalvar2.TabIndex = 12;
            this.buttonSalvar2.Text = "Salvar";
            this.buttonSalvar2.UseVisualStyleBackColor = false;
            this.buttonSalvar2.Click += new System.EventHandler(this.buttonSalvar2_Click);
            // 
            // textBoxTurno2
            // 
            this.textBoxTurno2.Location = new System.Drawing.Point(341, 137);
            this.textBoxTurno2.Name = "textBoxTurno2";
            this.textBoxTurno2.Size = new System.Drawing.Size(271, 27);
            this.textBoxTurno2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(341, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Turno";
            // 
            // textboxAno2
            // 
            this.textboxAno2.Location = new System.Drawing.Point(19, 137);
            this.textboxAno2.Name = "textboxAno2";
            this.textboxAno2.Size = new System.Drawing.Size(290, 27);
            this.textboxAno2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ano";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(818, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "CADASTRO DE ELEIÇÃO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormCadastroEleição
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 540);
            this.Controls.Add(this.buttonCancelar2);
            this.Controls.Add(this.buttonSalvar2);
            this.Controls.Add(this.textBoxTurno2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxAno2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroEleição";
            this.Text = "FormCadastroEleição";
            this.Load += new System.EventHandler(this.FormCadastroEleição_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCancelar2;
        private Button buttonSalvar2;
        private TextBox textBoxTurno2;
        private Label label3;
        private TextBox textboxAno2;
        private Label label2;
        private Label label1;
    }
}