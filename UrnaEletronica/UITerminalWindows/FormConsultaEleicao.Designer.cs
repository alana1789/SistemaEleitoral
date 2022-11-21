namespace UITerminalWindows
{
    partial class FormConsultaEleicão
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
            this.buttonExcluir1 = new System.Windows.Forms.Button();
            this.buttonInserir1 = new System.Windows.Forms.Button();
            this.buttonBuscar1 = new System.Windows.Forms.Button();
            this.textBoxBuscar1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceEleicao = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEleicao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Informe o ano da eleição";
            // 
            // buttonExcluir1
            // 
            this.buttonExcluir1.Location = new System.Drawing.Point(112, 537);
            this.buttonExcluir1.Name = "buttonExcluir1";
            this.buttonExcluir1.Size = new System.Drawing.Size(101, 43);
            this.buttonExcluir1.TabIndex = 9;
            this.buttonExcluir1.Text = "Excluir";
            this.buttonExcluir1.UseVisualStyleBackColor = true;
            this.buttonExcluir1.Click += new System.EventHandler(this.buttonExcluir1_Click);
            // 
            // buttonInserir1
            // 
            this.buttonInserir1.Location = new System.Drawing.Point(5, 537);
            this.buttonInserir1.Name = "buttonInserir1";
            this.buttonInserir1.Size = new System.Drawing.Size(101, 43);
            this.buttonInserir1.TabIndex = 10;
            this.buttonInserir1.Text = "Inserir";
            this.buttonInserir1.UseVisualStyleBackColor = true;
            this.buttonInserir1.Click += new System.EventHandler(this.buttonInserir1_Click);
            // 
            // buttonBuscar1
            // 
            this.buttonBuscar1.Location = new System.Drawing.Point(753, 46);
            this.buttonBuscar1.Name = "buttonBuscar1";
            this.buttonBuscar1.Size = new System.Drawing.Size(96, 27);
            this.buttonBuscar1.TabIndex = 8;
            this.buttonBuscar1.Text = "Buscar";
            this.buttonBuscar1.UseVisualStyleBackColor = true;
            this.buttonBuscar1.Click += new System.EventHandler(this.buttonBuscar1_Click);
            // 
            // textBoxBuscar1
            // 
            this.textBoxBuscar1.Location = new System.Drawing.Point(12, 46);
            this.textBoxBuscar1.Name = "textBoxBuscar1";
            this.textBoxBuscar1.Size = new System.Drawing.Size(718, 27);
            this.textBoxBuscar1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceEleicao;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(851, 390);
            this.dataGridView1.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            this.turnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.turnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "Ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            this.anoDataGridViewTextBoxColumn.ReadOnly = true;
            this.anoDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSourceEleicao
            // 
            this.bindingSourceEleicao.DataSource = typeof(Models.Eleicao);
            // 
            // FormConsultaEleicão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExcluir1);
            this.Controls.Add(this.buttonInserir1);
            this.Controls.Add(this.buttonBuscar1);
            this.Controls.Add(this.textBoxBuscar1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormConsultaEleicão";
            this.Text = "Consulta Eleicão";
            this.Load += new System.EventHandler(this.FormConsultaEleicão_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEleicao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonExcluir1;
        private Button buttonInserir1;
        private Button buttonBuscar1;
        private TextBox textBoxBuscar1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private BindingSource bindingSourceEleicao;
    }
}