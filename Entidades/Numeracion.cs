using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades

{
    public enum Esistema{Decimal,Binario};//la comparacion devuelve true
    public class Numeracion
    {
        private double valorNumerico;
        private Esistema sistema;
        
        //cc
        public Numeracion(double valor,Esistema sistema):this(valor.ToString(),sistema)
        {   
        }
        public Numeracion(string valor,Esistema sistema)
        {
            InicializarValores(valor,sistema);
        }
        


        public Esistema Sistema
        { 
            get 
            { 
                return sistema; 
            } 
        }

        //Valor num devuelve valor decimal que tengo almacenado con el sistema que tengo almacenado. en el que inicializo
        public string ValorNumerico
        {
            get
            {
                if(Esistema.Decimal == this.sistema)
                {
                    return valorNumerico.ToString();
                    
                }//else
                return DecimalABinario((int)valorNumerico);
            }
        }


        private void InicializarValores(string valor, Esistema sistema)
        {
            this.sistema = sistema;
            if (sistema == Esistema.Binario && EsBinario(valor))
            {
                // Si el sistema es binario y la cadena es válida, conviértela a decimal.
                valorNumerico = BinarioADecimal(valor);
            }
            else if (double.TryParse(valor, out double numeroDecimal))
            {
                // Si se puede convertir a double, almacena el valor decimal.
                valorNumerico = numeroDecimal;
            }
            else
            {
                // Si no se cumple ninguna de las condiciones anteriores, almacena MinValue de un double.
                valorNumerico = double.MinValue;
            }
        }

        private bool EsBinario(string valor)
        {
            foreach (char c in valor)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }

        private string DecimalABinario(int valor)
        {
            return Convert.ToString(valor, 2);
        }

        //Toma valor en string, convierte a decimal y vuelve a validar con valores numericos.
        private string DecimalABinario(string valor)
        {
            if (double.TryParse(valor, out double numeroDecimal))
            {
                int numeroEntero = (int)Math.Abs(numeroDecimal);
                return Convert.ToString(numeroEntero, 2);
            }
            else
            {
                //no debe convertir negativos a binario !?
                return "Número inválido";
            }
        }

        private double BinarioADecimal(string valor)
        {
            int result = 0;
            int exponente = 0;

            for (int i = valor.Length - 1; i >= 0; i--)
            {
                if (valor[i] == '1')
                {
                    result += (int)Math.Pow(2, exponente);
                }
                exponente++;
            }

            return result;
        }
        public string ConvertirA(Esistema sistemaDestino)
        {
            if (sistemaDestino == Esistema.Binario)
            {
                return DecimalABinario((int)valorNumerico);//valor num es decimal
            }
            else
            {
                return valorNumerico.ToString();
            }
        }
        /*Dos numeraciones serán iguales si pertenecen al mismo sistema.
        • Un Sistema y una Numeración serán iguales, si el sistema es igual a sistema de la
        numeración;
        • Los operadores realizarán las operaciones correspondientes entre dos números.*/
        public static bool operator == (Esistema sistema, Numeracion num)
        {
            return sistema == num.Sistema;
        }
        public static bool operator !=(Esistema sistema, Numeracion num)
        {
            return !(sistema == num);
        }
        public static bool operator ==(Numeracion primerNumeracion, Numeracion segundaNumeracion)
        {
            return primerNumeracion.sistema == segundaNumeracion.sistema;
        }
        public static bool operator !=(Numeracion primerNumeracion, Numeracion segundaNumeracion)
        {
            return !(primerNumeracion.sistema == segundaNumeracion.sistema);
        }
        public static Numeracion operator +(Numeracion primerNumero, Numeracion segundoNumero)
        {
            double resultado = double.MinValue;
            if (primerNumero == segundoNumero)
            { 
                resultado = primerNumero.valorNumerico + segundoNumero.valorNumerico;
                return new Numeracion(resultado, primerNumero.sistema);
            }
            else
            {
                return new Numeracion(resultado, primerNumero.sistema);
            }
        }
        public static Numeracion operator -(Numeracion primerNumero, Numeracion segundoNumero)
        {
            double resultado = double.MinValue;
            if (primerNumero == segundoNumero && (segundoNumero.valorNumerico < primerNumero.valorNumerico && primerNumero.sistema != Esistema.Binario))
            {
                
                resultado = primerNumero.valorNumerico - segundoNumero.valorNumerico;
                return new Numeracion(resultado, primerNumero.Sistema);
            }
            else
            {
                return new Numeracion(resultado, primerNumero.Sistema);
            }
        }

        public static Numeracion operator *(Numeracion primerNumero, Numeracion segundoNumero)
        {
            double resultado = double.MinValue;
            if (primerNumero == segundoNumero)
            {

                resultado = primerNumero.valorNumerico * segundoNumero.valorNumerico;
                return new Numeracion(resultado, primerNumero.Sistema);
            }
            else
            {
                return new Numeracion(resultado, primerNumero.Sistema);
            }
        }

        public static Numeracion operator /(Numeracion primerNumero, Numeracion segundoNumero)
        {
            double resultado = double.MinValue;
            if (primerNumero == segundoNumero&& segundoNumero.valorNumerico != 0)
            {

                resultado = primerNumero.valorNumerico / segundoNumero.valorNumerico;
                return new Numeracion(resultado, primerNumero.Sistema);
            }
            else
            {
                return new Numeracion(resultado, primerNumero.Sistema);
            }
        }

    }


}