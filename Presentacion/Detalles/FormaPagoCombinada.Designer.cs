namespace Presentacion
{
    partial class FormaPagoCombinada
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.txtEfectivo = new DevExpress.XtraEditors.TextEdit();
            this.lblEfectivo = new DevExpress.XtraEditors.LabelControl();
            this.lblCheque = new DevExpress.XtraEditors.LabelControl();
            this.lblCuentaCorriente = new DevExpress.XtraEditors.LabelControl();
            this.lblTarjeta = new DevExpress.XtraEditors.LabelControl();
            this.txtCheque = new DevExpress.XtraEditors.TextEdit();
            this.txtCuentaCorriente = new DevExpress.XtraEditors.TextEdit();
            this.txtTarjeta = new DevExpress.XtraEditors.TextEdit();
            this.lblMontoTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblMontoRestante = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEfectivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCheque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaCorriente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarjeta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.7324F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.33803F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.92958F));
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtEfectivo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEfectivo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCheque, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCuentaCorriente, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTarjeta, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCheque, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCuentaCorriente, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtTarjeta, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMontoTotal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMontoRestante, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66319F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 298);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(156, 260);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(266, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtEfectivo, 2);
            this.txtEfectivo.EditValue = "0";
            this.txtEfectivo.Location = new System.Drawing.Point(202, 63);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(91, 20);
            this.txtEfectivo.TabIndex = 2;
            this.txtEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEfectivo_KeyPress);
            this.txtEfectivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEfectivo_KeyUp);
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEfectivo.Location = new System.Drawing.Point(92, 67);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(43, 13);
            this.lblEfectivo.TabIndex = 3;
            this.lblEfectivo.Text = "Efectivo:";
            // 
            // lblCheque
            // 
            this.lblCheque.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCheque.Location = new System.Drawing.Point(94, 165);
            this.lblCheque.Name = "lblCheque";
            this.lblCheque.Size = new System.Drawing.Size(41, 13);
            this.lblCheque.TabIndex = 5;
            this.lblCheque.Text = "Cheque:";
            // 
            // lblCuentaCorriente
            // 
            this.lblCuentaCorriente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCuentaCorriente.Location = new System.Drawing.Point(51, 214);
            this.lblCuentaCorriente.Name = "lblCuentaCorriente";
            this.lblCuentaCorriente.Size = new System.Drawing.Size(84, 13);
            this.lblCuentaCorriente.TabIndex = 6;
            this.lblCuentaCorriente.Text = "CuentaCorriente:";
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTarjeta.Location = new System.Drawing.Point(96, 116);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(39, 13);
            this.lblTarjeta.TabIndex = 4;
            this.lblTarjeta.Text = "Tarjeta:";
            // 
            // txtCheque
            // 
            this.txtCheque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtCheque, 2);
            this.txtCheque.EditValue = "0";
            this.txtCheque.Location = new System.Drawing.Point(204, 161);
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.Size = new System.Drawing.Size(88, 20);
            this.txtCheque.TabIndex = 8;
            this.txtCheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheque_KeyPress);
            this.txtCheque.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCheque_KeyUp);
            // 
            // txtCuentaCorriente
            // 
            this.txtCuentaCorriente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtCuentaCorriente, 2);
            this.txtCuentaCorriente.EditValue = "0";
            this.txtCuentaCorriente.Location = new System.Drawing.Point(204, 210);
            this.txtCuentaCorriente.Name = "txtCuentaCorriente";
            this.txtCuentaCorriente.Size = new System.Drawing.Size(88, 20);
            this.txtCuentaCorriente.TabIndex = 9;
            this.txtCuentaCorriente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuentaCorriente_KeyPress);
            this.txtCuentaCorriente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCuentaCorriente_KeyUp);
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtTarjeta, 2);
            this.txtTarjeta.EditValue = "0";
            this.txtTarjeta.Location = new System.Drawing.Point(204, 112);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(88, 20);
            this.txtTarjeta.TabIndex = 7;
            this.txtTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTarjeta_KeyPress);
            this.txtTarjeta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTarjeta_KeyUp);
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMontoTotal.Location = new System.Drawing.Point(35, 18);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(67, 13);
            this.lblMontoTotal.TabIndex = 10;
            this.lblMontoTotal.Text = "Monto Total : ";
            // 
            // lblMontoRestante
            // 
            this.lblMontoRestante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMontoRestante, 2);
            this.lblMontoRestante.Location = new System.Drawing.Point(206, 18);
            this.lblMontoRestante.Name = "lblMontoRestante";
            this.lblMontoRestante.Size = new System.Drawing.Size(84, 13);
            this.lblMontoRestante.TabIndex = 11;
            this.lblMontoRestante.Text = "Monto Restante :";
            // 
            // FormaPagoCombinada
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(358, 298);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaPagoCombinada";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combinado";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEfectivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCheque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaCorriente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarjeta.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.TextEdit txtEfectivo;
        private DevExpress.XtraEditors.LabelControl lblEfectivo;
        private DevExpress.XtraEditors.LabelControl lblCheque;
        private DevExpress.XtraEditors.LabelControl lblCuentaCorriente;
        private DevExpress.XtraEditors.LabelControl lblTarjeta;
        private DevExpress.XtraEditors.TextEdit txtCheque;
        private DevExpress.XtraEditors.TextEdit txtCuentaCorriente;
        private DevExpress.XtraEditors.TextEdit txtTarjeta;
        private DevExpress.XtraEditors.LabelControl lblMontoTotal;
        private DevExpress.XtraEditors.LabelControl lblMontoRestante;
    }
}