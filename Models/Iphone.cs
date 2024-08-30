namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modeloDefinido, string imeiDefinido, int memoriaDefinida) : base(numero, modeloDefinido, imeiDefinido, memoriaDefinida)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo: {nomeApp} no Iphone...");
        }
    }
}