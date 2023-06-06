namespace Malthus_v1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_alunos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fld_crescpop = new System.Windows.Forms.TextBox();
            this.fld_cnsum = new System.Windows.Forms.TextBox();
            this.fld_crescalim = new System.Windows.Forms.TextBox();
            this.fld_alimnt = new System.Windows.Forms.TextBox();
            this.fld_populac = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_dadosreais = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade inicial da população:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade inicial de alimentos (Ton):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Consumo de alimentos por pessoa (Ton/ano):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Taxa de crescimento da população (por ano):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Taxa de produção de alimentos (por ano):";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Image = global::Malthus_v1.Properties.Resources.Banner_mini2;
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 95);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_alunos
            // 
            this.lbl_alunos.AutoSize = true;
            this.lbl_alunos.Location = new System.Drawing.Point(12, 375);
            this.lbl_alunos.Name = "lbl_alunos";
            this.lbl_alunos.Size = new System.Drawing.Size(322, 13);
            this.lbl_alunos.TabIndex = 6;
            this.lbl_alunos.Text = "Programa criado por alunos do IFSP. Seu uso é apenas educativo.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "&Limpar Campos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fld_crescpop
            // 
            this.fld_crescpop.Location = new System.Drawing.Point(240, 228);
            this.fld_crescpop.Name = "fld_crescpop";
            this.fld_crescpop.Size = new System.Drawing.Size(100, 20);
            this.fld_crescpop.TabIndex = 4;
            this.fld_crescpop.TextChanged += new System.EventHandler(this.fld_crescpop_TextChanged);
            this.fld_crescpop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fld_crescpop_KeyPress);
            // 
            // fld_cnsum
            // 
            this.fld_cnsum.Location = new System.Drawing.Point(240, 193);
            this.fld_cnsum.Name = "fld_cnsum";
            this.fld_cnsum.Size = new System.Drawing.Size(100, 20);
            this.fld_cnsum.TabIndex = 3;
            this.fld_cnsum.TextChanged += new System.EventHandler(this.fld_cnsum_TextChanged);
            this.fld_cnsum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fld_cnsum_KeyPress);
            // 
            // fld_crescalim
            // 
            this.fld_crescalim.Location = new System.Drawing.Point(240, 261);
            this.fld_crescalim.Name = "fld_crescalim";
            this.fld_crescalim.Size = new System.Drawing.Size(100, 20);
            this.fld_crescalim.TabIndex = 5;
            this.fld_crescalim.TextChanged += new System.EventHandler(this.fld_crescalim_TextChanged);
            this.fld_crescalim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fld_crescalim_KeyPress);
            // 
            // fld_alimnt
            // 
            this.fld_alimnt.Location = new System.Drawing.Point(240, 158);
            this.fld_alimnt.Name = "fld_alimnt";
            this.fld_alimnt.Size = new System.Drawing.Size(100, 20);
            this.fld_alimnt.TabIndex = 2;
            this.fld_alimnt.TextChanged += new System.EventHandler(this.fld_alimnt_TextChanged);
            this.fld_alimnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fld_alimnt_KeyPress);
            // 
            // fld_populac
            // 
            this.fld_populac.Location = new System.Drawing.Point(240, 125);
            this.fld_populac.Name = "fld_populac";
            this.fld_populac.Size = new System.Drawing.Size(100, 20);
            this.fld_populac.TabIndex = 1;
            this.fld_populac.TextChanged += new System.EventHandler(this.fld_populac_TextChanged);
            this.fld_populac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fld_populac_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ton";
            // 
            // cb_dadosreais
            // 
            this.cb_dadosreais.AutoSize = true;
            this.cb_dadosreais.Location = new System.Drawing.Point(15, 301);
            this.cb_dadosreais.Name = "cb_dadosreais";
            this.cb_dadosreais.Size = new System.Drawing.Size(131, 17);
            this.cb_dadosreais.TabIndex = 6;
            this.cb_dadosreais.Text = "Usar dados padrão (?)";
            this.cb_dadosreais.UseVisualStyleBackColor = true;
            this.cb_dadosreais.CheckedChanged += new System.EventHandler(this.cb_dadosreais_CheckedChanged);
            this.cb_dadosreais.MouseHover += new System.EventHandler(this.cb_dadosreais_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "mil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 413);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_dadosreais);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fld_populac);
            this.Controls.Add(this.fld_alimnt);
            this.Controls.Add(this.fld_crescalim);
            this.Controls.Add(this.fld_cnsum);
            this.Controls.Add(this.fld_crescpop);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_alunos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Programa Malthusiano 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_alunos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox fld_crescpop;
        private System.Windows.Forms.TextBox fld_cnsum;
        private System.Windows.Forms.TextBox fld_crescalim;
        private System.Windows.Forms.TextBox fld_alimnt;
        private System.Windows.Forms.TextBox fld_populac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_dadosreais;
        private System.Windows.Forms.Label label6;
    }
}

