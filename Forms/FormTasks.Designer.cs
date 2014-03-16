namespace PRIZ
{
    partial class FormTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTasks));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnModules = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnWriteToUs = new System.Windows.Forms.Button();
            this.panelForElements = new System.Windows.Forms.Panel();
            this.lName = new System.Windows.Forms.Label();
            this.lblTitleModule = new System.Windows.Forms.Label();
            this.btnLogoCreativeThinker = new System.Windows.Forms.Button();
            this.btnLogoEducationEra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.BackgroundImage = global::PRIZ.Properties.Resources.back01;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(51, 103);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseDown);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseUp);
            // 
            // btnModules
            // 
            this.btnModules.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModules.FlatAppearance.BorderSize = 0;
            this.btnModules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModules.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnModules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.btnModules.Image = global::PRIZ.Properties.Resources.modules01;
            this.btnModules.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModules.Location = new System.Drawing.Point(12, 164);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(111, 68);
            this.btnModules.TabIndex = 2;
            this.btnModules.Text = "Модули";
            this.btnModules.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModules.UseVisualStyleBackColor = true;
            this.btnModules.Click += new System.EventHandler(this.btnModules_Click);
            this.btnModules.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnModules_MouseDown);
            this.btnModules.MouseEnter += new System.EventHandler(this.btnModules_MouseEnter);
            this.btnModules.MouseLeave += new System.EventHandler(this.btnModules_MouseLeave);
            this.btnModules.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnModules_MouseUp);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.btnAbout.Image = global::PRIZ.Properties.Resources.about01;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbout.Location = new System.Drawing.Point(12, 244);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(111, 68);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "О программе";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAbout_MouseDown);
            this.btnAbout.MouseEnter += new System.EventHandler(this.btnAbout_MouseEnter);
            this.btnAbout.MouseLeave += new System.EventHandler(this.btnAbout_MouseLeave);
            this.btnAbout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAbout_MouseUp);
            // 
            // btnWriteToUs
            // 
            this.btnWriteToUs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWriteToUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWriteToUs.FlatAppearance.BorderSize = 0;
            this.btnWriteToUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWriteToUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnWriteToUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWriteToUs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnWriteToUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.btnWriteToUs.Image = global::PRIZ.Properties.Resources.writeus01;
            this.btnWriteToUs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWriteToUs.Location = new System.Drawing.Point(12, 324);
            this.btnWriteToUs.Name = "btnWriteToUs";
            this.btnWriteToUs.Size = new System.Drawing.Size(111, 68);
            this.btnWriteToUs.TabIndex = 5;
            this.btnWriteToUs.Text = "Напишите нам";
            this.btnWriteToUs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWriteToUs.UseVisualStyleBackColor = true;
            this.btnWriteToUs.Click += new System.EventHandler(this.btnWriteToUs_Click);
            this.btnWriteToUs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnWriteToUs_MouseDown);
            this.btnWriteToUs.MouseEnter += new System.EventHandler(this.btnWriteToUs_MouseEnter);
            this.btnWriteToUs.MouseLeave += new System.EventHandler(this.btnWriteToUs_MouseLeave);
            this.btnWriteToUs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnWriteToUs_MouseUp);
            // 
            // panelForElements
            // 
            this.panelForElements.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelForElements.AutoScroll = true;
            this.panelForElements.BackColor = System.Drawing.Color.Transparent;
            this.panelForElements.Location = new System.Drawing.Point(154, 114);
            this.panelForElements.Name = "panelForElements";
            this.panelForElements.Size = new System.Drawing.Size(802, 604);
            this.panelForElements.TabIndex = 7;
            // 
            // lName
            // 
            this.lName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lName.AutoSize = true;
            this.lName.BackColor = System.Drawing.Color.Transparent;
            this.lName.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.lName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lName.Location = new System.Drawing.Point(151, 28);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(100, 20);
            this.lName.TabIndex = 8;
            this.lName.Text = "Имя Фамилия";
            // 
            // lblTitleModule
            // 
            this.lblTitleModule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitleModule.AutoSize = true;
            this.lblTitleModule.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleModule.Font = new System.Drawing.Font("Segoe UI Light", 21F);
            this.lblTitleModule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.lblTitleModule.Location = new System.Drawing.Point(147, 69);
            this.lblTitleModule.Name = "lblTitleModule";
            this.lblTitleModule.Size = new System.Drawing.Size(242, 38);
            this.lblTitleModule.TabIndex = 10;
            this.lblTitleModule.Text = "Выберите задание";
            // 
            // btnLogoCreativeThinker
            // 
            this.btnLogoCreativeThinker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogoCreativeThinker.BackColor = System.Drawing.Color.White;
            this.btnLogoCreativeThinker.BackgroundImage = global::PRIZ.Properties.Resources.Logo_ShKM;
            this.btnLogoCreativeThinker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogoCreativeThinker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoCreativeThinker.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogoCreativeThinker.FlatAppearance.BorderSize = 0;
            this.btnLogoCreativeThinker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogoCreativeThinker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogoCreativeThinker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoCreativeThinker.Location = new System.Drawing.Point(861, 14);
            this.btnLogoCreativeThinker.Name = "btnLogoCreativeThinker";
            this.btnLogoCreativeThinker.Size = new System.Drawing.Size(114, 93);
            this.btnLogoCreativeThinker.TabIndex = 14;
            this.btnLogoCreativeThinker.UseVisualStyleBackColor = false;
            this.btnLogoCreativeThinker.Click += new System.EventHandler(this.btnLogoCreativeThinker_Click);
            // 
            // btnLogoEducationEra
            // 
            this.btnLogoEducationEra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogoEducationEra.BackgroundImage = global::PRIZ.Properties.Resources.logo_educationfornewera;
            this.btnLogoEducationEra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogoEducationEra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoEducationEra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogoEducationEra.FlatAppearance.BorderSize = 0;
            this.btnLogoEducationEra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogoEducationEra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogoEducationEra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoEducationEra.Location = new System.Drawing.Point(739, 10);
            this.btnLogoEducationEra.Name = "btnLogoEducationEra";
            this.btnLogoEducationEra.Size = new System.Drawing.Size(121, 99);
            this.btnLogoEducationEra.TabIndex = 15;
            this.btnLogoEducationEra.UseVisualStyleBackColor = true;
            this.btnLogoEducationEra.Click += new System.EventHandler(this.btnLogoEducationEra_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label3.Location = new System.Drawing.Point(44, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Выход";
            this.label3.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1008, 727);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogoEducationEra);
            this.Controls.Add(this.btnLogoCreativeThinker);
            this.Controls.Add(this.lblTitleModule);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.panelForElements);
            this.Controls.Add(this.btnWriteToUs);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnModules);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "FormTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПРИЗ";
            this.SizeChanged += new System.EventHandler(this.tbForText_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnModules;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnWriteToUs;
        private System.Windows.Forms.Panel panelForElements;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lblTitleModule;
        private System.Windows.Forms.Button btnLogoCreativeThinker;
        private System.Windows.Forms.Button btnLogoEducationEra;
        private System.Windows.Forms.Label label3;

    }
}