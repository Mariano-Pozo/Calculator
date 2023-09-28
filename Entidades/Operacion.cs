using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }
        public Numeracion PrimerOperando
        {
            get
            {
                return primerOperando;
            }
            set
            {
                primerOperando = value;
            }
        }

        public Numeracion SegundoOperando
        {
            get
            {
                return segundoOperando;
            }
            set
            {
                segundoOperando = value;
            }
        }

        public Numeracion Operar(char operador)
        {
            Numeracion resultado;
            
            if (operador == '-')
            {
                resultado = primerOperando - segundoOperando;
            }
            else if(operador == '*')
            {
                resultado = primerOperando * segundoOperando;
            }
            else if (operador == '/')
            {
                resultado = primerOperando / segundoOperando;
            }
            else
            {
                resultado = primerOperando + segundoOperando;
            }
            return resultado;
        }

    }     
}
