namespace PRIZ
{
    partial class FormModuleEditor
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
            this.btnNewModule = new System.Windows.Forms.Button();
            this.btnEditModule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewModule
            // 
            this.btnNewModule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNewModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnNewModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewModule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnNewModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewModule.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnNewModule.ForeColor = System.Drawing.Color.White;
            this.btnNewModule.Location = new System.Drawing.Point(48, 74);
            this.btnNewModule.Name = "btnNewModule";
            this.btnNewModule.Size = new System.Drawing.Size(162, 31);
            this.btnNewModule.TabIndex = 36;
            this.btnNewModule.Text = "Новый модуль";
            this.btnNewModule.UseVisualStyleBackColor = false;
            this.btnNewModule.Click += new System.EventHandler(this.btnNewModule_Click);
            // 
            // btnEditModule
            // 
            this.btnEditModule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnEditModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditModule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnEditModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditModule.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnEditModule.ForeColor = System.Drawing.Color.White;
            this.btnEditModule.Location = new System.Drawing.Point(47, 136);
            this.btnEditModule.Name = "btnEditModule";
            this.btnEditModule.Size = new System.Drawing.Size(162, 31);
            this.btnEditModule.TabIndex = 37;
            this.btnEditModule.Text = "Редактировать модуль";
            this.btnEditModule.UseVisualStyleBackColor = false;
            this.btnEditModule.Click += new System.EventHandler(this.btnEditModule_Click);
            // 
            // FormModuleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(256, 262);
            this.Controls.Add(this.btnEditModule);
            this.Controls.Add(this.btnNewModule);
            this.Name = "FormModuleEditor";
            this.Text = "FormModuleEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewModule;
        private System.Windows.Forms.Button btnEditModule;
    }
}