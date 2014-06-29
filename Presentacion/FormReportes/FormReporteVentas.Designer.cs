namespace Presentacion
{
    partial class FormReporteVentas
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
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnEmitir = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.chkEfectivo = new System.Windows.Forms.CheckBox();
            this.chkCtaCte = new System.Windows.Forms.CheckBox();
            this.chkCheque = new System.Windows.Forms.CheckBox();
            this.chkTarjeta = new System.Windows.Forms.CheckBox();
            this.formaPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionCC = new Presentacion.GestionCC();
            this.formaPagoTableAdapter = new Presentacion.GestionCCTableAdapters.FormaPagoTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(3, 105);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(861, 479);
            this.crystalReportViewer2.TabIndex = 0;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer2.Load += new System.EventHandler(this.crystalReportViewer2_Load);
            // 
            // btnEmitir
            // 
            this.btnEmitir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEmitir.Location = new System.Drawing.Point(697, 46);
            this.btnEmitir.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.btnEmitir.Name = "btnEmitir";
            this.btnEmitir.Size = new System.Drawing.Size(114, 32);
            this.btnEmitir.TabIndex = 1;
            this.btnEmitir.Text = "Emitir";
            this.btnEmitir.Click += new System.EventHandler(this.btnEmitirReporte_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.crystalReportViewer2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(867, 587);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.994193F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.7921F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.626016F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9291521F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.86876F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9291521F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.74448F));
            this.tableLayoutPanel2.Controls.Add(this.btnEmitir, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.82707F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.17294F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(861, 96);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.0757F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.9243F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dtpDesde, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(46, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(288, 23);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha Desde";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(92, 3);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(193, 20);
            this.dtpDesde.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.51711F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.48289F));
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dtpHasta, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(402, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(277, 23);
            this.tableLayoutPanel5.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Hasta";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(81, 3);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(193, 20);
            this.dtpHasta.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.16049F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.64198F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.88889F));
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.chkEfectivo, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.chkCtaCte, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.chkCheque, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.chkTarjeta, 2, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(46, 32);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(324, 61);
            this.tableLayoutPanel6.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Forma Pago";
            // 
            // chkEfectivo
            // 
            this.chkEfectivo.AutoSize = true;
            this.chkEfectivo.Checked = true;
            this.chkEfectivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEfectivo.Location = new System.Drawing.Point(91, 3);
            this.chkEfectivo.Name = "chkEfectivo";
            this.chkEfectivo.Size = new System.Drawing.Size(65, 17);
            this.chkEfectivo.TabIndex = 15;
            this.chkEfectivo.Text = "Efectivo";
            this.chkEfectivo.UseVisualStyleBackColor = true;
            // 
            // chkCtaCte
            // 
            this.chkCtaCte.AutoSize = true;
            this.chkCtaCte.Checked = true;
            this.chkCtaCte.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCtaCte.Location = new System.Drawing.Point(91, 33);
            this.chkCtaCte.Name = "chkCtaCte";
            this.chkCtaCte.Size = new System.Drawing.Size(103, 17);
            this.chkCtaCte.TabIndex = 16;
            this.chkCtaCte.Text = "Cuenta Corriente";
            this.chkCtaCte.UseVisualStyleBackColor = true;
            // 
            // chkCheque
            // 
            this.chkCheque.AutoSize = true;
            this.chkCheque.Checked = true;
            this.chkCheque.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCheque.Location = new System.Drawing.Point(200, 3);
            this.chkCheque.Name = "chkCheque";
            this.chkCheque.Size = new System.Drawing.Size(63, 17);
            this.chkCheque.TabIndex = 18;
            this.chkCheque.Text = "Cheque";
            this.chkCheque.UseVisualStyleBackColor = true;
            // 
            // chkTarjeta
            // 
            this.chkTarjeta.AutoSize = true;
            this.chkTarjeta.Checked = true;
            this.chkTarjeta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTarjeta.Location = new System.Drawing.Point(200, 33);
            this.chkTarjeta.Name = "chkTarjeta";
            this.chkTarjeta.Size = new System.Drawing.Size(59, 17);
            this.chkTarjeta.TabIndex = 17;
            this.chkTarjeta.Text = "Tarjeta";
            this.chkTarjeta.UseVisualStyleBackColor = true;
            // 
            // formaPagoBindingSource
            // 
            this.formaPagoBindingSource.DataMember = "FormaPago";
            this.formaPagoBindingSource.DataSource = this.gestionCC;
            // 
            // gestionCC
            // 
            this.gestionCC.DataSetName = "GestionCC";
            this.gestionCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formaPagoTableAdapter
            // 
            this.formaPagoTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 587);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormReporteVentas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReporteVentas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private DevExpress.XtraEditors.SimpleButton btnEmitir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private GestionCC gestionCC;
        private System.Windows.Forms.BindingSource formaPagoBindingSource;
        private GestionCCTableAdapters.FormaPagoTableAdapter formaPagoTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkEfectivo;
        private System.Windows.Forms.CheckBox chkCtaCte;
        private System.Windows.Forms.CheckBox chkTarjeta;
        private System.Windows.Forms.CheckBox chkCheque;
    }
}