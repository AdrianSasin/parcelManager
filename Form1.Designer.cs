namespace managerPaczek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            btnDodaj = new Button();
            Usuń = new Button();
            pictureBox1 = new PictureBox();
            btnZapiszXml = new Button();
            btnWczytajXml = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.DarkSalmon;
            dataGridView1.Location = new Point(12, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(956, 412);
            dataGridView1.TabIndex = 0;
            // 
            // btnDodaj
            // 
            btnDodaj.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnDodaj.Location = new Point(224, 12);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(200, 100);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // Usuń
            // 
            Usuń.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Usuń.Location = new Point(436, 12);
            Usuń.Name = "Usuń";
            Usuń.Size = new Size(200, 100);
            Usuń.TabIndex = 2;
            Usuń.Text = "Usuń";
            Usuń.UseVisualStyleBackColor = true;
            Usuń.Click += btnUsun_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnZapiszXml
            // 
            btnZapiszXml.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnZapiszXml.Location = new Point(658, 12);
            btnZapiszXml.Name = "btnZapiszXml";
            btnZapiszXml.Size = new Size(200, 100);
            btnZapiszXml.TabIndex = 4;
            btnZapiszXml.Text = "Zapisz";
            btnZapiszXml.UseVisualStyleBackColor = true;
            btnZapiszXml.Click += btnZapiszXml_Click;
            // 
            // btnWczytajXml
            // 
            btnWczytajXml.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnWczytajXml.Location = new Point(885, 12);
            btnWczytajXml.Name = "btnWczytajXml";
            btnWczytajXml.Size = new Size(200, 100);
            btnWczytajXml.TabIndex = 5;
            btnWczytajXml.Text = "Wczytaj";
            btnWczytajXml.UseVisualStyleBackColor = true;
            btnWczytajXml.Click += btnWczytajXml_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1382, 553);
            Controls.Add(btnWczytajXml);
            Controls.Add(btnZapiszXml);
            Controls.Add(Usuń);
            Controls.Add(btnDodaj);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "paczuszkii ;)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDodaj;
        private Button Usuń;
        private PictureBox pictureBox1;
        private Button btnZapiszXml;
        private Button btnWczytajXml;
    }
}
