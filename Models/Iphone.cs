using System.Security.Cryptography.X509Certificates;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, string memoria) : base(numero)
        {
            

        }

        // no iphone precisa de verificação do usuario para conseguir instalar um APP, então simplifiquei 
         public override void InstalarAplicativo (string nomeApp){
            string aut = "N";

            Console.WriteLine("Abrindo aba de autenticação para instalar aplicativo");
            Console.WriteLine("Autenticando.. \n Autenticação precisa ser aprovada, Digite S para autenticar ou N para cancelar");
            aut = Console.ReadLine();

            if(aut == "S" || aut =="s"){
            
                Console.WriteLine($"Instalando Aplicativo {nomeApp} no Iphone...");
                Console.WriteLine("Aplicativo instalado com sucesso!");
            }else{
                Console.WriteLine($"O {nomeApp} não pode ser instalado por não haver autenticação");
            }
         }
    }
}