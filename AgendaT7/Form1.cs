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

namespace AgendaT7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Contato[] contatos = new Contato[1];

        private void Escrever(Contato contato)
        {
            StreamWriter escreveContatos = new StreamWriter("Contatos.txt");
            escreveContatos.WriteLine(contatos.Length + 1);
            escreveContatos.WriteLine(contato.Nome);
            escreveContatos.WriteLine(contato.Sobrenome);
            escreveContatos.WriteLine(contato.Telefone);

            for (int bazinga = 0; bazinga < contatos.Length; bazinga++)           
            {
                escreveContatos.WriteLine(contatos[bazinga].Nome);
                escreveContatos.WriteLine(contatos[bazinga].Sobrenome);
                escreveContatos.WriteLine(contatos[bazinga].Telefone);
            }
            escreveContatos.Close();
        }

        private void Ler()
        {
            StreamReader leContatos = new StreamReader("Contatos.txt");
            contatos = new Contato[Convert.ToInt32(leContatos.ReadLine())];

            for (int bazinga = 0; bazinga < contatos.Length; bazinga++)
            {
                contatos[bazinga] = new Contato();
                contatos[bazinga].Nome = leContatos.ReadLine();
                contatos[bazinga].Sobrenome = leContatos.ReadLine();
                contatos[bazinga].Telefone = leContatos.ReadLine();
            }
            leContatos.Close();
        }

        private void Mostrar()
        {
            listBoxContatos.Items.Clear();
            for (int bazinga = 0; bazinga < contatos.Length; bazinga++)
            {
                listBoxContatos.Items.Add(contatos[bazinga].ToString());
            }
        }

        private void Apagar()
        { 
            textBoxNome.Text = String.Empty;
            textBoxSobrenome.Text = String.Empty;
            textBoxTelefone.Text = String.Empty;
        }

        private void buttonAdCon_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.Nome = textBoxNome.Text;
            contato.Sobrenome = textBoxSobrenome.Text;
            contato.Telefone = textBoxTelefone.Text;

            //listBoxContatos.Items.Add(contato.ToString());

            Escrever(contato);
            Ler();
            Mostrar();
            Apagar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ler();
            Mostrar();
        }
    }
}
