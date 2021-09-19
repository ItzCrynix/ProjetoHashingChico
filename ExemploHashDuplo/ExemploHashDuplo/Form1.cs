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

namespace ExemploHashDuplo
{
    public partial class FormsHashDuplo : Form
    {

        static List<string> listaCampeao;
        static HashDuplo listaHash;

        public FormsHashDuplo()
        {
            InitializeComponent();
        }

        static List<string> AddCampeoes()
        {
            StreamReader campeoes = new StreamReader(@"..\..\..\ChampsLol.txt");
            List<string> ret = new List<string>();

            while (!campeoes.EndOfStream)
                ret.Add(campeoes.ReadLine());

            campeoes.Close();

            return ret;
        }

        static void Exibir(DataGridView dgv, List<string> listinha)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < listinha.Count; i++)
            {
                dgv.Rows.Add(i, listinha[i]);
            }
        }

        private void FormsHashDuplo_Load(object sender, EventArgs e)
        {

        }

        private void btnCriaLista_Click(object sender, EventArgs e)
        {
            try
            {
                listaCampeao = AddCampeoes();
                listaHash = new HashDuplo((int)numTamanho.Value);
                
                txtOcorrencias.Text += "Ocorrências de Colisões:" + Environment.NewLine + listaHash.Incluir(listaCampeao);
                txtOcorrencias.Text += "Listagem dos objetos:" + Environment.NewLine + listaHash.Listar(listaCampeao);
                
                Exibir(dgvLista, listaHash.getLista());
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }
    }
}
