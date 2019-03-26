namespace Ahp
{
    partial class Izracuni_tabel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Atributi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utezi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodaj_alternative = new System.Windows.Forms.Button();
            this.ime_alt_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.izbris_alt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.spremeni_tb = new System.Windows.Forms.TextBox();
            this.spremeni = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.ime_atr_tb = new System.Windows.Forms.TextBox();
            this.addstolpec_bt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.izracunaj_ut_korist = new System.Windows.Forms.Button();
            this.izbrisi_tabelo_bt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.spremeni_atrr_tb = new System.Windows.Forms.TextBox();
            this.spremeniimeattr_bt = new System.Windows.Forms.Button();
            this.shrani_tabelo_bt = new System.Windows.Forms.Button();
            this.izracun_starsev_bt = new System.Windows.Forms.Button();
            this.izbrisivrstico = new System.Windows.Forms.Button();
            this.rezulta_delj = new System.Windows.Forms.Label();
            this.deli_bt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imenovalec = new System.Windows.Forms.TextBox();
            this.stevec = new System.Windows.Forms.TextBox();
            this.prikazigraf = new System.Windows.Forms.Button();
            this.izracunutezistolpec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Atributi,
            this.Utezi});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // Atributi
            // 
            this.Atributi.HeaderText = "Parametri";
            this.Atributi.Name = "Atributi";
            this.Atributi.ReadOnly = true;
            // 
            // Utezi
            // 
            this.Utezi.HeaderText = "Utezi";
            this.Utezi.Name = "Utezi";
            // 
            // dodaj_alternative
            // 
            this.dodaj_alternative.Location = new System.Drawing.Point(787, 81);
            this.dodaj_alternative.Name = "dodaj_alternative";
            this.dodaj_alternative.Size = new System.Drawing.Size(141, 24);
            this.dodaj_alternative.TabIndex = 1;
            this.dodaj_alternative.Text = "Dodaj alternative";
            this.dodaj_alternative.UseVisualStyleBackColor = true;
            this.dodaj_alternative.Click += new System.EventHandler(this.dodaj_alternative_Click);
            // 
            // ime_alt_tb
            // 
            this.ime_alt_tb.Location = new System.Drawing.Point(787, 45);
            this.ime_alt_tb.Name = "ime_alt_tb";
            this.ime_alt_tb.Size = new System.Drawing.Size(141, 20);
            this.ime_alt_tb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(805, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vpisi ime alternative";
            // 
            // izbris_alt
            // 
            this.izbris_alt.Location = new System.Drawing.Point(786, 327);
            this.izbris_alt.Name = "izbris_alt";
            this.izbris_alt.Size = new System.Drawing.Size(142, 24);
            this.izbris_alt.TabIndex = 4;
            this.izbris_alt.Text = "izbrisi alternativo";
            this.izbris_alt.UseVisualStyleBackColor = true;
            this.izbris_alt.Click += new System.EventHandler(this.izbris_alt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "spremeni ime alternative";
            // 
            // spremeni_tb
            // 
            this.spremeni_tb.Location = new System.Drawing.Point(787, 199);
            this.spremeni_tb.Name = "spremeni_tb";
            this.spremeni_tb.Size = new System.Drawing.Size(141, 20);
            this.spremeni_tb.TabIndex = 6;
            // 
            // spremeni
            // 
            this.spremeni.Location = new System.Drawing.Point(787, 238);
            this.spremeni.Name = "spremeni";
            this.spremeni.Size = new System.Drawing.Size(141, 24);
            this.spremeni.TabIndex = 5;
            this.spremeni.Text = "spremeni ime alternative";
            this.spremeni.UseVisualStyleBackColor = true;
            this.spremeni.Click += new System.EventHandler(this.spremeni_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(813, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Izberi alternativo";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView2.Location = new System.Drawing.Point(12, 505);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(719, 238);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView2_CellValidating);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Atributi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(774, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "vpisi ime stolpca";
            // 
            // ime_atr_tb
            // 
            this.ime_atr_tb.Location = new System.Drawing.Point(752, 595);
            this.ime_atr_tb.Name = "ime_atr_tb";
            this.ime_atr_tb.Size = new System.Drawing.Size(141, 20);
            this.ime_atr_tb.TabIndex = 11;
            // 
            // addstolpec_bt
            // 
            this.addstolpec_bt.Location = new System.Drawing.Point(753, 621);
            this.addstolpec_bt.Name = "addstolpec_bt";
            this.addstolpec_bt.Size = new System.Drawing.Size(141, 24);
            this.addstolpec_bt.TabIndex = 10;
            this.addstolpec_bt.Text = "Dodaj  stolpec";
            this.addstolpec_bt.UseVisualStyleBackColor = true;
            this.addstolpec_bt.Click += new System.EventHandler(this.addstolpec_bt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Za izračun Uteži/Kosritnosti";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 749);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 32);
            this.button3.TabIndex = 15;
            this.button3.Text = "izbrisi stolpec";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // izracunaj_ut_korist
            // 
            this.izracunaj_ut_korist.Location = new System.Drawing.Point(569, 749);
            this.izracunaj_ut_korist.Name = "izracunaj_ut_korist";
            this.izracunaj_ut_korist.Size = new System.Drawing.Size(157, 32);
            this.izracunaj_ut_korist.TabIndex = 23;
            this.izracunaj_ut_korist.Text = "Izracunaj utez ali koristnost";
            this.izracunaj_ut_korist.UseVisualStyleBackColor = true;
            this.izracunaj_ut_korist.Click += new System.EventHandler(this.izracunaj_ut_korist_Click);
            // 
            // izbrisi_tabelo_bt
            // 
            this.izbrisi_tabelo_bt.Location = new System.Drawing.Point(12, 749);
            this.izbrisi_tabelo_bt.Name = "izbrisi_tabelo_bt";
            this.izbrisi_tabelo_bt.Size = new System.Drawing.Size(150, 32);
            this.izbrisi_tabelo_bt.TabIndex = 24;
            this.izbrisi_tabelo_bt.Text = "izbrisi tabelo";
            this.izbrisi_tabelo_bt.UseVisualStyleBackColor = true;
            this.izbrisi_tabelo_bt.Click += new System.EventHandler(this.izbrisi_tabelo_bt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "vpisi ime za atribut";
            // 
            // spremeni_atrr_tb
            // 
            this.spremeni_atrr_tb.Location = new System.Drawing.Point(422, 475);
            this.spremeni_atrr_tb.Name = "spremeni_atrr_tb";
            this.spremeni_atrr_tb.Size = new System.Drawing.Size(141, 20);
            this.spremeni_atrr_tb.TabIndex = 26;
            // 
            // spremeniimeattr_bt
            // 
            this.spremeniimeattr_bt.Location = new System.Drawing.Point(569, 475);
            this.spremeniimeattr_bt.Name = "spremeniimeattr_bt";
            this.spremeniimeattr_bt.Size = new System.Drawing.Size(141, 24);
            this.spremeniimeattr_bt.TabIndex = 25;
            this.spremeniimeattr_bt.Text = "spremeni ime atributa";
            this.spremeniimeattr_bt.UseVisualStyleBackColor = true;
            this.spremeniimeattr_bt.Click += new System.EventHandler(this.spremeniimeattr_bt_Click);
            // 
            // shrani_tabelo_bt
            // 
            this.shrani_tabelo_bt.Location = new System.Drawing.Point(12, 361);
            this.shrani_tabelo_bt.Name = "shrani_tabelo_bt";
            this.shrani_tabelo_bt.Size = new System.Drawing.Size(142, 24);
            this.shrani_tabelo_bt.TabIndex = 28;
            this.shrani_tabelo_bt.Text = "shrani tabelo";
            this.shrani_tabelo_bt.UseVisualStyleBackColor = true;
            this.shrani_tabelo_bt.Click += new System.EventHandler(this.shrani_tabelo_bt_Click);
            // 
            // izracun_starsev_bt
            // 
            this.izracun_starsev_bt.Location = new System.Drawing.Point(589, 361);
            this.izracun_starsev_bt.Name = "izracun_starsev_bt";
            this.izracun_starsev_bt.Size = new System.Drawing.Size(142, 24);
            this.izracun_starsev_bt.TabIndex = 29;
            this.izracun_starsev_bt.Text = "izracunaj koristnost staršev";
            this.izracun_starsev_bt.UseVisualStyleBackColor = true;
            this.izracun_starsev_bt.Click += new System.EventHandler(this.izracun_starsev_bt_Click);
            // 
            // izbrisivrstico
            // 
            this.izbrisivrstico.Location = new System.Drawing.Point(316, 749);
            this.izbrisivrstico.Name = "izbrisivrstico";
            this.izbrisivrstico.Size = new System.Drawing.Size(142, 32);
            this.izbrisivrstico.TabIndex = 30;
            this.izbrisivrstico.Text = "izbrisi vrsico";
            this.izbrisivrstico.UseVisualStyleBackColor = true;
            this.izbrisivrstico.Click += new System.EventHandler(this.izbrisivrstico_Click);
            // 
            // rezulta_delj
            // 
            this.rezulta_delj.AutoSize = true;
            this.rezulta_delj.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rezulta_delj.Location = new System.Drawing.Point(909, 505);
            this.rezulta_delj.Name = "rezulta_delj";
            this.rezulta_delj.Size = new System.Drawing.Size(0, 20);
            this.rezulta_delj.TabIndex = 37;
            // 
            // deli_bt
            // 
            this.deli_bt.Location = new System.Drawing.Point(782, 536);
            this.deli_bt.Name = "deli_bt";
            this.deli_bt.Size = new System.Drawing.Size(75, 20);
            this.deli_bt.TabIndex = 36;
            this.deli_bt.Text = "Deli";
            this.deli_bt.UseVisualStyleBackColor = true;
            this.deli_bt.Click += new System.EventHandler(this.deli_bt_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(909, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(887, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(812, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "÷";
            // 
            // imenovalec
            // 
            this.imenovalec.Location = new System.Drawing.Point(835, 505);
            this.imenovalec.Name = "imenovalec";
            this.imenovalec.Size = new System.Drawing.Size(46, 20);
            this.imenovalec.TabIndex = 32;
            // 
            // stevec
            // 
            this.stevec.Location = new System.Drawing.Point(761, 505);
            this.stevec.Name = "stevec";
            this.stevec.Size = new System.Drawing.Size(45, 20);
            this.stevec.TabIndex = 31;
            // 
            // prikazigraf
            // 
            this.prikazigraf.Location = new System.Drawing.Point(405, 361);
            this.prikazigraf.Name = "prikazigraf";
            this.prikazigraf.Size = new System.Drawing.Size(142, 24);
            this.prikazigraf.TabIndex = 38;
            this.prikazigraf.Text = "prikazi koncni graf";
            this.prikazigraf.UseVisualStyleBackColor = true;
            this.prikazigraf.Click += new System.EventHandler(this.prikazigraf_Click);
            // 
            // izracunutezistolpec
            // 
            this.izracunutezistolpec.Location = new System.Drawing.Point(752, 672);
            this.izracunutezistolpec.Name = "izracunutezistolpec";
            this.izracunutezistolpec.Size = new System.Drawing.Size(142, 24);
            this.izracunutezistolpec.TabIndex = 39;
            this.izracunutezistolpec.Text = "dodaj stolpce alternativ";
            this.izracunutezistolpec.UseVisualStyleBackColor = true;
            this.izracunutezistolpec.Click += new System.EventHandler(this.izracunutezistolpec_Click);
            // 
            // Izracuni_tabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(969, 793);
            this.Controls.Add(this.izracunutezistolpec);
            this.Controls.Add(this.prikazigraf);
            this.Controls.Add(this.rezulta_delj);
            this.Controls.Add(this.deli_bt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.imenovalec);
            this.Controls.Add(this.stevec);
            this.Controls.Add(this.izbrisivrstico);
            this.Controls.Add(this.izracun_starsev_bt);
            this.Controls.Add(this.shrani_tabelo_bt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.spremeni_atrr_tb);
            this.Controls.Add(this.spremeniimeattr_bt);
            this.Controls.Add(this.izbrisi_tabelo_bt);
            this.Controls.Add(this.izracunaj_ut_korist);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ime_atr_tb);
            this.Controls.Add(this.addstolpec_bt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spremeni_tb);
            this.Controls.Add(this.spremeni);
            this.Controls.Add(this.izbris_alt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ime_alt_tb);
            this.Controls.Add(this.dodaj_alternative);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Izracuni_tabel";
            this.Text = "Izracuni_tabel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dodaj_alternative;
        private System.Windows.Forms.TextBox ime_alt_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button izbris_alt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox spremeni_tb;
        private System.Windows.Forms.Button spremeni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atributi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utezi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ime_atr_tb;
        private System.Windows.Forms.Button addstolpec_bt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button izracunaj_ut_korist;
        private System.Windows.Forms.Button izbrisi_tabelo_bt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox spremeni_atrr_tb;
        private System.Windows.Forms.Button spremeniimeattr_bt;
        private System.Windows.Forms.Button shrani_tabelo_bt;
        private System.Windows.Forms.Button izracun_starsev_bt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button izbrisivrstico;
        private System.Windows.Forms.Label rezulta_delj;
        private System.Windows.Forms.Button deli_bt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox imenovalec;
        private System.Windows.Forms.TextBox stevec;
        private System.Windows.Forms.Button prikazigraf;
        private System.Windows.Forms.Button izracunutezistolpec;
    }
}