namespace Adam_Asmaca
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
            HangmanLabel = new Label();
            txtHarf = new TextBox();
            btnTahmin = new Button();
            btnBaslat = new Button();
            panelCizim = new Panel();
            lblKelime = new Label();
            lblHak = new Label();
            SuspendLayout();
            // 
            // HangmanLabel
            // 
            HangmanLabel.AutoSize = true;
            HangmanLabel.BackColor = Color.Azure;
            HangmanLabel.Font = new Font("Cooper Black", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HangmanLabel.Location = new Point(86, 9);
            HangmanLabel.Name = "HangmanLabel";
            HangmanLabel.Size = new Size(377, 64);
            HangmanLabel.TabIndex = 0;
            HangmanLabel.Text = " HANGMAN ";
            // 
            // txtHarf
            // 
            txtHarf.Location = new Point(181, 306);
            txtHarf.Margin = new Padding(3, 2, 3, 2);
            txtHarf.Name = "txtHarf";
            txtHarf.Size = new Size(182, 31);
            txtHarf.TabIndex = 1;
            // 
            // btnTahmin
            // 
            btnTahmin.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnTahmin.Location = new Point(216, 342);
            btnTahmin.Margin = new Padding(3, 2, 3, 2);
            btnTahmin.Name = "btnTahmin";
            btnTahmin.Size = new Size(112, 34);
            btnTahmin.TabIndex = 2;
            btnTahmin.Text = "Tahmin";
            btnTahmin.UseVisualStyleBackColor = true;
            btnTahmin.Click += btnTahmin_Click;
            // 
            // btnBaslat
            // 
            btnBaslat.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnBaslat.Location = new Point(132, 425);
            btnBaslat.Margin = new Padding(3, 2, 3, 2);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(278, 86);
            btnBaslat.TabIndex = 4;
            btnBaslat.Text = "BAŞLA!";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += StartButton_Click;
            // 
            // panelCizim
            // 
            panelCizim.Location = new Point(101, 71);
            panelCizim.Margin = new Padding(3, 2, 3, 2);
            panelCizim.Name = "panelCizim";
            panelCizim.Size = new Size(336, 178);
            panelCizim.TabIndex = 5;
            panelCizim.Paint += panelCizim_Paint;
            // 
            // lblKelime
            // 
            lblKelime.AutoSize = true;
            lblKelime.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblKelime.Location = new Point(147, 272);
            lblKelime.Name = "lblKelime";
            lblKelime.Size = new Size(250, 20);
            lblKelime.TabIndex = 6;
            lblKelime.Text = "Bilgisayar Mühendislerine Özel!";
            lblKelime.Click += lblKelime_Click;
            // 
            // lblHak
            // 
            lblHak.AutoSize = true;
            lblHak.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHak.Location = new Point(169, 390);
            lblHak.Name = "lblHak";
            lblHak.Size = new Size(209, 20);
            lblHak.TabIndex = 7;
            lblHak.Text = "Başlamak için butona bas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(553, 542);
            Controls.Add(lblKelime);
            Controls.Add(lblHak);
            Controls.Add(panelCizim);
            Controls.Add(btnBaslat);
            Controls.Add(btnTahmin);
            Controls.Add(txtHarf);
            Controls.Add(HangmanLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hangman";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HangmanLabel;
        private TextBox txtHarf;
        private Button btnTahmin;
        private Button btnBaslat;
        private Panel panelCizim;
        private Label lblKelime;
        private Label lblHak;
    }
}
