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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tbModuleName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateModule = new System.Windows.Forms.Button();
            this.pnlWhite = new System.Windows.Forms.Panel();
            this.btnAddTasks = new System.Windows.Forms.Button();
            this.btnAnotherModule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pnlWhite.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage.Image = global::PRIZ.Properties.Resources.Logo_ShKM;
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(12, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(427, 282);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbModuleName
            // 
            this.tbModuleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModuleName.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbModuleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.tbModuleName.Location = new System.Drawing.Point(446, 12);
            this.tbModuleName.Name = "tbModuleName";
            this.tbModuleName.Size = new System.Drawing.Size(350, 46);
            this.tbModuleName.TabIndex = 2;
            this.tbModuleName.Text = "Введите название модуля";
            this.tbModuleName.Enter += new System.EventHandler(this.txtFrom_Enter);
            this.tbModuleName.Leave += new System.EventHandler(this.txtFrom_Leave);
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDescription.Location = new System.Drawing.Point(12, 335);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(427, 179);
            this.tbDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите описание модуля";
            // 
            // btnCreateModule
            // 
            this.btnCreateModule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreateModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnCreateModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateModule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnCreateModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateModule.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnCreateModule.ForeColor = System.Drawing.Color.White;
            this.btnCreateModule.Location = new System.Drawing.Point(634, 335);
            this.btnCreateModule.Name = "btnCreateModule";
            this.btnCreateModule.Size = new System.Drawing.Size(162, 31);
            this.btnCreateModule.TabIndex = 37;
            this.btnCreateModule.Text = "Создать модуль";
            this.btnCreateModule.UseVisualStyleBackColor = false;
            this.btnCreateModule.Click += new System.EventHandler(this.btnCreateModule_Click);
            // 
            // pnlWhite
            // 
            this.pnlWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWhite.Controls.Add(this.btnAddTasks);
            this.pnlWhite.Controls.Add(this.btnAnotherModule);
            this.pnlWhite.Location = new System.Drawing.Point(0, 0);
            this.pnlWhite.Margin = new System.Windows.Forms.Padding(0);
            this.pnlWhite.Name = "pnlWhite";
            this.pnlWhite.Size = new System.Drawing.Size(807, 532);
            this.pnlWhite.TabIndex = 38;
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
            this.btnAddTasks.Location = new System.Drawing.Point(461, 263);
            this.btnAddTasks.Name = "btnAddTasks";
            this.btnAddTasks.Size = new System.Drawing.Size(197, 31);
            this.btnAddTasks.TabIndex = 39;
            this.btnAddTasks.Text = "Добавить задания в модуль";
            this.btnAddTasks.UseVisualStyleBackColor = false;
            this.btnAddTasks.Click += new System.EventHandler(this.btnAddTasks_Click);
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
            this.btnAnotherModule.Location = new System.Drawing.Point(163, 263);
            this.btnAnotherModule.Name = "btnAnotherModule";
            this.btnAnotherModule.Size = new System.Drawing.Size(197, 31);
            this.btnAnotherModule.TabIndex = 38;
            this.btnAnotherModule.Text = "Создать ещё модуль";
            this.btnAnotherModule.UseVisualStyleBackColor = false;
            this.btnAnotherModule.Click += new System.EventHandler(this.btnAnotherModule_Click);
            // 
            // FormNewModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 527);
            this.Controls.Add(this.pnlWhite);
            this.Controls.Add(this.btnCreateModule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbModuleName);
            this.Controls.Add(this.pbImage);
            this.Name = "FormNewModule";
            this.Text = "FormNewModule";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pnlWhite.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox tbModuleName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateModule;
        private System.Windows.Forms.Panel pnlWhite;
        private System.Windows.Forms.Button btnAddTasks;
        private System.Windows.Forms.Button btnAnotherModule;
    }
}