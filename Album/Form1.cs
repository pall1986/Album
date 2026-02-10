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
                if (autori.Any(a => a.Nome == tBNome.Text && a.Cognome == tBCognome.Text))
                {
                    MessageBox.Show("Autore già presente!!");
                    return;
                }
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                cBListaArtisti.Items.Clear();
                foreach (Autore a in autori)
                {
                    cBListaArtisti.Items.Add(a.Nome + " " + a.Cognome);
                }
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                cBListaCantanti.Items.Clear();
                foreach (Album a in album)
                {
                    cBListaCantanti.Items.Add(a.Nome + " - " + a.Autore.Nome + " " + a.Autore.Cognome);
                }
            }
        }

        private void btInserisciAlbum_Click(object sender, EventArgs e)
        {
            if (tBAlbum.Text == "" || tBDataAlbum.Text == "" || cBListaArtisti.SelectedIndex == -1 || tBNTracce.Text == "")
            { MessageBox.Show("Inserisci tutti i campi!!"); }
            else
            {
                if (album.Any(a => a.Nome == tBAlbum.Text && a.Autore.Nome == autori.ElementAt(cBListaArtisti.SelectedIndex).Nome && a.Autore.Cognome == autori.ElementAt(cBListaArtisti.SelectedIndex).Cognome))
                {
                    MessageBox.Show("Album già presente!!");
                    return;
                }
                else
                {
                    Album a = new Album();
                    a.Nome = tBAlbum.Text;
                    a.Data = tBAlbum.Text;
                    a.Autore = autori.ElementAt(cBListaArtisti.SelectedIndex);
                    a.NumeroBrani = int.Parse(tBNTracce.Text);
                    album.AddLast(a);
                    MessageBox.Show("Album inserito correttamente!!");
                }
            }
        }
    }
}
