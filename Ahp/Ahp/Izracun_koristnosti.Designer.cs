namespace Ahp
{
    partial class Izracun_koristnosti
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.spremeni_atrr_tb = new System.Windows.Forms.TextBox();
            this.spremeniimeattr_bt = new System.Windows.Forms.Button();
            this.addvrstica_bt = new System.Windows.Forms.Button();
            this.izbris_vrstice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.izbris_tabele = new System.Windows.Forms.Button();
            this.izracunajkoristnost_bt = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Utezi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1_rez = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Utezi});
            this.dataGridView2.Location = new System.Drawing.Point(12, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(655, 223);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "vpisi ime za atribut";
            // 
            // spremeni_atrr_tb
            // 
            this.spremeni_atrr_tb.Location = new System.Drawing.Point(379, 12);
            this.spremeni_atrr_tb.Name = "spremeni_atrr_tb";
            this.spremeni_atrr_tb.Size = new System.Drawing.Size(141, 20);
            this.spremeni_atrr_tb.TabIndex = 29;
            // 
            // spremeniimeattr_bt
            // 
            this.spremeniimeattr_bt.Location = new System.Drawing.Point(526, 12);
            this.spremeniimeattr_bt.Name = "spremeniimeattr_bt";
            this.spremeniimeattr_bt.Size = new System.Drawing.Size(141, 24);
            this.spremeniimeattr_bt.TabIndex = 28;
            this.spremeniimeattr_bt.Text = "spremeni ime atributa";
            this.spremeniimeattr_bt.UseVisualStyleBackColor = true;
            this.spremeniimeattr_bt.Click += new System.EventHandler(this.spremeniimeattr_bt_Click);
            // 
            // addvrstica_bt
            // 
            this.addvrstica_bt.Location = new System.Drawing.Point(12, 287);
            this.addvrstica_bt.Name = "addvrstica_bt";
            this.addvrstica_bt.Size = new System.Drawing.Size(141, 24);
            this.addvrstica_bt.TabIndex = 31;
            this.addvrstica_bt.Text = "Dodaj  vrstico";
            this.addvrstica_bt.UseVisualStyleBackColor = true;
            this.addvrstica_bt.Click += new System.EventHandler(this.addvrstica_bt_Click);
            // 
            // izbris_vrstice
            // 
            this.izbris_vrstice.Location = new System.Drawing.Point(12, 353);
            this.izbris_vrstice.Name = "izbris_vrstice";
            this.izbris_vrstice.Size = new System.Drawing.Size(142, 24);
            this.izbris_vrstice.TabIndex = 34;
            this.izbris_vrstice.Text = "izbrisi vrstico";
            this.izbris_vrstice.UseVisualStyleBackColor = true;
            this.izbris_vrstice.Click += new System.EventHandler(this.izbris_vrstice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "izberi vrstico";
            // 
            // izbris_tabele
            // 
            this.izbris_tabele.Location = new System.Drawing.Point(526, 353);
            this.izbris_tabele.Name = "izbris_tabele";
            this.izbris_tabele.Size = new System.Drawing.Size(142, 24);
            this.izbris_tabele.TabIndex = 36;
            this.izbris_tabele.Text = "izbrisi tabelo";
            this.izbris_tabele.UseVisualStyleBackColor = true;
            this.izbris_tabele.Click += new System.EventHandler(this.izbris_tabele_Click);
            // 
            // izracunajkoristnost_bt
            // 
            this.izracunajkoristnost_bt.Location = new System.Drawing.Point(525, 287);
            this.izracunajkoristnost_bt.Name = "izracunajkoristnost_bt";
            this.izracunajkoristnost_bt.Size = new System.Drawing.Size(142, 24);
            this.izracunajkoristnost_bt.TabIndex = 37;
            this.izracunajkoristnost_bt.Text = "izracunaj koristnost starsev";
            this.izracunajkoristnost_bt.UseVisualStyleBackColor = true;
            this.izracunajkoristnost_bt.Click += new System.EventHandler(this.izracunajkoristnost_bt_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Atributi";
            this.Column1.MaxDropDownItems = 15;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 90;
            // 
            // Utezi
            // 
            this.Utezi.HeaderText = "Utezi";
            this.Utezi.Name = "Utezi";
            // 
            // textBox1_rez
            // 
            this.textBox1_rez.Location = new System.Drawing.Point(218, 287);
            this.textBox1_rez.Multiline = true;
            this.textBox1_rez.Name = "textBox1_rez";
            this.textBox1_rez.ReadOnly = true;
            this.textBox1_rez.Size = new System.Drawing.Size(250, 90);
            this.textBox1_rez.TabIndex = 38;
            // 
            // Izracun_koristnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 389);
            this.Controls.Add(this.textBox1_rez);
            this.Controls.Add(this.izracunajkoristnost_bt);
            this.Controls.Add(this.izbris_tabele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.izbris_vrstice);
            this.Controls.Add(this.addvrstica_bt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.spremeni_atrr_tb);
            this.Controls.Add(this.spremeniimeattr_bt);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Izracun_koristnosti";
            this.Text = "Izracun_koristnosti";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox spremeni_atrr_tb;
        private System.Windows.Forms.Button spremeniimeattr_bt;
        private System.Windows.Forms.Button addvrstica_bt;
        private System.Windows.Forms.Button izbris_vrstice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button izbris_tabele;
        private System.Windows.Forms.Button izracunajkoristnost_bt;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utezi;
        private System.Windows.Forms.TextBox textBox1_rez;
    }
}