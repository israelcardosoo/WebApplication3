using WebApiFinal.Migrations;

namespace WebApiFinal.Models
{
    public class Produtos : Base
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }



        //Tipos de Dados

        string nome = "Etec"; //Tipo de referencia
        int valor = 10; //Números inteiros
        double valor2 = 20; //Numeros interios

        long valorF = 10.5F; //Numeros reais
        byte valor 4 = 10; //Numeros reais





    }
}
