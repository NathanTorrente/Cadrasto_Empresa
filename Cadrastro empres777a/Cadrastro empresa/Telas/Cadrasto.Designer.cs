﻿namespace Cadrastro_empresa
{
    partial class Cadrasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadrasto));
            rz = new TextBox();
            nomefantasi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            CNPJ = new MaskedTextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label7 = new Label();
            telefones = new MaskedTextBox();
            label8 = new Label();
            label9 = new Label();
            CapitalS = new TextBox();
            label10 = new Label();
            enderecoC = new ComboBox();
            radioButton4 = new RadioButton();
            label11 = new Label();
            radioButton5 = new RadioButton();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            naturezaJ = new ComboBox();
            label15 = new Label();
            nomepropris = new TextBox();
            cpfpro = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            situacao = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // rz
            // 
            rz.BackColor = SystemColors.ActiveBorder;
            rz.Location = new Point(219, 181);
            rz.Name = "rz";
            rz.Size = new Size(201, 23);
            rz.TabIndex = 1;
            // 
            // nomefantasi
            // 
            nomefantasi.BackColor = SystemColors.ActiveBorder;
            nomefantasi.Location = new Point(219, 236);
            nomefantasi.Name = "nomefantasi";
            nomefantasi.Size = new Size(201, 23);
            nomefantasi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(60, 135);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 5;
            label1.Text = "Cnpj";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(58, 183);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 6;
            label2.Text = "Razão Social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(58, 238);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 7;
            label3.Text = "Nome Fantasia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(58, 287);
            label4.Name = "label4";
            label4.Size = new Size(144, 21);
            label4.TabIndex = 8;
            label4.Text = "Situação Cadratal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(57, 337);
            label5.Name = "label5";
            label5.Size = new Size(145, 21);
            label5.TabIndex = 9;
            label5.Text = "Regime tributário";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Khaki;
            label6.Location = new Point(0, 9);
            label6.Name = "label6";
            label6.Size = new Size(462, 65);
            label6.TabIndex = 10;
            label6.Text = "Cadrastar  Empresa";
            // 
            // CNPJ
            // 
            CNPJ.BackColor = SystemColors.ActiveBorder;
            CNPJ.Location = new Point(219, 137);
            CNPJ.Mask = "00,000,000/0000-00";
            CNPJ.Name = "CNPJ";
            CNPJ.Size = new Size(201, 23);
            CNPJ.TabIndex = 11;
            CNPJ.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = SystemColors.WindowFrame;
            radioButton1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.AliceBlue;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(153, 24);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Simples Nacional";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = SystemColors.WindowFrame;
            radioButton2.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.AliceBlue;
            radioButton2.Location = new Point(274, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(152, 24);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Lucro Presumido";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = SystemColors.WindowFrame;
            radioButton3.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.ForeColor = Color.AliceBlue;
            radioButton3.Location = new Point(165, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(103, 24);
            radioButton3.TabIndex = 15;
            radioButton3.TabStop = true;
            radioButton3.Text = "Lucro Real";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DeepSkyBlue;
            label7.Location = new Point(60, 397);
            label7.Name = "label7";
            label7.Size = new Size(180, 21);
            label7.TabIndex = 17;
            label7.Text = "Data Inicio atividades:";
            // 
            // telefones
            // 
            telefones.BackColor = SystemColors.ActiveBorder;
            telefones.Location = new Point(161, 429);
            telefones.Mask = "(00) 00000-0000";
            telefones.Name = "telefones";
            telefones.Size = new Size(152, 23);
            telefones.TabIndex = 18;
            telefones.ValidatingType = typeof(DateTime);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DeepSkyBlue;
            label8.Location = new Point(60, 427);
            label8.Name = "label8";
            label8.Size = new Size(76, 21);
            label8.TabIndex = 19;
            label8.Text = "Telefone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DeepSkyBlue;
            label9.Location = new Point(60, 472);
            label9.Name = "label9";
            label9.Size = new Size(114, 21);
            label9.TabIndex = 20;
            label9.Text = "Capital Social";
            // 
            // CapitalS
            // 
            CapitalS.BackColor = SystemColors.ActiveBorder;
            CapitalS.Location = new Point(202, 474);
            CapitalS.Name = "CapitalS";
            CapitalS.Size = new Size(172, 23);
            CapitalS.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DeepSkyBlue;
            label10.Location = new Point(58, 532);
            label10.Name = "label10";
            label10.Size = new Size(164, 21);
            label10.TabIndex = 22;
            label10.Text = "Endereço Completo:";
            // 
            // enderecoC
            // 
            enderecoC.BackColor = SystemColors.ActiveBorder;
            enderecoC.FormattingEnabled = true;
            enderecoC.Items.AddRange(new object[] { "Acre", "Amazonas", "Amapa", "Alagoas", "Bahia", "Ceará", "Roraima", "Tocantins ", "Pará", "Paraná", "Rio Grande do Sul", "Santa Catarina", "Mato grosso", "Mato grosso do sul", "Goías", "Dístrito Federal", "São Paulo", "Rio de Janeiro", "Minas Gerais", "Espírito do Santo", "Sergipe", "Mararrão", "Piauí", "Pernambuco", "Paraíba", "Rio Grande do Norte", "Rondônia" });
            enderecoC.Location = new Point(242, 532);
            enderecoC.Name = "enderecoC";
            enderecoC.Size = new Size(126, 23);
            enderecoC.TabIndex = 23;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = SystemColors.WindowFrame;
            radioButton4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton4.ForeColor = SystemColors.ButtonHighlight;
            radioButton4.Location = new Point(142, 22);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(77, 25);
            radioButton4.TabIndex = 24;
            radioButton4.TabStop = true;
            radioButton4.Text = "Matriz";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DeepSkyBlue;
            label11.Location = new Point(60, 606);
            label11.Name = "label11";
            label11.Size = new Size(48, 21);
            label11.TabIndex = 25;
            label11.Text = "Tipo:";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.BackColor = SystemColors.WindowFrame;
            radioButton5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton5.ForeColor = SystemColors.ButtonHighlight;
            radioButton5.Location = new Point(54, 22);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(65, 25);
            radioButton5.TabIndex = 26;
            radioButton5.TabStop = true;
            radioButton5.Text = "Filial";
            radioButton5.UseVisualStyleBackColor = false;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.DeepSkyBlue;
            label12.Location = new Point(707, 139);
            label12.Name = "label12";
            label12.Size = new Size(147, 21);
            label12.TabIndex = 28;
            label12.Text = "Porte da Empresa:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.DeepSkyBlue;
            label13.Location = new Point(710, 234);
            label13.Name = "label13";
            label13.Size = new Size(144, 21);
            label13.TabIndex = 29;
            label13.Text = "Natureza Jurídica";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.DeepSkyBlue;
            label14.Location = new Point(707, 297);
            label14.Name = "label14";
            label14.Size = new Size(177, 21);
            label14.TabIndex = 30;
            label14.Text = "Nome do Proprietário";
            // 
            // naturezaJ
            // 
            naturezaJ.BackColor = SystemColors.ActiveBorder;
            naturezaJ.FormattingEnabled = true;
            naturezaJ.Items.AddRange(new object[] { "EI - Empresário Individual", "MEI - Micropreendedor Individual", "Sociedade Anônima" });
            naturezaJ.Location = new Point(898, 236);
            naturezaJ.Name = "naturezaJ";
            naturezaJ.Size = new Size(214, 23);
            naturezaJ.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.DeepSkyBlue;
            label15.Location = new Point(707, 337);
            label15.Name = "label15";
            label15.Size = new Size(160, 21);
            label15.TabIndex = 35;
            label15.Text = "Cpf do Proprietário:";
            // 
            // nomepropris
            // 
            nomepropris.BackColor = SystemColors.ActiveBorder;
            nomepropris.Location = new Point(911, 289);
            nomepropris.Name = "nomepropris";
            nomepropris.Size = new Size(201, 23);
            nomepropris.TabIndex = 36;
            // 
            // cpfpro
            // 
            cpfpro.BackColor = SystemColors.ActiveBorder;
            cpfpro.Location = new Point(911, 337);
            cpfpro.Mask = "000,000,000,00";
            cpfpro.Name = "cpfpro";
            cpfpro.Size = new Size(201, 23);
            cpfpro.TabIndex = 37;
            cpfpro.MaskInputRejected += maskedTextBox4_MaskInputRejected;
            // 
            // button1
            // 
            button1.BackColor = Color.LawnGreen;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.WindowText;
            button1.ImageKey = "(nenhum)";
            button1.Location = new Point(920, 455);
            button1.Name = "button1";
            button1.Size = new Size(221, 56);
            button1.TabIndex = 41;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Source Code Pro Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(920, 535);
            button2.Name = "button2";
            button2.Size = new Size(251, 54);
            button2.TabIndex = 42;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(246, 400);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 43;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.BackColor = SystemColors.ControlDarkDark;
            radioButton6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton6.ForeColor = Color.AliceBlue;
            radioButton6.Location = new Point(13, 22);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(96, 25);
            radioButton6.TabIndex = 32;
            radioButton6.TabStop = true;
            radioButton6.Text = "Pequeno";
            radioButton6.UseVisualStyleBackColor = false;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.BackColor = SystemColors.ControlDarkDark;
            radioButton7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton7.ForeColor = Color.AliceBlue;
            radioButton7.Location = new Point(115, 22);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(77, 25);
            radioButton7.TabIndex = 33;
            radioButton7.TabStop = true;
            radioButton7.Text = "Medio";
            radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.BackColor = SystemColors.ControlDarkDark;
            radioButton8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton8.ForeColor = Color.AliceBlue;
            radioButton8.Location = new Point(209, 22);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(83, 25);
            radioButton8.TabIndex = 34;
            radioButton8.TabStop = true;
            radioButton8.Text = "Grande";
            radioButton8.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chartreuse;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(1079, 472);
            panel1.Name = "panel1";
            panel1.Size = new Size(33, 32);
            panel1.TabIndex = 44;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.WindowFrame;
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(220, 337);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 57);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlDarkDark;
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Location = new Point(219, 585);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(257, 64);
            groupBox2.TabIndex = 46;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlDarkDark;
            groupBox3.Controls.Add(radioButton6);
            groupBox3.Controls.Add(radioButton7);
            groupBox3.Controls.Add(radioButton8);
            groupBox3.Location = new Point(898, 135);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(326, 60);
            groupBox3.TabIndex = 46;
            groupBox3.TabStop = false;
            // 
            // situacao
            // 
            situacao.BackColor = SystemColors.ActiveBorder;
            situacao.FormattingEnabled = true;
            situacao.Items.AddRange(new object[] { "Ativa", "Nula", "Suspensa", "Inapta ", "Baixada" });
            situacao.Location = new Point(220, 285);
            situacao.Name = "situacao";
            situacao.Size = new Size(200, 23);
            situacao.TabIndex = 12;
            situacao.SelectedIndexChanged += situacao_SelectedIndexChanged;
            // 
            // Cadrasto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1310, 661);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cpfpro);
            Controls.Add(nomepropris);
            Controls.Add(label15);
            Controls.Add(naturezaJ);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(enderecoC);
            Controls.Add(label10);
            Controls.Add(CapitalS);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(telefones);
            Controls.Add(label7);
            Controls.Add(situacao);
            Controls.Add(CNPJ);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nomefantasi);
            Controls.Add(rz);
            Name = "Cadrasto";
            Text = "Cadrasto";
            Load += Cadrasto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox rz;
        private TextBox nomefantasi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox CNPJ;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label7;
        private MaskedTextBox telefones;
        private Label label8;
        private Label label9;
        private TextBox CapitalS;
        private Label label10;
        private ComboBox enderecoC;
        private RadioButton radioButton4;
        private Label label11;
        private RadioButton radioButton5;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox naturezaJ;
        private Label label15;
        private TextBox nomepropris;
        private MaskedTextBox cpfpro;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox situacao;
    }
}