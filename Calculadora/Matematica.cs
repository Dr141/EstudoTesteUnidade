namespace Calculadora
{
    public class Matematica
    {

        public decimal Adicao(decimal value1, decimal value2) 
        {
            return value1 + value2;
        }

        public decimal Subtracao(decimal value1, decimal value2)
        {
            return value1 - value2; 
        }

        public decimal Multiplicacao(decimal value1, decimal value2)
        {
            return value1 * value2;
        }

        public decimal Divisao(decimal value1, decimal value2)
        { 
            return value1 / value2; 
        }

        public decimal Potencia(decimal value1, decimal potencia)
        {
            switch (potencia)
            {
                case 0:
                {
                    return 1;
                }
                case 1: 
                {
                    return value1;
                }
                default:
                {
                    decimal result = value1;
                    for (int i = 1; i < potencia; i++) 
                    {
                            result *= value1;
                    }
                    return result;
                }
            }
        }
    }
}