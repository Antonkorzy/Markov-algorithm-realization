namespace НАМ
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveAs = new System.Windows.Forms.ToolStripButton();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WorkStr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EventTable = new System.Windows.Forms.DataGridView();
            this.Экземпляр = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Замена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Комментарий = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStep = new System.Windows.Forms.Button();
            this.buttonAddStr = new System.Windows.Forms.Button();
            this.buttonDelStr = new System.Windows.Forms.Button();
            this.buttonCreateAlp = new System.Windows.Forms.Button();
            this.labelAlp = new System.Windows.Forms.Label();
            this.textBoxEmpty = new System.Windows.Forms.TextBox();
            this.labelStepBefore = new System.Windows.Forms.Label();
            this.labelStrFirst = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventTable)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripButtonSaveAs});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(924, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = global::НАМ.Properties.Resources.fileopen_1195;
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpen.Text = "Открыть...";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::НАМ.Properties.Resources.floppy;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "Сохранить...";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonSaveAs
            // 
            this.toolStripButtonSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveAs.Image = global::НАМ.Properties.Resources.save_all_1227;
            this.toolStripButtonSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveAs.Name = "toolStripButtonSaveAs";
            this.toolStripButtonSaveAs.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveAs.Text = "Сохранить как...";
            this.toolStripButtonSaveAs.Click += new System.EventHandler(this.toolStripButtonSaveAs_Click);
            // 
            // textBoxTask
            // 
            this.textBoxTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask.Location = new System.Drawing.Point(12, 54);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(898, 73);
            this.textBoxTask.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Условие задачи:";
            // 
            // WorkStr
            // 
            this.WorkStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.WorkStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkStr.Location = new System.Drawing.Point(133, 138);
            this.WorkStr.MaxLength = 100;
            this.WorkStr.Name = "WorkStr";
            this.WorkStr.Size = new System.Drawing.Size(777, 31);
            this.WorkStr.TabIndex = 3;
            this.toolTipInfo.SetToolTip(this.WorkStr, "Сюда можно ввести элементы из выбранного алфавита!\r\nСтрока рассчитана на 100 элем" +
        "ентов!");
            this.WorkStr.TextChanged += new System.EventHandler(this.WorkStr_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Рабочая строка:";
            // 
            // EventTable
            // 
            this.EventTable.AllowUserToAddRows = false;
            this.EventTable.AllowUserToDeleteRows = false;
            this.EventTable.AllowUserToResizeColumns = false;
            this.EventTable.AllowUserToResizeRows = false;
            this.EventTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventTable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.EventTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Экземпляр,
            this.Замена,
            this.Комментарий});
            this.EventTable.GridColor = System.Drawing.Color.Gray;
            this.EventTable.Location = new System.Drawing.Point(146, 282);
            this.EventTable.MultiSelect = false;
            this.EventTable.Name = "EventTable";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.EventTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.EventTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EventTable.ShowEditingIcon = false;
            this.EventTable.Size = new System.Drawing.Size(778, 318);
            this.EventTable.TabIndex = 5;
            this.EventTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventTable_CellClick);
            this.EventTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventTable_CellEndEdit);
            // 
            // Экземпляр
            // 
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.Экземпляр.DefaultCellStyle = dataGridViewCellStyle7;
            this.Экземпляр.HeaderText = "Экземпляр";
            this.Экземпляр.MinimumWidth = 100;
            this.Экземпляр.Name = "Экземпляр";
            this.Экземпляр.Width = 200;
            // 
            // Замена
            // 
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.Замена.DefaultCellStyle = dataGridViewCellStyle8;
            this.Замена.HeaderText = "Замена";
            this.Замена.MinimumWidth = 100;
            this.Замена.Name = "Замена";
            this.Замена.Width = 200;
            // 
            // Комментарий
            // 
            this.Комментарий.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.Комментарий.DefaultCellStyle = dataGridViewCellStyle9;
            this.Комментарий.HeaderText = "Комментарий";
            this.Комментарий.MinimumWidth = 200;
            this.Комментарий.Name = "Комментарий";
            this.Комментарий.Width = 200;
            // 
            // buttonStart
            // 
            this.buttonStart.Image = global::НАМ.Properties.Resources.shell32_290;
            this.buttonStart.Location = new System.Drawing.Point(56, 294);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(27, 28);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStep
            // 
            this.buttonStep.Location = new System.Drawing.Point(16, 328);
            this.buttonStep.Name = "buttonStep";
            this.buttonStep.Size = new System.Drawing.Size(101, 34);
            this.buttonStep.TabIndex = 7;
            this.buttonStep.Text = "Пошаговое выполнение";
            this.buttonStep.UseVisualStyleBackColor = true;
            this.buttonStep.Click += new System.EventHandler(this.buttonStep_Click);
            // 
            // buttonAddStr
            // 
            this.buttonAddStr.Location = new System.Drawing.Point(12, 471);
            this.buttonAddStr.Name = "buttonAddStr";
            this.buttonAddStr.Size = new System.Drawing.Size(105, 23);
            this.buttonAddStr.TabIndex = 8;
            this.buttonAddStr.Text = "Добавить строку";
            this.buttonAddStr.UseVisualStyleBackColor = true;
            this.buttonAddStr.Click += new System.EventHandler(this.buttonAddStr_Click);
            // 
            // buttonDelStr
            // 
            this.buttonDelStr.Location = new System.Drawing.Point(12, 527);
            this.buttonDelStr.Name = "buttonDelStr";
            this.buttonDelStr.Size = new System.Drawing.Size(105, 23);
            this.buttonDelStr.TabIndex = 9;
            this.buttonDelStr.Text = "Удалить строку";
            this.buttonDelStr.UseVisualStyleBackColor = true;
            this.buttonDelStr.Click += new System.EventHandler(this.buttonDelStr_Click);
            // 
            // buttonCreateAlp
            // 
            this.buttonCreateAlp.Location = new System.Drawing.Point(12, 190);
            this.buttonCreateAlp.Name = "buttonCreateAlp";
            this.buttonCreateAlp.Size = new System.Drawing.Size(124, 23);
            this.buttonCreateAlp.TabIndex = 10;
            this.buttonCreateAlp.Text = "Создание алфавита";
            this.toolTipInfo.SetToolTip(this.buttonCreateAlp, "Откроется меню создания алфавита!");
            this.buttonCreateAlp.UseVisualStyleBackColor = true;
            this.buttonCreateAlp.Click += new System.EventHandler(this.buttonCreateAlp_Click);
            // 
            // labelAlp
            // 
            this.labelAlp.AutoSize = true;
            this.labelAlp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlp.Location = new System.Drawing.Point(163, 252);
            this.labelAlp.Name = "labelAlp";
            this.labelAlp.Size = new System.Drawing.Size(98, 16);
            this.labelAlp.TabIndex = 11;
            this.labelAlp.Text = "Ваш алфавит:";
            // 
            // textBoxEmpty
            // 
            this.textBoxEmpty.Location = new System.Drawing.Point(16, 424);
            this.textBoxEmpty.Name = "textBoxEmpty";
            this.textBoxEmpty.Size = new System.Drawing.Size(25, 20);
            this.textBoxEmpty.TabIndex = 12;
            // 
            // labelStepBefore
            // 
            this.labelStepBefore.AutoSize = true;
            this.labelStepBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelStepBefore.Location = new System.Drawing.Point(163, 189);
            this.labelStepBefore.Name = "labelStepBefore";
            this.labelStepBefore.Size = new System.Drawing.Size(0, 16);
            this.labelStepBefore.TabIndex = 13;
            // 
            // labelStrFirst
            // 
            this.labelStrFirst.AutoSize = true;
            this.labelStrFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelStrFirst.Location = new System.Drawing.Point(163, 219);
            this.labelStrFirst.Name = "labelStrFirst";
            this.labelStrFirst.Size = new System.Drawing.Size(121, 16);
            this.labelStrFirst.TabIndex = 14;
            this.labelStrFirst.Text = "Исходная строка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 395);
            this.label3.MaximumSize = new System.Drawing.Size(100, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Для обозначения пустоты";
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(924, 598);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelStrFirst);
            this.Controls.Add(this.labelStepBefore);
            this.Controls.Add(this.textBoxEmpty);
            this.Controls.Add(this.labelAlp);
            this.Controls.Add(this.buttonCreateAlp);
            this.Controls.Add(this.buttonDelStr);
            this.Controls.Add(this.buttonAddStr);
            this.Controls.Add(this.buttonStep);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.EventTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WorkStr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTask);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Main";
            this.Text = "Интерпретатор нормальных алгорифмов Маркова";
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WorkStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView EventTable;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStep;
        private System.Windows.Forms.Button buttonAddStr;
        private System.Windows.Forms.Button buttonDelStr;
        private System.Windows.Forms.Button buttonCreateAlp;
        private System.Windows.Forms.Label labelAlp;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveAs;
        private System.Windows.Forms.TextBox textBoxEmpty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Экземпляр;
        private System.Windows.Forms.DataGridViewTextBoxColumn Замена;
        private System.Windows.Forms.DataGridViewTextBoxColumn Комментарий;
        private System.Windows.Forms.Label labelStepBefore;
        private System.Windows.Forms.Label labelStrFirst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTipInfo;
    }
}

