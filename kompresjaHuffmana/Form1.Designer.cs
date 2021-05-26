namespace kompresjaHuffmana
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tekst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.informacje = new System.Windows.Forms.TextBox();
            this.tekstBinary = new System.Windows.Forms.TextBox();
            this.statystyka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tekst
            // 
            this.tekst.Location = new System.Drawing.Point(13, 29);
            this.tekst.Multiline = true;
            this.tekst.Name = "tekst";
            this.tekst.Size = new System.Drawing.Size(359, 114);
            this.tekst.TabIndex = 1;
            this.tekst.Text = "SHE SELLS SEASHELLS BY THE SEASHORE\r\nTHE SHELLS SHE SELLS ARE SEASHELLS I\'M SURE\r" +
    "\nSO IF SHE SELLS SEASHELLS ON THE SEASHORE\r\nTHEN I\'M SURE SHE SELLS SEASHORE SHE" +
    "LLS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tekst do kompresji:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Policz prawdopodobieństwa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // informacje
            // 
            this.informacje.Enabled = false;
            this.informacje.Location = new System.Drawing.Point(378, 29);
            this.informacje.Multiline = true;
            this.informacje.Name = "informacje";
            this.informacje.Size = new System.Drawing.Size(345, 409);
            this.informacje.TabIndex = 3;
            this.informacje.Text = "znak(liczba bitów) - ciąg bitów";
            // 
            // tekstBinary
            // 
            this.tekstBinary.Enabled = false;
            this.tekstBinary.Location = new System.Drawing.Point(13, 179);
            this.tekstBinary.Multiline = true;
            this.tekstBinary.Name = "tekstBinary";
            this.tekstBinary.Size = new System.Drawing.Size(359, 259);
            this.tekstBinary.TabIndex = 4;
            this.tekstBinary.Text = "Postać skompresowana";
            // 
            // statystyka
            // 
            this.statystyka.AutoSize = true;
            this.statystyka.Location = new System.Drawing.Point(13, 445);
            this.statystyka.Name = "statystyka";
            this.statystyka.Size = new System.Drawing.Size(160, 13);
            this.statystyka.TabIndex = 5;
            this.statystyka.Text = "Naciśnij przycisk aby rozpocząć!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 467);
            this.Controls.Add(this.statystyka);
            this.Controls.Add(this.tekstBinary);
            this.Controls.Add(this.informacje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tekst);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tekst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox informacje;
        private System.Windows.Forms.TextBox tekstBinary;
        private System.Windows.Forms.Label statystyka;
    }
}

