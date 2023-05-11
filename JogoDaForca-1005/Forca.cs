using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca_1005
{
    public class Forca
    {
        public List<char> preenchimentoLetras;
        public string palavraSelecionada;
        public char palpiteJogador { get; set; }
        public int erros;

        public Forca()
        {
            this.palavraSelecionada = ObterPalavraSecreta();
            this.preenchimentoLetras = palavraSelecionada.ToList<char>();
            this.erros = 0;
        }

        public List<char> PreencherBrancoTela()
        {

            for (int i = 0; i < palavraSelecionada.Length; i++)
            {
                preenchimentoLetras[i] = '_';
            }
            return preenchimentoLetras;
        }
        public void VerificarPalpite(char palpite)
        {
            bool letraEncontrada = false;

            palavraSelecionada.ToList<char>();

            for (int i = 0; i < palavraSelecionada.Length; i++)
            {
                if (palpiteJogador == palavraSelecionada[i])
                {
                    preenchimentoLetras[i] = palpiteJogador;
                    letraEncontrada = true;
                }
            }
            if (letraEncontrada == false)
            {
                erros++;
            }

        }
        public bool VerificarVitoria()
        {
            string compararResultados = String.Join("", preenchimentoLetras);

            bool jogadorAcertou = compararResultados == palavraSelecionada.ToString();

            return jogadorAcertou;
        }
        public bool JogadorPerdeu()
        {
            return erros == 5;
        }

        public List<string> palavrasParaSortear = new List<string>
        {
            "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "AÇAÍ",
                "ARAÇA",
                "ABACATE",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJÁ",
                "CAJÚ",
                "CARAMBOLA",
                "CUPUAÇU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MAÇÃ",
                "MANGABA",
                "MANGA",
                "MARACUJÁ",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
        };
        private string ObterPalavraSecreta()
        {
            int indiceAleatorio = new Random().Next(palavrasParaSortear.Count);

            return palavrasParaSortear[indiceAleatorio];
        }

        //public void ResetarJogo()
        //{
        //    palavraSelecionada.

        //    preenchimentoLetras = palavraSelecionada.ToList<char>();

        //    erros = 0;

        //    preenchimentoLetras.Clear();

        //    PreencherBrancoTela();
        //}
    }
}
