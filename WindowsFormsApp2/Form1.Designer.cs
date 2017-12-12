namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartstationInput = new System.Windows.Forms.TextBox();
            this.EndstationInput = new System.Windows.Forms.TextBox();
            this.Auswahl1 = new System.Windows.Forms.ListBox();
            this.Auswahl2 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.abfahrtsstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abfahrtszone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftszone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verspätung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Changer = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.GoogleMapsSearch2 = new System.Windows.Forms.Button();
            this.GoogleMapsSearch1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Startstation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Endstation";
            // 
            // StartstationInput
            // 
            this.StartstationInput.AutoCompleteCustomSource.AddRange(new string[] {
            "a",
            "ab",
            "ac",
            "ad",
            "af"});
            this.StartstationInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.StartstationInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.StartstationInput.Location = new System.Drawing.Point(12, 41);
            this.StartstationInput.Name = "StartstationInput";
            this.StartstationInput.Size = new System.Drawing.Size(319, 20);
            this.StartstationInput.TabIndex = 4;
            this.StartstationInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EndstationInput
            // 
            this.EndstationInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.EndstationInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.EndstationInput.Location = new System.Drawing.Point(426, 41);
            this.EndstationInput.Name = "EndstationInput";
            this.EndstationInput.Size = new System.Drawing.Size(310, 20);
            this.EndstationInput.TabIndex = 5;
            this.EndstationInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Auswahl1
            // 
            this.Auswahl1.FormattingEnabled = true;
            this.Auswahl1.Location = new System.Drawing.Point(12, 67);
            this.Auswahl1.Name = "Auswahl1";
            this.Auswahl1.Size = new System.Drawing.Size(319, 95);
            this.Auswahl1.TabIndex = 14;
            this.Auswahl1.Visible = false;
            this.Auswahl1.SelectedIndexChanged += new System.EventHandler(this.Auswahl1_SelectedIndexChanged);
            this.Auswahl1.DoubleClick += new System.EventHandler(this.DoubleClick1);
            // 
            // Auswahl2
            // 
            this.Auswahl2.FormattingEnabled = true;
            this.Auswahl2.Location = new System.Drawing.Point(426, 67);
            this.Auswahl2.Name = "Auswahl2";
            this.Auswahl2.Size = new System.Drawing.Size(310, 95);
            this.Auswahl2.TabIndex = 15;
            this.Auswahl2.Visible = false;
            this.Auswahl2.DoubleClick += new System.EventHandler(this.DoubleClick2);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abfahrtsstation,
            this.abfahrtszeit,
            this.abfahrtszone,
            this.Ankunftsstation,
            this.Ankunftszeit,
            this.Ankunftszone,
            this.Verspätung});
            this.dataGridView1.Location = new System.Drawing.Point(12, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 270);
            this.dataGridView1.TabIndex = 16;
            // 
            // abfahrtsstation
            // 
            this.abfahrtsstation.HeaderText = "Ort";
            this.abfahrtsstation.Name = "abfahrtsstation";
            // 
            // abfahrtszeit
            // 
            this.abfahrtszeit.HeaderText = "Abfahrtszeit";
            this.abfahrtszeit.Name = "abfahrtszeit";
            // 
            // abfahrtszone
            // 
            this.abfahrtszone.HeaderText = "Abfahrtszone";
            this.abfahrtszone.Name = "abfahrtszone";
            // 
            // Ankunftsstation
            // 
            this.Ankunftsstation.HeaderText = "Ankunftsstation";
            this.Ankunftsstation.Name = "Ankunftsstation";
            // 
            // Ankunftszeit
            // 
            this.Ankunftszeit.HeaderText = "Ankunftszeit";
            this.Ankunftszeit.Name = "Ankunftszeit";
            // 
            // Ankunftszone
            // 
            this.Ankunftszone.HeaderText = "Ankunftszone";
            this.Ankunftszone.Name = "Ankunftszone";
            // 
            // Verspätung
            // 
            this.Verspätung.HeaderText = "Verspätung";
            this.Verspätung.Name = "Verspätung";
            // 
            // Changer
            // 
            this.Changer.Location = new System.Drawing.Point(337, 39);
            this.Changer.Name = "Changer";
            this.Changer.Size = new System.Drawing.Size(83, 23);
            this.Changer.TabIndex = 17;
            this.Changer.Text = "<--->";
            this.Changer.UseVisualStyleBackColor = true;
            this.Changer.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(319, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Verbindungen von Startstation suchen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // GoogleMapsSearch2
            // 
            this.GoogleMapsSearch2.Location = new System.Drawing.Point(426, 67);
            this.GoogleMapsSearch2.Name = "GoogleMapsSearch2";
            this.GoogleMapsSearch2.Size = new System.Drawing.Size(122, 23);
            this.GoogleMapsSearch2.TabIndex = 19;
            this.GoogleMapsSearch2.Text = "Open in Google Maps";
            this.GoogleMapsSearch2.UseVisualStyleBackColor = true;
            this.GoogleMapsSearch2.Visible = false;
            this.GoogleMapsSearch2.Click += new System.EventHandler(this.button5_Click);
            // 
            // GoogleMapsSearch1
            // 
            this.GoogleMapsSearch1.Location = new System.Drawing.Point(12, 67);
            this.GoogleMapsSearch1.Name = "GoogleMapsSearch1";
            this.GoogleMapsSearch1.Size = new System.Drawing.Size(122, 23);
            this.GoogleMapsSearch1.TabIndex = 20;
            this.GoogleMapsSearch1.Text = "Open in Google Maps";
            this.GoogleMapsSearch1.UseVisualStyleBackColor = true;
            this.GoogleMapsSearch1.Visible = false;
            this.GoogleMapsSearch1.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 495);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Changer);
            this.Controls.Add(this.Auswahl2);
            this.Controls.Add(this.Auswahl1);
            this.Controls.Add(this.EndstationInput);
            this.Controls.Add(this.StartstationInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GoogleMapsSearch1);
            this.Controls.Add(this.GoogleMapsSearch2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StartstationInput;
        private System.Windows.Forms.TextBox EndstationInput;
        private System.Windows.Forms.ListBox Auswahl1;
        private System.Windows.Forms.ListBox Auswahl2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrtsstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrtszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn abfahrtszone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftsstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftszone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verspätung;
        private System.Windows.Forms.Button Changer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button GoogleMapsSearch2;
        private System.Windows.Forms.Button GoogleMapsSearch1;
    }
}

