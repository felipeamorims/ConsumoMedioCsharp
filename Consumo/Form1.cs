using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Consumo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Função que não deixa digitar nada além de números e um único ponto
        private void txtDistanciaKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            //Apenas permite digitar um único ponto
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        //Função que não deixa digitar nada além de números e um único ponto
        private void txtConsumoLitros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            //Apenas permite digitar um único ponto
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        //Validação das textbox
        public static bool verificaVazio(string texto_verificar)
        {
            if (texto_verificar == string.Empty) // Verifica se não digitou nada
            {
                return false;
            }
           
            if (Convert.ToDouble(texto_verificar) == 0) // Verifica se digitou zero
            {
                return false;
            }
            return true;
        }

        //Função Cadastro
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            double distancia = 0, consumo = 0, resultado = 0;
            

            if (verificaVazio(txtDistanciaKm.Text) == false || verificaVazio(txtConsumoLitros.Text) == false)
            {
                MessageBox.Show("Dados inválidos, digite os dados novamente.", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //Cálculo e mostrar resultado
                distancia = Double.Parse(txtDistanciaKm.Text);
                consumo = Double.Parse(txtConsumoLitros.Text);

                resultado = distancia / consumo;

                lblConsumoAtual.Text = "Consumo Atual: " + resultado.ToString("F1") + " Km/l"; // limitar numero de caracteres depois do ponto

                //Cadastro no Arquivo de texto
            
                using (StreamWriter writer = new StreamWriter("cadastroConsumo.txt", true))
                {
                   writer.WriteLine(txtDistanciaKm.Text+" Km");
                   writer.WriteLine(txtConsumoLitros.Text+" Litro(s)");
                   writer.WriteLine(lblConsumoAtual.Text);
                   writer.WriteLine("------------------------");
                   MessageBox.Show("Cadastro realizado com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
        }

        //Função Limpar Arquivo
        private void btnLimparArquivo_Click(object sender, EventArgs e)
        {            
            string sourceFile = @"C:\Users\claud\source\repos\Consumo\Consumo\bin\Debug\cadastroConsumo.txt";

            string[] lines;

            if (File.Exists(sourceFile))
            {
                lines = File.ReadAllLines(sourceFile);

                if (lines.Length == 0)
                {
                    MessageBox.Show("Seu arquivo está vazio!", "Limpar Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    using (StreamWriter writer = File.CreateText(sourceFile))
                    {
                        writer.Write(string.Empty);
                        writer.Close();
                        MessageBox.Show("Arquivo de cadastro limpo com sucesso!", "Limpar Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Arquivo de cadastro inexistente! Gere o arquivo através da função 'Cadastrar'.", "Arquivo Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Função Limpar Tela
        private void btnLimparTela_Click(object sender, EventArgs e)
        {
            txtConsumoLitros.Text = string.Empty;
            txtDistanciaKm.Text = string.Empty;
            lblConsumoAtual.Text = "Consumo Atual:";

        }

        //Função Fechar Programa
        private void btnFechar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Até Breve!", "Finalizando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
