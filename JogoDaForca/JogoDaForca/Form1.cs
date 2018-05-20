using System;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class frmJogoDaForca : Form
    {
        #region "Variaveis"
        private string[] _palavras;
        private string[] _dicas;
        private int _erros;
        private string _palavraSec;
        private string _palavraTela;
        #endregion

        #region "Métodos"
        public frmJogoDaForca()
        {
            InitializeComponent();
            iniciaVetores();
        }

        private void iniciaVetores()
        {
            _palavras = new string[5];
            _dicas = new string[5];

            _palavras[0] = "PIPOCA";
            _dicas[0] = "CINEMA";

            _palavras[1] = "ENERGIA";
            _dicas[1] = "LUZ";

            _palavras[2] = "ONIBUS";
            _dicas[2] = "TRASNPORTE";

            _palavras[3] = "REFRIGERANTE";
            _dicas[3] = "BEBIDA";

            _palavras[4] = "FUTEBOL";
            _dicas[4] = "ESPORTE";
        }

        private void iniciaJogo()
        {
            Random r = new Random();
            int posicao = r.Next(_palavras.Length);
            _palavraTela = "";
            _erros = 0;
            _palavraSec = _palavras[posicao];
            lblDica.Text = _dicas[posicao];

            for (int i = 0; i < _palavraSec.Length; i++)
            {
                _palavraTela = _palavraTela + "#";
            }
            boxImagem.Image = Properties.Resources._0;
            lblPalavraSecreta.Text = _palavraTela;
        }

        private bool verificaLetra(string letra)
        {
            Boolean achou = false;
            char l = Convert.ToChar(letra);
            string text = "";
            for (int i = 0; i < _palavraSec.Length; i++)
            {
                if (_palavraSec[i] == l)
                {
                    achou = true;
                    text = text + l;
                }
                else
                {
                    text = text + _palavraTela[i];
                }

            }
            _palavraTela = text;
            return achou;
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
        #endregion

        #region "Eventos"
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

        private void letra_select(object sender, EventArgs e)
        {
            Button btnLetraEscolhida = sender as Button;
            btnLetraEscolhida.Visible = false;
            if (verificaLetra(btnLetraEscolhida.Text))
            {
                lblPalavraSecreta.Text = _palavraTela;
                int mask = _palavraTela.IndexOf("#");
                if (mask == -1)
                {
                    lblRevela.Text = _palavraTela;
                    pnlGanhou.Visible = true;
                    pnlGameOver.Visible = false;
                    pnlInicio.Visible = false;
                    pnlJogo.Visible = false;
                }
            }
            else
            {
                _erros = _erros + 1;
                switch (_erros)
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

        #endregion


    }
}
