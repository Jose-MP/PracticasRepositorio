namespace PracticasRepositorio
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.practica1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practica2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practica3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practicaBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.practica1ToolStripMenuItem,
            this.practica2ToolStripMenuItem,
            this.practica3ToolStripMenuItem,
            this.practicaBaseDeDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // practica1ToolStripMenuItem
            // 
            this.practica1ToolStripMenuItem.Name = "practica1ToolStripMenuItem";
            this.practica1ToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.practica1ToolStripMenuItem.Text = "Practica 1";
            this.practica1ToolStripMenuItem.Click += new System.EventHandler(this.practica1ToolStripMenuItem_Click);
            // 
            // practica2ToolStripMenuItem
            // 
            this.practica2ToolStripMenuItem.Name = "practica2ToolStripMenuItem";
            this.practica2ToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.practica2ToolStripMenuItem.Text = "Practica 2";
            this.practica2ToolStripMenuItem.Click += new System.EventHandler(this.practica2ToolStripMenuItem_Click);
            // 
            // practica3ToolStripMenuItem
            // 
            this.practica3ToolStripMenuItem.Name = "practica3ToolStripMenuItem";
            this.practica3ToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.practica3ToolStripMenuItem.Text = "Practica 3";
            this.practica3ToolStripMenuItem.Click += new System.EventHandler(this.practica3ToolStripMenuItem_Click);
            // 
            // practicaBaseDeDatosToolStripMenuItem
            // 
            this.practicaBaseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLToolStripMenuItem,
            this.mySQLToolStripMenuItem});
            this.practicaBaseDeDatosToolStripMenuItem.Name = "practicaBaseDeDatosToolStripMenuItem";
            this.practicaBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.practicaBaseDeDatosToolStripMenuItem.Text = "Practica Base de datos";
            this.practicaBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.practicaBaseDeDatosToolStripMenuItem_Click);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // mySQLToolStripMenuItem
            // 
            this.mySQLToolStripMenuItem.Name = "mySQLToolStripMenuItem";
            this.mySQLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mySQLToolStripMenuItem.Text = "MySQL";
            this.mySQLToolStripMenuItem.Click += new System.EventHandler(this.mySQLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 674);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem practica1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practica2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practica3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practicaBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mySQLToolStripMenuItem;
    }
}

