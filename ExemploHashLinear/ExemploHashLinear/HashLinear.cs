using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploHashLinear
{
    class HashLinear<Generico>
    {
        private Generico[] listaHash;
        private const int tamanhoPadrao = 31;
        private string colisoes = "";

        public HashLinear()
        {
            this.listaHash = new Generico[tamanhoPadrao];
        }
        public HashLinear(int tamanho)
        {
            this.listaHash = new Generico[tamanho];
        }

        private int Hash(Generico chave)
        {
            long ret = 0;
            string txtChave = chave.ToString();

            for (int index = 0; index < txtChave.Length; index++)
            {
                ret += 7 * ret + ((int)txtChave[index]);
            }
            return (int) (ret % this.listaHash.Length);
        }

        public void Incluir(Generico chave)
        {
            int posicao;

            if (!Existe(chave, out posicao))
                this.listaHash[posicao] = chave;
            else
            {
                bool continua = true;
                int pos2 = posicao;
                colisoes += $"Encontrei um item na posição {posicao} : {this.listaHash[posicao]}" + Environment.NewLine;
                do
                {
                    posicao++;
                    if (posicao >= this.listaHash.Length)
                    {
                        posicao = 0;
                    }
                    else if (posicao == pos2)
                        continua = false;

                    colisoes += $"Pulando para a próxima posição: {posicao}" + Environment.NewLine;
                } while (this.listaHash[posicao] != null && continua);

                this.listaHash[posicao] = chave;
            }
        }
        

        private bool Existe(Generico chave, out int pos)
        {
            pos = Hash(chave);
            if (this.listaHash[pos] == null)
                return false;
            else if (this.listaHash[pos].Equals(chave))
                return true;
            return true;
        }

        public Generico[] GetLista()
        {
            return this.listaHash;
        }

        public string GetColisoes()
        {
            return this.colisoes;
        }
    }
}
