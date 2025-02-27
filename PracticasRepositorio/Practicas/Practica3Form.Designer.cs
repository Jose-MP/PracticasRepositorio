namespace PracticasRepositorio.Practicas
{
    partial class Practica3Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValidarRFC = new System.Windows.Forms.Button();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtLetras = new System.Windows.Forms.TextBox();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.userControl11 = new Practic3.UserControl1();
            this.userControl21 = new Practic3.UserControl2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Solo numeros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Solo letras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "RFC formato AAAA######XXX";
            // 
            // btnValidarRFC
            // 
            this.btnValidarRFC.Location = new System.Drawing.Point(381, 397);
            this.btnValidarRFC.Name = "btnValidarRFC";
            this.btnValidarRFC.Size = new System.Drawing.Size(108, 23);
            this.btnValidarRFC.TabIndex = 5;
            this.btnValidarRFC.Text = "Validar RFC";
            this.btnValidarRFC.UseVisualStyleBackColor = true;
            this.btnValidarRFC.Click += new System.EventHandler(this.btnValidarRFC_Click);
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(326, 350);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(226, 22);
            this.txtRFC.TabIndex = 6;
            // 
            // txtLetras
            // 
            this.txtLetras.Location = new System.Drawing.Point(190, 279);
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.Size = new System.Drawing.Size(226, 22);
            this.txtLetras.TabIndex = 7;
            this.txtLetras.TextChanged += new System.EventHandler(this.txtLetras_TextChanged);
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(190, 224);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(226, 22);
            this.txtNumeros.TabIndex = 8;
            this.txtNumeros.TextChanged += new System.EventHandler(this.txtNumeros_TextChanged);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(54, 36);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(181, 106);
            this.userControl11.TabIndex = 9;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(287, 69);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(315, 41);
            this.userControl21.TabIndex = 10;
            // 
            // Practica3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.btnValidarRFC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Practica3Form";
            this.Text = "Practica3Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValidarRFC;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtLetras;
        private System.Windows.Forms.TextBox txtNumeros;
        private Practic3.UserControl1 userControl11;
        private Practic3.UserControl2 userControl21;
    }
}