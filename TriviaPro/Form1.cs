using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TriviaPro.Clases;


namespace TriviaPro
{
    public partial class Form1 : Form
    {
        private List<Pregunta> preguntasActuales;
        private int indicePregunta;
        private Puntaje puntaje;
        private Jugador jugador;
        private TemporizadorTrivia temporizador;
        private string categoriaSeleccionada;
        private string nivelSeleccionado;

        public Form1()
        {
            InitializeComponent();

            cmbCategoria.Items.AddRange(new string[] { "Ciencia", "Historia", "Cultura General" });
            cmbNivel.Items.AddRange(new string[] { "Fácil", "Medio", "Difícil" });

            btnResponder.Enabled = false;
            btnReiniciar.Enabled = false;
        }


        private void MostrarPreguntaActual()
        {
            if (indicePregunta >= preguntasActuales.Count)
            {
                FinalizarJuego();
                return;
            }

            var pregunta = preguntasActuales[indicePregunta];
            lblPregunta.Text = pregunta.Texto;

            var opciones = pregunta.Opciones;

            rbtnOpcion1.Text = opciones[0];
            rbtnOpcion2.Text = opciones[1];
            rbtnOpcion3.Text = opciones[2];
            rbtnOpcion4.Text = opciones.Count > 3 ? opciones[3] : "";
            rbtnOpcion4.Visible = opciones.Count > 3;

            rbtnOpcion1.Checked = rbtnOpcion2.Checked = rbtnOpcion3.Checked = rbtnOpcion4.Checked = false;

            lblPreguntasRestantes.Text = $"Pregunta {indicePregunta + 1} de {preguntasActuales.Count}";
            lblPuntaje.Text = $"Puntaje: {puntaje.ValorActual}";
            progressBarTiempo.Value = 100;

            int segundos = nivelSeleccionado == "Fácil" ? 20 :
                           nivelSeleccionado == "Medio" ? 15 : 10;

            temporizador.Iniciar(segundos);
        }

        private void TiempoAgotado()
        {
            MessageBox.Show("⏰ Tiempo agotado. Respuesta incorrecta.");
            puntaje.Restar();
            indicePregunta++;
            MostrarPreguntaActual();
        }

        private void ActualizarTiempo(int tiempo)
        {
            if (lblTiempo.InvokeRequired)
            {
                lblTiempo.Invoke(new Action(() => ActualizarTiempo(tiempo)));
            }
            else
            {
                lblTiempo.Text = $"Tiempo restante: {tiempo}s";

                int total = nivelSeleccionado == "Fácil" ? 20 :
                            nivelSeleccionado == "Medio" ? 15 : 10;

                progressBarTiempo.Value = (int)((tiempo / (double)total) * 100);
            }
        }

        private void FinalizarJuego()
        {
            temporizador.Detener();
            MessageBox.Show($"🎉 Juego finalizado.\nPuntaje total: {puntaje.ValorActual}", "Resumen");
            btnResponder.Enabled = false;
            btnIniciar.Enabled = true;
            cmbCategoria.Enabled = true;
            cmbNivel.Enabled = true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedItem == null || cmbNivel.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar una categoría y un nivel.");
                return;
            }

            categoriaSeleccionada = cmbCategoria.SelectedItem.ToString();
            nivelSeleccionado = cmbNivel.SelectedItem.ToString();

            preguntasActuales = PreguntaFactory.ObtenerPreguntas(categoriaSeleccionada, nivelSeleccionado)
                                               .OrderBy(p => Guid.NewGuid())
                                               .ToList();

            if (preguntasActuales.Count == 0)
            {
                MessageBox.Show("No hay preguntas para esta categoría y nivel.");
                return;
            }

            jugador = new Jugador("Jugador");
            puntaje = new Puntaje();
            temporizador = new TemporizadorTrivia();
            temporizador.TiempoFinalizado += TiempoAgotado;
            temporizador.TiempoActualizado += ActualizarTiempo;

            indicePregunta = 0;

            btnIniciar.Enabled = false;
            cmbCategoria.Enabled = false;
            cmbNivel.Enabled = false;
            btnResponder.Enabled = true;
            btnReiniciar.Enabled = true;

            MostrarPreguntaActual();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            var pregunta = preguntasActuales[indicePregunta];
            string seleccion = null;

            if (rbtnOpcion1.Checked) seleccion = rbtnOpcion1.Text;
            else if (rbtnOpcion2.Checked) seleccion = rbtnOpcion2.Text;
            else if (rbtnOpcion3.Checked) seleccion = rbtnOpcion3.Text;
            else if (rbtnOpcion4.Checked) seleccion = rbtnOpcion4.Text;

            if (string.IsNullOrEmpty(seleccion))
            {
                MessageBox.Show("Selecciona una respuesta.");
                return;
            }

            temporizador.Detener();

            bool esCorrecta = pregunta.EvaluarRespuesta(seleccion) > 0;

            if (esCorrecta)
            {
                puntaje.Sumar(nivelSeleccionado);
                MessageBox.Show("✅ ¡Correcto!");
            }
            else
            {
                puntaje.Restar();
                MessageBox.Show("❌ Incorrecto. La correcta era: " + pregunta.RespuestaCorrecta);
            }

         
            string estado = esCorrecta ? "✔ Correcta" : "✘ Incorrecta";
            string entradaHistorial = $"[{estado}] {pregunta.Texto}";
            lstHistorial.Items.Add(entradaHistorial);

            indicePregunta++;
            MostrarPreguntaActual();
        }


        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Enabled = true;
            cmbCategoria.Enabled = true;
            cmbNivel.Enabled = true;
            btnResponder.Enabled = false;
            btnReiniciar.Enabled = false;

            lblPregunta.Text = "";
            lblTiempo.Text = "";
            lblPuntaje.Text = "";
            lblPreguntasRestantes.Text = "";
            progressBarTiempo.Value = 0;

            preguntasActuales?.Clear();
            temporizador?.Detener();

            cmbCategoria.SelectedIndex = -1;
            cmbNivel.SelectedIndex = -1;

            rbtnOpcion1.Text = "";
            rbtnOpcion2.Text = "";
            rbtnOpcion3.Text = "";
            rbtnOpcion4.Text = "";
            rbtnOpcion1.Checked = rbtnOpcion2.Checked = rbtnOpcion3.Checked = rbtnOpcion4.Checked = false;

            lstHistorial.Items.Clear();

        }


    }
}
