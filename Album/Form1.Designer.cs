namespace Album
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tBInserisciArtista = new Button();
            tBCognome = new TextBox();
            tBNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            tBNTracce = new TextBox();
            label6 = new Label();
            btInserisciAlbum = new Button();
            tBDataAlbum = new TextBox();
            tBAlbum = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            cBListaArtisti = new ComboBox();
            tabPage3 = new TabPage();
            lBAlbumCantante = new ListBox();
            label7 = new Label();
            cBListaCantanti = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tBInserisciArtista);
            tabPage1.Controls.Add(tBCognome);
            tabPage1.Controls.Add(tBNome);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Inserimento Artista";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tBInserisciArtista
            // 
            tBInserisciArtista.Location = new Point(175, 157);
            tBInserisciArtista.Name = "tBInserisciArtista";
            tBInserisciArtista.Size = new Size(100, 22);
            tBInserisciArtista.TabIndex = 4;
            tBInserisciArtista.Text = "Inserisci Artista";
            tBInserisciArtista.UseVisualStyleBackColor = true;
            tBInserisciArtista.Click += tBInserisciArtista_Click;
            // 
            // tBCognome
            // 
            tBCognome.Location = new Point(175, 91);
            tBCognome.Name = "tBCognome";
            tBCognome.Size = new Size(100, 23);
            tBCognome.TabIndex = 3;
            // 
            // tBNome
            // 
            tBNome.Location = new Point(175, 49);
            tBNome.Name = "tBNome";
            tBNome.Size = new Size(100, 23);
            tBNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 91);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Cognome Artista";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 47);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome Artista";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tBNTracce);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(btInserisciAlbum);
            tabPage2.Controls.Add(tBDataAlbum);
            tabPage2.Controls.Add(tBAlbum);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(cBListaArtisti);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Inserimento Album Artista";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tBNTracce
            // 
            tBNTracce.Location = new Point(155, 173);
            tBNTracce.Name = "tBNTracce";
            tBNTracce.Size = new Size(100, 23);
            tBNTracce.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 181);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 10;
            label6.Text = "Numero Tracce";
            // 
            // btInserisciAlbum
            // 
            btInserisciAlbum.Location = new Point(135, 235);
            btInserisciAlbum.Name = "btInserisciAlbum";
            btInserisciAlbum.Size = new Size(108, 29);
            btInserisciAlbum.TabIndex = 9;
            btInserisciAlbum.Text = "Inserisci Album";
            btInserisciAlbum.UseVisualStyleBackColor = true;
            btInserisciAlbum.Click += btInserisciAlbum_Click;
            // 
            // tBDataAlbum
            // 
            tBDataAlbum.Location = new Point(157, 133);
            tBDataAlbum.Name = "tBDataAlbum";
            tBDataAlbum.Size = new Size(100, 23);
            tBDataAlbum.TabIndex = 8;
            // 
            // tBAlbum
            // 
            tBAlbum.Location = new Point(157, 86);
            tBAlbum.Name = "tBAlbum";
            tBAlbum.Size = new Size(100, 23);
            tBAlbum.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 136);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Data";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 94);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 5;
            label5.Text = "Nome Album";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 38);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 1;
            label3.Text = "Nome Artista";
            // 
            // cBListaArtisti
            // 
            cBListaArtisti.FormattingEnabled = true;
            cBListaArtisti.Location = new Point(146, 30);
            cBListaArtisti.Name = "cBListaArtisti";
            cBListaArtisti.Size = new Size(121, 23);
            cBListaArtisti.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lBAlbumCantante);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(cBListaCantanti);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Visualizzazione Album Artista";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lBAlbumCantante
            // 
            lBAlbumCantante.FormattingEnabled = true;
            lBAlbumCantante.ItemHeight = 15;
            lBAlbumCantante.Location = new Point(6, 57);
            lBAlbumCantante.Name = "lBAlbumCantante";
            lBAlbumCantante.Size = new Size(756, 334);
            lBAlbumCantante.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 23);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 3;
            label7.Text = "Nome Artista";
            // 
            // cBListaCantanti
            // 
            cBListaCantanti.FormattingEnabled = true;
            cBListaCantanti.Location = new Point(145, 15);
            cBListaCantanti.Name = "cBListaCantanti";
            cBListaCantanti.Size = new Size(121, 23);
            cBListaCantanti.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button tBInserisciArtista;
        private TextBox tBCognome;
        private TextBox tBNome;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btInserisciAlbum;
        private TextBox tBDataAlbum;
        private TextBox tBAlbum;
        private Label label4;
        private Label label5;
        private Label label3;
        private ComboBox cBListaArtisti;
        private TextBox tBNTracce;
        private Label label6;
        private Label label7;
        private ComboBox cBListaCantanti;
        private ListBox lBAlbumCantante;
    }
}
