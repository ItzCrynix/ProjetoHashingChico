using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExemploHashLinear
{
    public partial class formsHashLinear : Form
    {
        static List<string> listaCampeoes;
        public formsHashLinear()
        {
            InitializeComponent();
            listaCampeoes = GetArquivo(@"..\..\..\ChampsLol.txt");
        }

        private void Exibir(DataGridView dgv, string[] lista)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < lista.Length; i++)
            {
                dgv.Rows.Add(i, lista[i]);
            }
        }

        private List<string> GetArquivo(string caminho)
        {
            List<string> ret = new List<string>();
            StreamReader leitor = new StreamReader(caminho);

            while (!leitor.EndOfStream)
                ret.Add(leitor.ReadLine());
            leitor.Close();

            return ret;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            HashLinear<string> listaComHash = new HashLinear<string>((int)numTamanho.Value);
            for (int i = 0; i < listaCampeoes.Count; i++)
                listaComHash.Incluir(listaCampeoes[i]);

            Exibir(dgvLista, listaComHash.GetLista());
            txtSaida.Clear();
            txtSaida.Text += listaComHash.GetColisoes();
            txtSaida.Text += Environment.NewLine + $"Essa lista tem {listaCampeoes.Count} elementos";
        }
    }
}
