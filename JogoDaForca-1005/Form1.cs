using JogoDaForca_1005.Properties;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;

namespace JogoDaForca_1005
{
    public partial class Form1 : Form
    {
        public char palpite;

        Forca forca = new Forca();

        public Form1()
        {

            InitializeComponent();

            forca.PreencherBrancoTela();

            MostrarImagemErro();

            btnA.Click += ReceberPalpite!;
            btnB.Click += ReceberPalpite!;
            btnC.Click += ReceberPalpite!;
            btnD.Click += ReceberPalpite!;
            btnE.Click += ReceberPalpite!;
            btnF.Click += ReceberPalpite!;
            btnG.Click += ReceberPalpite!;
            btnH.Click += ReceberPalpite!;
            btnI.Click += ReceberPalpite!;
            btnJ.Click += ReceberPalpite!;
            btnK.Click += ReceberPalpite!;
            btnL.Click += ReceberPalpite!;
            btnM.Click += ReceberPalpite!;
            btnN.Click += ReceberPalpite!;
            btnO.Click += ReceberPalpite!;
            btnP.Click += ReceberPalpite!;
            btnQ.Click += ReceberPalpite!;
            btnR.Click += ReceberPalpite!;
            btnS.Click += ReceberPalpite!;
            btnT.Click += ReceberPalpite!;
            btnU.Click += ReceberPalpite!;
            btnV.Click += ReceberPalpite!;
            btnX.Click += ReceberPalpite!;
            btnW.Click += ReceberPalpite!;
            btnY.Click += ReceberPalpite!;
            btnZ.Click += ReceberPalpite!;
            btnÇ.Click += ReceberPalpite!;

        }
        public void VerificarVitoria()
        {
            bool ehVitoria = forca.VerificarVitoria();

            if (ehVitoria)
            {
                MessageBox.Show($"Parabéns! Você acertou a palavra {forca.palavraSelecionada}");
                //forca.ResetarJogo();
            }
            else if (forca.JogadorPerdeu())
            {
                MessageBox.Show($"Você perdeu! A palavra correta é {forca.palavraSelecionada}");
                //forca.ResetarJogo();
            }

        }
        public string ApresentarEspacos()
        {
            string nomeTela = String.Join(" ", forca.preenchimentoLetras);

            return txtMostrarEspacos.Text = nomeTela;
        }
        public void ReceberPalpite(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            forca.palpiteJogador = Convert.ToChar(button.Text);

            AtribuirLetras();

            VerificarVitoria();
        }
        private void AtribuirLetras()
        {
            forca.VerificarPalpite(forca.palpiteJogador);

            listBoxLetrasDigitadas.Items.Add(forca.palpiteJogador.ToString());

            ApresentarEspacos();

            MostrarImagemErro();
        }
        private void MostrarImagemErro()
        {
            pictureBox2.Image = imageListForcaBreja.Images[forca.erros];
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void mensagem1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void listBoxLetrasDigitadas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void btnTesteImagem_Click(object sender, EventArgs e)
        {

        }
    }
}