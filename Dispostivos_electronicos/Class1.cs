namespace Dispostivos_electronicos
{
    public interface ICamara
    {
        void MostrarAppCamara();
        void TomarFoto();

        public string NombreFoto { get; set; }
        public int CantidadDEFotos { get; set; }

    }

    public class Celular : ICamara
    {
        public string NombreFoto { get; set; }
        public int CantidadDEFotos { get; set; }

        public Celular(string nombrefoto, int cantidadFotos)
        { 
            this.NombreFoto = nombrefoto;
            this.CantidadDEFotos = cantidadFotos;
        }

        public void MostrarAppCamara()
        {
            Console.WriteLine("se esta mostrando algo en pantalla, y la app es......\n");
        }

        public void TomarFoto()
        {
            Console.WriteLine("se tomo foto\n");
        }
    }


    public interface IGps : ICamara
    {
        void localizar();
        void ObtenerCoordenadas();
    }

    public class Tablets : IGps
    {
        public string NombreFoto { get; set; }
        public int CantidadDEFotos { get; set; }

        public Tablets(string nombreFoto, int cantidadFotos)
        { 
            this.NombreFoto = nombreFoto;
            this.CantidadDEFotos= cantidadFotos;
        }

        public void localizar()
        {
            Console.WriteLine("se esta localizando el dispostivo\n");
        }

        public void MostrarAppCamara()
        {
            Console.WriteLine("se esta mostrado algo en pantalla, la app es .......\n");
        }

        public void ObtenerCoordenadas()
        {
            Console.WriteLine("Las Coordenadas son: 48o 51’ 30.2328’’N, 2o 17’ 40.1388’’E\n");
        }

        public void TomarFoto()
        {
            Console.WriteLine("se tomo la foto\n");
        }
    }

}