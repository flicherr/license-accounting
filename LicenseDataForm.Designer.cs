namespace accounting
{
    partial class LicenseDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelmain = new Panel();
            panelData = new Panel();
            textBoxDescPrg = new TextBox();
            labelDescPrg = new Label();
            label1 = new Label();
            labelUser = new Label();
            comboBoxProgram = new ComboBox();
            comboBoxUser = new ComboBox();
            labelPurchased = new Label();
            dateTimePickerPurchased = new DateTimePicker();
            textBoxLicenseKey = new TextBox();
            lableLicenseKey = new Label();
            toolStripMain = new ToolStrip();
            toolStripLabelWindow = new ToolStripLabel();
            toolStripLabelClose = new ToolStripLabel();
            buttonDone = new Button();
            panelmain.SuspendLayout();
            panelData.SuspendLayout();
            toolStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelmain
            // 
            panelmain.BackColor = Color.White;
            panelmain.Controls.Add(panelData);
            panelmain.Controls.Add(toolStripMain);
            panelmain.Controls.Add(buttonDone);
            panelmain.Location = new Point(1, 1);
            panelmain.Margin = new Padding(0);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(530, 417);
            panelmain.TabIndex = 14;
            panelmain.MouseDown += panelmain_MouseDown;
            panelmain.MouseMove += panelmain_MouseMove;
            // 
            // panelData
            // 
            panelData.BackColor = Color.WhiteSmoke;
            panelData.Controls.Add(textBoxDescPrg);
            panelData.Controls.Add(labelDescPrg);
            panelData.Controls.Add(label1);
            panelData.Controls.Add(labelUser);
            panelData.Controls.Add(comboBoxProgram);
            panelData.Controls.Add(comboBoxUser);
            panelData.Controls.Add(labelPurchased);
            panelData.Controls.Add(dateTimePickerPurchased);
            panelData.Controls.Add(textBoxLicenseKey);
            panelData.Controls.Add(lableLicenseKey);
            panelData.Location = new Point(33, 29);
            panelData.Name = "panelData";
            panelData.Size = new Size(464, 335);
            panelData.TabIndex = 13;
            // 
            // textBoxDescPrg
            // 
            textBoxDescPrg.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescPrg.Font = new Font("Ubuntu", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescPrg.Location = new Point(96, 129);
            textBoxDescPrg.Multiline = true;
            textBoxDescPrg.Name = "textBoxDescPrg";
            textBoxDescPrg.ScrollBars = ScrollBars.Both;
            textBoxDescPrg.Size = new Size(273, 79);
            textBoxDescPrg.TabIndex = 21;
            // 
            // labelDescPrg
            // 
            labelDescPrg.AutoSize = true;
            labelDescPrg.Font = new Font("Ubuntu", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescPrg.ForeColor = Color.FromArgb(64, 64, 64);
            labelDescPrg.Location = new Point(99, 109);
            labelDescPrg.Name = "labelDescPrg";
            labelDescPrg.Size = new Size(187, 18);
            labelDescPrg.TabIndex = 20;
            labelDescPrg.Text = "Информация о программе:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ubuntu", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(85, 56);
            label1.Name = "label1";
            label1.Size = new Size(87, 18);
            label1.TabIndex = 19;
            label1.Text = "Программа:";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Ubuntu", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelUser.ForeColor = Color.FromArgb(64, 64, 64);
            labelUser.Location = new Point(83, 6);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(102, 18);
            labelUser.TabIndex = 18;
            labelUser.Text = "Пользователь:";
            // 
            // comboBoxProgram
            // 
            comboBoxProgram.FlatStyle = FlatStyle.Flat;
            comboBoxProgram.Font = new Font("Ubuntu", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxProgram.FormattingEnabled = true;
            comboBoxProgram.Location = new Point(82, 76);
            comboBoxProgram.Name = "comboBoxProgram";
            comboBoxProgram.Size = new Size(301, 29);
            comboBoxProgram.TabIndex = 1;
            comboBoxProgram.SelectedIndexChanged += comboBoxProgram_SelectedIndexChanged;
            // 
            // comboBoxUser
            // 
            comboBoxUser.FlatStyle = FlatStyle.Flat;
            comboBoxUser.Font = new Font("Ubuntu", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUser.FormattingEnabled = true;
            comboBoxUser.Location = new Point(80, 26);
            comboBoxUser.Name = "comboBoxUser";
            comboBoxUser.Size = new Size(304, 29);
            comboBoxUser.TabIndex = 0;
            // 
            // labelPurchased
            // 
            labelPurchased.AutoSize = true;
            labelPurchased.Font = new Font("Ubuntu", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPurchased.ForeColor = Color.FromArgb(64, 64, 64);
            labelPurchased.Location = new Point(132, 218);
            labelPurchased.Name = "labelPurchased";
            labelPurchased.Size = new Size(176, 18);
            labelPurchased.TabIndex = 15;
            labelPurchased.Text = "Дата активации лицензии:";
            // 
            // dateTimePickerPurchased
            // 
            dateTimePickerPurchased.Font = new Font("Ubuntu", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerPurchased.Format = DateTimePickerFormat.Short;
            dateTimePickerPurchased.Location = new Point(129, 238);
            dateTimePickerPurchased.Name = "dateTimePickerPurchased";
            dateTimePickerPurchased.Size = new Size(206, 27);
            dateTimePickerPurchased.TabIndex = 2;
            // 
            // textBoxLicenseKey
            // 
            textBoxLicenseKey.Font = new Font("Ubuntu", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLicenseKey.Location = new Point(66, 295);
            textBoxLicenseKey.Name = "textBoxLicenseKey";
            textBoxLicenseKey.Size = new Size(332, 27);
            textBoxLicenseKey.TabIndex = 3;
            // 
            // lableLicenseKey
            // 
            lableLicenseKey.AutoSize = true;
            lableLicenseKey.Font = new Font("Ubuntu", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lableLicenseKey.ForeColor = Color.FromArgb(64, 64, 64);
            lableLicenseKey.Location = new Point(69, 275);
            lableLicenseKey.Name = "lableLicenseKey";
            lableLicenseKey.Size = new Size(46, 18);
            lableLicenseKey.TabIndex = 0;
            lableLicenseKey.Text = "Ключ:";
            // 
            // toolStripMain
            // 
            toolStripMain.AutoSize = false;
            toolStripMain.BackColor = Color.FromArgb(64, 64, 64);
            toolStripMain.Dock = DockStyle.None;
            toolStripMain.GripMargin = new Padding(0);
            toolStripMain.GripStyle = ToolStripGripStyle.Hidden;
            toolStripMain.Items.AddRange(new ToolStripItem[] { toolStripLabelWindow, toolStripLabelClose });
            toolStripMain.Location = new Point(-1, -7);
            toolStripMain.Name = "toolStripMain";
            toolStripMain.Padding = new Padding(0);
            toolStripMain.Size = new Size(533, 33);
            toolStripMain.Stretch = true;
            toolStripMain.TabIndex = 12;
            toolStripMain.MouseDown += panelmain_MouseDown;
            toolStripMain.MouseMove += panelmain_MouseMove;
            // 
            // toolStripLabelWindow
            // 
            toolStripLabelWindow.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripLabelWindow.ForeColor = Color.White;
            toolStripLabelWindow.Name = "toolStripLabelWindow";
            toolStripLabelWindow.Size = new Size(204, 30);
            toolStripLabelWindow.Text = "Информация о лицензии";
            toolStripLabelWindow.MouseDown += panelmain_MouseDown;
            toolStripLabelWindow.MouseMove += panelmain_MouseMove;
            // 
            // toolStripLabelClose
            // 
            toolStripLabelClose.Alignment = ToolStripItemAlignment.Right;
            toolStripLabelClose.Font = new Font("Courier New", 20F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabelClose.ForeColor = Color.White;
            toolStripLabelClose.Name = "toolStripLabelClose";
            toolStripLabelClose.Size = new Size(29, 30);
            toolStripLabelClose.Text = "x";
            toolStripLabelClose.Click += toolStripLabelClose_Click;
            toolStripLabelClose.MouseDown += panelmain_MouseDown;
            toolStripLabelClose.MouseEnter += toolStripLabelClose_MouseEnter;
            toolStripLabelClose.MouseLeave += toolStripLabelClose_MouseLeave;
            toolStripLabelClose.MouseMove += panelmain_MouseMove;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LightSlateGray;
            buttonDone.DialogResult = DialogResult.OK;
            buttonDone.FlatAppearance.BorderColor = Color.Black;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDone.ForeColor = Color.White;
            buttonDone.Location = new Point(227, 374);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(76, 33);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Готово";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // LicenseDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(532, 419);
            Controls.Add(panelmain);
            Font = new Font("Ubuntu", 9.163635F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "LicenseDataForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "acquisition";
            panelmain.ResumeLayout(false);
            panelData.ResumeLayout(false);
            panelData.PerformLayout();
            toolStripMain.ResumeLayout(false);
            toolStripMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelmain;
        private Panel panelData;
        private TextBox textBoxLicenseKey;
        private Label lableLicenseKey;
        private ToolStrip toolStripMain;
        private ToolStripLabel toolStripLabelWindow;
        private ToolStripLabel toolStripLabelClose;
        private Button buttonDone;
        private DateTimePicker dateTimePickerPurchased;
        private Label labelPurchased;
        private ComboBox comboBoxProgram;
        private ComboBox comboBoxUser;
        private Label label1;
        private Label labelUser;
        private Label labelDescPrg;
        private TextBox textBoxDescPrg;
    }
}