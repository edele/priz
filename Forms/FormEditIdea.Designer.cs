namespace PRIZ
{
    partial class FormEditOrAddIdea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditOrAddIdea));
            this.tbToEdit = new System.Windows.Forms.TextBox();
            this.btnEditIdea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbToEdit
            // 
            this.tbToEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbToEdit.Location = new System.Drawing.Point(12, 12);
            this.tbToEdit.Multiline = true;
            this.tbToEdit.Name = "tbToEdit";
            this.tbToEdit.Size = new System.Drawing.Size(294, 204);
            this.tbToEdit.TabIndex = 0;
            // 
            // btnEditIdea
            // 
            this.btnEditIdea.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditIdea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnEditIdea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditIdea.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditIdea.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnEditIdea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditIdea.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnEditIdea.ForeColor = System.Drawing.Color.White;
            this.btnEditIdea.Location = new System.Drawing.Point(103, 220);
            this.btnEditIdea.Name = "btnEditIdea";
            this.btnEditIdea.Size = new System.Drawing.Size(113, 32);
            this.btnEditIdea.TabIndex = 40;
            this.btnEditIdea.Text = "Редактировать";
            this.btnEditIdea.UseVisualStyleBackColor = false;
            this.btnEditIdea.Click += new System.EventHandler(this.btnEditIdea_Click);
            // 
            // FormEditOrAddIdea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 255);
            this.Controls.Add(this.btnEditIdea);
            this.Controls.Add(this.tbToEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(258, 179);
            this.MinimumSize = new System.Drawing.Size(334, 293);
            this.Name = "FormEditOrAddIdea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Введите текст идеи";
            this.Load += new System.EventHandler(this.FormEditIdea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbToEdit;
        private System.Windows.Forms.Button btnEditIdea;
    }
}