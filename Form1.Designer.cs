
namespace UP3Jazda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.skanujButton = new System.Windows.Forms.Button();
            this.listaSkanerow = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.PojemnikNaObraz = new System.Windows.Forms.PictureBox();
            this.resLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PojemnikNaObraz)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.skanujButton);
            this.panel1.Controls.Add(this.listaSkanerow);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 270);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista urządzeń";
            // 
            // skanujButton
            // 
            this.skanujButton.Location = new System.Drawing.Point(7, 195);
            this.skanujButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skanujButton.Name = "skanujButton";
            this.skanujButton.Size = new System.Drawing.Size(130, 40);
            this.skanujButton.TabIndex = 2;
            this.skanujButton.Text = "Skanuj!";
            this.skanujButton.UseVisualStyleBackColor = true;
            this.skanujButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaSkanerow
            // 
            this.listaSkanerow.FormattingEnabled = true;
            this.listaSkanerow.ItemHeight = 20;
            this.listaSkanerow.Location = new System.Drawing.Point(7, 42);
            this.listaSkanerow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listaSkanerow.Name = "listaSkanerow";
            this.listaSkanerow.Size = new System.Drawing.Size(271, 144);
            this.listaSkanerow.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.PojemnikNaObraz);
            this.panel2.Location = new System.Drawing.Point(393, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 587);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "rozdzielczość:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(176, 405);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(274, 69);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Value = 300;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(15, 548);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(93, 24);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "1-bitowy";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(15, 514);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 24);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "RGB";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 480);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Skala szarości";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PojemnikNaObraz
            // 
            this.PojemnikNaObraz.Location = new System.Drawing.Point(3, 4);
            this.PojemnikNaObraz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PojemnikNaObraz.Name = "PojemnikNaObraz";
            this.PojemnikNaObraz.Size = new System.Drawing.Size(489, 385);
            this.PojemnikNaObraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PojemnikNaObraz.TabIndex = 0;
            this.PojemnikNaObraz.TabStop = false;
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Location = new System.Drawing.Point(35, 442);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(40, 20);
            this.resLabel.TabIndex = 13;
            this.resLabel.Text = " 300";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PojemnikNaObraz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listaSkanerow;
        private System.Windows.Forms.Button skanujButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PojemnikNaObraz;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label resLabel;
    }
}

