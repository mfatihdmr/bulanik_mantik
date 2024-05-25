namespace WinFormsApp2
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
            btn_calistir = new Button();
            lbhassaslık = new Label();
            lKirlilik = new Label();
            lMiktar = new Label();
            lblHassas = new Label();
            lblMiktar = new Label();
            lblKirli = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listgoster = new ListView();
            tbhassaslik = new TrackBar();
            tbmiktar = new TrackBar();
            tbkirlilik = new TrackBar();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)tbhassaslik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbmiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbkirlilik).BeginInit();
            SuspendLayout();
            // 
            // btn_calistir
            // 
            btn_calistir.Location = new Point(51, 392);
            btn_calistir.Name = "btn_calistir";
            btn_calistir.Size = new Size(75, 23);
            btn_calistir.TabIndex = 0;
            btn_calistir.Text = "Hesapla";
            btn_calistir.UseVisualStyleBackColor = true;
            btn_calistir.Click += Button1_Click;
            // 
            // lbhassaslık
            // 
            lbhassaslık.AutoSize = true;
            lbhassaslık.Location = new Point(34, 56);
            lbhassaslık.Name = "lbhassaslık";
            lbhassaslık.Size = new Size(13, 15);
            lbhassaslık.TabIndex = 1;
            lbhassaslık.Text = "0";
            // 
            // lKirlilik
            // 
            lKirlilik.AutoSize = true;
            lKirlilik.Location = new Point(34, 323);
            lKirlilik.Name = "lKirlilik";
            lKirlilik.Size = new Size(13, 15);
            lKirlilik.TabIndex = 2;
            lKirlilik.Text = "0";
            // 
            // lMiktar
            // 
            lMiktar.AutoSize = true;
            lMiktar.Location = new Point(34, 184);
            lMiktar.Name = "lMiktar";
            lMiktar.Size = new Size(13, 15);
            lMiktar.TabIndex = 3;
            lMiktar.Text = "0";
            // 
            // lblHassas
            // 
            lblHassas.AutoSize = true;
            lblHassas.Location = new Point(116, 56);
            lblHassas.Name = "lblHassas";
            lblHassas.Size = new Size(13, 15);
            lblHassas.TabIndex = 4;
            lblHassas.Text = "0";
            // 
            // lblMiktar
            // 
            lblMiktar.AutoSize = true;
            lblMiktar.Location = new Point(116, 184);
            lblMiktar.Name = "lblMiktar";
            lblMiktar.Size = new Size(13, 15);
            lblMiktar.TabIndex = 5;
            lblMiktar.Text = "0";
            // 
            // lblKirli
            // 
            lblKirli.AutoSize = true;
            lblKirli.Location = new Point(116, 323);
            lblKirli.Name = "lblKirli";
            lblKirli.Size = new Size(13, 15);
            lblKirli.TabIndex = 6;
            lblKirli.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 463);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 10;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 488);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 11;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 437);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 12;
            label3.Text = "0";
            // 
            // listgoster
            // 
            listgoster.Location = new Point(245, 12);
            listgoster.Name = "listgoster";
            listgoster.Size = new Size(605, 500);
            listgoster.TabIndex = 13;
            listgoster.UseCompatibleStateImageBehavior = false;
            // 
            // tbhassaslik
            // 
            tbhassaslik.Location = new Point(23, 74);
            tbhassaslik.Maximum = 100;
            tbhassaslik.Name = "tbhassaslik";
            tbhassaslik.Size = new Size(131, 45);
            tbhassaslik.TabIndex = 14;
            tbhassaslik.ValueChanged += tbHassas_ValueChanged;
            // 
            // tbmiktar
            // 
            tbmiktar.Location = new Point(23, 202);
            tbmiktar.Maximum = 100;
            tbmiktar.Name = "tbmiktar";
            tbmiktar.Size = new Size(131, 45);
            tbmiktar.TabIndex = 15;
            tbmiktar.ValueChanged += tbMiktar_ValueChanged;
            // 
            // tbkirlilik
            // 
            tbkirlilik.Location = new Point(23, 341);
            tbkirlilik.Maximum = 100;
            tbkirlilik.Name = "tbkirlilik";
            tbkirlilik.Size = new Size(131, 45);
            tbkirlilik.TabIndex = 16;
            tbkirlilik.ValueChanged += tbKirli_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(50, 25);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 17;
            label4.Text = "Hassaslık";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(51, 153);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 18;
            label5.Text = "Miktar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label6.Location = new Point(51, 292);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 19;
            label6.Text = "Kirlilik";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 524);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbkirlilik);
            Controls.Add(tbmiktar);
            Controls.Add(tbhassaslik);
            Controls.Add(listgoster);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblKirli);
            Controls.Add(lblMiktar);
            Controls.Add(lblHassas);
            Controls.Add(lMiktar);
            Controls.Add(lKirlilik);
            Controls.Add(lbhassaslık);
            Controls.Add(btn_calistir);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)tbhassaslik).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbmiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbkirlilik).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_calistir;
        private Label lbhassaslık;
        private Label lKirlilik;
        private Label lMiktar;
        private Label lblHassas;
        private Label lblMiktar;
        private Label lblKirli;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView listgoster;
        private TrackBar tbhassaslik;
        private TrackBar tbmiktar;
        private TrackBar tbkirlilik;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
