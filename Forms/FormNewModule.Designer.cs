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
            this.btnAnotherModule = new System.Windows.Forms.Button();
            this.btnAddTasks = new System.Windows.Forms.Button();
            this.pnlWhite = new System.Windows.Forms.Panel();
            this.tbModuleName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
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
            this.btnAnotherModule.Location = new System.Drawing.Point(191, 263);
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
            this.btnAddTasks.Location = new System.Drawing.Point(489, 263);
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
            this.pnlWhite.Location = new System.Drawing.Point(2, 0);
            this.pnlWhite.Margin = new System.Windows.Forms.Padding(0);
            this.pnlWhite.Name = "pnlWhite";
            this.pnlWhite.Size = new System.Drawing.Size(863, 527);
            this.pnlWhite.TabIndex = 38;
            // 
            // tbModuleName
            // 
            this.tbModuleName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbModuleName.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbModuleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.tbModuleName.Location = new System.Drawing.Point(467, 30);
            this.tbModuleName.Name = "tbModuleName";
            this.tbModuleName.Size = new System.Drawing.Size(363, 46);
            this.tbModuleName.TabIndex = 41;
            this.tbModuleName.Text = "Название модуля";
            this.tbModuleName.Enter += new System.EventHandler(this.txtFrom_Enter);
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
            this.button1.Location = new System.Drawing.Point(668, 327);
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
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImage.Image = global::PRIZ.Properties.Resources.iconimage;
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(12, 30);
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
            this.tbDescription.Location = new System.Drawing.Point(467, 82);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(363, 217);
            this.tbDescription.TabIndex = 42;
            this.tbDescription.Text = "Описание модуля";
            this.tbDescription.Enter += new System.EventHandler(this.descFrom_Enter);
            this.tbDescription.Leave += new System.EventHandler(this.descFrom_Leave);
            // 
            // FormNewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 527);
            this.Controls.Add(this.tbModuleName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.pnlWhite);
            this.Name = "FormNewModule";
            this.Text = "FormNewModule";
            this.pnlWhite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnotherModule;
        private System.Windows.Forms.Button btnAddTasks;
        private System.Windows.Forms.Panel pnlWhite;
        private System.Windows.Forms.TextBox tbModuleName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox tbDescription;

    }
}