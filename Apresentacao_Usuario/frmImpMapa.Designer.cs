namespace Apresentacao_Usuario
{
    partial class frmImpMapa
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImpMapa));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Bd_GlicemiaDataSet = new Apresentacao_Usuario.Bd_GlicemiaDataSet();
            this.tbl_PacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PacienteTableAdapter = new Apresentacao_Usuario.Bd_GlicemiaDataSetTableAdapters.tbl_PacienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Bd_GlicemiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_PacienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_PacienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.rptMapa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(823, 507);
            this.reportViewer1.TabIndex = 0;
            // 
            // Bd_GlicemiaDataSet
            // 
            this.Bd_GlicemiaDataSet.DataSetName = "Bd_GlicemiaDataSet";
            this.Bd_GlicemiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PacienteBindingSource
            // 
            this.tbl_PacienteBindingSource.DataMember = "tbl_Paciente";
            this.tbl_PacienteBindingSource.DataSource = this.Bd_GlicemiaDataSet;
            // 
            // tbl_PacienteTableAdapter
            // 
            this.tbl_PacienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmImpMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 507);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImpMapa";
            this.Text = "Relatorio de Mapa Glicêmico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmImpMapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bd_GlicemiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_PacienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_PacienteBindingSource;
        private Bd_GlicemiaDataSet Bd_GlicemiaDataSet;
        private Bd_GlicemiaDataSetTableAdapters.tbl_PacienteTableAdapter tbl_PacienteTableAdapter;
    }
}