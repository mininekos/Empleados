namespace Empleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioGerente = new System.Windows.Forms.RadioButton();
            this.radioSubGerente = new System.Windows.Forms.RadioButton();
            this.radioSecretaria = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre : ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(337, 75);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(107, 23);
            this.txtSalario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salario : ";
            // 
            // radioGerente
            // 
            this.radioGerente.AutoSize = true;
            this.radioGerente.Location = new System.Drawing.Point(36, 154);
            this.radioGerente.Name = "radioGerente";
            this.radioGerente.Size = new System.Drawing.Size(66, 19);
            this.radioGerente.TabIndex = 4;
            this.radioGerente.TabStop = true;
            this.radioGerente.Text = "Gerente";
            this.radioGerente.UseVisualStyleBackColor = true;
            // 
            // radioSubGerente
            // 
            this.radioSubGerente.AutoSize = true;
            this.radioSubGerente.Location = new System.Drawing.Point(202, 154);
            this.radioSubGerente.Name = "radioSubGerente";
            this.radioSubGerente.Size = new System.Drawing.Size(86, 19);
            this.radioSubGerente.TabIndex = 5;
            this.radioSubGerente.TabStop = true;
            this.radioSubGerente.Text = "SubGerente";
            this.radioSubGerente.UseVisualStyleBackColor = true;
            // 
            // radioSecretaria
            // 
            this.radioSecretaria.AutoSize = true;
            this.radioSecretaria.Location = new System.Drawing.Point(353, 154);
            this.radioSecretaria.Name = "radioSecretaria";
            this.radioSecretaria.Size = new System.Drawing.Size(76, 19);
            this.radioSecretaria.TabIndex = 6;
            this.radioSecretaria.TabStop = true;
            this.radioSecretaria.Text = "Secretaria";
            this.radioSecretaria.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(177, 212);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(111, 26);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 285);
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

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtSalario;
        private Label label2;
        private RadioButton radioGerente;
        private RadioButton radioSubGerente;
        private RadioButton radioSecretaria;
        private Button btnCalcular;
    }
}