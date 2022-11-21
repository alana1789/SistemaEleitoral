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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSourceEleicao = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSalvar3 = new System.Windows.Forms.Button();
            this.buttonCancelar3 = new System.Windows.Forms.Button();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.textBoxTurno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEleicao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(907, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Eleição";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ano";
            // 
            // bindingSourceEleicao
            // 
            this.bindingSourceEleicao.DataSource = typeof(Models.Eleicao);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Turno";
            // 
            // buttonSalvar3
            // 
            this.buttonSalvar3.Location = new System.Drawing.Point(654, 547);
            this.buttonSalvar3.Name = "buttonSalvar3";
            this.buttonSalvar3.Size = new System.Drawing.Size(108, 35);
            this.buttonSalvar3.TabIndex = 5;
            this.buttonSalvar3.Text = "Salvar";
            this.buttonSalvar3.UseVisualStyleBackColor = true;
            this.buttonSalvar3.Click += new System.EventHandler(this.buttonSalvar3_Click);
            // 
            // buttonCancelar3
            // 
            this.buttonCancelar3.Location = new System.Drawing.Point(768, 547);
            this.buttonCancelar3.Name = "buttonCancelar3";
            this.buttonCancelar3.Size = new System.Drawing.Size(108, 35);
            this.buttonCancelar3.TabIndex = 5;
            this.buttonCancelar3.Text = "Cancelar";
            this.buttonCancelar3.UseVisualStyleBackColor = true;
            this.buttonCancelar3.Click += new System.EventHandler(this.buttonCancelar3_Click);
            // 
            // textBoxAno
            // 
            this.textBoxAno.Location = new System.Drawing.Point(12, 193);
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(174, 27);
            this.textBoxAno.TabIndex = 6;
            // 
            // textBoxTurno
            // 
            this.textBoxTurno.Location = new System.Drawing.Point(12, 330);
            this.textBoxTurno.Name = "textBoxTurno";
            this.textBoxTurno.Size = new System.Drawing.Size(174, 27);
            this.textBoxTurno.TabIndex = 6;
            // 
            // FormCadastroEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 594);
            this.Controls.Add(this.textBoxTurno);
            this.Controls.Add(this.textBoxAno);
            this.Controls.Add(this.buttonCancelar3);
            this.Controls.Add(this.buttonSalvar3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroEleicao";
            this.Text = "CadastroEleicao";
            this.Load += new System.EventHandler(this.FormCadastroEleicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEleicao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private BindingSource bindingSourceEleicao;
        private Button buttonSalvar3;
        private Button buttonCancelar3;
        private TextBox textBoxAno;
        private TextBox textBoxTurno;
    }
}