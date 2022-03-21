using System;
using Xunit;

namespace SuperCodigo.TestesUnidade
{
    public class ValorTeste
    {
        private readonly Valor _valor;

        public ValorTeste()
        {
            // arrange
            _valor = new Valor();
        }

        [Fact]
        public void AdionarValorTeste()
        {
            // act
            _valor.Adicionar(5);

            // assert
            Assert.Equal(5, _valor.GetValor());
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        public void VerificarMaiorQueZeroTeste(int valor, bool expectativa)
        {
            // arrange
            _valor.Adicionar(valor);

            // act
            bool ehMaiorQueZero = _valor.VerificarMaiorQueZero();

            // assert
            Assert.Equal(expectativa, ehMaiorQueZero);
        }

        [Fact]
        public void Dividir_SucessoTeste()
        {
            // arrange
            _valor.Adicionar(10);

            // act
            _valor.Dividir(2);

            // assert
            Assert.Equal(5, _valor.GetValor());
        }

        [Fact]
        public void Dividir_ErroTeste()
        {
            // arrange
            _valor.Adicionar(5);

            // act and assert
            var exception = Assert.Throws<ArgumentException>(() => _valor.Dividir(0));

            // assert
            Assert.Equal(Constantes.ERRO_DENOMINADOR_IGUAL_ZERO, exception.Message);
        }
    }
}







