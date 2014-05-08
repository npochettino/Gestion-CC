namespace Presentacion
{
    partial class FormCancelacionVenta
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
            this.lblFechaCancelacion = new System.Windows.Forms.Label();
            this.lblMotivoCancelación = new System.Windows.Forms.Label();
            this.txtFechaCancelacion = new System.Windows.Forms.TextBox();
            this.txtMotivoCancelacion = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.66197F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.33803F));
            this.tableLayoutPanel1.Controls.Add(this.lblFechaCancelacion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMotivoCancelación, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFechaCancelacion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMotivoCancelacion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07693F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 162);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblFechaCancelacion
            // 
            this.lblFechaCancelacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaCancelacion.AutoSize = true;
            this.lblFechaCancelacion.Location = new System.Drawing.Point(14, 24);
            this.lblFechaCancelacion.Name = "lblFechaCancelacion";
            this.lblFechaCancelacion.Size = new System.Drawing.Size(115, 13);
            this.lblFechaCancelacion.TabIndex = 0;
            this.lblFechaCancelacion.Text = "Fecha de Cancelación:";
            // 
            // lblMotivoCancelación
            // 
            this.lblMotivoCancelación.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMotivoCancelación.AutoSize = true;
            this.lblMotivoCancelación.Location = new System.Drawing.Point(12, 86);
            this.lblMotivoCancelación.Name = "lblMotivoCancelación";
            this.lblMotivoCancelación.Size = new System.Drawing.Size(118, 13);
            this.lblMotivoCancelación.TabIndex = 1;
            this.lblMotivoCancelación.Text = "Motivo de Cancelación:";
            this.lblMotivoCancelación.Visible = false;
            // 
            // txtFechaCancelacion
            // 
            this.txtFechaCancelacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFechaCancelacion.Enabled = false;
            this.txtFechaCancelacion.Location = new System.Drawing.Point(165, 20);
            this.txtFechaCancelacion.Name = "txtFechaCancelacion";
            this.txtFechaCancelacion.Size = new System.Drawing.Size(140, 21);
            this.txtFechaCancelacion.TabIndex = 2;
            this.txtFechaCancelacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMotivoCancelacion
            // 
            this.txtMotivoCancelacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMotivoCancelacion.Location = new System.Drawing.Point(165, 82);
            this.txtMotivoCancelacion.Name = "txtMotivoCancelacion";
            this.txtMotivoCancelacion.Size = new System.Drawing.Size(140, 21);
            this.txtMotivoCancelacion.TabIndex = 3;
            this.txtMotivoCancelacion.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAceptar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(146, 127);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(179, 32);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(7, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(96, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormCancelacionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 162);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "FormCancelacionVenta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelación de la Venta";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFechaCancelacion;
        private System.Windows.Forms.Label lblMotivoCancelación;
        private System.Windows.Forms.TextBox txtFechaCancelacion;
        private System.Windows.Forms.TextBox txtMotivoCancelacion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
    }
}