namespace Luceed
{
    partial class LuceedForm
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
            btnOcisti = new Button();
            txtNaziv = new TextBox();
            gridArtikli = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            naziv = new DataGridViewTextBoxColumn();
            btnGetByNaziv = new Button();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridArtikli).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(575, 322);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnOcisti);
            tabPage1.Controls.Add(txtNaziv);
            tabPage1.Controls.Add(gridArtikli);
            tabPage1.Controls.Add(btnGetByNaziv);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(567, 289);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Traži artikle po nazivu";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnOcisti
            // 
            btnOcisti.Location = new Point(398, 24);
            btnOcisti.Name = "btnOcisti";
            btnOcisti.Size = new Size(94, 29);
            btnOcisti.TabIndex = 2;
            btnOcisti.Text = "Očisti";
            btnOcisti.UseVisualStyleBackColor = true;
            btnOcisti.Click += btnOcisti_Click;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(6, 25);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(255, 27);
            txtNaziv.TabIndex = 1;
            // 
            // gridArtikli
            // 
            gridArtikli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridArtikli.Columns.AddRange(new DataGridViewColumn[] { id, naziv });
            gridArtikli.Location = new Point(6, 81);
            gridArtikli.Name = "gridArtikli";
            gridArtikli.ReadOnly = true;
            gridArtikli.RowHeadersWidth = 51;
            gridArtikli.RowTemplate.Height = 29;
            gridArtikli.Size = new Size(555, 202);
            gridArtikli.TabIndex = 1;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 200;
            // 
            // naziv
            // 
            naziv.HeaderText = "Naziv";
            naziv.MinimumWidth = 6;
            naziv.Name = "naziv";
            naziv.ReadOnly = true;
            naziv.Width = 300;
            // 
            // btnGetByNaziv
            // 
            btnGetByNaziv.Location = new Point(267, 24);
            btnGetByNaziv.Name = "btnGetByNaziv";
            btnGetByNaziv.Size = new Size(125, 29);
            btnGetByNaziv.TabIndex = 0;
            btnGetByNaziv.Text = "Traži";
            btnGetByNaziv.UseVisualStyleBackColor = true;
            btnGetByNaziv.Click += btnGetByNaziv_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(567, 289);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // LuceedForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 344);
            Controls.Add(tabControl1);
            Name = "LuceedForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridArtikli).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnGetByNaziv;
        private DataGridView gridArtikli;
        private TextBox txtNaziv;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn naziv;
        private Button btnOcisti;
    }
}