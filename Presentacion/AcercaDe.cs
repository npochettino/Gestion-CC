using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Presentacion
{
    public partial class AcercaDe : SplashScreen
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AcercaDe_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}