namespace managerPaczek
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnZapisz = new Button();
            txtCena = new TextBox();
            txtWaga = new TextBox();
            txtOdbiorca = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Cena = new Label();
            label4 = new Label();
            cmbStatus = new ComboBox();
            label3 = new Label();
            cmbTyp = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtSymbolPaczkomatu = new TextBox();
            txtNrDomu = new TextBox();
            txtUlica = new TextBox();
            txtNrMieszkania = new TextBox();
            txtKodPocztowy = new TextBox();
            txtMiejscowosc = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtNadawca = new TextBox();
            SuspendLayout();
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(614, 276);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(94, 29);
            btnZapisz.TabIndex = 0;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += button1_Click;
            // 
            // txtCena
            // 
            txtCena.Location = new Point(177, 176);
            txtCena.Name = "txtCena";
            txtCena.Size = new Size(125, 27);
            txtCena.TabIndex = 2;
            txtCena.Leave += txtCena_Leave;
            // 
            // txtWaga
            // 
            txtWaga.Location = new Point(177, 131);
            txtWaga.Name = "txtWaga";
            txtWaga.Size = new Size(125, 27);
            txtWaga.TabIndex = 3;
            // 
            // txtOdbiorca
            // 
            txtOdbiorca.Location = new Point(177, 82);
            txtOdbiorca.Name = "txtOdbiorca";
            txtOdbiorca.Size = new Size(125, 27);
            txtOdbiorca.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.IBeam;
            label1.Location = new Point(81, 85);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 5;
            label1.Text = "Odbiorca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 135);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 6;
            label2.Text = "Waga";
            // 
            // Cena
            // 
            Cena.AutoSize = true;
            Cena.Location = new Point(81, 183);
            Cena.Name = "Cena";
            Cena.Size = new Size(42, 20);
            Cena.TabIndex = 7;
            Cena.Text = "Cena";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 229);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 8;
            label4.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(177, 229);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 9);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 10;
            label3.Text = "Typ przesyłki";
            // 
            // cmbTyp
            // 
            cmbTyp.FormattingEnabled = true;
            cmbTyp.Location = new Point(180, 9);
            cmbTyp.Name = "cmbTyp";
            cmbTyp.Size = new Size(151, 28);
            cmbTyp.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 280);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 12;
            label5.Text = "Symbol Paczkomatu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 47);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 13;
            label6.Text = "Ulica";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(392, 85);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 14;
            label7.Text = "numer domu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(392, 134);
            label8.Name = "label8";
            label8.Size = new Size(128, 20);
            label8.TabIndex = 15;
            label8.Text = "numer mieszkania";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(392, 176);
            label9.Name = "label9";
            label9.Size = new Size(102, 20);
            label9.TabIndex = 16;
            label9.Text = "kod pocztowy";
            // 
            // txtSymbolPaczkomatu
            // 
            txtSymbolPaczkomatu.Location = new Point(241, 273);
            txtSymbolPaczkomatu.Name = "txtSymbolPaczkomatu";
            txtSymbolPaczkomatu.Size = new Size(125, 27);
            txtSymbolPaczkomatu.TabIndex = 17;
            // 
            // txtNrDomu
            // 
            txtNrDomu.Location = new Point(519, 85);
            txtNrDomu.Name = "txtNrDomu";
            txtNrDomu.Size = new Size(125, 27);
            txtNrDomu.TabIndex = 18;
            // 
            // txtUlica
            // 
            txtUlica.Location = new Point(519, 47);
            txtUlica.Name = "txtUlica";
            txtUlica.Size = new Size(125, 27);
            txtUlica.TabIndex = 20;
            // 
            // txtNrMieszkania
            // 
            txtNrMieszkania.Location = new Point(519, 132);
            txtNrMieszkania.Name = "txtNrMieszkania";
            txtNrMieszkania.Size = new Size(125, 27);
            txtNrMieszkania.TabIndex = 21;
            // 
            // txtKodPocztowy
            // 
            txtKodPocztowy.Location = new Point(519, 173);
            txtKodPocztowy.Name = "txtKodPocztowy";
            txtKodPocztowy.Size = new Size(125, 27);
            txtKodPocztowy.TabIndex = 22;
            // 
            // txtMiejscowosc
            // 
            txtMiejscowosc.Location = new Point(519, 210);
            txtMiejscowosc.Name = "txtMiejscowosc";
            txtMiejscowosc.Size = new Size(125, 27);
            txtMiejscowosc.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(392, 217);
            label10.Name = "label10";
            label10.Size = new Size(93, 20);
            label10.TabIndex = 24;
            label10.Text = "miejscowość";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(81, 51);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 25;
            label11.Text = "nadawca";
            // 
            // txtNadawca
            // 
            txtNadawca.Location = new Point(180, 44);
            txtNadawca.Name = "txtNadawca";
            txtNadawca.Size = new Size(125, 27);
            txtNadawca.TabIndex = 26;
            //txtNadawca.TextChanged += textBox1_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNadawca);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtMiejscowosc);
            Controls.Add(txtKodPocztowy);
            Controls.Add(txtNrMieszkania);
            Controls.Add(txtUlica);
            Controls.Add(txtNrDomu);
            Controls.Add(txtSymbolPaczkomatu);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbTyp);
            Controls.Add(label3);
            Controls.Add(cmbStatus);
            Controls.Add(label4);
            Controls.Add(Cena);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOdbiorca);
            Controls.Add(txtWaga);
            Controls.Add(txtCena);
            Controls.Add(btnZapisz);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Nowa przesyłka";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnZapisz;
        private TextBox txtCena;
        private TextBox txtWaga;
        private TextBox txtOdbiorca;
        private Label label1;
        private Label label2;
        private Label Cena;
        private Label label4;
        private ComboBox cmbStatus;
        private Label label3;
        private ComboBox cmbTyp;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtSymbolPaczkomatu;
        private TextBox txtNrDomu;
        private TextBox txtUlica;
        private TextBox txtNrMieszkania;
        private TextBox txtKodPocztowy;
        private TextBox txtMiejscowosc;
        private Label label10;
        private Label label11;
        private TextBox txtNadawca;
    }
}