namespace accounting
{
    partial class LoginForm
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
            buttonDone = new Button();
            textBoxLogin = new TextBox();
            labelLogin = new Label();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            statusStripMain = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            panelmain = new Panel();
            labelClose = new Label();
            panelInput = new Panel();
            labelTitle = new Label();
            statusStripMain.SuspendLayout();
            panelmain.SuspendLayout();
            panelInput.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LightSlateGray;
            buttonDone.DialogResult = DialogResult.OK;
            buttonDone.FlatAppearance.BorderColor = Color.Black;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Font = new Font("Sitka Text", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDone.ForeColor = SystemColors.Window;
            buttonDone.Location = new Point(91, 186);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(105, 45);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Войти";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(31, 63);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(218, 31);
            textBoxLogin.TabIndex = 0;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.Location = new Point(34, 42);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(61, 21);
            labelLogin.TabIndex = 6;
            labelLogin.Text = "Логин:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(31, 122);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(218, 31);
            textBoxPassword.TabIndex = 1;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(34, 101);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(68, 21);
            labelPassword.TabIndex = 8;
            labelPassword.Text = "Пароль:";
            // 
            // statusStripMain
            // 
            statusStripMain.BackColor = Color.FromArgb(64, 64, 64);
            statusStripMain.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStripMain.Location = new Point(0, 348);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(661, 24);
            statusStripMain.SizingGrip = false;
            statusStripMain.TabIndex = 10;
            statusStripMain.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.BackColor = Color.FromArgb(64, 64, 64);
            statusLabel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            statusLabel.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            statusLabel.ForeColor = SystemColors.Window;
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(163, 19);
            statusLabel.Text = "Введите логин и пароль";
            // 
            // panelmain
            // 
            panelmain.BackColor = Color.White;
            panelmain.Controls.Add(labelClose);
            panelmain.Controls.Add(panelInput);
            panelmain.Controls.Add(labelTitle);
            panelmain.Controls.Add(statusStripMain);
            panelmain.Location = new Point(1, 1);
            panelmain.Margin = new Padding(0);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(661, 372);
            panelmain.TabIndex = 12;
            panelmain.MouseDown += LoginForm_MouseDown;
            panelmain.MouseMove += LoginForm_MouseMove;
            // 
            // labelClose
            // 
            labelClose.AutoSize = true;
            labelClose.Font = new Font("Courier New", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelClose.Location = new Point(615, 7);
            labelClose.Name = "labelClose";
            labelClose.Size = new Size(34, 36);
            labelClose.TabIndex = 14;
            labelClose.Text = "x";
            labelClose.Click += labelClose_Click;
            labelClose.MouseEnter += labelClose_MouseEnter;
            labelClose.MouseLeave += labelClose_MouseLeave;
            // 
            // panelInput
            // 
            panelInput.BackColor = Color.White;
            panelInput.Controls.Add(buttonDone);
            panelInput.Controls.Add(labelPassword);
            panelInput.Controls.Add(textBoxLogin);
            panelInput.Controls.Add(textBoxPassword);
            panelInput.Controls.Add(labelLogin);
            panelInput.Location = new Point(318, 47);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(287, 262);
            panelInput.TabIndex = 13;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Sitka Text", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(20, 79);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(274, 158);
            labelTitle.TabIndex = 12;
            labelTitle.Text = "СИСТЕМА УЧЁТА ЛИЦЕНЗИОННОГО ПРОГРАММНОГО ОБЕСПЕЧЕНИЯ";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            labelTitle.MouseDown += LoginForm_MouseDown;
            labelTitle.MouseMove += LoginForm_MouseMove;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(663, 374);
            Controls.Add(panelmain);
            Font = new Font("Ubuntu", 9.163635F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "login";
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            panelmain.ResumeLayout(false);
            panelmain.PerformLayout();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private TextBox textBoxLogin;
        private Label labelLogin;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel statusLabel;
        private Panel panelmain;
        private Label labelTitle;
        private Panel panelInput;
        private Label labelClose;
    }
}