namespace НАМ
{
    partial class CreateAlp
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
            this.components = new System.ComponentModel.Container();
            this.alph1 = new System.Windows.Forms.Button();
            this.alph2 = new System.Windows.Forms.Button();
            this.alph3 = new System.Windows.Forms.Button();
            this.alph = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateMasText = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAlphCreate = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxEmpty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // alph1
            // 
            this.alph1.Location = new System.Drawing.Point(119, 60);
            this.alph1.Name = "alph1";
            this.alph1.Size = new System.Drawing.Size(127, 23);
            this.alph1.TabIndex = 0;
            this.alph1.Text = "Бинарный алфавит";
            this.alph1.UseVisualStyleBackColor = true;
            this.alph1.Click += new System.EventHandler(this.alph1_Click);
            // 
            // alph2
            // 
            this.alph2.Location = new System.Drawing.Point(119, 102);
            this.alph2.Name = "alph2";
            this.alph2.Size = new System.Drawing.Size(127, 23);
            this.alph2.TabIndex = 1;
            this.alph2.Text = "Английский алфавит";
            this.toolTipInfo.SetToolTip(this.alph2, "Сгенерируется английский алфавит без знаков препинания");
            this.alph2.UseVisualStyleBackColor = true;
            this.alph2.Click += new System.EventHandler(this.alph2_Click);
            // 
            // alph3
            // 
            this.alph3.AutoSize = true;
            this.alph3.Location = new System.Drawing.Point(119, 148);
            this.alph3.Name = "alph3";
            this.alph3.Size = new System.Drawing.Size(127, 23);
            this.alph3.TabIndex = 2;
            this.alph3.Text = "Русский алфавит";
            this.toolTipInfo.SetToolTip(this.alph3, "Сгенерируется русский алфавит без знаков препинания");
            this.alph3.UseVisualStyleBackColor = true;
            this.alph3.Click += new System.EventHandler(this.alph3_Click);
            // 
            // alph
            // 
            this.alph.AutoSize = true;
            this.alph.Location = new System.Drawing.Point(61, 58);
            this.alph.Name = "alph";
            this.alph.Size = new System.Drawing.Size(77, 23);
            this.alph.TabIndex = 3;
            this.alph.Text = "Создание";
            this.alph.UseVisualStyleBackColor = true;
            this.alph.Click += new System.EventHandler(this.alph_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(77, 18);
            this.label1.MaximumSize = new System.Drawing.Size(350, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Задайте свой алфавит!";
            // 
            // CreateMasText
            // 
            this.CreateMasText.Location = new System.Drawing.Point(6, 32);
            this.CreateMasText.Name = "CreateMasText";
            this.CreateMasText.Size = new System.Drawing.Size(185, 20);
            this.CreateMasText.TabIndex = 8;
            this.toolTipInfo.SetToolTip(this.CreateMasText, "Задайте свой алфавит!\r\nЗнак \"λ\" обозначает пустоту!");
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(147, 365);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 9;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateMasText);
            this.groupBox1.Controls.Add(this.alph);
            this.groupBox1.Location = new System.Drawing.Point(84, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 98);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Свой алфавит";
            // 
            // buttonAlphCreate
            // 
            this.buttonAlphCreate.Location = new System.Drawing.Point(145, 319);
            this.buttonAlphCreate.Name = "buttonAlphCreate";
            this.buttonAlphCreate.Size = new System.Drawing.Size(77, 23);
            this.buttonAlphCreate.TabIndex = 9;
            this.buttonAlphCreate.Text = "Из файла";
            this.toolTipInfo.SetToolTip(this.buttonAlphCreate, "Загрузите ваш алфавит из текстового файла!");
            this.buttonAlphCreate.UseVisualStyleBackColor = true;
            this.buttonAlphCreate.Click += new System.EventHandler(this.buttonAlphCreate_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // toolTipInfo
            // 
            this.toolTipInfo.AutomaticDelay = 100;
            this.toolTipInfo.AutoPopDelay = 5000;
            this.toolTipInfo.InitialDelay = 100;
            this.toolTipInfo.ReshowDelay = 20;
            this.toolTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfo.ToolTipTitle = "Важно!";
            // 
            // textBoxEmpty
            // 
            this.textBoxEmpty.Location = new System.Drawing.Point(15, 354);
            this.textBoxEmpty.Name = "textBoxEmpty";
            this.textBoxEmpty.Size = new System.Drawing.Size(22, 20);
            this.textBoxEmpty.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 316);
            this.label3.MaximumSize = new System.Drawing.Size(100, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Для обозначения пустоты";
            // 
            // CreateAlp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(390, 399);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEmpty);
            this.Controls.Add(this.buttonAlphCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alph3);
            this.Controls.Add(this.alph2);
            this.Controls.Add(this.alph1);
            this.Name = "CreateAlp";
            this.Text = "Алфавит";
            this.Load += new System.EventHandler(this.CreateAlp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button alph1;
        private System.Windows.Forms.Button alph2;
        private System.Windows.Forms.Button alph3;
        private System.Windows.Forms.Button alph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CreateMasText;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAlphCreate;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.TextBox textBoxEmpty;
        private System.Windows.Forms.Label label3;
    }
}