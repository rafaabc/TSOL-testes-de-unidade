using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SuperCodigo.TestesUnidade
{
    public class OperacoesTeste
    {   
        [Theory]
        [InlineData("", "")]
        [InlineData("abcdefghijklmnopqrstu", "u")]
        public void ObterPosicaoDeUmCaractereCadeiaInvalida(string cadeia, string caractere)
        {
            var exception = Assert.Throws<ArgumentException>(() => Operacoes.ObterPosicaoCaractere(cadeia, caractere));
            Assert.Equal(ConstantesOperacoes.CADEIA_CARACTERES_CADEIA_INVALIDA, exception.Message);
        }

        [Fact]
        public void ObterPosicaoDeUmCaractereInvalido()
        {
            var exception = Assert.Throws<ArgumentException>(() => Operacoes.ObterPosicaoCaractere("a", ""));
            Assert.Equal(ConstantesOperacoes.CADEIA_CARACTERES_CARACTERE_INVALIDO, exception.Message);
        }

        [Fact]
        public void ObterPosicaoCaractereNaPosicao1()
        {
            Assert.Equal(1, Operacoes.ObterPosicaoCaractere("a", "a"));
        }

        [Fact]
        public void ObterPosicaoCaractereNaPosicao20()
        {
            Assert.Equal(20, Operacoes.ObterPosicaoCaractere("abcdefghijklmnopqrst", "t"));
        }

        [Fact]
        public void ObterPosicaoCaractereInexistente()
        {
            Assert.Equal(-1, Operacoes.ObterPosicaoCaractere("teste", "a"));
        }

        [Fact]
        public void ObterElementoFibonnaciInvalido()
        {
            var exception = Assert.Throws<ArgumentException>(() => Operacoes.ObterElementoFibonnaci(0));
            Assert.Equal(ConstantesOperacoes.FIBONNACI_MAIOR_QUE_ZERO, exception.Message);
        }
        
        [Fact]
        public void ObterElementoFibonnaciIgual1()
        {   
            Assert.Equal(1, Operacoes.ObterElementoFibonnaci(1));
        }
        
        [Fact]
        public void ObterElementoFibonnaciIgual2()
        {
            Assert.Equal(2, Operacoes.ObterElementoFibonnaci(2));
        }

        [Fact]
        public void ObterElementoFibonnaciIgual3()
        {
            Assert.Equal(6, Operacoes.ObterElementoFibonnaci(3));
        }

        [Theory]
        [InlineData(-1, 0, 0)]
        [InlineData(0, -1, 0)]
        [InlineData(0, 0, -1)]
        [InlineData(1, 1, 3)]
        public void DeterminarTipoTrianguloArestaNegativa(int a, int b, int c)
        {   
            Assert.Equal("INEXISTENTE", Operacoes.DeterminarTipoTriangulo(a, b, c));
        }

        [Fact]        
        public void DeterminarTipoTrianguloEquilatero()
        {
            Assert.Equal("EQUILATERO", Operacoes.DeterminarTipoTriangulo(3, 3, 3));
        }

        [Theory]
        [InlineData(3, 3, 4)]
        [InlineData(4, 3, 3)]
        [InlineData(3, 4, 3)]
        public void DeterminarTipoTrianguloIsosceles(int a, int b, int c)
        {
            Assert.Equal("ISOSCELES", Operacoes.DeterminarTipoTriangulo(a, b, c));
        }

        [Fact]
        public void DeterminarTipoTrianguloEscaleno()
        {
            Assert.Equal("ESCALENO", Operacoes.DeterminarTipoTriangulo(3, 4, 5));
        }
    }
}
