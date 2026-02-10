namespace Album
{
    public partial class Form1 : Form
    {
        public class Autore
        {
            private string _nome;
            private string _cognome;
            public string Nome { get { return _nome; } set { _nome = value; } }
            public string Cognome { get { return _cognome; } set { _cognome = value; } }
        }
        public class Album
        {
            private string _nome;
            private string _data;
            private Autore _autore;
            private int _numeroBrani;
            public string Nome { get { return _nome; } set { _nome = value; } }
            public string Data { get { return _data; } set { _data = value; } }
            public Autore Autore { get { return _autore; } set { _autore = value; } }
            public int NumeroBrani { get { return _numeroBrani; } set { _numeroBrani = value; } }


        }
        LinkedList<Album> album = new LinkedList<Album>();
        LinkedList<Autore> autori = new LinkedList<Autore>();
        public Form1()
        {
            InitializeComponent();
        }

        private void tBInserisciArtista_Click(object sender, EventArgs e)
        {
            if (tBCognome.Text == "" || tBNome.Text == "")
            { MessageBox.Show("Inserisci tutti i campi!!"); }
            else
            {
                Autore a = new Autore();
                a.Nome = tBNome.Text;
                a.Cognome = tBCognome.Text;
                autori.AddLast(a);
                MessageBox.Show("Autore inserito correttamente!!");
            }
        }
    }
}
