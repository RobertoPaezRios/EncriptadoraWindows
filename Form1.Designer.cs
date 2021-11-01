
namespace EncriptadoraASCII
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMensajeResultado = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.lblMensajeTexto = new System.Windows.Forms.Label();
            this.lblMensajeClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblPantalla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensajeResultado
            // 
            this.lblMensajeResultado.AutoSize = true;
            this.lblMensajeResultado.Font = new System.Drawing.Font("Source Code Pro Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeResultado.ForeColor = System.Drawing.Color.White;
            this.lblMensajeResultado.Location = new System.Drawing.Point(11, 178);
            this.lblMensajeResultado.Name = "lblMensajeResultado";
            this.lblMensajeResultado.Size = new System.Drawing.Size(130, 24);
            this.lblMensajeResultado.TabIndex = 0;
            this.lblMensajeResultado.Text = "Resultado:";
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Source Code Pro Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(12, 37);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(444, 31);
            this.txtTexto.TabIndex = 1;
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.BackColor = System.Drawing.Color.LightGreen;
            this.btnEncriptar.Font = new System.Drawing.Font("Source Code Pro Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncriptar.Location = new System.Drawing.Point(12, 129);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(226, 35);
            this.btnEncriptar.TabIndex = 2;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = false;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.BackColor = System.Drawing.Color.Red;
            this.btnDesencriptar.Font = new System.Drawing.Font("Source Code Pro Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesencriptar.Location = new System.Drawing.Point(244, 129);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(211, 35);
            this.btnDesencriptar.TabIndex = 3;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = false;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // lblMensajeTexto
            // 
            this.lblMensajeTexto.AutoSize = true;
            this.lblMensajeTexto.Font = new System.Drawing.Font("Source Code Pro Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeTexto.ForeColor = System.Drawing.Color.White;
            this.lblMensajeTexto.Location = new System.Drawing.Point(8, 10);
            this.lblMensajeTexto.Name = "lblMensajeTexto";
            this.lblMensajeTexto.Size = new System.Drawing.Size(70, 24);
            this.lblMensajeTexto.TabIndex = 4;
            this.lblMensajeTexto.Text = "Texto";
            // 
            // lblMensajeClave
            // 
            this.lblMensajeClave.AutoSize = true;
            this.lblMensajeClave.Font = new System.Drawing.Font("Source Code Pro Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeClave.ForeColor = System.Drawing.Color.White;
            this.lblMensajeClave.Location = new System.Drawing.Point(8, 82);
            this.lblMensajeClave.Name = "lblMensajeClave";
            this.lblMensajeClave.Size = new System.Drawing.Size(70, 24);
            this.lblMensajeClave.TabIndex = 5;
            this.lblMensajeClave.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Source Code Pro Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(96, 79);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(360, 31);
            this.txtClave.TabIndex = 6;
            // 
            // lblPantalla
            // 
            this.lblPantalla.AutoSize = true;
            this.lblPantalla.Font = new System.Drawing.Font("Source Code Pro Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPantalla.ForeColor = System.Drawing.Color.White;
            this.lblPantalla.Location = new System.Drawing.Point(147, 178);
            this.lblPantalla.Name = "lblPantalla";
            this.lblPantalla.Size = new System.Drawing.Size(82, 24);
            this.lblPantalla.TabIndex = 7;
            this.lblPantalla.Text = "PRUEBA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(474, 218);
            this.Controls.Add(this.lblPantalla);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblMensajeClave);
            this.Controls.Add(this.lblMensajeTexto);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblMensajeResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensajeResultado;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.Label lblMensajeTexto;
        private System.Windows.Forms.Label lblMensajeClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblPantalla;
    }
}

