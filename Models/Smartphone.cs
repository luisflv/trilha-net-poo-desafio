namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Numero { get; set; }
        private string Modelo { get; }
        private string IMEI {get;}
        private int Memoria { get;}

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
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