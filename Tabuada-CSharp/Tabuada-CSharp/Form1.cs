using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada_CSharp
{
    public partial class Form1 : Form
    {

        //Variável static global -> tabuadaEscolhida
        static int tabuadaEscolhida = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodo para Criar a Tabuada passando um valor como parametro
        private String CriarTabuada(int tabuada)
        {

            //Variável resultado
            String resultado = "";

            //qtdMax 
            //Contador
            //Calculo
            int qtdMax = 10, contador, calculo;

            //Se tabuadaEscolhida diferente ou igual 0 Então faça
            if (tabuadaEscolhida != 0)
            {
                for (contador = 1; contador <= qtdMax; contador++)
                {
                    calculo = tabuada * contador;

                    //Environment.NewLine = Obtém a cadeia de caracteres de nova linha ou quebra de linha.
                    resultado = resultado + tabuada + " X " + contador + " = " + calculo + Environment.NewLine;
                }
            }
            //Se não faça
            else
            {
                resultado = "";
            }

            return resultado;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodo para Exibir a Tabuada passando um valor como parametro
        public void ExibirTabuada(int valor)
        {
            lblExibirTabuada.Text = "";
            tabuadaEscolhida = valor;
            lblExibirTabuada.Text = CriarTabuada(tabuadaEscolhida);
            lblTituloTabuada.Text = "TABUADA " + tabuadaEscolhida;
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Evento ao Clicar
        //No botão btn01 até btn10

        //Botão Btn01 = (Tabuada 1)
        private void btn01_Click(object sender, EventArgs e)
        {
            ExibirTabuada(1);
        }

        //Botão Btn02 = (Tabuada 2)
        private void btn02_Click(object sender, EventArgs e)
        {
            ExibirTabuada(2);
        }

        //Botão Btn03 = (Tabuada 3)
        private void btn03_Click(object sender, EventArgs e)
        {
            ExibirTabuada(3);
        }

        //Botão Btn04 = (Tabuada 4)
        private void btn04_Click(object sender, EventArgs e)
        {
            ExibirTabuada(4);
        }

        //Botão Btn05 = (Tabuada 5)
        private void btn05_Click(object sender, EventArgs e)
        {
            ExibirTabuada(5);
        }

        //Botão Btn06 = (Tabuada 6)
        private void btn06_Click(object sender, EventArgs e)
        {
            ExibirTabuada(6);
        }

        //Botão Btn07 = (Tabuada 7)
        private void btn07_Click(object sender, EventArgs e)
        {
            ExibirTabuada(7);
        }

        //Botão Btn08 = (Tabuada 8)
        private void btn08_Click(object sender, EventArgs e)
        {
            ExibirTabuada(8);
        }

        //Botão Btn09 = (Tabuada 9)
        private void btn09_Click(object sender, EventArgs e)
        {
            ExibirTabuada(9);
        }

        //Botão Btn10 = (Tabuada 10)
        private void btn10_Click(object sender, EventArgs e)
        {
            ExibirTabuada(10);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodo exibir (Cursor da Mao) = Cursors.Hand
        //Ao entrar, sair de um btn = (Button)
        private void CursorMao(String valor, Button botao)
        {
            if (valor.Equals("SIM"))
            {
                //Ao entrar com o maouse = Cursor da mão
                this.Cursor = Cursors.Hand;
                botao.BackColor = Color.FromArgb(255, 182, 133);
                botao.Font = new Font("Microsoft Sans", 20.20F, System.Drawing.FontStyle.Bold);
                //Etc...
            }
            else
            {
                //Ao Sair com o maouse = Curso padrão
                this.Cursor = Cursors.Default;
                botao.BackColor = Color.FromArgb(48, 48, 48);
                botao.Font = new Font("Microsoft Sans", 18F, System.Drawing.FontStyle.Bold);
                //Etc...
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Botão Btn01 
        private void btn01_MouseEnter(object sender, EventArgs e)
        {
            CursorMao("SIM", btn01);
        }

        private void btn01_MouseLeave(object sender, EventArgs e)
        {
            CursorMao("NAO", btn01);
        }
        /////////////////////////////////////////////////////////
        //Botão Btn02 
        private void btn02_MouseEnter(object sender, EventArgs e)
        {
            CursorMao("SIM", btn02);
        }

        private void btn02_MouseLeave(object sender, EventArgs e)
        {
            CursorMao("NAO", btn02);
        }
        /////////////////////////////////////////////////////////
        //Botão Btn03
        private void btn03_MouseEnter(object sender, EventArgs e)
        {
            CursorMao("SIM", btn03);
        }

        private void btn03_MouseLeave(object sender, EventArgs e)
        {
            CursorMao("NAO", btn03);
        }
        /////////////////////////////////////////////////////////
        //Botão Btn04
        private void btn04_MouseEnter(object sender, EventArgs e)
        {
            CursorMao("SIM", btn04);
        }

        private void btn04_MouseLeave(object sender, EventArgs e)
        {
            CursorMao("NAO", btn04);
        }
        /////////////////////////////////////////////////////////
        //Botão Btn05
        private void btn05_MouseEnter(object sender, EventArgs e)
        {
            CursorMao("SIM", btn05);
        }

        private void btn05_MouseLeave(object sender, EventArgs e)
        {
            CursorMao("NAO", btn05);
        }
        /////////////////////////////////////////////////////////
        //Botão Btn06
        private void btn06_MouseEnter(object sender, EventArgs e)
        {
            CursorMao("SIM", btn06);
        }

        private void btn06_MouseLeave(object sender, EventArgs e)
        {
            CursorMao("NAO", btn06);
        }
        /////////////////////////////////////////////////////////
        //Botão Btn07
        private void btn07_MouseEnter(object sender, EventArgs e)
        {
            CursorMao("SIM", btn07);
        }

        private void btn07_MouseLeave(object sender, EventArgs e)
        {
            CursorMao("NAO", btn07);
        }
        /////////////////////////////////////////////////////////
        //Botão Btn08
        private void btn08_MouseEnter(object sender, EventArgs e)
        {
            CursorMao("SIM", btn08);
        }

        private void btn08_MouseLeave(object sender, EventArgs e)
        {
            CursorMao("NAO", btn08);
        }
        /////////////////////////////////////////////////////////
        //Botão Btn09
        private void btn09_MouseEnter(object sender, EventArgs e)
        {
            CursorMao("SIM", btn09);
        }

        private void btn09_MouseLeave(object sender, EventArgs e)
        {
            CursorMao("NAO", btn09);
        }
        /////////////////////////////////////////////////////////
        //Botão Btn10
        private void btn10_MouseEnter(object sender, EventArgs e)
        {
            CursorMao("SIM", btn10);
        }

        private void btn10_MouseLeave(object sender, EventArgs e)
        {
            CursorMao("NAO", btn10);
        }

        //FIM
    }
}
