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
            this.components = new System.ComponentModel.Container();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.bindingSourceCandidato = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textboxNome1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancelar1 = new System.Windows.Forms.Button();
            this.buttonSalvar1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCandidato)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(899, 50);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Cadastro de candidato";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTitulo.UseMnemonic = false;
            // 
            // textBoxNumero1
            // 
            this.textBoxNumero1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCandidato, "Numero", true));
            this.textBoxNumero1.Location = new System.Drawing.Point(455, 202);
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(271, 27);
            this.textBoxNumero1.TabIndex = 5;
            // 
            // bindingSourceCandidato
            // 
            this.bindingSourceCandidato.DataSource = typeof(Models.Candidato);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(455, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número";
            // 
            // textboxNome1
            // 
            this.textboxNome1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCandidato, "Nome_candidato", true));
            this.textboxNome1.Location = new System.Drawing.Point(133, 202);
            this.textboxNome1.Name = "textboxNome1";
            this.textboxNome1.Size = new System.Drawing.Size(290, 27);
            this.textboxNome1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(133, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
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
            // FormCadastroCandidato
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
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormCadastroCandidato";
            this.Load += new System.EventHandler(this.CadastroCandidato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCandidato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitulo;
        private TextBox textBoxNumero1;
        private Label label3;
        private TextBox textboxNome1;
        private Label label2;
        private Button buttonCancelar1;
        private Button buttonSalvar1;
        private BindingSource bindingSourceCandidato;
    }
}