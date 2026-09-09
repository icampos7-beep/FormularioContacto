namespace FormularioContacto
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
            this.txtFormulario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpMotivo = new System.Windows.Forms.GroupBox();
            this.radSugerencia = new System.Windows.Forms.RadioButton();
            this.radQueja = new System.Windows.Forms.RadioButton();
            this.radConsulta = new System.Windows.Forms.RadioButton();
            this.chkRespuesta = new System.Windows.Forms.CheckBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblConf = new System.Windows.Forms.Label();
            this.txtConf = new System.Windows.Forms.TextBox();
            this.linkPolitica = new System.Windows.Forms.LinkLabel();
            this.grpMotivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFormulario
            // 
            this.txtFormulario.AutoSize = true;
            this.txtFormulario.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormulario.Location = new System.Drawing.Point(166, 9);
            this.txtFormulario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtFormulario.Name = "txtFormulario";
            this.txtFormulario.Size = new System.Drawing.Size(457, 37);
            this.txtFormulario.TabIndex = 0;
            this.txtFormulario.Text = "Formulario de Contacto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(60, 67);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 29);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 74);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(553, 22);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // grpMotivo
            // 
            this.grpMotivo.Controls.Add(this.radSugerencia);
            this.grpMotivo.Controls.Add(this.radQueja);
            this.grpMotivo.Controls.Add(this.radConsulta);
            this.grpMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMotivo.Location = new System.Drawing.Point(65, 123);
            this.grpMotivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMotivo.Name = "grpMotivo";
            this.grpMotivo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMotivo.Size = new System.Drawing.Size(327, 180);
            this.grpMotivo.TabIndex = 3;
            this.grpMotivo.TabStop = false;
            this.grpMotivo.Text = "Motivo de Contacto";
            // 
            // radSugerencia
            // 
            this.radSugerencia.AutoSize = true;
            this.radSugerencia.Location = new System.Drawing.Point(23, 128);
            this.radSugerencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radSugerencia.Name = "radSugerencia";
            this.radSugerencia.Size = new System.Drawing.Size(157, 33);
            this.radSugerencia.TabIndex = 2;
            this.radSugerencia.TabStop = true;
            this.radSugerencia.Text = "Sugerencia";
            this.radSugerencia.UseVisualStyleBackColor = true;
            // 
            // radQueja
            // 
            this.radQueja.AutoSize = true;
            this.radQueja.Location = new System.Drawing.Point(23, 86);
            this.radQueja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radQueja.Name = "radQueja";
            this.radQueja.Size = new System.Drawing.Size(99, 33);
            this.radQueja.TabIndex = 1;
            this.radQueja.TabStop = true;
            this.radQueja.Text = "Queja";
            this.radQueja.UseVisualStyleBackColor = true;
            // 
            // radConsulta
            // 
            this.radConsulta.AutoSize = true;
            this.radConsulta.Location = new System.Drawing.Point(23, 44);
            this.radConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radConsulta.Name = "radConsulta";
            this.radConsulta.Size = new System.Drawing.Size(115, 33);
            this.radConsulta.TabIndex = 0;
            this.radConsulta.TabStop = true;
            this.radConsulta.Text = "Cosulta";
            this.radConsulta.UseVisualStyleBackColor = true;
            // 
            // chkRespuesta
            // 
            this.chkRespuesta.AutoSize = true;
            this.chkRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRespuesta.Location = new System.Drawing.Point(65, 322);
            this.chkRespuesta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRespuesta.Name = "chkRespuesta";
            this.chkRespuesta.Size = new System.Drawing.Size(239, 29);
            this.chkRespuesta.TabIndex = 4;
            this.chkRespuesta.Text = "Deseo recibir respuesta";
            this.chkRespuesta.UseVisualStyleBackColor = true;
            this.chkRespuesta.CheckedChanged += new System.EventHandler(this.chkRespuesta_CheckedChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(101, 368);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(159, 44);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblConf
            // 
            this.lblConf.AutoSize = true;
            this.lblConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConf.Location = new System.Drawing.Point(61, 432);
            this.lblConf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConf.Name = "lblConf";
            this.lblConf.Size = new System.Drawing.Size(126, 24);
            this.lblConf.TabIndex = 6;
            this.lblConf.Text = "Confirmación:";
            this.lblConf.Click += new System.EventHandler(this.lblConf_Click);
            // 
            // txtConf
            // 
            this.txtConf.Location = new System.Drawing.Point(34, 460);
            this.txtConf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConf.Multiline = true;
            this.txtConf.Name = "txtConf";
            this.txtConf.ReadOnly = true;
            this.txtConf.Size = new System.Drawing.Size(719, 143);
            this.txtConf.TabIndex = 7;
            this.txtConf.TextChanged += new System.EventHandler(this.txtConf_TextChanged);
            // 
            // linkPolitica
            // 
            this.linkPolitica.AutoSize = true;
            this.linkPolitica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPolitica.Location = new System.Drawing.Point(267, 624);
            this.linkPolitica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkPolitica.Name = "linkPolitica";
            this.linkPolitica.Size = new System.Drawing.Size(229, 25);
            this.linkPolitica.TabIndex = 8;
            this.linkPolitica.TabStop = true;
            this.linkPolitica.Text = "Ver politica de privacidad";
            this.linkPolitica.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPolitica_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 675);
            this.Controls.Add(this.linkPolitica);
            this.Controls.Add(this.txtConf);
            this.Controls.Add(this.lblConf);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.chkRespuesta);
            this.Controls.Add(this.grpMotivo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtFormulario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Forulario de contacto";
            this.grpMotivo.ResumeLayout(false);
            this.grpMotivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtFormulario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grpMotivo;
        private System.Windows.Forms.RadioButton radConsulta;
        private System.Windows.Forms.RadioButton radSugerencia;
        private System.Windows.Forms.RadioButton radQueja;
        private System.Windows.Forms.CheckBox chkRespuesta;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblConf;
        private System.Windows.Forms.TextBox txtConf;
        private System.Windows.Forms.LinkLabel linkPolitica;
    }
}

