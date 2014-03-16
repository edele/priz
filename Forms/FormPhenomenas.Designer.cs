namespace PRIZ
{
    partial class FormPhenomenas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhenomenas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lIdeas = new System.Windows.Forms.Label();
            this.btnPlusIdea = new System.Windows.Forms.Button();
            this.btnSendToTheNextForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbIdea = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btnWriteToUs = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnModules = new System.Windows.Forms.Button();
            this.btnLogoCreativeThinker = new System.Windows.Forms.Button();
            this.tbHypo = new System.Windows.Forms.RichTextBox();
            this.btnLogoEducationEra = new System.Windows.Forms.Button();
            this.lblSound = new System.Windows.Forms.Label();
            this.lblMagnetic = new System.Windows.Forms.Label();
            this.lblThermal = new System.Windows.Forms.Label();
            this.lblElectrical = new System.Windows.Forms.Label();
            this.lblMechanical = new System.Windows.Forms.Label();
            this.lblLight = new System.Windows.Forms.Label();
            this.showTaskCond = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label1.Location = new System.Drawing.Point(147, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выдвижение гипотиз";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label2.Location = new System.Drawing.Point(150, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Явления";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.panel2.Controls.Add(this.lIdeas);
            this.panel2.Controls.Add(this.btnPlusIdea);
            this.panel2.Controls.Add(this.btnSendToTheNextForm);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 546);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 185);
            this.panel2.TabIndex = 0;
            // 
            // lIdeas
            // 
            this.lIdeas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lIdeas.AutoSize = true;
            this.lIdeas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lIdeas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lIdeas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.lIdeas.Location = new System.Drawing.Point(656, 120);
            this.lIdeas.Name = "lIdeas";
            this.lIdeas.Size = new System.Drawing.Size(203, 20);
            this.lIdeas.TabIndex = 30;
            this.lIdeas.Text = "Вы не ввели ни одной идеи";
            this.lIdeas.Click += new System.EventHandler(this.lIdeas_Click);
            // 
            // btnPlusIdea
            // 
            this.btnPlusIdea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnPlusIdea.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnPlusIdea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnPlusIdea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnPlusIdea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusIdea.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnPlusIdea.ForeColor = System.Drawing.Color.White;
            this.btnPlusIdea.Location = new System.Drawing.Point(659, 24);
            this.btnPlusIdea.Name = "btnPlusIdea";
            this.btnPlusIdea.Size = new System.Drawing.Size(148, 32);
            this.btnPlusIdea.TabIndex = 4;
            this.btnPlusIdea.Text = "Следующая идея";
            this.btnPlusIdea.UseVisualStyleBackColor = false;
            this.btnPlusIdea.Click += new System.EventHandler(this.btnPlusIdea_Click);
            // 
            // btnSendToTheNextForm
            // 
            this.btnSendToTheNextForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnSendToTheNextForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnSendToTheNextForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnSendToTheNextForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.btnSendToTheNextForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendToTheNextForm.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSendToTheNextForm.ForeColor = System.Drawing.Color.White;
            this.btnSendToTheNextForm.Location = new System.Drawing.Point(835, 24);
            this.btnSendToTheNextForm.Name = "btnSendToTheNextForm";
            this.btnSendToTheNextForm.Size = new System.Drawing.Size(109, 32);
            this.btnSendToTheNextForm.TabIndex = 1;
            this.btnSendToTheNextForm.Text = "Отчет";
            this.btnSendToTheNextForm.UseVisualStyleBackColor = false;
            this.btnSendToTheNextForm.Click += new System.EventHandler(this.btnSendToTheNextForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PRIZ.Properties.Resources.registration_underlay_big;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tbIdea);
            this.panel1.Location = new System.Drawing.Point(155, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 116);
            this.panel1.TabIndex = 3;
            // 
            // tbIdea
            // 
            this.tbIdea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIdea.Location = new System.Drawing.Point(3, 6);
            this.tbIdea.Multiline = true;
            this.tbIdea.Name = "tbIdea";
            this.tbIdea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbIdea.Size = new System.Drawing.Size(475, 107);
            this.tbIdea.TabIndex = 0;
            this.tbIdea.TextChanged += new System.EventHandler(this.tbIdea_TextChanged);
            this.tbIdea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbIdea_KeyDown);
            this.tbIdea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIdea_KeyPress);
            this.tbIdea.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbIdea_KeyUp);
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.lbUserName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbUserName.Location = new System.Drawing.Point(151, 28);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(100, 20);
            this.lbUserName.TabIndex = 16;
            this.lbUserName.Text = "Имя Фамилия";
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
            this.btnWriteToUs.TabIndex = 20;
            this.btnWriteToUs.Text = "Напишите нам";
            this.btnWriteToUs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWriteToUs.UseVisualStyleBackColor = true;
            this.btnWriteToUs.Click += new System.EventHandler(this.btnWriteToUs_Click);
            this.btnWriteToUs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnWriteToUs_MouseDown);
            this.btnWriteToUs.MouseEnter += new System.EventHandler(this.btnWriteToUs_MouseEnter);
            this.btnWriteToUs.MouseLeave += new System.EventHandler(this.btnWriteToUs_MouseLeave);
            this.btnWriteToUs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnWriteToUs_MouseUp);
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
            this.btnAbout.TabIndex = 19;
            this.btnAbout.Text = "О программе";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAbout_MouseDown);
            this.btnAbout.MouseEnter += new System.EventHandler(this.btnAbout_MouseEnter);
            this.btnAbout.MouseLeave += new System.EventHandler(this.btnAbout_MouseLeave);
            this.btnAbout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAbout_MouseUp);
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
            this.btnModules.TabIndex = 18;
            this.btnModules.Text = "Модули";
            this.btnModules.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModules.UseVisualStyleBackColor = true;
            this.btnModules.Click += new System.EventHandler(this.btnModules_Click);
            this.btnModules.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnModules_MouseDown);
            this.btnModules.MouseEnter += new System.EventHandler(this.btnModules_MouseEnter);
            this.btnModules.MouseLeave += new System.EventHandler(this.btnModules_MouseLeave);
            this.btnModules.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnModules_MouseUp);
            // 
            // btnLogoCreativeThinker
            // 
            this.btnLogoCreativeThinker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogoCreativeThinker.BackColor = System.Drawing.Color.White;
            this.btnLogoCreativeThinker.BackgroundImage = global::PRIZ.Properties.Resources.Logo_ShKM;
            this.btnLogoCreativeThinker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogoCreativeThinker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoCreativeThinker.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogoCreativeThinker.FlatAppearance.BorderSize = 0;
            this.btnLogoCreativeThinker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogoCreativeThinker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogoCreativeThinker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoCreativeThinker.Location = new System.Drawing.Point(864, 14);
            this.btnLogoCreativeThinker.Name = "btnLogoCreativeThinker";
            this.btnLogoCreativeThinker.Size = new System.Drawing.Size(114, 93);
            this.btnLogoCreativeThinker.TabIndex = 21;
            this.btnLogoCreativeThinker.UseVisualStyleBackColor = false;
            this.btnLogoCreativeThinker.Click += new System.EventHandler(this.btnLogoCreativeThinker_Click_1);
            // 
            // tbHypo
            // 
            this.tbHypo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbHypo.BackColor = System.Drawing.Color.White;
            this.tbHypo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHypo.Location = new System.Drawing.Point(304, 155);
            this.tbHypo.Name = "tbHypo";
            this.tbHypo.ReadOnly = true;
            this.tbHypo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbHypo.Size = new System.Drawing.Size(644, 327);
            this.tbHypo.TabIndex = 0;
            this.tbHypo.Text = "";
            // 
            // btnLogoEducationEra
            // 
            this.btnLogoEducationEra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogoEducationEra.BackgroundImage = global::PRIZ.Properties.Resources.logo_educationfornewera;
            this.btnLogoEducationEra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogoEducationEra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoEducationEra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogoEducationEra.FlatAppearance.BorderSize = 0;
            this.btnLogoEducationEra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogoEducationEra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogoEducationEra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoEducationEra.Location = new System.Drawing.Point(739, 10);
            this.btnLogoEducationEra.Name = "btnLogoEducationEra";
            this.btnLogoEducationEra.Size = new System.Drawing.Size(121, 99);
            this.btnLogoEducationEra.TabIndex = 20;
            this.btnLogoEducationEra.UseVisualStyleBackColor = true;
            this.btnLogoEducationEra.Click += new System.EventHandler(this.btnLogoEducationEra_Click);
            // 
            // lblSound
            // 
            this.lblSound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSound.AutoSize = true;
            this.lblSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSound.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(179)))), ((int)(((byte)(151)))));
            this.lblSound.Location = new System.Drawing.Point(151, 163);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(84, 20);
            this.lblSound.TabIndex = 22;
            this.lblSound.Text = "Звуковые ";
            this.lblSound.Click += new System.EventHandler(this.ClickToLabel);
            this.lblSound.Enter += new System.EventHandler(this.LabelGotFokus);
            this.lblSound.Leave += new System.EventHandler(this.LabelLostFokus);
            // 
            // lblMagnetic
            // 
            this.lblMagnetic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMagnetic.AutoSize = true;
            this.lblMagnetic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMagnetic.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMagnetic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.lblMagnetic.Location = new System.Drawing.Point(151, 191);
            this.lblMagnetic.Name = "lblMagnetic";
            this.lblMagnetic.Size = new System.Drawing.Size(88, 20);
            this.lblMagnetic.TabIndex = 23;
            this.lblMagnetic.Text = "Магнитные";
            this.lblMagnetic.Click += new System.EventHandler(this.ClickToLabel);
            this.lblMagnetic.Enter += new System.EventHandler(this.LabelGotFokus);
            this.lblMagnetic.Leave += new System.EventHandler(this.LabelLostFokus);
            // 
            // lblThermal
            // 
            this.lblThermal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThermal.AutoSize = true;
            this.lblThermal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblThermal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblThermal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.lblThermal.Location = new System.Drawing.Point(151, 247);
            this.lblThermal.Name = "lblThermal";
            this.lblThermal.Size = new System.Drawing.Size(78, 20);
            this.lblThermal.TabIndex = 24;
            this.lblThermal.Text = "Тепловые";
            this.lblThermal.Click += new System.EventHandler(this.ClickToLabel);
            this.lblThermal.Enter += new System.EventHandler(this.LabelGotFokus);
            this.lblThermal.Leave += new System.EventHandler(this.LabelLostFokus);
            // 
            // lblElectrical
            // 
            this.lblElectrical.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblElectrical.AutoSize = true;
            this.lblElectrical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblElectrical.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblElectrical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.lblElectrical.Location = new System.Drawing.Point(151, 219);
            this.lblElectrical.Name = "lblElectrical";
            this.lblElectrical.Size = new System.Drawing.Size(112, 20);
            this.lblElectrical.TabIndex = 25;
            this.lblElectrical.Text = "Электрические";
            this.lblElectrical.Click += new System.EventHandler(this.ClickToLabel);
            this.lblElectrical.Enter += new System.EventHandler(this.LabelGotFokus);
            this.lblElectrical.Leave += new System.EventHandler(this.LabelLostFokus);
            // 
            // lblMechanical
            // 
            this.lblMechanical.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMechanical.AutoSize = true;
            this.lblMechanical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMechanical.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMechanical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.lblMechanical.Location = new System.Drawing.Point(151, 275);
            this.lblMechanical.Name = "lblMechanical";
            this.lblMechanical.Size = new System.Drawing.Size(110, 20);
            this.lblMechanical.TabIndex = 26;
            this.lblMechanical.Text = "Механические";
            this.lblMechanical.Click += new System.EventHandler(this.ClickToLabel);
            this.lblMechanical.Enter += new System.EventHandler(this.LabelGotFokus);
            this.lblMechanical.Leave += new System.EventHandler(this.LabelLostFokus);
            // 
            // lblLight
            // 
            this.lblLight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLight.AutoSize = true;
            this.lblLight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLight.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblLight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.lblLight.Location = new System.Drawing.Point(151, 303);
            this.lblLight.Name = "lblLight";
            this.lblLight.Size = new System.Drawing.Size(76, 20);
            this.lblLight.TabIndex = 27;
            this.lblLight.Text = "Световые";
            this.lblLight.Click += new System.EventHandler(this.ClickToLabel);
            this.lblLight.Enter += new System.EventHandler(this.LabelGotFokus);
            this.lblLight.Leave += new System.EventHandler(this.LabelLostFokus);
            // 
            // showTaskCond
            // 
            this.showTaskCond.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.showTaskCond.AutoSize = true;
            this.showTaskCond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showTaskCond.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showTaskCond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.showTaskCond.Location = new System.Drawing.Point(151, 514);
            this.showTaskCond.Name = "showTaskCond";
            this.showTaskCond.Size = new System.Drawing.Size(214, 20);
            this.showTaskCond.TabIndex = 29;
            this.showTaskCond.Text = "Просмотреть условие задачи";
            this.showTaskCond.Click += new System.EventHandler(this.showTaskCond_Click);
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
            this.label3.TabIndex = 30;
            this.label3.Text = "Выход";
            this.label3.Click += new System.EventHandler(this.button1_Click);
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
            this.btnBack.TabIndex = 31;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormPhenomenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1008, 727);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showTaskCond);
            this.Controls.Add(this.lblLight);
            this.Controls.Add(this.lblMechanical);
            this.Controls.Add(this.lblElectrical);
            this.Controls.Add(this.lblThermal);
            this.Controls.Add(this.lblMagnetic);
            this.Controls.Add(this.lblSound);
            this.Controls.Add(this.btnLogoEducationEra);
            this.Controls.Add(this.btnLogoCreativeThinker);
            this.Controls.Add(this.btnWriteToUs);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnModules);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHypo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "FormPhenomenas";
            this.Text = "ПРИЗ";
            this.SizeChanged += new System.EventHandler(this.tbForText_SizeChanged);
            this.Click += new System.EventHandler(this.tbForText_SizeChanged);
            this.Leave += new System.EventHandler(this.LabelLostFokus);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSendToTheNextForm;
        private System.Windows.Forms.TextBox tbIdea;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btnWriteToUs;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnModules;
        private System.Windows.Forms.Button btnLogoCreativeThinker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox tbHypo;
        private System.Windows.Forms.Button btnPlusIdea;
        private System.Windows.Forms.Button btnLogoEducationEra;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.Label lblMagnetic;
        private System.Windows.Forms.Label lblThermal;
        private System.Windows.Forms.Label lblElectrical;
        private System.Windows.Forms.Label lblMechanical;
        private System.Windows.Forms.Label lblLight;
        private System.Windows.Forms.Label showTaskCond;
        private System.Windows.Forms.Label lIdeas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
    }
}