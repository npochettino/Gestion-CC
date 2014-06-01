namespace Presentacion
{
    partial class FormVentasCliente
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvVentas = new DevExpress.XtraGrid.GridControl();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionCC = new Presentacion.GestionCC();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcionFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiNuevaVenta = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiModificarVenta = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiCancelarVenta = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiEmitirInforme = new DevExpress.XtraNavBar.NavBarItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LblNombreCLiente = new DevExpress.XtraEditors.LabelControl();
            this.lblCliente = new DevExpress.XtraEditors.LabelControl();
            this.ventaTableAdapter = new Presentacion.GestionCCTableAdapters.VentaTableAdapter();
            this.nbiDetalle = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "Ayuda";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(572, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 373);
            this.barDockControlBottom.Size = new System.Drawing.Size(572, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 351);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(572, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 351);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvVentas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.navBarControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 351);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dgvVentas
            // 
            this.dgvVentas.DataSource = this.ventaBindingSource;
            this.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentas.Location = new System.Drawing.Point(197, 33);
            this.dgvVentas.MainView = this.gridView1;
            this.dgvVentas.MenuManager = this.barManager1;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(372, 315);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "Venta";
            this.ventaBindingSource.DataSource = this.gestionCC;
            // 
            // gestionCC
            // 
            this.gestionCC.DataSetName = "GestionCC";
            this.gestionCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcionFormaPago,
            this.colImporte,
            this.colFechaVenta,
            this.colHora,
            this.Total});
            this.gridView1.GridControl = this.dgvVentas;
            this.gridView1.GroupCount = 2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFechaVenta, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colHora, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // coldescripcionFormaPago
            // 
            this.coldescripcionFormaPago.Caption = "Forma Pago";
            this.coldescripcionFormaPago.FieldName = "descripcionFormaPago";
            this.coldescripcionFormaPago.Name = "coldescripcionFormaPago";
            this.coldescripcionFormaPago.OptionsColumn.AllowEdit = false;
            this.coldescripcionFormaPago.OptionsColumn.AllowFocus = false;
            this.coldescripcionFormaPago.OptionsColumn.ReadOnly = true;
            this.coldescripcionFormaPago.Visible = true;
            this.coldescripcionFormaPago.VisibleIndex = 0;
            // 
            // colImporte
            // 
            this.colImporte.FieldName = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.OptionsColumn.AllowEdit = false;
            this.colImporte.OptionsColumn.AllowFocus = false;
            this.colImporte.OptionsColumn.ReadOnly = true;
            this.colImporte.Visible = true;
            this.colImporte.VisibleIndex = 1;
            // 
            // colFechaVenta
            // 
            this.colFechaVenta.FieldName = "FechaVenta";
            this.colFechaVenta.Name = "colFechaVenta";
            this.colFechaVenta.OptionsColumn.AllowEdit = false;
            this.colFechaVenta.OptionsColumn.AllowFocus = false;
            this.colFechaVenta.OptionsColumn.ReadOnly = true;
            this.colFechaVenta.Visible = true;
            this.colFechaVenta.VisibleIndex = 2;
            // 
            // colHora
            // 
            this.colHora.FieldName = "Hora";
            this.colHora.Name = "colHora";
            this.colHora.OptionsColumn.AllowEdit = false;
            this.colHora.OptionsColumn.AllowFocus = false;
            this.colHora.Visible = true;
            this.colHora.VisibleIndex = 2;
            // 
            // Total
            // 
            this.Total.Caption = "Total";
            this.Total.FieldName = "ImporteTotal";
            this.Total.Name = "Total";
            this.Total.OptionsColumn.AllowEdit = false;
            this.Total.OptionsColumn.AllowFocus = false;
            this.Total.OptionsColumn.ReadOnly = true;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiModificarVenta,
            this.nbiNuevaVenta,
            this.nbiCancelarVenta,
            this.nbiEmitirInforme,
            this.nbiDetalle});
            this.navBarControl1.Location = new System.Drawing.Point(3, 33);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 188;
            this.navBarControl1.Size = new System.Drawing.Size(188, 315);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Opciones de Ventas";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiNuevaVenta),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiModificarVenta),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiCancelarVenta),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiEmitirInforme),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDetalle)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbiNuevaVenta
            // 
            this.nbiNuevaVenta.Caption = "Nueva Venta";
            this.nbiNuevaVenta.Name = "nbiNuevaVenta";
            this.nbiNuevaVenta.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiNuevaVenta_LinkClicked);
            // 
            // nbiModificarVenta
            // 
            this.nbiModificarVenta.Caption = "Modificar Venta";
            this.nbiModificarVenta.Name = "nbiModificarVenta";
            this.nbiModificarVenta.Visible = false;
            this.nbiModificarVenta.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiModificarVenta_LinkClicked);
            // 
            // nbiCancelarVenta
            // 
            this.nbiCancelarVenta.Caption = "Cancelar Venta";
            this.nbiCancelarVenta.Name = "nbiCancelarVenta";
            this.nbiCancelarVenta.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiCancelarVenta_LinkClicked);
            // 
            // nbiEmitirInforme
            // 
            this.nbiEmitirInforme.Caption = "Emitir Informe";
            this.nbiEmitirInforme.Name = "nbiEmitirInforme";
            this.nbiEmitirInforme.Visible = false;
            this.nbiEmitirInforme.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiEmitirInforme_LinkClicked);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.48936F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.51064F));
            this.tableLayoutPanel2.Controls.Add(this.LblNombreCLiente, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCliente, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(188, 24);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // LblNombreCLiente
            // 
            this.LblNombreCLiente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNombreCLiente.Location = new System.Drawing.Point(97, 5);
            this.LblNombreCLiente.Name = "LblNombreCLiente";
            this.LblNombreCLiente.Size = new System.Drawing.Size(70, 13);
            this.LblNombreCLiente.TabIndex = 9;
            this.LblNombreCLiente.Text = "NombreCliente";

            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.Location = new System.Drawing.Point(20, 5);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(37, 13);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente:";
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // nbiDetalle
            // 
            this.nbiDetalle.Caption = "Detalle Venta";
            this.nbiDetalle.Name = "nbiDetalle";
            this.nbiDetalle.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDetalle_LinkClicked);
            // 
            // FormVentasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 373);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormVentasCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVentasCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl dgvVentas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbiNuevaVenta;
        private DevExpress.XtraNavBar.NavBarItem nbiModificarVenta;
        private DevExpress.XtraNavBar.NavBarItem nbiCancelarVenta;
        private GestionCC gestionCC;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private GestionCCTableAdapters.VentaTableAdapter ventaTableAdapter;
        private DevExpress.XtraEditors.LabelControl LblNombreCLiente;
        private DevExpress.XtraEditors.LabelControl lblCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraNavBar.NavBarItem nbiEmitirInforme;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcionFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colHora;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraNavBar.NavBarItem nbiDetalle;
    }
}