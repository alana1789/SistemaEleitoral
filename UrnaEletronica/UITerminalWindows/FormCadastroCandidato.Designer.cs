namespace UITerminalWindows
{
    partial class FormCadastroCandidato
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
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxNome1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancelar1 = new System.Windows.Forms.Button();
            this.buttonSalvar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(899, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de candidato";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxNumero1
            // 
            this.textBoxNumero1.Location = new System.Drawing.Point(334, 199);
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(271, 27);
            this.textBoxNumero1.TabIndex = 5;
            this.textBoxNumero1.TextChanged += new System.EventHandler(this.textBoxTitulo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(334, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textboxNome1
            // 
            this.textboxNome1.Location = new System.Drawing.Point(12, 199);
            this.textboxNome1.Name = "textboxNome1";
            this.textboxNome1.Size = new System.Drawing.Size(290, 27);
            this.textboxNome1.TabIndex = 6;
            this.textboxNome1.TextChanged += new System.EventHandler(this.textboxNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonCancelar1
            // 
            this.buttonCancelar1.Location = new System.Drawing.Point(779, 509);
            this.buttonCancelar1.Name = "buttonCancelar1";
            this.buttonCancelar1.Size = new System.Drawing.Size(108, 34);
            this.buttonCancelar1.TabIndex = 7;
            this.buttonCancelar1.Text = "Cancelar";
            this.buttonCancelar1.UseVisualStyleBackColor = true;
            this.buttonCancelar1.Click += new System.EventHandler(this.buttonCancelar1_Click);
            // 
            // buttonSalvar1
            // 
            this.buttonSalvar1.Location = new System.Drawing.Point(664, 509);
            this.buttonSalvar1.Name = "buttonSalvar1";
            this.buttonSalvar1.Size = new System.Drawing.Size(108, 34);
            this.buttonSalvar1.TabIndex = 8;
            this.buttonSalvar1.Text = "Salvar";
            this.buttonSalvar1.UseVisualStyleBackColor = true;
            this.buttonSalvar1.Click += new System.EventHandler(this.buttonSalvar1_Click);
            // 
            // CadastroCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 555);
            this.Controls.Add(this.buttonCancelar1);
            this.Controls.Add(this.buttonSalvar1);
            this.Controls.Add(this.textBoxNumero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxNome1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroCandidato";
            this.Load += new System.EventHandler(this.CadastroCandidato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxNumero1;
        private Label label3;
        private TextBox textboxNome1;
        private Label label2;
        private Button buttonCancelar1;
        private Button buttonSalvar1;
    }
}