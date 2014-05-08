namespace Presentacion
{
    partial class FormGrillaClientes
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
            this.dgcClientes = new DevExpress.XtraGrid.GridControl();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionCC = new Presentacion.GestionCC();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDNI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clienteTableAdapter = new Presentacion.GestionCCTableAdapters.ClienteTableAdapter();
            this.sbtnOK = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgcClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgcClientes
            // 
            this.dgcClientes.DataSource = this.clienteBindingSource;
            this.dgcClientes.Location = new System.Drawing.Point(12, 54);
            this.dgcClientes.MainView = this.gridView1;
            this.dgcClientes.Name = "dgcClientes";
            this.dgcClientes.Size = new System.Drawing.Size(518, 243);
            this.dgcClientes.TabIndex = 0;
            this.dgcClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.gestionCC;
            // 
            // gestionCC
            // 
            this.gestionCC.DataSetName = "GestionCC";
            this.gestionCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_cliente,
            this.colDireccion,
            this.colLocalidad,
            this.colTelefono,
            this.colComentario,
            this.colDNI,
            this.colNombre,
            this.colApellido,
            this.colImporte});
            this.gridView1.GridControl = this.dgcClientes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            // 
            // colId_cliente
            // 
            this.colId_cliente.FieldName = "Id_cliente";
            this.colId_cliente.Name = "colId_cliente";
            this.colId_cliente.OptionsColumn.ReadOnly = true;
            // 
            // colDireccion
            // 
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            // 
            // colLocalidad
            // 
            this.colLocalidad.FieldName = "Localidad";
            this.colLocalidad.Name = "colLocalidad";
            // 
            // colTelefono
            // 
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            // 
            // colComentario
            // 
            this.colComentario.FieldName = "Comentario";
            this.colComentario.Name = "colComentario";
            // 
            // colDNI
            // 
            this.colDNI.FieldName = "DNI";
            this.colDNI.Name = "colDNI";
            this.colDNI.OptionsColumn.AllowEdit = false;
            this.colDNI.OptionsColumn.AllowFocus = false;
            this.colDNI.OptionsColumn.ReadOnly = true;
            this.colDNI.Visible = true;
            this.colDNI.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.OptionsColumn.AllowFocus = false;
            this.colNombre.OptionsColumn.ReadOnly = true;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colApellido
            // 
            this.colApellido.FieldName = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.OptionsColumn.AllowEdit = false;
            this.colApellido.OptionsColumn.AllowFocus = false;
            this.colApellido.OptionsColumn.ReadOnly = true;
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 2;
            // 
            // colImporte
            // 
            this.colImporte.FieldName = "Importe";
            this.colImporte.Name = "colImporte";
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // sbtnOK
            // 
            this.sbtnOK.Image = global::Presentacion.Properties.Resources.ok;
            this.sbtnOK.Location = new System.Drawing.Point(475, 12);
            this.sbtnOK.Name = "sbtnOK";
            this.sbtnOK.Size = new System.Drawing.Size(55, 36);
            this.sbtnOK.TabIndex = 1;
            this.sbtnOK.Click += new System.EventHandler(this.sbtnOK_Click);
            // 
            // sbtnCancel
            // 
            this.sbtnCancel.Image = global::Presentacion.Properties.Resources.cancel;
            this.sbtnCancel.Location = new System.Drawing.Point(401, 12);
            this.sbtnCancel.Name = "sbtnCancel";
            this.sbtnCancel.Size = new System.Drawing.Size(55, 36);
            this.sbtnCancel.TabIndex = 2;
            // 
            // FormGrillaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 309);
            this.Controls.Add(this.sbtnCancel);
            this.Controls.Add(this.sbtnOK);
            this.Controls.Add(this.dgcClientes);
            this.Name = "FormGrillaClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormGrillaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgcClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private GestionCC gestionCC;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private GestionCCTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId_cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalidad;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colComentario;
        private DevExpress.XtraGrid.Columns.GridColumn colDNI;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte;
        private DevExpress.XtraEditors.SimpleButton sbtnOK;
        private DevExpress.XtraEditors.SimpleButton sbtnCancel;
    }
}