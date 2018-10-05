
namespace Estacionamientos
{
    public class Estacionamiento
    {
        private string nombre;
        private string dirección;
        private double latitud;
        private double longitud;


        public string Nombre { get => nombre; set => nombre = value; }
        public string Dirección { get => dirección; set => dirección = value; }
        public double Latitud { get => latitud; set => latitud = value; }
        public double Longitud { get => longitud; set => longitud = value; }


        public Estacionamiento(string nombre, string dirección, double latitud, double longitud)
        {
            Nombre = nombre;
            Dirección = dirección;
            Latitud = latitud;
            Longitud = longitud;
        }
    }
}
