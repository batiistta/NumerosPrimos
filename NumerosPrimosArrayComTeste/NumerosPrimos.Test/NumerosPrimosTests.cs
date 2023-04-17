using NumerosPrimosArrayComTeste;
using System;

namespace NumerosPrimos.Test
{
    public class NumerosPrimosTest
    {
        [Fact]
        public void NumerosPrimosTeste()
        {
            int[] numeros = { 1, 2, 37, 4, 5, 6, 17, 8, 9, 10 };
            int[] numerosPrimosEsperados = { 2, 37, 5, 17 };

            int[] numerosPrimos = NumerosPrimosArray.GetNumerosPrimos(numeros);

            // Assert
            Assert.Equal(numerosPrimosEsperados, numerosPrimos);
        }
    }
}