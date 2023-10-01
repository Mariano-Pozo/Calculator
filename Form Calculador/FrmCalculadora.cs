using Entidades;
using System;
using System.Windows.Forms;

namespace Form_Calculador
{
    public partial class FrmCalculadora : Form
    {
        private Operacion calculadora;
        private Numeracion primerOperando;
        private Numeracion resultado;
        private Numeracion segundoOperando;
        private Esistema sistema;
        private string operadorSeleccionado;

        public FrmCalculadora()
        {
            InitializeComponent();

            primerOperando = new Numeracion(0, Esistema.Decimal);
            resultado = new Numeracion(0, Esistema.Decimal);
            segundoOperando = new Numeracion(0, Esistema.Decimal);
            sistema = Esistema.Decimal;
            this.operadorSeleccionado = "+";

        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var operacion = cmbOperacion.SelectedItem.ToString();
            if (operacion != string.Empty)
            {
                operadorSeleccionado = operacion;
            }
            else
            {
                operadorSeleccionado = "+";
            }
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e) // no funciona actualizar
        {
            // cuadro de diálogo de confirmación
            DialogResult resultado = MessageBox.Show("¿Desea cerrar la calculadora?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario elige NO, cancela
            if (resultado == DialogResult.No)
            {
                e.Cancel = true; // evita que el formulario se cierre
            }
            // Si el usuario elige SI, se cerrará
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //borrará los datos de los TextBox, Label de resultado de la pantalla y
            //también asignará null al atributo resultado del
            //formulario.
            txtPrimerOperador.Clear();
            txtSegundoOperador.Clear();
            lblResultado.Text = "Resultado: ";
            primerOperando = null;
            segundoOperando = null;

        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            //aqui nada
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            sistema = Esistema.Binario;
            setResultado();
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            sistema = Esistema.Decimal;
            setResultado();
        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            primerOperando = new Numeracion(txtPrimerOperador.Text, Esistema.Decimal);
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            segundoOperando = new Numeracion(txtSegundoOperador.Text, Esistema.Decimal);
        }

        private void setResultado()
        //??
        {
            if (primerOperando is not null && segundoOperando is not null)
            {
                // Crear un objeto Operacion a partir de los valores de primerOperando y segundoOperando
                Operacion calculadora = new Operacion(primerOperando, segundoOperando);

                // Obtener el operador seleccionado desde el ComboBox (operacion)
                char operador = operadorSeleccionado != null ? operadorSeleccionado[0] : '+';


                // Realizar la operación
                Numeracion resultadoOperacion = calculadora.Operar(operador);

                // Mostrar el resultado en lblResultado, convertido según el sistema seleccionado
                lblResultado.Text = "Resultado: " + resultadoOperacion.ConvertirA(sistema);
            }
            else
            {
                // Si alguno de los operandos es nulo, muestra un mensaje de error
                lblResultado.Text = "Resultado: Error";
            }
        }

        private void lblPrimerOperador_Click(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click_1(object sender, EventArgs e)
        {
            //apreta el boton, genera objetos tipo numeracion, en base a los text box.
            setResultado();
            //a traves de OPERACION hacer la cuenta.
            //asignar resultado al label con set resultado
        }

        private void txtPrimerOperador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}