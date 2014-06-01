namespace Presentacion
{
    partial class FormABMarca
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
            this.btnAgregarTipoArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificarTipoArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminarTipoArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.dtMarca = new DevExpress.XtraGrid.GridControl();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionCC = new Presentacion.GestionCC();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId_TipoArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tipoArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoArticuloTableAdapter = new Presentacion.GestionCCTableAdapters.TipoArticuloTableAdapter();
            this.grbDatosTiposArticulos = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescripcionTipoArticulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuardarTipoArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.txtTipoArticulo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.marcaTableAdapter = new Presentacion.GestionCCTableAdapters.MarcaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoArticuloBindingSource)).BeginInit();
            this.grbDatosTiposArticulos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarTipoArticulo
            // 
            this.btnAgregarTipoArticulo.Location = new System.Drawing.Point(100, 55);
            this.btnAgregarTipoArticulo.Name = "btnAgregarTipoArticulo";
            this.btnAgregarTipoArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTipoArticulo.TabIndex = 0;
            this.btnAgregarTipoArticulo.Text = "Agregar";
            this.btnAgregarTipoArticulo.Click += new System.EventHandler(this.btnAgregarTipoArticulo_Click);
            // 
            // btnModificarTipoArticulo
            // 
            this.btnModificarTipoArticulo.Location = new System.Drawing.Point(100, 97);
            this.btnModificarTipoArticulo.Name = "btnModificarTipoArticulo";
            this.btnModificarTipoArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnModificarTipoArticulo.TabIndex = 1;
            this.btnModificarTipoArticulo.Text = "Modificar";
            this.btnModificarTipoArticulo.Click += new System.EventHandler(this.btnModificarTipoArticulo_Click);
            // 
            // btnEliminarTipoArticulo
            // 
            this.btnEliminarTipoArticulo.Location = new System.Drawing.Point(100, 140);
            this.btnEliminarTipoArticulo.Name = "btnEliminarTipoArticulo";
            this.btnEliminarTipoArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTipoArticulo.TabIndex = 2;
            this.btnEliminarTipoArticulo.Text = "Eliminar";
            this.btnEliminarTipoArticulo.Click += new System.EventHandler(this.btnEliminarTipoArticulo_Click);
            // 
            // dtMarca
            // 
            this.dtMarca.DataSource = this.marcaBindingSource;
            this.dtMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtMarca.Location = new System.Drawing.Point(294, 3);
            this.dtMarca.MainView = this.gridView1;
            this.dtMarca.Name = "dtMarca";
            this.dtMarca.Size = new System.Drawing.Size(329, 469);
            this.dtMarca.TabIndex = 3;
            this.dtMarca.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dtMarca.Click += new System.EventHandler(this.dtTipoArticulo_Click);
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.gestionCC;
            // 
            // gestionCC
            // 
            this.gestionCC.DataSetName = "GestionCC";
            this.gestionCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_TipoArticulo,
            this.colDescripcion});
            this.gridView1.GridControl = this.dtMarca;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colId_TipoArticulo
            // 
            this.colId_TipoArticulo.FieldName = "Id_TipoArticulo";
            this.colId_TipoArticulo.Name = "colId_TipoArticulo";
            this.colId_TipoArticulo.OptionsColumn.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AppearanceCell.Options.UseTextOptions = true;
            this.colDescripcion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescripcion.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDescripcion.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescripcion.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.AllowFocus = false;
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            // 
            // tipoArticuloBindingSource
            // 
            this.tipoArticuloBindingSource.DataMember = "TipoArticulo";
            this.tipoArticuloBindingSource.DataSource = this.gestionCC;
            // 
            // tipoArticuloTableAdapter
            // 
            this.tipoArticuloTableAdapter.ClearBeforeFill = true;
            // 
            // grbDatosTiposArticulos
            // 
            this.grbDatosTiposArticulos.Controls.Add(this.tableLayoutPanel2);
            this.grbDatosTiposArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDatosTiposArticulos.Location = new System.Drawing.Point(0, 0);
            this.grbDatosTiposArticulos.Name = "grbDatosTiposArticulos";
            this.grbDatosTiposArticulos.Size = new System.Drawing.Size(285, 242);
            this.grbDatosTiposArticulos.TabIndex = 4;
            this.grbDatosTiposArticulos.TabStop = false;
            this.grbDatosTiposArticulos.Text = "Gestión de datos";
            this.grbDatosTiposArticulos.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblDescripcionTipoArticulo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTipoArticulo, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.63285F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.36715F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(279, 154);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lblDescripcionTipoArticulo
            // 
            this.lblDescripcionTipoArticulo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescripcionTipoArticulo.AutoSize = true;
            this.lblDescripcionTipoArticulo.Location = new System.Drawing.Point(9, 45);
            this.lblDescripcionTipoArticulo.Name = "lblDescripcionTipoArticulo";
            this.lblDescripcionTipoArticulo.Size = new System.Drawing.Size(65, 13);
            this.lblDescripcionTipoArticulo.TabIndex = 1;
            this.lblDescripcionTipoArticulo.Text = "Descripción:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnGuardarTipoArticulo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(80, 107);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(196, 44);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnGuardarTipoArticulo
            // 
            this.btnGuardarTipoArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarTipoArticulo.Location = new System.Drawing.Point(9, 10);
            this.btnGuardarTipoArticulo.Name = "btnGuardarTipoArticulo";
            this.btnGuardarTipoArticulo.Size = new System.Drawing.Size(80, 23);
            this.btnGuardarTipoArticulo.TabIndex = 2;
            this.btnGuardarTipoArticulo.Text = "Guardar";
            this.btnGuardarTipoArticulo.Click += new System.EventHandler(this.btnGuardarTipoArticulo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(107, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTipoArticulo
            // 
            this.txtTipoArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTipoArticulo.Location = new System.Drawing.Point(107, 41);
            this.txtTipoArticulo.Name = "txtTipoArticulo";
            this.txtTipoArticulo.Size = new System.Drawing.Size(141, 21);
            this.txtTipoArticulo.TabIndex = 0;
            this.txtTipoArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoArticulo_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 291F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dtMarca, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 475);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbDatosTiposArticulos);
            this.panel1.Controls.Add(this.btnModificarTipoArticulo);
            this.panel1.Controls.Add(this.btnEliminarTipoArticulo);
            this.panel1.Controls.Add(this.btnAgregarTipoArticulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 242);
            this.panel1.TabIndex = 4;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // FormABMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 475);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormABMarca";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Marcas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormABMTipoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoArticuloBindingSource)).EndInit();
            this.grbDatosTiposArticulos.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAgregarTipoArticulo;
        private DevExpress.XtraEditors.SimpleButton btnModificarTipoArticulo;
        private DevExpress.XtraEditors.SimpleButton btnEliminarTipoArticulo;
        private DevExpress.XtraGrid.GridControl dtMarca;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private GestionCC gestionCC;
        private System.Windows.Forms.BindingSource tipoArticuloBindingSource;
        private GestionCCTableAdapters.TipoArticuloTableAdapter tipoArticuloTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId_TipoArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private System.Windows.Forms.GroupBox grbDatosTiposArticulos;
        private System.Windows.Forms.Label lblDescripcionTipoArticulo;
        private System.Windows.Forms.TextBox txtTipoArticulo;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardarTipoArticulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private GestionCCTableAdapters.MarcaTableAdapter marcaTableAdapter;
    }
}