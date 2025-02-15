namespace PracticasRepositorio
{
    partial class formimagenes
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
            this.pictureBoxGrande = new System.Windows.Forms.PictureBox();
            this.nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrande)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGrande
            // 
            this.pictureBoxGrande.Location = new System.Drawing.Point(12, 56);
            this.pictureBoxGrande.Name = "pictureBoxGrande";
            this.pictureBoxGrande.Size = new System.Drawing.Size(776, 382);
            this.pictureBoxGrande.TabIndex = 0;
            this.pictureBoxGrande.TabStop = false;
            this.pictureBoxGrande.Click += new System.EventHandler(this.pictureBoxGrande_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(403, 21);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(16, 16);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "...";
            this.nombre.Click += new System.EventHandler(this.nombre_Click);
            // 
            // formimagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.pictureBoxGrande);
            this.Name = "formimagenes";
            this.Text = "formimagenes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxGrande;
        public System.Windows.Forms.Label nombre;
    }
}