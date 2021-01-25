namespace WriterApp
{
    partial class ucMain
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listOnline = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listOnline
            // 
            this.listOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOnline.FormattingEnabled = true;
            this.listOnline.Items.AddRange(new object[] {
            "test 1",
            "test 2",
            "test 3"});
            this.listOnline.Location = new System.Drawing.Point(0, 0);
            this.listOnline.Name = "listOnline";
            this.listOnline.Size = new System.Drawing.Size(327, 506);
            this.listOnline.TabIndex = 0;
            this.listOnline.Click += new System.EventHandler(this.listOnline_Click);
            // 
            // ucMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listOnline);
            this.Name = "ucMain";
            this.Size = new System.Drawing.Size(327, 506);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOnline;
    }
}
