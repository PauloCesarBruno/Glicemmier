namespace Apresentacao_Usuario
{
    partial class frmImpressaoParametros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImpressaoParametros));
            this.tbl_CorrecaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Bd_GlicemiaDataSet = new Apresentacao_Usuario.Bd_GlicemiaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_CorrecaoTableAdapter = new Apresentacao_Usuario.Bd_GlicemiaDataSetTableAdapters.tbl_CorrecaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CorrecaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bd_GlicemiaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_CorrecaoBindingSource
            // 
            this.tbl_CorrecaoBindingSource.DataMember = "tbl_Correcao";
            this.tbl_CorrecaoBindingSource.DataSource = this.Bd_GlicemiaDataSet;
            // 
            // Bd_GlicemiaDataSet
            // 
            this.Bd_GlicemiaDataSet.DataSetName = "Bd_GlicemiaDataSet";
            this.Bd_GlicemiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_CorrecaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Apresentacao_Usuario.rptParametros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(837, 514);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbl_CorrecaoTableAdapter
            // 
            this.tbl_CorrecaoTableAdapter.ClearBeforeFill = true;
            // 
            // frmImpressaoParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 514);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImpressaoParametros";
            this.Text = "Parâmetros Glicêmicos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmImpressaoParametros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CorrecaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bd_GlicemiaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_CorrecaoBindingSource;
        private Bd_GlicemiaDataSet Bd_GlicemiaDataSet;
        private Bd_GlicemiaDataSetTableAdapters.tbl_CorrecaoTableAdapter tbl_CorrecaoTableAdapter;
    }
}