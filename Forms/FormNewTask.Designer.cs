namespace PRIZ
{
    partial class FormNewTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewTask));
            this.btnAddTask = new System.Windows.Forms.Button();
            this.tbGiven = new System.Windows.Forms.TextBox();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlAdded = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pnlAdded.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(668, 327);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(162, 31);
            this.btnAddTask.TabIndex = 42;
            this.btnAddTask.Text = "Добавить задание";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // tbGiven
            // 
            this.tbGiven.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbGiven.Font = new System.Drawing.Font("Segoe UI Light", 12.75F);
            this.tbGiven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.tbGiven.Location = new System.Drawing.Point(467, 95);
            this.tbGiven.Multiline = true;
            this.tbGiven.Name = "tbGiven";
            this.tbGiven.Size = new System.Drawing.Size(363, 217);
            this.tbGiven.TabIndex = 39;
            this.tbGiven.Text = "Описание задания";
            this.tbGiven.Enter += new System.EventHandler(this.descFrom_Enter);
            this.tbGiven.Leave += new System.EventHandler(this.descFrom_Leave);
            // 
            // tbTaskName
            // 
            this.tbTaskName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTaskName.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTaskName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.tbTaskName.Location = new System.Drawing.Point(467, 30);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(363, 46);
            this.tbTaskName.TabIndex = 40;
            this.tbTaskName.Text = "Название задания";
            this.tbTaskName.Enter += new System.EventHandler(this.txtFrom_Enter);
            this.tbTaskName.Leave += new System.EventHandler(this.txtFrom_Leave);
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
            this.pbImage.Size = new System.Drawing.Size(427, 282);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImage.TabIndex = 38;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pbImage.MouseEnter += new System.EventHandler(this.pbImage_MouseEnter);
            this.pbImage.MouseLeave += new System.EventHandler(this.pbImage_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlAdded
            // 
            this.pnlAdded.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAdded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pnlAdded.Controls.Add(this.label1);
            this.pnlAdded.Location = new System.Drawing.Point(-4, 171);
            this.pnlAdded.Name = "pnlAdded";
            this.pnlAdded.Size = new System.Drawing.Size(910, 216);
            this.pnlAdded.TabIndex = 0;
            this.pnlAdded.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(335, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задание добавлено";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 557);
            this.Controls.Add(this.pnlAdded);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.tbGiven);
            this.Controls.Add(this.tbTaskName);
            this.Controls.Add(this.pbImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNewTask";
            this.Text = "Новое задание";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pnlAdded.ResumeLayout(false);
            this.pnlAdded.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox tbGiven;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlAdded;
        private System.Windows.Forms.Label label1;
    }
}