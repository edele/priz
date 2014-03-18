namespace PRIZ
{
    partial class FormShowAllIdeas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowAllIdeas));
            this.lShowAllIdeas = new System.Windows.Forms.ListBox();
            this.btnRemoveIdea = new System.Windows.Forms.Button();
            this.btnEditIdea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lShowAllIdeas
            // 
            this.lShowAllIdeas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lShowAllIdeas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lShowAllIdeas.FormattingEnabled = true;
            this.lShowAllIdeas.Location = new System.Drawing.Point(11, 12);
            this.lShowAllIdeas.Name = "lShowAllIdeas";
            this.lShowAllIdeas.Size = new System.Drawing.Size(472, 342);
            this.lShowAllIdeas.TabIndex = 0;
            this.lShowAllIdeas.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lShowAllIdeas_DrawItem);
            this.lShowAllIdeas.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lShowAllIdeas_MeasureItem);
            this.lShowAllIdeas.SelectedIndexChanged += new System.EventHandler(this.lShowAllIdeas_SelectedIndexChanged);
            // 
            // btnRemoveIdea
            // 
            this.btnRemoveIdea.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemoveIdea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnRemoveIdea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveIdea.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnRemoveIdea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveIdea.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnRemoveIdea.ForeColor = System.Drawing.Color.White;
            this.btnRemoveIdea.Location = new System.Drawing.Point(346, 367);
            this.btnRemoveIdea.Name = "btnRemoveIdea";
            this.btnRemoveIdea.Size = new System.Drawing.Size(137, 31);
            this.btnRemoveIdea.TabIndex = 39;
            this.btnRemoveIdea.Text = "Удалить";
            this.btnRemoveIdea.UseVisualStyleBackColor = false;
            this.btnRemoveIdea.Click += new System.EventHandler(this.btnRemoveIdea_Click);
            // 
            // btnEditIdea
            // 
            this.btnEditIdea.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditIdea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnEditIdea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditIdea.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnEditIdea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditIdea.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnEditIdea.ForeColor = System.Drawing.Color.White;
            this.btnEditIdea.Location = new System.Drawing.Point(12, 367);
            this.btnEditIdea.Name = "btnEditIdea";
            this.btnEditIdea.Size = new System.Drawing.Size(137, 31);
            this.btnEditIdea.TabIndex = 38;
            this.btnEditIdea.Text = "Редактировать";
            this.btnEditIdea.UseVisualStyleBackColor = false;
            this.btnEditIdea.Click += new System.EventHandler(this.btnEditIdea_Click);
            // 
            // FormShowAllIdeas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 410);
            this.Controls.Add(this.btnRemoveIdea);
            this.Controls.Add(this.btnEditIdea);
            this.Controls.Add(this.lShowAllIdeas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(511, 448);
            this.Name = "FormShowAllIdeas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Все мои гиппотезы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormShowAllIdeas_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lShowAllIdeas;
        private System.Windows.Forms.Button btnRemoveIdea;
        private System.Windows.Forms.Button btnEditIdea;
    }
}