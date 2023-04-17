using System;

namespace NumerosPrimosArrayComTeste
{
    public static class NumerosPrimosArray
    {
        public static int[] GetNumerosPrimos(int[] numeros)
        {
            List<int> numerosPrimos = new List<int>();

            for (int i = 0; i < numeros.Length; i++)
            {
                int num = numeros[i];
                if (IsPrimo(num))
                {
                    numerosPrimos.Add(num);
                }
            }
            return numerosPrimos.ToArray();            
        }

        private static bool IsPrimo(int numero)
        {
            int qtdDivisores = 0;
            if (numero <= 1)
            {
                return false;
            }
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    qtdDivisores++;                    
                }
            }
            if (qtdDivisores == 2)
            {
                return true;
            };
            return false;
            
        }
    }
}