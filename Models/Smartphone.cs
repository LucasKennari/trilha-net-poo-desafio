namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // XXX - TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }

        private string IMEI { get; set; }

        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

            // XXX - TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void Informacoes()
        {
            Console.WriteLine(this.Numero);
            Console.WriteLine(this.Modelo);
            Console.WriteLine(this.IMEI);
            Console.WriteLine(this.Memoria);
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}