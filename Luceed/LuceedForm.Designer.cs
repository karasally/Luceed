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
            btnClearArticle = new Button();
            txtNaziv = new TextBox();
            gridArtikli = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            naziv = new DataGridViewTextBoxColumn();
            btnGetByNaziv = new Button();
            tabPage2 = new TabPage();
            btnClearPayment = new Button();
            btnGetByPayment = new Button();
            gridPayment = new DataGridView();
            paymentVrstaPlacanjaUID = new DataGridViewTextBoxColumn();
            paymentNaziv = new DataGridViewTextBoxColumn();
            paymentIznos = new DataGridViewTextBoxColumn();
            paymentNadgrupaPlacanjaId = new DataGridViewTextBoxColumn();
            paymentNadgrupaPlacanjaNaziv = new DataGridViewTextBoxColumn();
            chkPaymentEnable = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            dtPaymentTo = new DateTimePicker();
            txtPaymentBU = new TextBox();
            dtPaymentFrom = new DateTimePicker();
            label1 = new Label();
            tabPage3 = new TabPage();
            btnClearProduct = new Button();
            btnGetByProduct = new Button();
            gridProduct = new DataGridView();
            productArtiklUID = new DataGridViewTextBoxColumn();
            productNaziv = new DataGridViewTextBoxColumn();
            productKolicina = new DataGridViewTextBoxColumn();
            productIznos = new DataGridViewTextBoxColumn();
            productUsluga = new DataGridViewTextBoxColumn();
            chkProductEnable = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            dtProductTo = new DateTimePicker();
            txtProductBU = new TextBox();
            dtProductFrom = new DateTimePicker();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridArtikli).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPayment).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProduct).BeginInit();
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
            tabControl1.Size = new Size(575, 408);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnClearArticle);
            tabPage1.Controls.Add(txtNaziv);
            tabPage1.Controls.Add(gridArtikli);
            tabPage1.Controls.Add(btnGetByNaziv);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(567, 375);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Articles by name";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClearArticle
            // 
            btnClearArticle.Location = new Point(398, 24);
            btnClearArticle.Name = "btnClearArticle";
            btnClearArticle.Size = new Size(94, 29);
            btnClearArticle.TabIndex = 2;
            btnClearArticle.Text = "Clear";
            btnClearArticle.UseVisualStyleBackColor = true;
            btnClearArticle.Click += btnClearArticle_Click;
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
            gridArtikli.Size = new Size(555, 288);
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
            naziv.HeaderText = "Name";
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
            btnGetByNaziv.Text = "Search";
            btnGetByNaziv.UseVisualStyleBackColor = true;
            btnGetByNaziv.Click += btnGetByNaziv_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnClearPayment);
            tabPage2.Controls.Add(btnGetByPayment);
            tabPage2.Controls.Add(gridPayment);
            tabPage2.Controls.Add(chkPaymentEnable);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(dtPaymentTo);
            tabPage2.Controls.Add(txtPaymentBU);
            tabPage2.Controls.Add(dtPaymentFrom);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(567, 375);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Calculations by payment type";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClearPayment
            // 
            btnClearPayment.Location = new Point(431, 14);
            btnClearPayment.Name = "btnClearPayment";
            btnClearPayment.Size = new Size(94, 29);
            btnClearPayment.TabIndex = 10;
            btnClearPayment.Text = "Clear";
            btnClearPayment.UseVisualStyleBackColor = true;
            btnClearPayment.Click += btnClearPayment_Click;
            // 
            // btnGetByPayment
            // 
            btnGetByPayment.Location = new Point(331, 14);
            btnGetByPayment.Name = "btnGetByPayment";
            btnGetByPayment.Size = new Size(94, 29);
            btnGetByPayment.TabIndex = 9;
            btnGetByPayment.Text = "Search";
            btnGetByPayment.UseVisualStyleBackColor = true;
            btnGetByPayment.Click += btnGetByPaymentType_Click;
            // 
            // gridPayment
            // 
            gridPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPayment.Columns.AddRange(new DataGridViewColumn[] { paymentVrstaPlacanjaUID, paymentNaziv, paymentIznos, paymentNadgrupaPlacanjaId, paymentNadgrupaPlacanjaNaziv });
            gridPayment.Location = new Point(9, 151);
            gridPayment.Name = "gridPayment";
            gridPayment.ReadOnly = true;
            gridPayment.RowHeadersWidth = 51;
            gridPayment.RowTemplate.Height = 29;
            gridPayment.Size = new Size(555, 218);
            gridPayment.TabIndex = 8;
            // 
            // paymentVrstaPlacanjaUID
            // 
            paymentVrstaPlacanjaUID.HeaderText = "Vrsta placanja UID";
            paymentVrstaPlacanjaUID.MinimumWidth = 6;
            paymentVrstaPlacanjaUID.Name = "paymentVrstaPlacanjaUID";
            paymentVrstaPlacanjaUID.ReadOnly = true;
            paymentVrstaPlacanjaUID.Width = 165;
            // 
            // paymentNaziv
            // 
            paymentNaziv.HeaderText = "Naziv";
            paymentNaziv.MinimumWidth = 6;
            paymentNaziv.Name = "paymentNaziv";
            paymentNaziv.ReadOnly = true;
            paymentNaziv.Width = 165;
            // 
            // paymentIznos
            // 
            paymentIznos.HeaderText = "Iznos";
            paymentIznos.MinimumWidth = 6;
            paymentIznos.Name = "paymentIznos";
            paymentIznos.ReadOnly = true;
            paymentIznos.Width = 165;
            // 
            // paymentNadgrupaPlacanjaId
            // 
            paymentNadgrupaPlacanjaId.HeaderText = "Nadgrupa Placanja UID";
            paymentNadgrupaPlacanjaId.MinimumWidth = 6;
            paymentNadgrupaPlacanjaId.Name = "paymentNadgrupaPlacanjaId";
            paymentNadgrupaPlacanjaId.ReadOnly = true;
            paymentNadgrupaPlacanjaId.Width = 195;
            // 
            // paymentNadgrupaPlacanjaNaziv
            // 
            paymentNadgrupaPlacanjaNaziv.HeaderText = "Nadgrupa Placanja Naziv";
            paymentNadgrupaPlacanjaNaziv.MinimumWidth = 6;
            paymentNadgrupaPlacanjaNaziv.Name = "paymentNadgrupaPlacanjaNaziv";
            paymentNadgrupaPlacanjaNaziv.ReadOnly = true;
            paymentNadgrupaPlacanjaNaziv.Width = 205;
            // 
            // chkPaymentEnable
            // 
            chkPaymentEnable.AutoSize = true;
            chkPaymentEnable.Location = new Point(331, 82);
            chkPaymentEnable.Name = "chkPaymentEnable";
            chkPaymentEnable.Size = new Size(76, 24);
            chkPaymentEnable.TabIndex = 7;
            chkPaymentEnable.Text = "Enable";
            chkPaymentEnable.UseVisualStyleBackColor = true;
            chkPaymentEnable.CheckedChanged += chkPaymentEnable_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 80);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(28, 20);
            label3.TabIndex = 6;
            label3.Text = "To:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 47);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "From:";
            // 
            // dtPaymentTo
            // 
            dtPaymentTo.Enabled = false;
            dtPaymentTo.Location = new Point(116, 80);
            dtPaymentTo.Name = "dtPaymentTo";
            dtPaymentTo.Size = new Size(209, 27);
            dtPaymentTo.TabIndex = 4;
            // 
            // txtPaymentBU
            // 
            txtPaymentBU.Location = new Point(116, 14);
            txtPaymentBU.Name = "txtPaymentBU";
            txtPaymentBU.PlaceholderText = "1234-56";
            txtPaymentBU.Size = new Size(209, 27);
            txtPaymentBU.TabIndex = 3;
            // 
            // dtPaymentFrom
            // 
            dtPaymentFrom.Location = new Point(116, 47);
            dtPaymentFrom.Name = "dtPaymentFrom";
            dtPaymentFrom.Size = new Size(209, 27);
            dtPaymentFrom.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 1;
            label1.Text = "Business unit:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnClearProduct);
            tabPage3.Controls.Add(btnGetByProduct);
            tabPage3.Controls.Add(gridProduct);
            tabPage3.Controls.Add(chkProductEnable);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(dtProductTo);
            tabPage3.Controls.Add(txtProductBU);
            tabPage3.Controls.Add(dtProductFrom);
            tabPage3.Controls.Add(label6);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(567, 375);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Calculations by products";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnClearProduct
            // 
            btnClearProduct.Location = new Point(431, 14);
            btnClearProduct.Name = "btnClearProduct";
            btnClearProduct.Size = new Size(94, 29);
            btnClearProduct.TabIndex = 20;
            btnClearProduct.Text = "Clear";
            btnClearProduct.UseVisualStyleBackColor = true;
            btnClearProduct.Click += btnClearProduct_Click;
            // 
            // btnGetByProduct
            // 
            btnGetByProduct.Location = new Point(331, 14);
            btnGetByProduct.Name = "btnGetByProduct";
            btnGetByProduct.Size = new Size(94, 29);
            btnGetByProduct.TabIndex = 19;
            btnGetByProduct.Text = "Search";
            btnGetByProduct.UseVisualStyleBackColor = true;
            btnGetByProduct.Click += btnGetByProduct_Click;
            // 
            // gridProduct
            // 
            gridProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProduct.Columns.AddRange(new DataGridViewColumn[] { productArtiklUID, productNaziv, productKolicina, productIznos, productUsluga });
            gridProduct.Location = new Point(9, 151);
            gridProduct.Name = "gridProduct";
            gridProduct.ReadOnly = true;
            gridProduct.RowHeadersWidth = 51;
            gridProduct.RowTemplate.Height = 29;
            gridProduct.Size = new Size(555, 218);
            gridProduct.TabIndex = 18;
            // 
            // productArtiklUID
            // 
            productArtiklUID.HeaderText = "Artikl UID";
            productArtiklUID.MinimumWidth = 6;
            productArtiklUID.Name = "productArtiklUID";
            productArtiklUID.ReadOnly = true;
            productArtiklUID.Width = 125;
            // 
            // productNaziv
            // 
            productNaziv.HeaderText = "Naziv";
            productNaziv.MinimumWidth = 6;
            productNaziv.Name = "productNaziv";
            productNaziv.ReadOnly = true;
            productNaziv.Width = 125;
            // 
            // productKolicina
            // 
            productKolicina.HeaderText = "Kolicina";
            productKolicina.MinimumWidth = 6;
            productKolicina.Name = "productKolicina";
            productKolicina.ReadOnly = true;
            productKolicina.Width = 125;
            // 
            // productIznos
            // 
            productIznos.HeaderText = "Iznos";
            productIznos.MinimumWidth = 6;
            productIznos.Name = "productIznos";
            productIznos.ReadOnly = true;
            productIznos.Width = 125;
            // 
            // productUsluga
            // 
            productUsluga.HeaderText = "Usluga";
            productUsluga.MinimumWidth = 6;
            productUsluga.Name = "productUsluga";
            productUsluga.ReadOnly = true;
            productUsluga.Width = 125;
            // 
            // chkProductEnable
            // 
            chkProductEnable.AutoSize = true;
            chkProductEnable.Location = new Point(331, 82);
            chkProductEnable.Name = "chkProductEnable";
            chkProductEnable.Size = new Size(76, 24);
            chkProductEnable.TabIndex = 17;
            chkProductEnable.Text = "Enable";
            chkProductEnable.UseVisualStyleBackColor = true;
            chkProductEnable.CheckedChanged += chkProductEnable_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 80);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(28, 20);
            label4.TabIndex = 16;
            label4.Text = "To:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 47);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 15;
            label5.Text = "From:";
            // 
            // dtProductTo
            // 
            dtProductTo.Enabled = false;
            dtProductTo.Location = new Point(116, 80);
            dtProductTo.Name = "dtProductTo";
            dtProductTo.Size = new Size(209, 27);
            dtProductTo.TabIndex = 14;
            // 
            // txtProductBU
            // 
            txtProductBU.Location = new Point(116, 14);
            txtProductBU.Name = "txtProductBU";
            txtProductBU.PlaceholderText = "1234-56";
            txtProductBU.Size = new Size(209, 27);
            txtProductBU.TabIndex = 13;
            // 
            // dtProductFrom
            // 
            dtProductFrom.Location = new Point(116, 47);
            dtProductFrom.Name = "dtProductFrom";
            dtProductFrom.Size = new Size(209, 27);
            dtProductFrom.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 14);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 11;
            label6.Text = "Business unit:";
            // 
            // LuceedForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 432);
            Controls.Add(tabControl1);
            Name = "LuceedForm";
            Text = "Luceed API";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridArtikli).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridPayment).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnGetByNaziv;
        private DataGridView gridArtikli;
        private TextBox txtNaziv;
        private Button btnClearArticle;
        private Label label1;
        private TabPage tabPage3;
        private DateTimePicker dtPaymentFrom;
        private Label label3;
        private Label label2;
        private DateTimePicker dtPaymentTo;
        private TextBox txtPaymentBU;
        private CheckBox chkPaymentEnable;
        private DataGridView gridPayment;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn naziv;
        private Button btnClearPayment;
        private Button btnGetByPayment;
        private DataGridViewTextBoxColumn paymentVrstaPlacanjaUID;
        private DataGridViewTextBoxColumn paymentNaziv;
        private DataGridViewTextBoxColumn paymentIznos;
        private DataGridViewTextBoxColumn paymentNadgrupaPlacanjaId;
        private DataGridViewTextBoxColumn paymentNadgrupaPlacanjaNaziv;
        private Button btnClearProduct;
        private Button btnGetByProduct;
        private DataGridView gridProduct;
        private CheckBox chkProductEnable;
        private Label label4;
        private Label label5;
        private DateTimePicker dtProductTo;
        private TextBox txtProductBU;
        private DateTimePicker dtProductFrom;
        private Label label6;
        private DataGridViewTextBoxColumn productArtiklUID;
        private DataGridViewTextBoxColumn productNaziv;
        private DataGridViewTextBoxColumn productKolicina;
        private DataGridViewTextBoxColumn productIznos;
        private DataGridViewTextBoxColumn productUsluga;
    }
}