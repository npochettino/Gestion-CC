namespace UI.Desktop
{
    partial class Principal
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Groups.Add(this.tileGroup3);
            this.tileControl1.Location = new System.Drawing.Point(-1, 0);
            this.tileControl1.MaxId = 6;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(651, 291);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem1);
            this.tileGroup2.Items.Add(this.tileItem2);
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = null;
            // 
            // tileItem1
            // 
            tileItemElement1.Text = "tileItem1";
            this.tileItem1.Elements.Add(tileItemElement1);
            this.tileItem1.Id = 1;
            this.tileItem1.Name = "tileItem1";
            // 
            // tileItem2
            // 
            tileItemElement2.Text = "tileItem2";
            this.tileItem2.Elements.Add(tileItemElement2);
            this.tileItem2.Id = 2;
            this.tileItem2.Name = "tileItem2";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.tileItem3);
            this.tileGroup3.Items.Add(this.tileItem4);
            this.tileGroup3.Name = "tileGroup3";
            this.tileGroup3.Text = null;
            // 
            // tileItem3
            // 
            tileItemElement3.Text = "tileItem3";
            this.tileItem3.Elements.Add(tileItemElement3);
            this.tileItem3.Id = 4;
            this.tileItem3.Name = "tileItem3";
            // 
            // tileItem4
            // 
            tileItemElement4.Text = "tileItem4";
            this.tileItem4.Elements.Add(tileItemElement4);
            this.tileItem4.Id = 5;
            this.tileItem4.Name = "tileItem4";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 290);
            this.Controls.Add(this.tileControl1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileItem tileItem4;


    }
}