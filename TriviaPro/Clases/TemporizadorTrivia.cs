using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TriviaPro.Clases
{
    public class TemporizadorTrivia
    {
        private readonly Timer timer;
        public int TiempoRestante { get; private set; }
        public event Action TiempoFinalizado;
        public event Action<int> TiempoActualizado;

        public TemporizadorTrivia()
        {
            timer = new Timer { Interval = 1000 };
            timer.Tick += (s, e) =>
            {
                TiempoRestante--;
                TiempoActualizado?.Invoke(TiempoRestante);
                if (TiempoRestante <= 0)
                {
                    timer.Stop();
                    TiempoFinalizado?.Invoke();
                }
            };
        }

        public void Iniciar(int segundos)
        {
            TiempoRestante = segundos;
            timer.Start();
        }

        public void Detener() => timer.Stop();
    }

}
