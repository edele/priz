namespace PRIZ
{
    partial class FormEditModuleEntity
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditModuleEntity));
            this.pbModule = new System.Windows.Forms.PictureBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnEditTasks = new System.Windows.Forms.Button();
            this.lName = new System.Windows.Forms.TextBox();
            this.lDescription = new System.Windows.Forms.TextBox();
            this.pnlEdited = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnWriteToUs = new System.Windows.Forms.Button();
            this.btnModules = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbModule)).BeginInit();
            this.pnlEdited.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbModule
            // 
            this.pbModule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbModule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbModule.Image = global::PRIZ.Properties.Resources.iconimage;
            this.pbModule.Location = new System.Drawing.Point(155, 117);
            this.pbModule.Name = "pbModule";
            this.pbModule.Size = new System.Drawing.Size(430, 270);
            this.pbModule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbModule.TabIndex = 0;
            this.pbModule.TabStop = false;
            this.pbModule.Click += new System.EventHandler(this.pbModule_Click);
            this.pbModule.MouseEnter += new System.EventHandler(this.pbImage_MouseEnter);
            this.pbModule.MouseLeave += new System.EventHandler(this.pbImage_MouseLeave);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnSaveChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(811, 413);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(162, 31);
            this.btnSaveChanges.TabIndex = 7;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnEditTasks
            // 
            this.btnEditTasks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnEditTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTasks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnEditTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTasks.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditTasks.ForeColor = System.Drawing.Color.White;
            this.btnEditTasks.Location = new System.Drawing.Point(610, 413);
            this.btnEditTasks.Name = "btnEditTasks";
            this.btnEditTasks.Size = new System.Drawing.Size(162, 31);
            this.btnEditTasks.TabIndex = 8;
            this.btnEditTasks.Text = "Редактировать задания";
            this.btnEditTasks.UseVisualStyleBackColor = false;
            this.btnEditTasks.Click += new System.EventHandler(this.btnEditTasks_Click);
            // 
            // lName
            // 
            this.lName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lName.Font = new System.Drawing.Font("Segoe UI Light", 21.75F);
            this.lName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.lName.Location = new System.Drawing.Point(610, 117);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(363, 46);
            this.lName.TabIndex = 9;
            this.lName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // lDescription
            // 
            this.lDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lDescription.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.lDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.lDescription.Location = new System.Drawing.Point(610, 182);
            this.lDescription.Multiline = true;
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(363, 205);
            this.lDescription.TabIndex = 10;
            // 
            // pnlEdited
            // 
            this.pnlEdited.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEdited.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pnlEdited.Controls.Add(this.label1);
            this.pnlEdited.Location = new System.Drawing.Point(-12, 171);
            this.pnlEdited.Name = "pnlEdited";
            this.pnlEdited.Size = new System.Drawing.Size(1034, 216);
            this.pnlEdited.TabIndex = 12;
            this.pnlEdited.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(362, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Модуль успешно изменён";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.btnBack.TabIndex = 34;
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
            this.label3.TabIndex = 33;
            this.label3.Text = "Выход";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.btnAbout.TabIndex = 36;
            this.btnAbout.Text = "О программе";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbout.UseVisualStyleBackColor = true;
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
            this.btnWriteToUs.TabIndex = 37;
            this.btnWriteToUs.Text = "Напишите нам";
            this.btnWriteToUs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWriteToUs.UseVisualStyleBackColor = true;
            this.btnWriteToUs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnWriteToUs_MouseDown);
            this.btnWriteToUs.MouseEnter += new System.EventHandler(this.btnWriteToUs_MouseEnter);
            this.btnWriteToUs.MouseLeave += new System.EventHandler(this.btnAbout_MouseLeave);
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
            this.btnModules.Image = global::PRIZ.Properties.Resources.modules02;
            this.btnModules.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModules.Location = new System.Drawing.Point(12, 164);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(111, 68);
            this.btnModules.TabIndex = 35;
            this.btnModules.Text = "Модули";
            this.btnModules.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModules.UseVisualStyleBackColor = true;
            this.btnModules.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnModules_MouseDown);
            this.btnModules.MouseEnter += new System.EventHandler(this.btnModules_MouseEnter);
            this.btnModules.MouseLeave += new System.EventHandler(this.btnModules_MouseLeave);
            this.btnModules.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnModules_MouseUp);
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
            this.label2.TabIndex = 38;
            this.label2.Text = "Имя Фамилия";
            // 
            // FormEditModuleEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 688);
            this.Controls.Add(this.pnlEdited);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnWriteToUs);
            this.Controls.Add(this.btnModules);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.btnEditTasks);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.pbModule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "FormEditModuleEntity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Редактировать Модуль";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form_SizeChanged);
            this.LocationChanged += new System.EventHandler(this.Form_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.Form_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbModule)).EndInit();
            this.pnlEdited.ResumeLayout(false);
            this.pnlEdited.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbModule;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnEditTasks;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox lDescription;
        private System.Windows.Forms.Panel pnlEdited;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnWriteToUs;
        private System.Windows.Forms.Button btnModules;
        private System.Windows.Forms.Label label2;
    }
}