namespace Presentacion
{
    partial class FormPagosEfectuados
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPagosEfectuados = new DevExpress.XtraGrid.GridControl();
            this.pagoEfectuadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionCC = new Presentacion.GestionCC();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId_PagoCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEmitirCertificado = new DevExpress.XtraEditors.SimpleButton();
            this.pagoEfectuadoTableAdapter = new Presentacion.GestionCCTableAdapters.PagoEfectuadoTableAdapter();
            this.CMSPagos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosEfectuados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoEfectuadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.CMSPagos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvPagosEfectuados, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEmitirCertificado, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvPagosEfectuados
            // 
            this.dgvPagosEfectuados.DataSource = this.pagoEfectuadoBindingSource;
            this.dgvPagosEfectuados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPagosEfectuados.Location = new System.Drawing.Point(3, 3);
            this.dgvPagosEfectuados.MainView = this.gridView1;
            this.dgvPagosEfectuados.Name = "dgvPagosEfectuados";
            this.dgvPagosEfectuados.Size = new System.Drawing.Size(278, 205);
            this.dgvPagosEfectuados.TabIndex = 0;
            this.dgvPagosEfectuados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgvPagosEfectuados.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPagosEfectuados_MouseDown);
            // 
            // pagoEfectuadoBindingSource
            // 
            this.pagoEfectuadoBindingSource.DataMember = "PagoEfectuado";
            this.pagoEfectuadoBindingSource.DataSource = this.gestionCC;
            // 
            // gestionCC
            // 
            this.gestionCC.DataSetName = "GestionCC";
            this.gestionCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_PagoCliente,
            this.colId_cliente,
            this.colImporte,
            this.colFechaPago});
            this.gridView1.GridControl = this.dgvPagosEfectuados;
            this.gridView1.Name = "gridView1";
            // 
            // colId_PagoCliente
            // 
            this.colId_PagoCliente.FieldName = "Id_PagoCliente";
            this.colId_PagoCliente.Name = "colId_PagoCliente";
            this.colId_PagoCliente.OptionsColumn.ReadOnly = true;
            // 
            // colId_cliente
            // 
            this.colId_cliente.FieldName = "Id_cliente";
            this.colId_cliente.Name = "colId_cliente";
            // 
            // colImporte
            // 
            this.colImporte.FieldName = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.OptionsColumn.AllowEdit = false;
            this.colImporte.OptionsColumn.AllowFocus = false;
            this.colImporte.OptionsColumn.ReadOnly = true;
            this.colImporte.Visible = true;
            this.colImporte.VisibleIndex = 0;
            // 
            // colFechaPago
            // 
            this.colFechaPago.FieldName = "FechaPago";
            this.colFechaPago.Name = "colFechaPago";
            this.colFechaPago.OptionsColumn.AllowEdit = false;
            this.colFechaPago.OptionsColumn.AllowFocus = false;
            this.colFechaPago.OptionsColumn.ReadOnly = true;
            this.colFechaPago.Visible = true;
            this.colFechaPago.VisibleIndex = 1;
            // 
            // btnEmitirCertificado
            // 
            this.btnEmitirCertificado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmitirCertificado.Location = new System.Drawing.Point(83, 225);
            this.btnEmitirCertificado.Name = "btnEmitirCertificado";
            this.btnEmitirCertificado.Size = new System.Drawing.Size(118, 23);
            this.btnEmitirCertificado.TabIndex = 1;
            this.btnEmitirCertificado.Text = "Emitir Certificado";
            this.btnEmitirCertificado.Visible = false;
            this.btnEmitirCertificado.Click += new System.EventHandler(this.btnEmitirCertificado_Click);
            // 
            // pagoEfectuadoTableAdapter
            // 
            this.pagoEfectuadoTableAdapter.ClearBeforeFill = true;
            // 
            // CMSPagos
            // 
            this.CMSPagos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.CMSPagos.Name = "CMSPagos";
            this.CMSPagos.Size = new System.Drawing.Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // FormPagosEfectuados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormPagosEfectuados";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos efectuados por el cliente ";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosEfectuados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoEfectuadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.CMSPagos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl dgvPagosEfectuados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnEmitirCertificado;
        private System.Windows.Forms.BindingSource pagoEfectuadoBindingSource;
        private GestionCC gestionCC;
        private DevExpress.XtraGrid.Columns.GridColumn colId_PagoCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colId_cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaPago;
        private GestionCCTableAdapters.PagoEfectuadoTableAdapter pagoEfectuadoTableAdapter;
        private System.Windows.Forms.ContextMenuStrip CMSPagos;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}