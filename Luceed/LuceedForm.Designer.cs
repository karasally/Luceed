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
            btnClearPaymentType = new Button();
            btnGetByPaymentType = new Button();
            gridPaymentType = new DataGridView();
            paymentVrstaPlacanjaUID = new DataGridViewTextBoxColumn();
            paymentNaziv = new DataGridViewTextBoxColumn();
            paymentIznos = new DataGridViewTextBoxColumn();
            paymentNadgrupaPlacanjaId = new DataGridViewTextBoxColumn();
            paymentNadgrupaPlacanjaNaziv = new DataGridViewTextBoxColumn();
            chkEnable = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            dtTo = new DateTimePicker();
            txtBU = new TextBox();
            dtFrom = new DateTimePicker();
            label1 = new Label();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridArtikli).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPaymentType).BeginInit();
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
            tabPage2.Controls.Add(btnClearPaymentType);
            tabPage2.Controls.Add(btnGetByPaymentType);
            tabPage2.Controls.Add(gridPaymentType);
            tabPage2.Controls.Add(chkEnable);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(dtTo);
            tabPage2.Controls.Add(txtBU);
            tabPage2.Controls.Add(dtFrom);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(567, 375);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Calculations by payment type";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClearPaymentType
            // 
            btnClearPaymentType.Location = new Point(431, 14);
            btnClearPaymentType.Name = "btnClearPaymentType";
            btnClearPaymentType.Size = new Size(94, 29);
            btnClearPaymentType.TabIndex = 10;
            btnClearPaymentType.Text = "Clear";
            btnClearPaymentType.UseVisualStyleBackColor = true;
            btnClearPaymentType.Click += btnClearPaymentType_Click;
            // 
            // btnGetByPaymentType
            // 
            btnGetByPaymentType.Location = new Point(331, 14);
            btnGetByPaymentType.Name = "btnGetByPaymentType";
            btnGetByPaymentType.Size = new Size(94, 29);
            btnGetByPaymentType.TabIndex = 9;
            btnGetByPaymentType.Text = "Search";
            btnGetByPaymentType.UseVisualStyleBackColor = true;
            btnGetByPaymentType.Click += btnGetByPaymentType_Click;
            // 
            // gridPaymentType
            // 
            gridPaymentType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPaymentType.Columns.AddRange(new DataGridViewColumn[] { paymentVrstaPlacanjaUID, paymentNaziv, paymentIznos, paymentNadgrupaPlacanjaId, paymentNadgrupaPlacanjaNaziv });
            gridPaymentType.Location = new Point(9, 151);
            gridPaymentType.Name = "gridPaymentType";
            gridPaymentType.ReadOnly = true;
            gridPaymentType.RowHeadersWidth = 51;
            gridPaymentType.RowTemplate.Height = 29;
            gridPaymentType.Size = new Size(555, 218);
            gridPaymentType.TabIndex = 8;
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
            // chkEnable
            // 
            chkEnable.AutoSize = true;
            chkEnable.Location = new Point(331, 82);
            chkEnable.Name = "chkEnable";
            chkEnable.Size = new Size(76, 24);
            chkEnable.TabIndex = 7;
            chkEnable.Text = "Enable";
            chkEnable.UseVisualStyleBackColor = true;
            chkEnable.CheckedChanged += chkEnable_CheckedChanged;
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
            // dtTo
            // 
            dtTo.Enabled = false;
            dtTo.Location = new Point(116, 80);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(209, 27);
            dtTo.TabIndex = 4;
            // 
            // txtBU
            // 
            txtBU.Location = new Point(116, 14);
            txtBU.Name = "txtBU";
            txtBU.PlaceholderText = "1234-56";
            txtBU.Size = new Size(209, 27);
            txtBU.TabIndex = 3;
            // 
            // dtFrom
            // 
            dtFrom.Location = new Point(116, 47);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(209, 27);
            dtFrom.TabIndex = 2;
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
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(567, 375);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Calculations by products";
            tabPage3.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)gridPaymentType).EndInit();
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
        private DateTimePicker dtFrom;
        private Label label3;
        private Label label2;
        private DateTimePicker dtTo;
        private TextBox txtBU;
        private CheckBox chkEnable;
        private DataGridView gridPaymentType;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn naziv;
        private Button btnClearPaymentType;
        private Button btnGetByPaymentType;
        private DataGridViewTextBoxColumn paymentVrstaPlacanjaUID;
        private DataGridViewTextBoxColumn paymentNaziv;
        private DataGridViewTextBoxColumn paymentIznos;
        private DataGridViewTextBoxColumn paymentNadgrupaPlacanjaId;
        private DataGridViewTextBoxColumn paymentNadgrupaPlacanjaNaziv;
    }
}