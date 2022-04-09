using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial.camara
{
    public interface ICamara
    {
        void MostrarAppCamara();
        void TomarFotografia();
        string NombreDeFoto { get; set; }
        int CantidadDeFotos { get; set; }

    }

    public interface IGps
    {
        void Localizar();
        void ObtenerCoordenadas();
    }

    public class Celulares : ICamara, IGps
    {
        public string NombreDeFoto { get; set; }
        public int CantidadDeFotos { get; set; }

        public void Localizar()
        {
            throw new NotImplementedException();
        }

        public void MostrarAppCamara()
        {
            Console.WriteLine("Mostrando App de Camara en Celular");
        }

        public void ObtenerCoordenadas()
        {
            Console.WriteLine("Las Coordenadas son: 48o 51’ 30.2328’’N, 2o 17’ 40.1388’’E");
        }

        public void TomarFotografia()
        {
            throw new NotImplementedException();
        }
    }
    public class Program
    {
        public static void Main()
        {
            Celulares cel = new Celulares();
            cel.MostrarAppCamara();
            cel.ObtenerCoordenadas();
        }
    }
}
