namespace accounting;

partial class UserDataForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lableLastName = new Label();
        labelFirstName = new Label();
        labelLogin = new Label();
        textBoxLastName = new TextBox();
        textBoxFirstName = new TextBox();
        textBoxLogin = new TextBox();
        buttonDone = new Button();
        textBoxMiddleName = new TextBox();
        labelMiddleName = new Label();
        panelmain = new Panel();
        panelData = new Panel();
        toolStripMain = new ToolStrip();
        toolStripLabelWindow = new ToolStripLabel();
        toolStripLabelClose = new ToolStripLabel();
        panelmain.SuspendLayout();
        panelData.SuspendLayout();
        toolStripMain.SuspendLayout();
        SuspendLayout();
        // 
        // lableLastName
        // 
        lableLastName.AutoSize = true;
        lableLastName.Font = new Font("Ubuntu", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lableLastName.ForeColor = Color.FromArgb(64, 64, 64);
        lableLastName.Location = new Point(69, 35);
        lableLastName.Name = "lableLastName";
        lableLastName.Size = new Size(74, 18);
        lableLastName.TabIndex = 0;
        lableLastName.Text = "Фамилия:";
        // 
        // labelFirstName
        // 
        labelFirstName.AutoSize = true;
        labelFirstName.Font = new Font("Ubuntu", 10F, FontStyle.Regular, GraphicsUnit.Point);
        labelFirstName.ForeColor = Color.FromArgb(64, 64, 64);
        labelFirstName.Location = new Point(69, 94);
        labelFirstName.Name = "labelFirstName";
        labelFirstName.Size = new Size(40, 18);
        labelFirstName.TabIndex = 1;
        labelFirstName.Text = "Имя:";
        // 
        // labelLogin
        // 
        labelLogin.AutoSize = true;
        labelLogin.Font = new Font("Ubuntu", 10F, FontStyle.Regular, GraphicsUnit.Point);
        labelLogin.ForeColor = Color.FromArgb(64, 64, 64);
        labelLogin.Location = new Point(69, 222);
        labelLogin.Name = "labelLogin";
        labelLogin.Size = new Size(51, 18);
        labelLogin.TabIndex = 2;
        labelLogin.Text = "Логин:";
        // 
        // textBoxLastName
        // 
        textBoxLastName.Font = new Font("Ubuntu", 13F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxLastName.Location = new Point(66, 55);
        textBoxLastName.Name = "textBoxLastName";
        textBoxLastName.Size = new Size(332, 27);
        textBoxLastName.TabIndex = 0;
        // 
        // textBoxFirstName
        // 
        textBoxFirstName.Font = new Font("Ubuntu", 13F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxFirstName.Location = new Point(66, 114);
        textBoxFirstName.Name = "textBoxFirstName";
        textBoxFirstName.Size = new Size(332, 27);
        textBoxFirstName.TabIndex = 1;
        // 
        // textBoxLogin
        // 
        textBoxLogin.Font = new Font("Ubuntu", 13F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxLogin.Location = new Point(66, 243);
        textBoxLogin.Name = "textBoxLogin";
        textBoxLogin.Size = new Size(332, 27);
        textBoxLogin.TabIndex = 3;
        // 
        // buttonDone
        // 
        buttonDone.BackColor = Color.LightSlateGray;
        buttonDone.DialogResult = DialogResult.OK;
        buttonDone.FlatAppearance.BorderColor = Color.Black;
        buttonDone.FlatStyle = FlatStyle.Flat;
        buttonDone.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
        buttonDone.ForeColor = Color.White;
        buttonDone.Location = new Point(227, 370);
        buttonDone.Name = "buttonDone";
        buttonDone.Size = new Size(76, 33);
        buttonDone.TabIndex = 4;
        buttonDone.Text = "Готово";
        buttonDone.UseVisualStyleBackColor = false;
        buttonDone.Click += buttonDone_Click;
        // 
        // textBoxMiddleName
        // 
        textBoxMiddleName.Font = new Font("Ubuntu", 13F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxMiddleName.Location = new Point(66, 175);
        textBoxMiddleName.Name = "textBoxMiddleName";
        textBoxMiddleName.Size = new Size(332, 27);
        textBoxMiddleName.TabIndex = 2;
        // 
        // labelMiddleName
        // 
        labelMiddleName.AutoSize = true;
        labelMiddleName.Font = new Font("Ubuntu", 10F, FontStyle.Regular, GraphicsUnit.Point);
        labelMiddleName.ForeColor = Color.FromArgb(64, 64, 64);
        labelMiddleName.Location = new Point(69, 155);
        labelMiddleName.Name = "labelMiddleName";
        labelMiddleName.Size = new Size(70, 18);
        labelMiddleName.TabIndex = 8;
        labelMiddleName.Text = "Отчество:";
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
        panelmain.TabIndex = 13;
        panelmain.MouseDown += panelmain_MouseDown;
        panelmain.MouseMove += panelmain_MouseMove;
        // 
        // panelData
        // 
        panelData.BackColor = Color.WhiteSmoke;
        panelData.Controls.Add(textBoxLastName);
        panelData.Controls.Add(textBoxFirstName);
        panelData.Controls.Add(textBoxLogin);
        panelData.Controls.Add(labelMiddleName);
        panelData.Controls.Add(labelLogin);
        panelData.Controls.Add(lableLastName);
        panelData.Controls.Add(labelFirstName);
        panelData.Controls.Add(textBoxMiddleName);
        panelData.Location = new Point(33, 46);
        panelData.Name = "panelData";
        panelData.Size = new Size(464, 307);
        panelData.TabIndex = 13;
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
        toolStripLabelWindow.Size = new Size(233, 30);
        toolStripLabelWindow.Text = "Информация о пользователе";
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
        // UserDataForm
        // 
        AutoScaleDimensions = new SizeF(7F, 16F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.WindowFrame;
        ClientSize = new Size(532, 419);
        Controls.Add(panelmain);
        Font = new Font("Ubuntu", 9.163635F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.None;
        MaximizeBox = false;
        Name = "UserDataForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Информация о пользователе";
        panelmain.ResumeLayout(false);
        panelData.ResumeLayout(false);
        panelData.PerformLayout();
        toolStripMain.ResumeLayout(false);
        toolStripMain.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label lableLastName;
    private Label labelFirstName;
    private Label labelLogin;
    private TextBox textBoxLastName;
    private TextBox textBoxFirstName;
    private TextBox textBoxLogin;
    private Button buttonDone;
    private TextBox textBoxMiddleName;
    private Label labelMiddleName;
    private Panel panelmain;
    private ToolStrip toolStripMain;
    private ToolStripLabel toolStripLabelWindow;
    private ToolStripLabel toolStripLabelClose;
    private Panel panelData;
}
