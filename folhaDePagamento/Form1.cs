using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace folhaDePagamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            salarioBrutoTB.ReadOnly = true;
            valorInssTB.ReadOnly = true;
            impostoTB.ReadOnly = true;
            garantiaTB.ReadOnly = true;
            valeTransporteTB.ReadOnly = true;
            descontosTB.ReadOnly = true;
            salarioLiquidoTB.ReadOnly = true;

            salarioBrutoTB.TabStop = false;
            valorInssTB.TabStop = false;
            impostoTB.TabStop = false;
            garantiaTB.TabStop = false;
            valeTransporteTB.TabStop = false;
            descontosTB.TabStop = false;
            salarioLiquidoTB.TabStop = false;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void calculoGeralBTT_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = nomeTB.Text.Trim(); // Permite espaços no nome

                if (string.IsNullOrWhiteSpace(horasTB.Text) || string.IsNullOrWhiteSpace(valorHoraTB.Text))
                {
                    MessageBox.Show("Preencha todos os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convertendo os valores para decimal
                decimal horas, valorHora;
                if (!decimal.TryParse(horasTB.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out horas) ||
                    !decimal.TryParse(valorHoraTB.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out valorHora))
                {
                    MessageBox.Show("Insira valores numéricos válidos para as horas e o valor por hora!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cálculo do Salário Bruto
                decimal salarioBruto = horas * valorHora;
                salarioBrutoTB.Text = salarioBruto.ToString("C2", CultureInfo.CurrentCulture);

                // Cálculo do INSS
                decimal valorInss = 0;
                if (salarioBruto <= 1212.00m)
                    valorInss = salarioBruto * 0.075m;
                else if (salarioBruto <= 2427.35m)
                    valorInss = salarioBruto * 0.09m;
                else if (salarioBruto <= 3641.03m)
                    valorInss = salarioBruto * 0.12m;
                else
                    valorInss = salarioBruto * 0.14m;

                valorInssTB.Text = valorInss.ToString("C2", CultureInfo.CurrentCulture);

                // Cálculo do Imposto de Renda
                decimal imposto = 0;
                decimal salarioBase = salarioBruto; 

                if (salarioBase <= 1903.98m)
                    imposto = 0;
                else if (salarioBase >= 1903.99m && salarioBase <= 2826.65m)
                    imposto = (salarioBase * 0.075m);
                else if (salarioBase >= 2826.66m && salarioBase <= 3751.05m)
                    imposto = (salarioBase * 0.15m);
                else if (salarioBase >= 3751.06m && salarioBase <= 4664.68m)
                    imposto = (salarioBase * 0.225m);
                else
                    imposto = (salarioBase * 0.275m);

                impostoTB.Text = imposto.ToString("C2", CultureInfo.CurrentCulture);

                // Cálculo do FGTS (como desconto)
                decimal fundoDeGarantia = salarioBruto * 0.08m;
                garantiaTB.Text = fundoDeGarantia.ToString("C2", CultureInfo.CurrentCulture);

                // Cálculo do Vale Transporte (6%)
                decimal valeTransporte = salarioBruto * 0.06m;
                valeTransporteTB.Text = valeTransporte.ToString("C2", CultureInfo.CurrentCulture);

                // Cálculo dos descontos totais (incluindo FGTS)
                decimal totalDescontos = valorInss + imposto + valeTransporte + fundoDeGarantia;
                descontosTB.Text = totalDescontos.ToString("C2", CultureInfo.CurrentCulture);

                // Cálculo do Salário Líquido
                decimal salarioLiquido = salarioBruto - totalDescontos;
                salarioLiquidoTB.Text = salarioLiquido.ToString("C2", CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao calcular: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limparBTT_Click(object sender, EventArgs e)
        {
            nomeTB.Text = "";
            horasTB.Text = "";
            valorHoraTB.Text = "";

            salarioBrutoTB.Text = "";
            valorInssTB.Text = "";
            impostoTB.Text = "";
            garantiaTB.Text = "";
            valeTransporteTB.Text = "";
            descontosTB.Text = "";
            salarioLiquidoTB.Text = "";
        }

        private void horasTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                calculoGeralBTT_Click(sender, e);
            }
        }

        private void valorHoraTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                calculoGeralBTT_Click(sender, e);
            }
        }

        private void valeTransporteTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
