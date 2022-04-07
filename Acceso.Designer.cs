
namespace PIDETEC
{
    partial class FrmAcceder
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
            this.groupBoxAcceso = new System.Windows.Forms.GroupBox();
            this.checkBoxInvitado = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtUsuarioIngreso = new System.Windows.Forms.TextBox();
            this.groupBoxAcceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAcceso
            // 
            this.groupBoxAcceso.Controls.Add(this.checkBoxInvitado);
            this.groupBoxAcceso.Controls.Add(this.btnSalir);
            this.groupBoxAcceso.Controls.Add(this.btnAceptar);
            this.groupBoxAcceso.Controls.Add(this.txtUsuarioIngreso);
            this.groupBoxAcceso.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAcceso.Location = new System.Drawing.Point(2, 2);
            this.groupBoxAcceso.Name = "groupBoxAcceso";
            this.groupBoxAcceso.Size = new System.Drawing.Size(497, 262);
            this.groupBoxAcceso.TabIndex = 0;
            this.groupBoxAcceso.TabStop = false;
            this.groupBoxAcceso.Text = "Acceso";
            // 
            // checkBoxInvitado
            // 
            this.checkBoxInvitado.AutoSize = true;
            this.checkBoxInvitado.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInvitado.Location = new System.Drawing.Point(26, 197);
            this.checkBoxInvitado.Name = "checkBoxInvitado";
            this.checkBoxInvitado.Size = new System.Drawing.Size(116, 26);
            this.checkBoxInvitado.TabIndex = 3;
            this.checkBoxInvitado.Text = "Invitado";
            this.checkBoxInvitado.UseVisualStyleBackColor = true;
            this.checkBoxInvitado.Click += new System.EventHandler(this.checkBoxInvitado_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(345, 156);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 67);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseHover += new System.EventHandler(this.btnSalir_MouseHover);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(200, 156);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(127, 67);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Entrar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnAceptar_MouseLeave);
            this.btnAceptar.MouseHover += new System.EventHandler(this.btnAceptar_MouseHover);
            // 
            // txtUsuarioIngreso
            // 
            this.txtUsuarioIngreso.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioIngreso.Location = new System.Drawing.Point(10, 38);
            this.txtUsuarioIngreso.Multiline = true;
            this.txtUsuarioIngreso.Name = "txtUsuarioIngreso";
            this.txtUsuarioIngreso.Size = new System.Drawing.Size(441, 48);
            this.txtUsuarioIngreso.TabIndex = 0;
            this.txtUsuarioIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUsuarioIngreso.Click += new System.EventHandler(this.txtUsuarioIngreso_Click);
           
            this.txtUsuarioIngreso.Enter += new System.EventHandler(this.txtUsuarioIngreso_Enter);
            this.txtUsuarioIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioIngreso_KeyPress);
            this.txtUsuarioIngreso.Leave += new System.EventHandler(this.txtUsuarioIngreso_Leave);
            // 
            // FrmAcceder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(502, 265);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxAcceso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAcceder";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmAcceder_Load);
            this.groupBoxAcceso.ResumeLayout(false);
            this.groupBoxAcceso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAcceso;
        private System.Windows.Forms.CheckBox checkBoxInvitado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.TextBox txtUsuarioIngreso;
    }
}

