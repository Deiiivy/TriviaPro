namespace TriviaPro
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
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.rbtnOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbtnOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbtnOpcion3 = new System.Windows.Forms.RadioButton();
            this.rbtnOpcion4 = new System.Windows.Forms.RadioButton();
            this.btnResponder = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.progressBarTiempo = new System.Windows.Forms.ProgressBar();
            this.lblPreguntasRestantes = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.lblNombreJugador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(99, 81);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 0;
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(99, 123);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(121, 21);
            this.cmbNivel.TabIndex = 1;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Location = new System.Drawing.Point(232, 99);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(115, 24);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(447, 165);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(35, 13);
            this.lblPregunta.TabIndex = 3;
            this.lblPregunta.Text = "label1";
            // 
            // rbtnOpcion1
            // 
            this.rbtnOpcion1.AutoSize = true;
            this.rbtnOpcion1.Location = new System.Drawing.Point(441, 206);
            this.rbtnOpcion1.Name = "rbtnOpcion1";
            this.rbtnOpcion1.Size = new System.Drawing.Size(63, 17);
            this.rbtnOpcion1.TabIndex = 4;
            this.rbtnOpcion1.TabStop = true;
            this.rbtnOpcion1.Text = "opcion1";
            this.rbtnOpcion1.UseVisualStyleBackColor = true;
            // 
            // rbtnOpcion2
            // 
            this.rbtnOpcion2.AutoSize = true;
            this.rbtnOpcion2.Location = new System.Drawing.Point(609, 206);
            this.rbtnOpcion2.Name = "rbtnOpcion2";
            this.rbtnOpcion2.Size = new System.Drawing.Size(63, 17);
            this.rbtnOpcion2.TabIndex = 5;
            this.rbtnOpcion2.TabStop = true;
            this.rbtnOpcion2.Text = "opcion2";
            this.rbtnOpcion2.UseVisualStyleBackColor = true;
            // 
            // rbtnOpcion3
            // 
            this.rbtnOpcion3.AutoSize = true;
            this.rbtnOpcion3.Location = new System.Drawing.Point(609, 263);
            this.rbtnOpcion3.Name = "rbtnOpcion3";
            this.rbtnOpcion3.Size = new System.Drawing.Size(63, 17);
            this.rbtnOpcion3.TabIndex = 6;
            this.rbtnOpcion3.TabStop = true;
            this.rbtnOpcion3.Text = "opcion3";
            this.rbtnOpcion3.UseVisualStyleBackColor = true;
            // 
            // rbtnOpcion4
            // 
            this.rbtnOpcion4.AutoSize = true;
            this.rbtnOpcion4.Location = new System.Drawing.Point(441, 263);
            this.rbtnOpcion4.Name = "rbtnOpcion4";
            this.rbtnOpcion4.Size = new System.Drawing.Size(63, 17);
            this.rbtnOpcion4.TabIndex = 7;
            this.rbtnOpcion4.TabStop = true;
            this.rbtnOpcion4.Text = "opcion4";
            this.rbtnOpcion4.UseVisualStyleBackColor = true;
            // 
            // btnResponder
            // 
            this.btnResponder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResponder.Location = new System.Drawing.Point(504, 306);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(113, 34);
            this.btnResponder.TabIndex = 8;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(593, 123);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(35, 13);
            this.lblTiempo.TabIndex = 9;
            this.lblTiempo.Text = "label1";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(409, 126);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(35, 13);
            this.lblPuntaje.TabIndex = 10;
            this.lblPuntaje.Text = "label1";
            // 
            // progressBarTiempo
            // 
            this.progressBarTiempo.Location = new System.Drawing.Point(412, 70);
            this.progressBarTiempo.Name = "progressBarTiempo";
            this.progressBarTiempo.Size = new System.Drawing.Size(361, 32);
            this.progressBarTiempo.TabIndex = 11;
            // 
            // lblPreguntasRestantes
            // 
            this.lblPreguntasRestantes.AutoSize = true;
            this.lblPreguntasRestantes.Location = new System.Drawing.Point(712, 123);
            this.lblPreguntasRestantes.Name = "lblPreguntasRestantes";
            this.lblPreguntasRestantes.Size = new System.Drawing.Size(35, 13);
            this.lblPreguntasRestantes.TabIndex = 12;
            this.lblPreguntasRestantes.Text = "label1";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Red;
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(674, 375);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Padding = new System.Windows.Forms.Padding(5);
            this.btnReiniciar.Size = new System.Drawing.Size(99, 35);
            this.btnReiniciar.TabIndex = 13;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nivel";
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.Location = new System.Drawing.Point(29, 197);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(345, 225);
            this.lstHistorial.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(360, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Trivia Pro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nombre Jugador";
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.Location = new System.Drawing.Point(103, 162);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.Size = new System.Drawing.Size(100, 20);
            this.txtNombreJugador.TabIndex = 19;
            // 
            // lblNombreJugador
            // 
            this.lblNombreJugador.AutoSize = true;
            this.lblNombreJugador.Location = new System.Drawing.Point(245, 165);
            this.lblNombreJugador.Name = "lblNombreJugador";
            this.lblNombreJugador.Size = new System.Drawing.Size(85, 13);
            this.lblNombreJugador.TabIndex = 20;
            this.lblNombreJugador.Text = "Nombre jugador:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.lblNombreJugador);
            this.Controls.Add(this.txtNombreJugador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblPreguntasRestantes);
            this.Controls.Add(this.progressBarTiempo);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.rbtnOpcion4);
            this.Controls.Add(this.rbtnOpcion3);
            this.Controls.Add(this.rbtnOpcion2);
            this.Controls.Add(this.rbtnOpcion1);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.cmbCategoria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.RadioButton rbtnOpcion1;
        private System.Windows.Forms.RadioButton rbtnOpcion2;
        private System.Windows.Forms.RadioButton rbtnOpcion3;
        private System.Windows.Forms.RadioButton rbtnOpcion4;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.ProgressBar progressBarTiempo;
        private System.Windows.Forms.Label lblPreguntasRestantes;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreJugador;
        private System.Windows.Forms.Label lblNombreJugador;
    }
}

