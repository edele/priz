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
            this.pbModule = new System.Windows.Forms.PictureBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnEditTasks = new System.Windows.Forms.Button();
            this.lName = new System.Windows.Forms.TextBox();
            this.lDescription = new System.Windows.Forms.TextBox();
            this.bDeleteImage = new System.Windows.Forms.Button();
            this.pnlEdited = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbModule)).BeginInit();
            this.pnlEdited.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbModule
            // 
            this.pbModule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbModule.Location = new System.Drawing.Point(11, 34);
            this.pbModule.Name = "pbModule";
            this.pbModule.Size = new System.Drawing.Size(430, 270);
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
            this.btnSaveChanges.Location = new System.Drawing.Point(475, 331);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(160, 34);
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
            this.btnEditTasks.Location = new System.Drawing.Point(669, 331);
            this.btnEditTasks.Name = "btnEditTasks";
            this.btnEditTasks.Size = new System.Drawing.Size(170, 34);
            this.btnEditTasks.TabIndex = 8;
            this.btnEditTasks.Text = "Редактировать задания";
            this.btnEditTasks.UseVisualStyleBackColor = false;
            this.btnEditTasks.Click += new System.EventHandler(this.btnEditTasks_Click);
            // 
            // lName
            // 
            this.lName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lName.Location = new System.Drawing.Point(475, 34);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(363, 20);
            this.lName.TabIndex = 9;
            // 
            // lDescription
            // 
            this.lDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lDescription.Location = new System.Drawing.Point(475, 89);
            this.lDescription.Multiline = true;
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(370, 215);
            this.lDescription.TabIndex = 10;
            // 
            // bDeleteImage
            // 
            this.bDeleteImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bDeleteImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.bDeleteImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bDeleteImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.bDeleteImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeleteImage.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDeleteImage.ForeColor = System.Drawing.Color.White;
            this.bDeleteImage.Location = new System.Drawing.Point(11, 331);
            this.bDeleteImage.Name = "bDeleteImage";
            this.bDeleteImage.Size = new System.Drawing.Size(160, 34);
            this.bDeleteImage.TabIndex = 11;
            this.bDeleteImage.Text = "Удалить изображение";
            this.bDeleteImage.UseVisualStyleBackColor = false;
            this.bDeleteImage.Click += new System.EventHandler(this.bDeleteImage_Click);
            // 
            // pnlEdited
            // 
            this.pnlEdited.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEdited.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pnlEdited.Controls.Add(this.label1);
            this.pnlEdited.Location = new System.Drawing.Point(-12, 171);
            this.pnlEdited.Name = "pnlEdited";
            this.pnlEdited.Size = new System.Drawing.Size(909, 216);
            this.pnlEdited.TabIndex = 12;
            this.pnlEdited.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(299, 88);
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
            // FormEditModuleEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 574);
            this.Controls.Add(this.pnlEdited);
            this.Controls.Add(this.bDeleteImage);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.btnEditTasks);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.pbModule);
            this.Name = "FormEditModuleEntity";
            this.Text = "FormEditModuleEntity";
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
        private System.Windows.Forms.Button bDeleteImage;
        private System.Windows.Forms.Panel pnlEdited;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}