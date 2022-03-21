using System;

namespace SuperCodigo
{
    public static class ConstantesOperacoes
    {
        public const string CADEIA_CARACTERES_CADEIA_INVALIDA = "Cadeia Inválida.";
        public const string CADEIA_CARACTERES_CARACTERE_INVALIDO = "Caractere inválido.";
        public const string FIBONNACI_MAIOR_QUE_ZERO = "n deve ser maior que zero.";
    }

    public static class Operacoes
    {
        public static int ObterPosicaoCaractere(string cadeia, string caractere)
        {
            if (cadeia.Length == 0 || cadeia.Length > 20)
                throw new ArgumentException(ConstantesOperacoes.CADEIA_CARACTERES_CADEIA_INVALIDA);

            if (caractere.Length != 1)
                throw new ArgumentException(ConstantesOperacoes.CADEIA_CARACTERES_CARACTERE_INVALIDO);

            for (int i = 1; i <= cadeia.Length; i++) // pelo enunciado do problema a primeira posição é 1 e não 0
            {
                if (cadeia[i-1].ToString() == caractere)
                    return i;
            }

            return -1;
        }

        public static int ObterElementoFibonnaci(int n)
        {
            if (n < 1)
                throw new ArgumentException(ConstantesOperacoes.FIBONNACI_MAIOR_QUE_ZERO);

            int elementoAnterior1 = 1, elementoAnterior2 = 1, elementoAtual = elementoAnterior1;

            if (n == 2)
                elementoAtual = elementoAnterior1;
            else
            {
                for (int i = 3; i <= n; i++)
                {
                    elementoAtual = elementoAnterior1 + elementoAnterior2;
                    elementoAnterior1 = elementoAnterior2;
                    elementoAnterior2 = elementoAtual;
                }
            }

            return elementoAtual;
        }

        public static string DeterminarTipoTriangulo(int a, int b, int c)
        {
            string tipo = "ESCALENO";

            if (a <= 0 || b <= 0 || c <= 0)
                tipo = "INEXISTENTE";
            else
            {
                if (!(a + b > c && a + c > b && b + c > a))
                    tipo = "INEXISTENTE";
                else
                {
                    if (a == b)
                    {
                        tipo = "ISOSCELES";
                        if (b == c)
                            tipo = "EQUILATERO";
                    }
                    else
                    {
                        if (b == c || a == c)
                            tipo = "ISOSCELES";
                    }
                }
            }

            return tipo;
        }
    }
}
