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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bindingSourceEleicao = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceEleicao, "Ano", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 182);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(361, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // bindingSourceEleicao
            // 
            this.bindingSourceEleicao.DataSource = typeof(Models.Eleicao);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSourceEleicao, "Turno", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceEleicao, "Turno", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 299);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 28);
            this.comboBox1.TabIndex = 4;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(768, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormCadastroEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 594);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroEleicao";
            this.Text = "CadastroEleicao";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEleicao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label3;
        private BindingSource bindingSourceEleicao;
        private Button button1;
        private Button button2;
    }
}