namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string modelo;
        protected string imei;
        protected int memoria;

        public Smartphone(string numero, string modeloDefinido, string imeiDefinido, int memoriaDefinida)
        {
            Numero = numero;
            modelo = modeloDefinido;
            imei = imeiDefinido;
            memoria = memoriaDefinida;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}