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

namespace ExemploHashQuadratico
{
    public partial class formsHashQuad : Form
    {
        static List<string> listaCampeoes;
        public formsHashQuad()
        {
            InitializeComponent();
            try
            {
                listaCampeoes = retornaLista(@"..\..\..\ChampsLol.txt");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro ao pegar a lista de nomes", MessageBoxButtons.OK);
            }
        }

        private List<string> retornaLista(string caminho)
        {
            StreamReader leitor = new StreamReader(caminho);
            List<string> lista = new List<string>();

            while (!leitor.EndOfStream)
                lista.Add(leitor.ReadLine());
            leitor.Close();

            return lista;
        }

        private void Exibir(DataGridView dgv, string[] lista)
        {
            dgv.Rows.Clear();

            for (int z = 0; z < lista.Length; z++)
                dgv.Rows.Add(z, lista[z]);
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            HashQuadratico<string> listaComHash = new HashQuadratico<string>((int)numTamanho.Value);
            string ocorrencias = "";
            for (int i = 0; i < listaCampeoes.Count; i++)
                ocorrencias += listaComHash.Incluir(listaCampeoes[i]);

            Exibir(dgvDados, listaComHash.GetLista());
            txtSaida.Clear();
            txtSaida.Text += ocorrencias;
            txtSaida.Text += listaComHash.ToString();
        }
    }
}
