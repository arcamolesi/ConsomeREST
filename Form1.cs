using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace ConsomeREST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.id = -1;
            aluno.nome = txtNome.Text;
            aluno.disciplina = txtDisciplina.Text;
            aluno.nota1 = Convert.ToSingle(txtNota1.Text);
            aluno.nota2 = Convert.ToSingle(txtNota2.Text);


            if (aluno != null)
            {
                using (var client = new HttpClient())
                {
                    // client.BaseAddress = new Uri("https://localhost:7237/api/Produtos");
                    //HTTP POST
                    string url = "https://localhost:7237/api/Alunos";
                    aluno.id = 0;
                    var dataAsString = JsonConvert.SerializeObject(aluno);
                    var content = new StringContent(dataAsString);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var postTask = client.PostAsync(url, content);

                    postTask.Wait();


                    var result = postTask.Result;

                }
                button2_Click_1(null, null);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            IEnumerable<Aluno> alunos = null;


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7237/api/Alunos");

                //HTTP GET
                var responseTask = client.GetAsync("alunos");
                responseTask.Wait();
                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadFromJsonAsync<IList<Aluno>>();
                    readTask.Wait();
                    alunos = readTask.Result;
                }
                else
                {
                    alunos = Enumerable.Empty<Aluno>();
                }
            }
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = alunos;

        }
    }
}
