using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class frmJogoDaForca : Form
    {
        private string[] palavras;
        private string[] dicas;
        private int erros;
        private string palavraSec;
        private string palavraTela;

        public frmJogoDaForca()
        {
            InitializeComponent();
            iniciaVetores();
        }

        private void iniciaVetores()
        {
            palavras = new string[5];
            dicas = new string[5];

            palavras[0] = "PIPOCA";
            dicas[0] = "CINEMA";

            palavras[1] = "ENERGIA";
            dicas[1] = "LUZ";

            palavras[2] = "ONIBUS";
            dicas[2] = "TRASNPORTE";

            palavras[3] = "REFRIGERANTE";
            dicas[3] = "BEBIDA";

            palavras[4] = "FUTEBOL";
            dicas[4] = "ESPORTE";
        }
        private void iniciaJogo()
        {
            Random r = new Random();
            int posicao = r.Next(palavras.Length);
            palavraTela = "";
            erros = 0;
            palavraSec = palavras[posicao];
            lblDica.Text = dicas[posicao];

            for (int i = 0; i < palavraSec.Length; i++)
            {
                palavraTela = palavraTela + "#";
            }
            boxImagem.Image = Properties.Resources._0;
            lblPalavraSecreta.Text = palavraTela;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlGanhou.Visible = false;
            pnlInicio.Visible = false;
            pnlGameOver.Visible = false;
            restauraTeclas();
            pnlJogo.Visible = true;
            btnStart.Text = "Restart";
            iniciaJogo();
        }

        private void restauraTeclas()
        {
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
            btnE.Visible = true;
            btnF.Visible = true;
            btnG.Visible = true;
            btnH.Visible = true;
            btnI.Visible = true;
            btnJ.Visible = true;
            btnK.Visible = true;
            btnL.Visible = true;
            btnM.Visible = true;
            btnN.Visible = true;
            btnO.Visible = true;
            btnP.Visible = true;
            btnQ.Visible = true;
            btnR.Visible = true;
            btnS.Visible = true;
            btnT.Visible = true;
            btnU.Visible = true;
            btnV.Visible = true;
            btnX.Visible = true;
            btnW.Visible = true;
            btnY.Visible = true;
            btnZ.Visible = true;
        }

        private bool verificaLetra(string letra)
        {
            Boolean achou = false;
            char l = Convert.ToChar(letra);
            string text = "";
            for (int i = 0; i < palavraSec.Length; i++)
            {
                if (palavraSec[i] == l)
                {
                    achou = true;
                    text = text + l;
                }
                else
                {
                    text = text + palavraTela[i];
                }

            }
            palavraTela = text;
            return achou;
        }

        private void letra_select(object sender, EventArgs e)
        {
            if (erros < 6)
            {
                Button btnLetraEscolhida = sender as Button;
                btnLetraEscolhida.Visible = false;
                if (verificaLetra(btnLetraEscolhida.Text))
                {
                    lblPalavraSecreta.Text = palavraTela;
                    int mask = palavraTela.IndexOf("#");
                    if (mask == -1)
                    {
                        lblRevela.Text = palavraTela;
                        pnlGanhou.Visible = true;
                        pnlGameOver.Visible = false;
                        pnlInicio.Visible = false;
                        pnlJogo.Visible = false;

                    }

                }
                else
                {
                    //ALERTA DE ERRO
                    erros = erros + 1;
                    switch (erros)
                    {
                        case 1:
                            boxImagem.Image = Properties.Resources._1;
                            break;
                        case 2:
                            boxImagem.Image = Properties.Resources._2;
                            break;
                        case 3:
                            boxImagem.Image = Properties.Resources._3;
                            break;
                        case 4:
                            boxImagem.Image = Properties.Resources._4;
                            break;
                        case 5:
                            boxImagem.Image = Properties.Resources._5;
                            break;
                        case 6:
                            boxImagem.Image = Properties.Resources._6;
                            pnlJogo.Visible = false;
                            pnlGameOver.Visible = true;
                            break;
                    }
                }
            }


        }
    }
}
