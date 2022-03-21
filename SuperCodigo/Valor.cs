using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCodigo
{
    public static class Constantes
    {
        public const string ERRO_DENOMINADOR_IGUAL_ZERO = "Denominador precisa ser diferente de zero.";
    }

    public class Valor
    {
        private int _numero;

        public int GetValor()
        {
            return _numero;
        }

        public void Adicionar(int valorAdicionado)
        {
            _numero += valorAdicionado;
        }

        public void Dividir(int denominador)
        {
            if (denominador == 0)
                throw new ArgumentException(Constantes.ERRO_DENOMINADOR_IGUAL_ZERO);

            _numero /= denominador;
        }

        public bool VerificarMaiorQueZero()
        {
            return _numero > 0;
        }
    }
}
