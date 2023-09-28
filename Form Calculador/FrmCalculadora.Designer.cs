namespace Form_Calculador
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            cmbOperacion = new ComboBox();
            lblResultado = new Label();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            txtPrimerOperador = new TextBox();
            txtSegundoOperador = new TextBox();
            panel1 = new Panel();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Location = new Point(290, 200);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(206, 100);
            grpSistema.TabIndex = 2;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            grpSistema.Enter += groupBox1_Enter;
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(100, 61);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 13;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(6, 61);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 12;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { " ", "+", "-", "*", "/" });
            cmbOperacion.Location = new Point(317, 344);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(142, 23);
            cmbOperacion.TabIndex = 7;
            cmbOperacion.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(12, 62);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(237, 59);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado:";
            lblResultado.Click += label1_Click;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(107, 320);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(142, 21);
            lblPrimerOperador.TabIndex = 3;
            lblPrimerOperador.Text = "Primer Operador:";
            lblPrimerOperador.Click += label2_Click;
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacion.Location = new Point(317, 320);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(93, 21);
            lblOperacion.TabIndex = 4;
            lblOperacion.Text = "Operacion:";
            lblOperacion.Click += label3_Click;
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(533, 320);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(159, 21);
            lblSegundoOperador.TabIndex = 5;
            lblSegundoOperador.Text = "Segundo Operador:";
            lblSegundoOperador.Click += label4_Click;
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(107, 395);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(142, 43);
            btnOperar.TabIndex = 9;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(317, 395);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(142, 43);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(533, 395);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(142, 43);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Location = new Point(107, 344);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(142, 23);
            txtPrimerOperador.TabIndex = 6;
            txtPrimerOperador.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Location = new Point(533, 344);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(142, 23);
            txtSegundoOperador.TabIndex = 8;
            txtSegundoOperador.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // panel1
            // 
            panel1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(290, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 117);
            panel1.TabIndex = 1;
            panel1.Paint += setResultado;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(txtSegundoOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(lblResultado);
            Controls.Add(cmbOperacion);
            Controls.Add(grpSistema);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Mariano Pozo";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpSistema;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private ComboBox cmbOperacion;
        private Label lblResultado;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private TextBox txtPrimerOperador;
        private TextBox txtSegundoOperador;
        private Panel panel1;
    }
}