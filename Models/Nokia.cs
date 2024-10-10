namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, string memoria) : base(numero)
        {
            
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nomeApp)
        {

            Console.WriteLine($"Instalando {nomeApp}..");
            Console.WriteLine($"{nomeApp} Instalado com sucesso!");
        
        }
    }
}