namespace Vehiculos
{
    public class Vehiculo
    {
        #region Atributos
        private string placas;
        private string horaEntrada;
        private string horaSalida;
        private string detalles;
        #endregion

        #region Propiedades
        public string Placas { get => placas; set => placas = value; }
        public string HoraEntrada
        {
            get
            {
                return horaEntrada;
            }
            set => horaEntrada = value;
        }
        public string HoraSalida { get => horaSalida; set => horaSalida = value; }
        public string Detalles { get => detalles; set => detalles = value; }
        #endregion

        #region Constructor
        public Vehiculo(string placas, string horaEntrada, string horaSalida, string detalles)
        {
            Placas = placas;
            HoraEntrada = horaEntrada;
            HoraSalida = horaSalida;
            Detalles = detalles;
        }
        #endregion

    }
}
