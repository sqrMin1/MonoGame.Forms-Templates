namespace MonoGame.Forms_Cross_Platform_Desktop_Project
{
    partial class Editor
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.sampleControl = new MonoGame.Forms_Cross_Platform_Desktop_Project.Controls.SampleControl();
            this.SuspendLayout();
            // 
            // sampleControl
            // 
            this.sampleControl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sampleControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleControl.ForeColor = System.Drawing.Color.White;
            this.sampleControl.Location = new System.Drawing.Point(0, 0);
            this.sampleControl.MouseHoverUpdatesOnly = false;
            this.sampleControl.Name = "sampleControl";
            this.sampleControl.Size = new System.Drawing.Size(800, 450);
            this.sampleControl.TabIndex = 0;
            this.sampleControl.Text = "Sample Control";
            // 
            // Editor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sampleControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SampleControl sampleControl;
    }
}

