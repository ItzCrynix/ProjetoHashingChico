using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploHashDuplo
{
    class HashDuplo
    {
        static private int tamanhoPadrao = 31;
        private string[] lista;
        
        public HashDuplo(int tamanho)
        {
            lista = new string[tamanho];
        }
        public HashDuplo()
        {
            lista = new string[tamanhoPadrao];
        }

        private int Hash(string chave)
        {
                long tot = 0;
                for (int i = 0; i < chave.Length; i++)
                {
                    tot = 11 * tot + (int)chave.ToString()[i];
                }

                return Math.Abs((int) (tot % lista.Length));
        }
        private int Hash2(string chave)
        {
            long tot = 0;
            for (int i = 0; i < chave.Length; i++)
            {
                tot += 11 * tot + (int)chave.ToString()[i];
            }

            return Math.Abs(7 - (int) (tot % 7));
        }

        public string Incluir(List<string> listaDado)
        {
            string resposta = "";
            for (int i = 0; i < listaDado.Count; i++)
            {
                int pos;

                if (Existe(listaDado[i], out pos))
                {
                    int pos2 = pos;
                    int pot = 1;
                    while (pos2 < lista.Length)
                    {
                        if (lista[pos] != null)
                        {
                            resposta += $"Encontrei um valor ja posicionado em {pos2} : {lista[pos2]}" + Environment.NewLine;
                            pos = pos2;
                            pos2 = Hash2(listaDado[i]) * pot;
                            resposta += $" Mudando para posição {pos2}" + Environment.NewLine + Environment.NewLine;
                            pot *= 2;
                        }
                        else break;
                    }
                }  

                lista[pos] = listaDado[i];
            }

            return resposta;
        }

        public bool Existe(string chave, out int posicao)
        {
            posicao = Hash(chave);
            return lista[posicao] != null;
        }

        public List<string> getLista()
        {
            return new List<string>(lista);
        }

        public string Listar(List<string> listaDados)
        {
            string ret = "";
            for (int i = 0; i < listaDados.Count; i++)
            {
                int pos;
                if (Existe(listaDados[i], out pos))
                    ret += $"{pos} : {listaDados[i]}" + Environment.NewLine;
            }
            return ret;
        }
    }
}