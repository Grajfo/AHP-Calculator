namespace Ahp
{
    partial class Form1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dodaj_node = new System.Windows.Forms.Button();
            this.ime_node = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.izbrisi = new System.Windows.Forms.Button();
            this.cleardrevo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.spremeni_tb = new System.Windows.Forms.TextBox();
            this.spremeni = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(258, 305);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // dodaj_node
            // 
            this.dodaj_node.Location = new System.Drawing.Point(301, 85);
            this.dodaj_node.Name = "dodaj_node";
            this.dodaj_node.Size = new System.Drawing.Size(118, 23);
            this.dodaj_node.TabIndex = 1;
            this.dodaj_node.Text = "Dodaj";
            this.dodaj_node.UseVisualStyleBackColor = true;
            this.dodaj_node.Click += new System.EventHandler(this.dodaj_node_Click);
            // 
            // ime_node
            // 
            this.ime_node.Location = new System.Drawing.Point(301, 42);
            this.ime_node.Name = "ime_node";
            this.ime_node.Size = new System.Drawing.Size(118, 20);
            this.ime_node.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "vpisi ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Izberi in odstrani";
            // 
            // izbrisi
            // 
            this.izbrisi.Location = new System.Drawing.Point(300, 280);
            this.izbrisi.Name = "izbrisi";
            this.izbrisi.Size = new System.Drawing.Size(119, 23);
            this.izbrisi.TabIndex = 5;
            this.izbrisi.Text = "Izbrisi";
            this.izbrisi.UseVisualStyleBackColor = true;
            this.izbrisi.Click += new System.EventHandler(this.izbrisi_Click);
            // 
            // cleardrevo
            // 
            this.cleardrevo.Location = new System.Drawing.Point(85, 323);
            this.cleardrevo.Name = "cleardrevo";
            this.cleardrevo.Size = new System.Drawing.Size(100, 23);
            this.cleardrevo.TabIndex = 6;
            this.cleardrevo.Text = "Izbrisi celo drevo";
            this.cleardrevo.UseVisualStyleBackColor = true;
            this.cleardrevo.Click += new System.EventHandler(this.cleardrevo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "spremeni ime";
            // 
            // spremeni_tb
            // 
            this.spremeni_tb.Location = new System.Drawing.Point(301, 155);
            this.spremeni_tb.Name = "spremeni_tb";
            this.spremeni_tb.Size = new System.Drawing.Size(118, 20);
            this.spremeni_tb.TabIndex = 8;
            // 
            // spremeni
            // 
            this.spremeni.Location = new System.Drawing.Point(301, 194);
            this.spremeni.Name = "spremeni";
            this.spremeni.Size = new System.Drawing.Size(118, 23);
            this.spremeni.TabIndex = 7;
            this.spremeni.Text = "spremeni";
            this.spremeni.UseVisualStyleBackColor = true;
            this.spremeni.Click += new System.EventHandler(this.spremeni_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Naprej";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.spremeni_tb);
            this.Controls.Add(this.spremeni);
            this.Controls.Add(this.cleardrevo);
            this.Controls.Add(this.izbrisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ime_node);
            this.Controls.Add(this.dodaj_node);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Sestava drevesne strukture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button dodaj_node;
        private System.Windows.Forms.TextBox ime_node;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button izbrisi;
        private System.Windows.Forms.Button cleardrevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox spremeni_tb;
        private System.Windows.Forms.Button spremeni;
        private System.Windows.Forms.Button button1;
    }
}

