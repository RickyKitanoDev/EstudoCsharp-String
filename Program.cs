using System;
using System.Text;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //TRATAMENTO DE STRINGS

            //GUID NUMERO RANDOMICO, NUMERO QUE QUASE NUNCA SE REPETE
            // var id = Guid.NewGuid();

            // id = new Guid("512f0f9e-da1f-47b6-802a-a2c39712ee17");
            // Console.WriteLine(id.ToString().Substring(0,8));
            // SubString(posição inicial, quantidade de caracteres )
            // ToString(Converter para string)

            // if(id == Guid.NewGuid())
            // Console.WriteLine(id.ToString().Substring(0,8));

            // //SE USAR NEW GUID SEM PASSAR VALOR, O RESULTADO VAI SER UM NEW GUID COM TODOS VALORES ZERADOS
            // id = new Guid();
            // Console.WriteLine(id); // RESULTADO: 00000000-0000-0000-0000-000000000000
            //-----------------------------------------------------------------------------------------------------------


            //INTERPOLAÇÃO DE STRINGS

            // var price = 10.2;
            //var texto = "O preço do produto é " + price;//CONCATENAÇÃO DE VARIAVEIS COM TEXTO, UTILIZANDO O "+".

            //string.Format() UTILIZADO PARA UTILIZAR VARIAVEIS E TEXTO, INFORMANDO AS VARIAVEIS SEMPRE APOS A VIRGULA, ONDE SERÁ PROCURADO DE ACORDO COM O INDICE IDENTIFICADOS PELAS "{}".
            // var texto = string.Format("O preço do produto é {0} apenas na promoção",price);

            //UTILIZANDO CIFRÃO
            //var texto = $"O preço do produto é {price} apenas na promoção.";
            //DICA: SE UTILIZAR O @ ANTES DAS ASPAS A APLICAÇÃO ENTENDE TODO TEXTO COMO UMA LINHA.

            //Console.WriteLine(texto);
            //-----------------------------------------------------------------------------------------------------------

            //COMPARANDO STRINGS

            //var texto = "Testando";

            //CompareTo() - SERVE PARA COMPARAR STRINGS, RETORNA INTEIRO.
            // Console.WriteLine(texto.CompareTo("Testando"));

            // var texto = "Este texto é um teste";

            //Contains() - SERVE PARA COMPARAR STRINGS, RETORNA BOOLEAN, BASTA PASSAR NOS PARENTESES O "PEDAÇO" DA STRING A SER COMPARADA.OBS CASE SENSITIVE.
            // Console.WriteLine(texto.Contains("teste"));
            // CASO QUERIA IGNORAR O "CASE SENSITIVE", BASTA PASSAR APÓS A STRING "StringComparison.OrdinalIgnoreCase".
            // Console.WriteLine(texto.Contains("Teste",StringComparison.OrdinalIgnoreCase));

            //STARTSWITH ENDSWITH - COMEÇA COM E TERMINA COM. RETORNA BOOLEAN.

            // var texto = "Este texto é um teste";

            // Console.WriteLine(texto.StartsWith("Este")); // TRUE
            // Console.WriteLine(texto.StartsWith("este")); // FALSE
            // Console.WriteLine(texto.StartsWith("texto")); // FALSE

            // Console.WriteLine(texto.EndsWith("teste")); // TRUE
            // Console.WriteLine(texto.EndsWith("Teste")); // FALSE
            // Console.WriteLine(texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase)); // TRUE 
            // Console.WriteLine(texto.EndsWith("xpto")); // FALSE

            //-----------------------------------------------------------------------------------------------------------

            //EQUALS - COMPARAR TEXTOS - O TEXTO PRECISA SER IGUAL - RETORNA BOOLEAN.

            // var texto = "Este texto é um teste";
            // Console.WriteLine(texto.Equals("Este texto é um teste")); //TRUE
            // Console.WriteLine(texto.Equals("este texto é um teste")); // FALSE - CASE SENSITIVE
            // Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase)); // TRUE

            //-----------------------------------------------------------------------------------------------------------

            //INDICE - POSICAO NO ARRAY - INICIA "0".
            // IndexOf - primeiro índice
            // LastIndexOf - ultimo índice

            // var texto  = "Este texto é um teste";
            // Console.WriteLine(texto.IndexOf("é"));//POSICAO 11
            // Console.WriteLine(texto.LastIndexOf("s"));

            //-----------------------------------------------------------------------------------------------------------

            // MÉTODOS ADICIONAIS
            // ToUpper - CONVERTE TODO O TEXTO PARA MAIÚSCULO.
            // ToLower - CONVERTE TODO O TEXTO PARA MINÚSCULO.
            // Insert - INSERIR UM CARACTERE - PASSAR ÍNDICE E O CARACTERE A SER INSERIDO.
            // Remove - PASSAR O INICIO E O FIM DO ÍNDICE.
            // Length - 


            // var texto = "Este texto é um teste";
            // Console.WriteLine(texto.ToLower());
            // Console.WriteLine(texto.ToUpper());
            // Console.WriteLine(texto.Insert(5,"AQUI "));
            // Console.WriteLine(texto.Remove(5,5));
            // Console.WriteLine(texto.Length);


            //-------------------------------------------------------------------------------------------------------    

            //MANIPULANDO STRINGS - 
            // Replace("passa o caractere que será substituído","passa o caractere substituto") - Trocar um caractere por outro;

            // Split() - Dividir o texto, por algum caractere. Ex: " ". Cria uma lista que pode ser chamado pelo índice.

            // Substring() - Passar dois parâmetros, onde o primeiro é o caractere inicial e o segundo irá informar até quantos caracteres deve ser capturados.

            // Trim() - Remove os espaços do início e fim.


            // var texto = "Este texto é um teste";

            //Console.WriteLine(texto.Replace("Este","Isto"));
            // var divisao = texto.Split(" ");

            // Console.WriteLine(divisao[0]);
            // Console.WriteLine(divisao[1]);
            // Console.WriteLine(divisao[2]);
            // Console.WriteLine(divisao[3]);
            // Console.WriteLine(divisao[4]);

            // var resultado = texto.Substring(5,5);
            // Console.WriteLine(resultado); // EX: texto(primeiro caractere na posicao "5"(t),5 caracteres após o inicial) = texto

            // var texto = "       Este texto é um teste     ";

            // Console.WriteLine(texto.Trim()); - NESTE CASO ESTÁ SENDO REMOVIDO OS ESPAÇOS, UTILIZANDO TRIM().
            // Console.WriteLine(texto); - JÁ NESTE CASO ESTÁ SENDO IMPRESSO CONFORME A ESCRITA, POIS NÃO ESTÁ UTILIZANDO O TRIM().

            //-----------------------------------------------------------------------------------------------------------

            // StringBuilder - JUNTAR VÁRIAS LINHAS DE TEXTO.
            // var texto = new StringBuilder();
            // texto.Append("Este texto é um teste,");
            // texto.Append("leia com atenção, ");
            // texto.Append("não leia rápido de mais, ");
            // texto.Append("boa leitura.");

            // texto.ToString();
            // Console.WriteLine(texto);



        }
    }
}
