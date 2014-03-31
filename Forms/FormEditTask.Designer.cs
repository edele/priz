namespace PRIZ
{
    partial class FormEditTask
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
            this.panelForElements = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelForElements
            // 
            this.panelForElements.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelForElements.AutoScroll = true;
            this.panelForElements.BackColor = System.Drawing.Color.Transparent;
            this.panelForElements.Location = new System.Drawing.Point(53, 58);
            this.panelForElements.Name = "panelForElements";
            this.panelForElements.Size = new System.Drawing.Size(802, 604);
            this.panelForElements.TabIndex = 8;
            // 
            // FormEditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 674);
            this.Controls.Add(this.panelForElements);
            this.Name = "FormEditTask";
            this.Text = "FormEditTask";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForElements;
    }
}