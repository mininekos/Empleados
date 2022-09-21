namespace Empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario=Convert.ToDouble(txtSalario.Text),salarioDescuento;
            
            if (salario > 0) {
                if (radioGerente.Checked == true)
                {
                    salarioDescuento = salario * 0.8;

                    MessageBox.Show("El empleado es un gerente. Su salario bruto es de " +
                        salario + "€, le descuentan " + (salario - salarioDescuento)
                        + "€ y su final es de " + salarioDescuento + "€.");
                }
                else if (radioSubGerente.Checked == true)
                {
                    salarioDescuento = salario * 0.85;
                    MessageBox.Show("El empleado es un SubGerente. Su salario bruto es de " +
                        salario + "€, le descuentan " + (salario - salarioDescuento)
                        + "€ y su final es de " + salarioDescuento + "€.");
                }
                else if (radioSecretaria.Checked == true)
                {
                    salarioDescuento = salario * 0.95;
                    MessageBox.Show("El empleado es una secretaria. Su salario bruto es de " +
                        salario + "€, le descuentan " + (salario - salarioDescuento)
                        + "€ y su final es de " + salarioDescuento + "€."); ;
                }
            }
        }
    }
}