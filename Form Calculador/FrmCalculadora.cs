using Entidades;

namespace Form_Calculador
{
    public partial class FrmCalculadora : Form
    {
        private Operacion calculadora;
        private Numeracion primerOperando;
        private Numeracion resultado;
        private Numeracion segundoOperando;
        private Esistema sistema;

        public FrmCalculadora()
        {
            InitializeComponent();
        }
        //hacer limpieza de metodos del form
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {

        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void setResultado(object sender, PaintEventArgs e)
        {

        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}