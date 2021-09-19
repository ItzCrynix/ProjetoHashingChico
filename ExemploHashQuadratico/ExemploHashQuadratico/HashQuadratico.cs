using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploHashQuadratico
{
    class HashQuadratico<Generico>
    {
        private Generico[] listaHash;
        const int tamanhoPadrao = 31;

        public HashQuadratico(int tamanho)
        {
            listaHash = new Generico[tamanho];
        }

        public int Hash(Generico dado)
        {
            string dadoTxt = dado.ToString();
            long ret = 0;
            for (int i = 0; i < dadoTxt.Length; i++)
                ret += ret * 7 + dadoTxt[i];

            return Math.Abs((int) (ret % listaHash.Length));
        }

        public string Incluir(Generico dado)
        {
            string resposta = "";
            int posicao;

            if (!Existe(dado, out posicao))
                listaHash[posicao] = dado;
            else if (Existe(dado, out posicao))
            {
                int pot = 1;
                while (listaHash[posicao] != null && Math.Abs(listaHash.Length - (posicao + pot * pot)) < listaHash.Length)
                {
                    resposta += $"Colisão na posição {posicao} de item : {listaHash[posicao]}" + Environment.NewLine;
                    int conta = posicao + pot * pot;
                    if (conta >= listaHash.Length)
                        posicao = Math.Abs(listaHash.Length - conta);
                    else
                        posicao = conta;

                    resposta += $"tentando nova posição : {posicao}" + Environment.NewLine;
                    pot++;
                }
                listaHash[posicao] = dado;
            }

            return resposta;
        }

        private bool Existe(Generico dado, out int pos)
        {
            pos = Hash(dado);
            if (listaHash[pos] == null)
                return false;
            else if (listaHash[pos].Equals(dado))
                return true;
            return true;
        }


        public Generico[] GetLista()
        {
            return listaHash;
        }

        public override string ToString()
        {
            string txt = "";
            int cont = 0;
            for (int i = 0; i < listaHash.Length; i++)
                if (listaHash[i] != null)
                {
                    txt += $"{i} : {listaHash[i]}" + Environment.NewLine;
                    cont++;
                }

            txt += $"A lista do hash possui {cont} elementos nela";

            return txt;
        }
    }
}
