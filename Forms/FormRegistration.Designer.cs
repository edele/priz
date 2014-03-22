namespace PRIZ
{
    partial class FormRegistration
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.tbSurename = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAbout = new System.Windows.Forms.TextBox();
            this.btnModules = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLogoCreativeThinker = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogoEducationEra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSurename
            // 
            this.tbSurename.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSurename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSurename.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbSurename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.tbSurename.Location = new System.Drawing.Point(15, 12);
            this.tbSurename.Name = "tbSurename";
            this.tbSurename.Size = new System.Drawing.Size(172, 20);
            this.tbSurename.TabIndex = 1;
            this.tbSurename.Text = "Фамилия";
            this.tbSurename.Enter += new System.EventHandler(this.TextBox_GotFocus);
            this.tbSurename.Leave += new System.EventHandler(this.TextBox_LostFocus);
            // 
            // tbCountry
            // 
            this.tbCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCountry.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.tbCountry.Location = new System.Drawing.Point(13, 12);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(172, 20);
            this.tbCountry.TabIndex = 1;
            this.tbCountry.Text = "Страна";
            this.tbCountry.Enter += new System.EventHandler(this.TextBox_GotFocus);
            this.tbCountry.Leave += new System.EventHandler(this.TextBox_LostFocus);
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.tbName.Location = new System.Drawing.Point(15, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(172, 20);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "Имя";
            this.tbName.Enter += new System.EventHandler(this.TextBox_GotFocus);
            this.tbName.Leave += new System.EventHandler(this.TextBox_LostFocus);
            // 
            // tbAbout
            // 
            this.tbAbout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAbout.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.tbAbout.Location = new System.Drawing.Point(3, 32);
            this.tbAbout.Multiline = true;
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAbout.Size = new System.Drawing.Size(403, 115);
            this.tbAbout.TabIndex = 1;
            this.tbAbout.Text = "О себе";
            this.tbAbout.Enter += new System.EventHandler(this.TextBox_GotFocus);
            this.tbAbout.Leave += new System.EventHandler(this.TextBox_LostFocus);
            // 
            // btnModules
            // 
            this.btnModules.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModules.BackColor = System.Drawing.Color.Transparent;
            this.btnModules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModules.FlatAppearance.BorderSize = 0;
            this.btnModules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModules.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnModules.ForeColor = System.Drawing.Color.White;
            this.btnModules.Image = global::PRIZ.Properties.Resources.login;
            this.btnModules.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModules.Location = new System.Drawing.Point(210, 23);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(111, 79);
            this.btnModules.TabIndex = 2;
            this.btnModules.Text = "Вход";
            this.btnModules.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModules.UseVisualStyleBackColor = false;
            this.btnModules.Click += new System.EventHandler(this.btnModules_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(180, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Зарегестрироваться";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Ученик",
            "Учитель",
            "Родитель",
            "Другое"});
            this.tbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.tbStatus.FormattingEnabled = true;
            this.tbStatus.Items.AddRange(new object[] {
            "Ученик",
            "Учитель",
            "Родитель",
            "Другое"});
            this.tbStatus.Location = new System.Drawing.Point(10, 9);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(185, 28);
            this.tbStatus.TabIndex = 1;
            this.tbStatus.SelectedValueChanged += new System.EventHandler(this.tbStatus_SelectedValueChanged);
            this.tbStatus.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.btnLogoCreativeThinker);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnLogoEducationEra);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(48, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(930, 141);
            this.panel4.TabIndex = 2;
            // 
            // btnLogoCreativeThinker
            // 
            this.btnLogoCreativeThinker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogoCreativeThinker.BackColor = System.Drawing.Color.White;
            this.btnLogoCreativeThinker.BackgroundImage = global::PRIZ.Properties.Resources.Logo_ShKM;
            this.btnLogoCreativeThinker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogoCreativeThinker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoCreativeThinker.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogoCreativeThinker.FlatAppearance.BorderSize = 0;
            this.btnLogoCreativeThinker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogoCreativeThinker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogoCreativeThinker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoCreativeThinker.Location = new System.Drawing.Point(2, 3);
            this.btnLogoCreativeThinker.Name = "btnLogoCreativeThinker";
            this.btnLogoCreativeThinker.Size = new System.Drawing.Size(153, 135);
            this.btnLogoCreativeThinker.TabIndex = 0;
            this.btnLogoCreativeThinker.UseVisualStyleBackColor = false;
            this.btnLogoCreativeThinker.Click += new System.EventHandler(this.btnLogoCreativeThinker_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.label2.Location = new System.Drawing.Point(154, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(596, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Решайте, летайте, ищите, творите и дерзостью мысли весь мир покорите!";
            // 
            // btnLogoEducationEra
            // 
            this.btnLogoEducationEra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogoEducationEra.BackgroundImage = global::PRIZ.Properties.Resources.logo_educationfornewera;
            this.btnLogoEducationEra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogoEducationEra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoEducationEra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogoEducationEra.FlatAppearance.BorderSize = 0;
            this.btnLogoEducationEra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogoEducationEra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogoEducationEra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoEducationEra.Location = new System.Drawing.Point(752, 3);
            this.btnLogoEducationEra.Name = "btnLogoEducationEra";
            this.btnLogoEducationEra.Size = new System.Drawing.Size(164, 135);
            this.btnLogoEducationEra.TabIndex = 2;
            this.btnLogoEducationEra.UseVisualStyleBackColor = true;
            this.btnLogoEducationEra.Click += new System.EventHandler(this.btnLogoEducationEra_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 40F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(239, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "ПРИЗ для умных";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::PRIZ.Properties.Resources.Krug;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnModules);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Location = new System.Drawing.Point(227, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 551);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 17F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(197, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Регистрация";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackgroundImage = global::PRIZ.Properties.Resources.tbPass;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.tbSurename);
            this.panel3.Location = new System.Drawing.Point(57, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 42);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackgroundImage = global::PRIZ.Properties.Resources.tbPass;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Location = new System.Drawing.Point(57, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 42);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackgroundImage = global::PRIZ.Properties.Resources.tbPass;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Controls.Add(this.tbCountry);
            this.panel5.Location = new System.Drawing.Point(273, 224);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 42);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.BackgroundImage = global::PRIZ.Properties.Resources.tbPass;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.tbStatus);
            this.panel6.Location = new System.Drawing.Point(273, 172);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 42);
            this.panel6.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Выберите статус";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel9.BackgroundImage = global::PRIZ.Properties.Resources.registration_underlay_big;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel9.Controls.Add(this.tbAbout);
            this.panel9.Location = new System.Drawing.Point(61, 253);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(409, 177);
            this.panel9.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::PRIZ.Properties.Resources.lineUnderTheText;
            this.pictureBox1.Location = new System.Drawing.Point(84, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(881, 10);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 727);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ПРИЗ";
            this.Load += new System.EventHandler(this.Form_VisibleChangedOrLoad);
            this.LocationChanged += new System.EventHandler(this.Form_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.Form_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.Form_VisibleChangedOrLoad);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSurename;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAbout;
        private System.Windows.Forms.Button btnModules;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox tbStatus;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnLogoCreativeThinker;
        private System.Windows.Forms.Button btnLogoEducationEra;
        private System.Windows.Forms.Label label4;

    }
}