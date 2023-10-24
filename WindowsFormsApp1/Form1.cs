using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<Trabalho> Trabalhos { get; set; }

        public Form1()
        {
            Trabalhos = GetTrabalhos();
            carregarDados();
            InitializeComponent();
            this.MaximizeBox = false;
            this.Text = "Controle de tarefas";
            this.Icon = Properties.Resources.tarefa;
        }
        private void AtualizarDataGridView()
        {
            var trabalhos = this.Trabalhos.OrderBy(t => string.IsNullOrEmpty(t.nomeTrabalho)).ToList();
            dgvTrabalhos.DataSource = trabalhos;
        }
        private List<Trabalho> GetTrabalhos()
        {
            var list = new List<Trabalho>();
            list.Add(new Trabalho() { nomeTrabalho = "", dataTrabalho = "" });
            return list;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var Trabalhos = this.Trabalhos.OrderBy(t => string.IsNullOrEmpty(t.nomeTrabalho)).ToList();
            dgvTrabalhos.DataSource = Trabalhos;

            dgvTrabalhos.Columns["nomeTrabalho"].HeaderText = "Trabalho";
            dgvTrabalhos.Columns["dataTrabalho"].HeaderText = "Data Limite";

            foreach (DataGridViewColumn column in dgvTrabalhos.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.Resizable = DataGridViewTriState.False;
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNomeTarefa.Text) && !string.IsNullOrWhiteSpace(mskDataTrabalho.Text))
            {
                Trabalho novoTrabalho = new Trabalho
                {
                    nomeTrabalho = txtNomeTarefa.Text,
                    dataTrabalho = mskDataTrabalho.Text
                };
                Trabalhos.Add(novoTrabalho);

                dgvTrabalhos.DataSource = null;
                dgvTrabalhos.DataSource = Trabalhos;

                txtNomeTarefa.Text = string.Empty;
                mskDataTrabalho.Text = string.Empty;

                foreach (DataGridViewColumn column in dgvTrabalhos.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    column.Resizable = DataGridViewTriState.False;
                }

                dgvTrabalhos.Columns["nomeTrabalho"].HeaderText = "Trabalho";
                dgvTrabalhos.Columns["dataTrabalho"].HeaderText = "Data Limite";

                salvarDados();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarDataGridView();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            if (dgvTrabalhos.SelectedRows.Count > 0)
            {
                Trabalho trabalhoSelecionado = dgvTrabalhos.SelectedRows[0].DataBoundItem as Trabalho;

                if (trabalhoSelecionado != null && !string.IsNullOrWhiteSpace(trabalhoSelecionado.nomeTrabalho) && !string.IsNullOrWhiteSpace(trabalhoSelecionado.dataTrabalho))
                {
                    Trabalhos.Remove(trabalhoSelecionado);

                    AtualizarDataGridView();
                    salvarDados();
                }
                else
                {
                    MessageBox.Show("Não é possível remover uma linha vazia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione todas as linhas da coluna, para que ela seja removida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataGridViewColumn column in dgvTrabalhos.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.Resizable = DataGridViewTriState.False;
            }

            dgvTrabalhos.Columns["nomeTrabalho"].HeaderText = "Trabalho";
            dgvTrabalhos.Columns["dataTrabalho"].HeaderText = "Data Limite";
        }

        private void salvarDados()
        {
            using (StreamWriter sw = new StreamWriter("dados.txt"))
            {
                foreach (Trabalho trabalho in Trabalhos)
                {
                    string linha = $"{trabalho.nomeTrabalho};{trabalho.dataTrabalho}";
                    sw.WriteLine(linha);
                }
            }
        }

        private void carregarDados()
        {
            if (File.Exists("dados.txt"))
            {
                Trabalhos.Clear();

                using (StreamReader sr = new StreamReader("dados.txt"))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] valores = linha.Split(';');

                        if (valores.Length == 2)
                        {
                            Trabalhos.Add(new Trabalho() { nomeTrabalho = valores[0], dataTrabalho = valores[1] });
                        }
                        else
                        {
                            MessageBox.Show("O formato do arquivo está incorreto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("O arquivo especificado não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
