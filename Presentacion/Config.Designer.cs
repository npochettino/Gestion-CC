namespace Presentacion
{
    partial class Config
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
            this.chkAutomatico = new System.Windows.Forms.CheckBox();
            this.chkPregunta = new System.Windows.Forms.CheckBox();
            this.btnAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.txtContrasena = new DevExpress.XtraEditors.TextEdit();
            this.txtMailEnvio = new DevExpress.XtraEditors.TextEdit();
            this.lblMailEnvio = new DevExpress.XtraEditors.LabelControl();
            this.lblContrasena = new DevExpress.XtraEditors.LabelControl();
            this.lblTextoPorDefecto = new DevExpress.XtraEditors.LabelControl();
            this.txtTextoPorDefecto = new DevExpress.XtraEditors.MemoEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMailEnvio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTextoPorDefecto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chkAutomatico, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkPregunta, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAplicar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtContrasena, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtMailEnvio, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMailEnvio, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblContrasena, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTextoPorDefecto, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtTextoPorDefecto, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 301);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chkAutomatico
            // 
            this.chkAutomatico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkAutomatico.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkAutomatico, 3);
            this.chkAutomatico.Location = new System.Drawing.Point(118, 16);
            this.chkAutomatico.Name = "chkAutomatico";
            this.chkAutomatico.Size = new System.Drawing.Size(279, 17);
            this.chkAutomatico.TabIndex = 0;
            this.chkAutomatico.Text = "Enviar en forma automática un email tras cada Venta";
            this.chkAutomatico.UseVisualStyleBackColor = true;
            this.chkAutomatico.CheckedChanged += new System.EventHandler(this.chkAutomatico_CheckedChanged);
            // 
            // chkPregunta
            // 
            this.chkPregunta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkPregunta.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkPregunta, 3);
            this.chkPregunta.Location = new System.Drawing.Point(115, 66);
            this.chkPregunta.Name = "chkPregunta";
            this.chkPregunta.Size = new System.Drawing.Size(284, 17);
            this.chkPregunta.TabIndex = 1;
            this.chkPregunta.Text = "Preguntar si se desea enviar un email tras cada Venta";
            this.chkPregunta.UseVisualStyleBackColor = true;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAplicar.Enabled = false;
            this.btnAplicar.Location = new System.Drawing.Point(337, 264);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 2;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(427, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContrasena.Location = new System.Drawing.Point(167, 165);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(200, 20);
            this.txtContrasena.TabIndex = 5;
            this.txtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasena_KeyPress);
            // 
            // txtMailEnvio
            // 
            this.txtMailEnvio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMailEnvio.Location = new System.Drawing.Point(167, 115);
            this.txtMailEnvio.Name = "txtMailEnvio";
            this.txtMailEnvio.Size = new System.Drawing.Size(200, 20);
            this.txtMailEnvio.TabIndex = 6;
            this.txtMailEnvio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMailEnvio_KeyPress);
            // 
            // lblMailEnvio
            // 
            this.lblMailEnvio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMailEnvio.Location = new System.Drawing.Point(25, 118);
            this.lblMailEnvio.Name = "lblMailEnvio";
            this.lblMailEnvio.Size = new System.Drawing.Size(69, 13);
            this.lblMailEnvio.TabIndex = 7;
            this.lblMailEnvio.Text = "Mail de Envío :";
            // 
            // lblContrasena
            // 
            this.lblContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContrasena.Location = new System.Drawing.Point(28, 168);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(63, 13);
            this.lblContrasena.TabIndex = 8;
            this.lblContrasena.Text = "Contraseña :";
            // 
            // lblTextoPorDefecto
            // 
            this.lblTextoPorDefecto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTextoPorDefecto.Location = new System.Drawing.Point(13, 218);
            this.lblTextoPorDefecto.Name = "lblTextoPorDefecto";
            this.lblTextoPorDefecto.Size = new System.Drawing.Size(94, 13);
            this.lblTextoPorDefecto.TabIndex = 9;
            this.lblTextoPorDefecto.Text = "Texto por defecto :";
            // 
            // txtTextoPorDefecto
            // 
            this.txtTextoPorDefecto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTextoPorDefecto.Location = new System.Drawing.Point(167, 203);
            this.txtTextoPorDefecto.Name = "txtTextoPorDefecto";
            this.txtTextoPorDefecto.Size = new System.Drawing.Size(200, 44);
            this.txtTextoPorDefecto.TabIndex = 4;
            this.txtTextoPorDefecto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTextoPorDefecto_KeyPress);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 301);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Mail";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMailEnvio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTextoPorDefecto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkAutomatico;
        private System.Windows.Forms.CheckBox chkPregunta;
        private DevExpress.XtraEditors.SimpleButton btnAplicar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.MemoEdit txtTextoPorDefecto;
        private DevExpress.XtraEditors.TextEdit txtContrasena;
        private DevExpress.XtraEditors.TextEdit txtMailEnvio;
        private DevExpress.XtraEditors.LabelControl lblMailEnvio;
        private DevExpress.XtraEditors.LabelControl lblContrasena;
        private DevExpress.XtraEditors.LabelControl lblTextoPorDefecto;
    }
}