using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Malthus_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public RichTextBox txt_thenumbersmason = new RichTextBox();

        private void button1_Click(object sender, EventArgs e)
        {
            /*Explicando como funciona a conta:
             - Primeiro, aumentamos a população pela PG.
             - Segundo, Aumentamos a taxa de alimentos pela 
             segunda PG.
             - Descontamos então dos alimentos o consumo médio
             de cada pessoa viva.
             - O ano "aumenta" em um.
             - Se os alimentos não acabaram, então a conta
             continua para o próximo ano (tudo denovo).*/


            bool testatudo = true;
            Form1.ActiveForm.Height = 440;
            Controls.Remove(txt_thenumbersmason);
            //Verifica se todos os campos estão preenchidos
            if (fld_populac.Text == "")
            {
                testatudo = false;
                MessageBox.Show("Digite um campo para a população!");
            }
            else if (fld_alimnt.Text == "")
            {
                MessageBox.Show("Digite um campo para a quantidade de alimento!");
                testatudo = false;
            }
            else if (fld_cnsum.Text == "")
            {
                MessageBox.Show("Digite um campo para o consumo por pessoa!");
                testatudo = false;
            }
            else if (fld_crescpop.Text == "")
            {
                MessageBox.Show("Digite um campo para o crescimento populacional!");
                testatudo = false;
            }
            else if (fld_crescalim.Text == "")
            {
                MessageBox.Show("Digite um campo para a taxa de alimentos!");
                testatudo = false;
            }
            //Fim dos testes de campo, agora faz a conta.

            txt_thenumbersmason.Text = "";
            if (testatudo == true)
            {
                double populacao = double.Parse(fld_populac.Text);
                double alimento = double.Parse(fld_alimnt.Text);
                double consumo = double.Parse(fld_cnsum.Text) * 1000;
                double cresc_pop = double.Parse(fld_crescpop.Text) / 100;
                double cresc_alim = double.Parse(fld_crescalim.Text);
                int ano = 1;
                Form1.ActiveForm.Height = 570;
                
                //pra mostrar os bag
                Controls.Add(txt_thenumbersmason);
                Math.Round(populacao, 3);
                while (alimento > 0 && ano < 300)
                {
                    txt_thenumbersmason.Text += "Ano " + ano + "\nPopulação: " + populacao + " mil\nAlimentos disponíveis (T): "+alimento + "\n\n";
                    populacao *= 1 + cresc_pop;

                    //confere decimais
                    string[] words = (populacao.ToString()).Split(',');
                    if (words.Length > 1 && words[1].Length > 3)
                    {
                        words[1] = words[1].Substring(0, 3);
                        populacao = double.Parse(words[0] + ',' + words[1]);
                    }//ACABA DE CONFERIR

                    alimento += cresc_alim;
                    alimento -= populacao * consumo;
                    
                    //alimento não é negativo
                    if (alimento < 0)
                        alimento = 0;

                    ano++;

                }
                txt_thenumbersmason.Text += "Ano " + ano + "\nPopulação: " + populacao + " mil\nAlimentos disponíveis (T): " + alimento + "\n\n";
                    
                
                if (alimento == 0)
                    MessageBox.Show("A população viverá " + ano + " anos segundo a teoria.");
                else
                    MessageBox.Show("Em 300 anos, as técnicas de produção\nestarão avançadas o suficiente\npara a sobrevivência humana.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fld_alimnt.Enabled = fld_cnsum.Enabled = fld_crescalim.Enabled = fld_crescpop.Enabled = fld_populac.Enabled = true;
            fld_alimnt.Clear();
            fld_cnsum.Clear();
            fld_crescalim.Clear();
            fld_crescpop.Clear();
            fld_populac.Clear();
            cb_dadosreais.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //pergunta se vai sair 0: <
            if (MessageBox.Show("Deseja realmente sair?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
            else { }
        }

        private void cb_dadosreais_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_dadosreais.Checked == true)
            {
                fld_alimnt.Enabled = fld_cnsum.Enabled = fld_crescalim.Enabled = fld_crescpop.Enabled = fld_populac.Enabled = false;
                fld_populac.Text = "165000";
                fld_alimnt.Text = "1070000000";
                fld_cnsum.Text = "0,95";
                fld_crescpop.Text = "0,9";
                fld_crescalim.Text = "68000000";
            }
            else
                button2_Click(sender, e);
        }

        private void cb_dadosreais_MouseHover(object sender, EventArgs e)
        {
            ToolTip resposta = new ToolTip();
            resposta.ShowAlways = true;
            resposta.AutoPopDelay = 5000;
            resposta.InitialDelay = 100;
            resposta.ReshowDelay = 500;

            resposta.SetToolTip(cb_dadosreais, "Dados aproximados para 12 anos de sobrevivência.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_thenumbersmason.Location = new Point(15, 391);
            txt_thenumbersmason.Height = 134;
            txt_thenumbersmason.Width = 384;
            txt_thenumbersmason.Font = new Font("Arial", 12);
        }

        private void fld_populac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                e.Handled = true;
        }

        private void fld_alimnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                e.Handled = true;
        }

        private void fld_cnsum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                e.Handled = true;
        }
        
        private void fld_crescalim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                e.Handled = true;
        }

        private void fld_crescpop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                e.Handled = true;
        }

        private void fld_populac_TextChanged(object sender, EventArgs e)
        {
            if (fld_populac.Text == ",")
                fld_populac.Text = "0";
            
            string[] words = fld_populac.Text.Split(',');
            if (words.Length > 1)
                fld_populac.Text = words[0] + ',' + words[1];

            if (fld_populac.Text != "")
                fld_populac.Text = (Math.Round(double.Parse(fld_populac.Text), 3)).ToString();
        }

        private void fld_alimnt_TextChanged(object sender, EventArgs e)
        {
            if (fld_alimnt.Text == ",")
                fld_alimnt.Text = "0";

            string[] words = fld_alimnt.Text.Split(',');
            if (words.Length > 1)
                fld_alimnt.Text = words[0] + ',' + words[1];
        }

        private void fld_cnsum_TextChanged(object sender, EventArgs e)
        {
            if (fld_cnsum.Text == ",")
                fld_cnsum.Text = "0";

            string[] words = fld_cnsum.Text.Split(',');
            if (words.Length > 1)
                fld_cnsum.Text = words[0] + ',' + words[1];
        }

        private void fld_crescpop_TextChanged(object sender, EventArgs e)
        {
            if (fld_crescpop.Text == ",")
                fld_crescpop.Text = "0";

            string[] words = fld_crescpop.Text.Split(',');
            if (words.Length > 1)
                fld_crescpop.Text = words[0] + ',' + words[1];
        }

        private void fld_crescalim_TextChanged(object sender, EventArgs e)
        {
            if (fld_crescalim.Text == ",")
                fld_crescalim.Text = "0";

            string[] words = fld_crescalim.Text.Split(',');
            if (words.Length > 1)
                fld_crescalim.Text = words[0] + ',' + words[1];
        }
    }
}
