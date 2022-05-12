
namespace Joc
{
    partial class FormClasament
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
            this.ScorMaxim = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.cartiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new Joc.BibliotecaDataSet();
            this.aLouryehDataSet = new Joc.aLouryehDataSet();
            this.aLouryehDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eleviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartiTableAdapter = new Joc.BibliotecaDataSetTableAdapters.CartiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jucatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clasamentDataSet = new Joc.ClasamentDataSet();
            this.jucatorTableAdapter = new Joc.ClasamentDataSetTableAdapters.JucatorTableAdapter();
            this.listJucatori = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLouryehDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLouryehDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clasamentul jucătorilor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Scorul tău maxim:";
            // 
            // ScorMaxim
            // 
            this.ScorMaxim.AutoSize = true;
            this.ScorMaxim.BackColor = System.Drawing.Color.Transparent;
            this.ScorMaxim.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScorMaxim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ScorMaxim.Location = new System.Drawing.Point(332, 407);
            this.ScorMaxim.Name = "ScorMaxim";
            this.ScorMaxim.Size = new System.Drawing.Size(35, 34);
            this.ScorMaxim.TabIndex = 3;
            this.ScorMaxim.Text = "0";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // cartiBindingSource
            // 
            this.cartiBindingSource.DataMember = "Carti";
            this.cartiBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLouryehDataSet
            // 
            this.aLouryehDataSet.DataSetName = "aLouryehDataSet";
            this.aLouryehDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLouryehDataSetBindingSource
            // 
            this.aLouryehDataSetBindingSource.DataSource = this.aLouryehDataSet;
            this.aLouryehDataSetBindingSource.Position = 0;
            // 
            // eleviBindingSource
            // 
            this.eleviBindingSource.DataMember = "Elevi";
            this.eleviBindingSource.DataSource = this.aLouryehDataSetBindingSource;
            // 
            // cartiTableAdapter
            // 
            this.cartiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.scorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jucatorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 279);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeDataGridViewTextBoxColumn.Width = 125;
            // 
            // scorDataGridViewTextBoxColumn
            // 
            this.scorDataGridViewTextBoxColumn.DataPropertyName = "Scor";
            this.scorDataGridViewTextBoxColumn.HeaderText = "Scor";
            this.scorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scorDataGridViewTextBoxColumn.Name = "scorDataGridViewTextBoxColumn";
            this.scorDataGridViewTextBoxColumn.ReadOnly = true;
            this.scorDataGridViewTextBoxColumn.Width = 125;
            // 
            // jucatorBindingSource
            // 
            this.jucatorBindingSource.DataMember = "Jucator";
            this.jucatorBindingSource.DataSource = this.clasamentDataSet;
            // 
            // clasamentDataSet
            // 
            this.clasamentDataSet.DataSetName = "ClasamentDataSet";
            this.clasamentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jucatorTableAdapter
            // 
            this.jucatorTableAdapter.ClearBeforeFill = true;
            // 
            // listJucatori
            // 
            this.listJucatori.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listJucatori.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listJucatori.FormattingEnabled = true;
            this.listJucatori.ItemHeight = 25;
            this.listJucatori.Items.AddRange(new object[] {
            "Octavian 25",
            "Andrei 9",
            "Vasile 388"});
            this.listJucatori.Location = new System.Drawing.Point(12, 114);
            this.listJucatori.Name = "listJucatori";
            this.listJucatori.Size = new System.Drawing.Size(776, 279);
            this.listJucatori.TabIndex = 0;
            this.listJucatori.SelectedIndexChanged += new System.EventHandler(this.listJucatori_SelectedIndexChanged);
            // 
            // FormClasament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ScorMaxim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listJucatori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormClasament";
            this.Text = "Clasament";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClasament_FormClosing);
            this.Load += new System.EventHandler(this.FormClasament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLouryehDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLouryehDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ScorMaxim;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.BindingSource eleviBindingSource;
        private System.Windows.Forms.BindingSource aLouryehDataSetBindingSource;
        private aLouryehDataSet aLouryehDataSet;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource cartiBindingSource;
        private BibliotecaDataSetTableAdapters.CartiTableAdapter cartiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ClasamentDataSet clasamentDataSet;
        private System.Windows.Forms.BindingSource jucatorBindingSource;
        private ClasamentDataSetTableAdapters.JucatorTableAdapter jucatorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scorDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listJucatori;
    }
}