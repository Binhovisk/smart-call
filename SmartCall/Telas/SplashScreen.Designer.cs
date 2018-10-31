namespace SmartCall.Telas
{
    partial class SplashScreen
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
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.lbLoadSplash = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(155, 63);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(80, 57);
            this.metroProgressSpinner1.TabIndex = 0;
            // 
            // lbLoadSplash
            // 
            this.lbLoadSplash.AutoSize = true;
            this.lbLoadSplash.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbLoadSplash.Location = new System.Drawing.Point(145, 151);
            this.lbLoadSplash.Name = "lbLoadSplash";
            this.lbLoadSplash.Size = new System.Drawing.Size(102, 25);
            this.lbLoadSplash.TabIndex = 1;
            this.lbLoadSplash.Text = "Carregando";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 214);
            this.Controls.Add(this.lbLoadSplash);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Name = "SplashScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroLabel lbLoadSplash;
    }
}