namespace EmpleadosV2
{
    partial class Form1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.radioSecretaria = new System.Windows.Forms.RadioButton();
            this.radioSubGerente = new System.Windows.Forms.RadioButton();
            this.radioGerente = new System.Windows.Forms.RadioButton();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(189, 213);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(111, 26);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // radioSecretaria
            // 
            this.radioSecretaria.AutoSize = true;
            this.radioSecretaria.Location = new System.Drawing.Point(365, 143);
            this.radioSecretaria.Name = "radioSecretaria";
            this.radioSecretaria.Size = new System.Drawing.Size(76, 19);
            this.radioSecretaria.TabIndex = 14;
            this.radioSecretaria.TabStop = true;
            this.radioSecretaria.Text = "Secretaria";
            this.radioSecretaria.UseVisualStyleBackColor = true;
            // 
            // radioSubGerente
            // 
            this.radioSubGerente.AutoSize = true;
            this.radioSubGerente.Location = new System.Drawing.Point(214, 143);
            this.radioSubGerente.Name = "radioSubGerente";
            this.radioSubGerente.Size = new System.Drawing.Size(86, 19);
            this.radioSubGerente.TabIndex = 13;
            this.radioSubGerente.TabStop = true;
            this.radioSubGerente.Text = "SubGerente";
            this.radioSubGerente.UseVisualStyleBackColor = true;
            // 
            // radioGerente
            // 
            this.radioGerente.AutoSize = true;
            this.radioGerente.Location = new System.Drawing.Point(48, 143);
            this.radioGerente.Name = "radioGerente";
            this.radioGerente.Size = new System.Drawing.Size(66, 19);
            this.radioGerente.TabIndex = 12;
            this.radioGerente.TabStop = true;
            this.radioGerente.Text = "Gerente";
            this.radioGerente.UseVisualStyleBackColor = true;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(349, 64);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(107, 23);
            this.txtSalario.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Salario : ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 23);
            this.txtNombre.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 312);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.radioSecretaria);
            this.Controls.Add(this.radioSubGerente);
            this.Controls.Add(this.radioGerente);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcular;
        private RadioButton radioSecretaria;
        private RadioButton radioSubGerente;
        private RadioButton radioGerente;
        private TextBox txtSalario;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
    }
}