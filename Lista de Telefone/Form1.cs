using BLL;
namespace Lista_de_Telefone
{
    public partial class Form1 : Form
    {
        public Repositorio Repositorio { get; set; } = new Repositorio();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bsTelefone.DataSource = Repositorio;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
           Telefone telefone = new Telefone();
            telefone.Nome = "Um nome ai";

            telefone.Numero = 40028922;
            telefone.Endereco = "Rua do carinha que mora logo ali.";

            Repositorio.Incluir(telefone);
            bsTelefone.ResetBindings(false);
        }
    }
}