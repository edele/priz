namespace PRIZ
{
    partial class FormNewModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewModule));
            this.btnAnotherModule = new System.Windows.Forms.Button();
            this.btnAddTasks = new System.Windows.Forms.Button();
            this.pnlWhite = new System.Windows.Forms.Panel();
            this.tbModuleName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnWriteToUs = new System.Windows.Forms.Button();
            this.btnModules = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBackToTasks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlWhite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnotherModule
            // 
            this.btnAnotherModule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAnotherModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnAnotherModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnotherModule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnAnotherModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnotherModule.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnAnotherModule.ForeColor = System.Drawing.Color.White;
            this.btnAnotherModule.Location = new System.Drawing.Point(263, 263);
            this.btnAnotherModule.Name = "btnAnotherModule";
            this.btnAnotherModule.Size = new System.Drawing.Size(197, 31);
            this.btnAnotherModule.TabIndex = 38;
            this.btnAnotherModule.Text = "Создать ещё модуль";
            this.btnAnotherModule.UseVisualStyleBackColor = false;
            this.btnAnotherModule.Click += new System.EventHandler(this.btnAnotherModule_Click);
            // 
            // btnAddTasks
            // 
            this.btnAddTasks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnAddTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTasks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnAddTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTasks.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnAddTasks.ForeColor = System.Drawing.Color.White;
            this.btnAddTasks.Location = new System.Drawing.Point(561, 263);
            this.btnAddTasks.Name = "btnAddTasks";
            this.btnAddTasks.Size = new System.Drawing.Size(197, 31);
            this.btnAddTasks.TabIndex = 39;
            this.btnAddTasks.Text = "Добавить задания в модуль";
            this.btnAddTasks.UseVisualStyleBackColor = false;
            this.btnAddTasks.Click += new System.EventHandler(this.btnAddTasks_Click);
            // 
            // pnlWhite
            // 
            this.pnlWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWhite.Controls.Add(this.btnAddTasks);
            this.pnlWhite.Controls.Add(this.btnAnotherModule);
            this.pnlWhite.Location = new System.Drawing.Point(-1, -2);
            this.pnlWhite.Margin = new System.Windows.Forms.Padding(0);
            this.pnlWhite.Name = "pnlWhite";
            this.pnlWhite.Size = new System.Drawing.Size(1007, 688);
            this.pnlWhite.TabIndex = 38;
            // 
            // tbModuleName
            // 
            this.tbModuleName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbModuleName.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbModuleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.tbModuleName.Location = new System.Drawing.Point(610, 117);
            this.tbModuleName.Name = "tbModuleName";
            this.tbModuleName.Size = new System.Drawing.Size(363, 46);
            this.tbModuleName.TabIndex = 41;
            this.tbModuleName.Text = "Название модуля";
            this.tbModuleName.Enter += new System.EventHandler(this.txtFrom_Enter);
            this.tbModuleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            this.tbModuleName.Leave += new System.EventHandler(this.txtFrom_Leave);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(811, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 31);
            this.button1.TabIndex = 40;
            this.button1.Text = "Создать модуль";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCreateModule_Click);
            // 
            // pbImage
            // 
            this.pbImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImage.Image = global::PRIZ.Properties.Resources.iconimage;
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(155, 117);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(430, 270);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImage.TabIndex = 39;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pbImage.MouseEnter += new System.EventHandler(this.pbImage_MouseEnter);
            this.pbImage.MouseLeave += new System.EventHandler(this.pbImage_MouseLeave);
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.tbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.tbDescription.Location = new System.Drawing.Point(610, 182);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(363, 204);
            this.tbDescription.TabIndex = 42;
            this.tbDescription.Text = "Описание модуля";
            this.tbDescription.Enter += new System.EventHandler(this.descFrom_Enter);
            this.tbDescription.Leave += new System.EventHandler(this.descFrom_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(151, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Имя Фамилия";
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
            this.btnAbout.TabIndex = 59;
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
            this.btnWriteToUs.TabIndex = 60;
            this.btnWriteToUs.Text = "Напишите нам";
            this.btnWriteToUs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWriteToUs.UseVisualStyleBackColor = true;
            this.btnWriteToUs.Click += new System.EventHandler(this.btnWriteToUs_Click);
            this.btnWriteToUs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnWriteToUs_MouseDown);
            this.btnWriteToUs.MouseEnter += new System.EventHandler(this.btnWriteToUs_MouseEnter);
            this.btnWriteToUs.MouseLeave += new System.EventHandler(this.btnWriteToUs_MouseLeave);
            this.btnWriteToUs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnWriteToUs_MouseUp);
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
            this.btnModules.TabIndex = 58;
            this.btnModules.Text = "Модули";
            this.btnModules.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModules.UseVisualStyleBackColor = true;
            this.btnModules.Click += new System.EventHandler(this.btnModules_Click);
            this.btnModules.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnModules_MouseDown);
            this.btnModules.MouseEnter += new System.EventHandler(this.btnModules_MouseEnter);
            this.btnModules.MouseLeave += new System.EventHandler(this.btnModules_MouseLeave);
            this.btnModules.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnModules_MouseUp);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(51, 103);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 57;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.label3.TabIndex = 56;
            this.label3.Text = "Выход";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnBackToTasks
            // 
            this.btnBackToTasks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBackToTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnBackToTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToTasks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnBackToTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToTasks.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnBackToTasks.ForeColor = System.Drawing.Color.White;
            this.btnBackToTasks.Location = new System.Drawing.Point(155, 413);
            this.btnBackToTasks.Name = "btnBackToTasks";
            this.btnBackToTasks.Size = new System.Drawing.Size(162, 31);
            this.btnBackToTasks.TabIndex = 62;
            this.btnBackToTasks.Text = "Вернуться к модулям";
            this.btnBackToTasks.UseVisualStyleBackColor = false;
            this.btnBackToTasks.Visible = false;
            this.btnBackToTasks.Click += new System.EventHandler(this.btnBackToTasks_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(148, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 38);
            this.label1.TabIndex = 75;
            this.label1.Text = "Новый модуль";
            // 
            // FormNewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 688);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackToTasks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnWriteToUs);
            this.Controls.Add(this.btnModules);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbModuleName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.pnlWhite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "FormNewModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ПРИЗ";
            this.pnlWhite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnotherModule;
        private System.Windows.Forms.Button btnAddTasks;
        private System.Windows.Forms.TextBox tbModuleName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnWriteToUs;
        private System.Windows.Forms.Button btnModules;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBackToTasks;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pnlWhite;

    }
}