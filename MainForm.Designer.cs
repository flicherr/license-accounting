namespace accounting;

partial class MainForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        tabPageLicenseData = new TabPage();
        listViewLicenseData = new ListView();
        columnUser = new ColumnHeader();
        columnProgram = new ColumnHeader();
        columnDateValid = new ColumnHeader();
        columnLicenseKey = new ColumnHeader();
        columnPrice = new ColumnHeader();
        toolStripMain = new ToolStrip();
        licenseDataInsert = new ToolStripButton();
        licenseDataUpdate = new ToolStripButton();
        licenseDataDelete = new ToolStripButton();
        lLogOut = new ToolStripButton();
        lCurrentUserName = new ToolStripLabel();
        toolStripSeparatorLicenseOne = new ToolStripSeparator();
        labelCountItemsLicenseData = new ToolStripLabel();
        toolStripSeparatorLicenseTwo = new ToolStripSeparator();
        textBoxFindLicense = new ToolStripTextBox();
        comboBoxFindLicense = new ToolStripComboBox();
        miniToolStrip = new ToolStrip();
        tabPageUser = new TabPage();
        listViewUser = new ListView();
        columnUserFirstName = new ColumnHeader();
        columnUserMiddleName = new ColumnHeader();
        columnUserLastName = new ColumnHeader();
        columnUserLogin = new ColumnHeader();
        columnUserEmail = new ColumnHeader();
        columnLicenses = new ColumnHeader();
        toolStripUser = new ToolStrip();
        userInsert = new ToolStripButton();
        userUpdate = new ToolStripButton();
        userDelete = new ToolStripButton();
        uLogOut = new ToolStripButton();
        uCurrentUserName = new ToolStripLabel();
        toolStripSeparatorUserOne = new ToolStripSeparator();
        labelCountItemsUser = new ToolStripLabel();
        toolStripSeparatorUserTwo = new ToolStripSeparator();
        textBoxFindUser = new ToolStripTextBox();
        comboBoxFindUser = new ToolStripComboBox();
        tabControlMain = new TabControl();
        tabPageLicenseData.SuspendLayout();
        toolStripMain.SuspendLayout();
        tabPageUser.SuspendLayout();
        toolStripUser.SuspendLayout();
        tabControlMain.SuspendLayout();
        SuspendLayout();
        // 
        // tabPageLicenseData
        // 
        tabPageLicenseData.Controls.Add(listViewLicenseData);
        tabPageLicenseData.Controls.Add(toolStripMain);
        tabPageLicenseData.Location = new Point(28, 4);
        tabPageLicenseData.Name = "tabPageLicenseData";
        tabPageLicenseData.Size = new Size(965, 645);
        tabPageLicenseData.TabIndex = 4;
        tabPageLicenseData.Text = "Лицензии";
        tabPageLicenseData.UseVisualStyleBackColor = true;
        tabPageLicenseData.Enter += tabPageLicenseData_Enter;
        // 
        // listViewLicenseData
        // 
        listViewLicenseData.BorderStyle = BorderStyle.None;
        listViewLicenseData.Columns.AddRange(new ColumnHeader[] { columnUser, columnProgram, columnDateValid, columnLicenseKey, columnPrice });
        listViewLicenseData.Dock = DockStyle.Fill;
        listViewLicenseData.Font = new Font("Ubuntu", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
        listViewLicenseData.FullRowSelect = true;
        listViewLicenseData.GridLines = true;
        listViewLicenseData.Location = new Point(0, 31);
        listViewLicenseData.Name = "listViewLicenseData";
        listViewLicenseData.Size = new Size(965, 614);
        listViewLicenseData.TabIndex = 3;
        listViewLicenseData.UseCompatibleStateImageBehavior = false;
        listViewLicenseData.View = View.Details;
        listViewLicenseData.ColumnClick += listViewLicenseData_ColumnClick;
        // 
        // columnUser
        // 
        columnUser.Text = "Пользователь";
        columnUser.Width = 240;
        // 
        // columnProgram
        // 
        columnProgram.Text = "Программа";
        columnProgram.Width = 210;
        // 
        // columnDateValid
        // 
        columnDateValid.Text = "Период действия лицензии";
        columnDateValid.Width = 210;
        // 
        // columnLicenseKey
        // 
        columnLicenseKey.Text = "Ключ";
        columnLicenseKey.Width = 200;
        // 
        // columnPrice
        // 
        columnPrice.Text = "Цена (USD)";
        columnPrice.Width = 100;
        // 
        // toolStripMain
        // 
        toolStripMain.AutoSize = false;
        toolStripMain.BackColor = Color.White;
        toolStripMain.Font = new Font("Ubuntu", 9.81818F, FontStyle.Regular, GraphicsUnit.Point);
        toolStripMain.GripStyle = ToolStripGripStyle.Hidden;
        toolStripMain.ImageScalingSize = new Size(18, 18);
        toolStripMain.Items.AddRange(new ToolStripItem[] { licenseDataInsert, licenseDataUpdate, licenseDataDelete, lLogOut, lCurrentUserName, toolStripSeparatorLicenseOne, labelCountItemsLicenseData, toolStripSeparatorLicenseTwo, textBoxFindLicense, comboBoxFindLicense });
        toolStripMain.Location = new Point(0, 0);
        toolStripMain.Name = "toolStripMain";
        toolStripMain.RenderMode = ToolStripRenderMode.System;
        toolStripMain.Size = new Size(965, 31);
        toolStripMain.TabIndex = 2;
        // 
        // licenseDataInsert
        // 
        licenseDataInsert.AutoSize = false;
        licenseDataInsert.DisplayStyle = ToolStripItemDisplayStyle.Image;
        licenseDataInsert.Font = new Font("Ubuntu", 14F, FontStyle.Regular, GraphicsUnit.Point);
        licenseDataInsert.Image = (Image)resources.GetObject("licenseDataInsert.Image");
        licenseDataInsert.ImageTransparentColor = Color.Magenta;
        licenseDataInsert.Name = "licenseDataInsert";
        licenseDataInsert.Size = new Size(32, 32);
        licenseDataInsert.Text = "Добавить";
        licenseDataInsert.Click += licenseDataInsert_Click;
        // 
        // licenseDataUpdate
        // 
        licenseDataUpdate.AutoSize = false;
        licenseDataUpdate.DisplayStyle = ToolStripItemDisplayStyle.Image;
        licenseDataUpdate.Font = new Font("Ubuntu", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
        licenseDataUpdate.Image = (Image)resources.GetObject("licenseDataUpdate.Image");
        licenseDataUpdate.ImageTransparentColor = Color.Magenta;
        licenseDataUpdate.Name = "licenseDataUpdate";
        licenseDataUpdate.Size = new Size(32, 32);
        licenseDataUpdate.Text = "Изменить";
        licenseDataUpdate.Click += licenseDataUpdate_Click;
        // 
        // licenseDataDelete
        // 
        licenseDataDelete.AutoSize = false;
        licenseDataDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
        licenseDataDelete.Font = new Font("Ubuntu", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
        licenseDataDelete.Image = (Image)resources.GetObject("licenseDataDelete.Image");
        licenseDataDelete.ImageTransparentColor = Color.Magenta;
        licenseDataDelete.Name = "licenseDataDelete";
        licenseDataDelete.Size = new Size(32, 32);
        licenseDataDelete.Text = "Удалить";
        licenseDataDelete.Click += licenseDataDelete_Click;
        // 
        // lLogOut
        // 
        lLogOut.Alignment = ToolStripItemAlignment.Right;
        lLogOut.DisplayStyle = ToolStripItemDisplayStyle.Text;
        lLogOut.Image = (Image)resources.GetObject("lLogOut.Image");
        lLogOut.ImageTransparentColor = Color.Magenta;
        lLogOut.Name = "lLogOut";
        lLogOut.Size = new Size(57, 28);
        lLogOut.Text = "log out";
        lLogOut.TextImageRelation = TextImageRelation.TextAboveImage;
        lLogOut.ToolTipText = "Выйти (сменить пользователя)";
        lLogOut.Click += LogOut_Click;
        // 
        // lCurrentUserName
        // 
        lCurrentUserName.Alignment = ToolStripItemAlignment.Right;
        lCurrentUserName.AutoSize = false;
        lCurrentUserName.Enabled = false;
        lCurrentUserName.Name = "lCurrentUserName";
        lCurrentUserName.Size = new Size(128, 24);
        lCurrentUserName.TextAlign = ContentAlignment.MiddleRight;
        lCurrentUserName.ToolTipText = "Выполнен вход в базу данных под данным пользователем";
        // 
        // toolStripSeparatorLicenseOne
        // 
        toolStripSeparatorLicenseOne.Name = "toolStripSeparatorLicenseOne";
        toolStripSeparatorLicenseOne.Size = new Size(6, 31);
        // 
        // labelCountItemsLicenseData
        // 
        labelCountItemsLicenseData.Name = "labelCountItemsLicenseData";
        labelCountItemsLicenseData.Size = new Size(95, 28);
        labelCountItemsLicenseData.Text = "Элементов: 0";
        // 
        // toolStripSeparatorLicenseTwo
        // 
        toolStripSeparatorLicenseTwo.Name = "toolStripSeparatorLicenseTwo";
        toolStripSeparatorLicenseTwo.Size = new Size(6, 31);
        // 
        // textBoxFindLicense
        // 
        textBoxFindLicense.AutoSize = false;
        textBoxFindLicense.Font = new Font("Ubuntu", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxFindLicense.Name = "textBoxFindLicense";
        textBoxFindLicense.Size = new Size(169, 25);
        textBoxFindLicense.TextChanged += textBoxFindLicense_TextChanged;
        // 
        // comboBoxFindLicense
        // 
        comboBoxFindLicense.AutoSize = false;
        comboBoxFindLicense.BackColor = SystemColors.Window;
        comboBoxFindLicense.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxFindLicense.FlatStyle = FlatStyle.System;
        comboBoxFindLicense.Font = new Font("Ubuntu", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        comboBoxFindLicense.Name = "comboBoxFindLicense";
        comboBoxFindLicense.Size = new Size(200, 25);
        // 
        // miniToolStrip
        // 
        miniToolStrip.AccessibleName = "Выбор нового элемента";
        miniToolStrip.AccessibleRole = AccessibleRole.ButtonDropDown;
        miniToolStrip.AutoSize = false;
        miniToolStrip.BackColor = Color.White;
        miniToolStrip.CanOverflow = false;
        miniToolStrip.Dock = DockStyle.None;
        miniToolStrip.Font = new Font("Ubuntu", 9.81818F, FontStyle.Regular, GraphicsUnit.Point);
        miniToolStrip.GripStyle = ToolStripGripStyle.Hidden;
        miniToolStrip.ImageScalingSize = new Size(18, 18);
        miniToolStrip.Location = new Point(390, 6);
        miniToolStrip.Name = "miniToolStrip";
        miniToolStrip.RenderMode = ToolStripRenderMode.System;
        miniToolStrip.Size = new Size(959, 31);
        miniToolStrip.TabIndex = 2;
        // 
        // tabPageUser
        // 
        tabPageUser.BackColor = Color.White;
        tabPageUser.Controls.Add(listViewUser);
        tabPageUser.Controls.Add(toolStripUser);
        tabPageUser.Location = new Point(28, 4);
        tabPageUser.Margin = new Padding(0);
        tabPageUser.Name = "tabPageUser";
        tabPageUser.Size = new Size(965, 645);
        tabPageUser.TabIndex = 0;
        tabPageUser.Text = "Пользователи";
        tabPageUser.Enter += tabPageUser_Enter;
        // 
        // listViewUser
        // 
        listViewUser.BorderStyle = BorderStyle.None;
        listViewUser.Columns.AddRange(new ColumnHeader[] { columnUserFirstName, columnUserMiddleName, columnUserLastName, columnUserLogin, columnUserEmail, columnLicenses });
        listViewUser.Dock = DockStyle.Fill;
        listViewUser.Font = new Font("Ubuntu", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
        listViewUser.FullRowSelect = true;
        listViewUser.GridLines = true;
        listViewUser.Location = new Point(0, 31);
        listViewUser.Name = "listViewUser";
        listViewUser.Size = new Size(965, 614);
        listViewUser.TabIndex = 1;
        listViewUser.UseCompatibleStateImageBehavior = false;
        listViewUser.View = View.Details;
        listViewUser.ColumnClick += listViewUser_ColumnClick;
        // 
        // columnUserFirstName
        // 
        columnUserFirstName.Text = "Имя";
        columnUserFirstName.Width = 200;
        // 
        // columnUserMiddleName
        // 
        columnUserMiddleName.Text = "Отчетство";
        columnUserMiddleName.Width = 210;
        // 
        // columnUserLastName
        // 
        columnUserLastName.Text = "Фамилия";
        columnUserLastName.Width = 200;
        // 
        // columnUserLogin
        // 
        columnUserLogin.Text = "Логин";
        columnUserLogin.Width = 180;
        // 
        // columnUserEmail
        // 
        columnUserEmail.Text = "Электронная почта";
        columnUserEmail.Width = 220;
        // 
        // columnLicenses
        // 
        columnLicenses.Text = "Количество программ";
        columnLicenses.Width = 130;
        // 
        // toolStripUser
        // 
        toolStripUser.AutoSize = false;
        toolStripUser.BackColor = Color.White;
        toolStripUser.Font = new Font("Ubuntu", 9.81818F, FontStyle.Regular, GraphicsUnit.Point);
        toolStripUser.GripStyle = ToolStripGripStyle.Hidden;
        toolStripUser.ImageScalingSize = new Size(18, 18);
        toolStripUser.Items.AddRange(new ToolStripItem[] { userInsert, userUpdate, userDelete, uLogOut, uCurrentUserName, toolStripSeparatorUserOne, labelCountItemsUser, toolStripSeparatorUserTwo, textBoxFindUser, comboBoxFindUser });
        toolStripUser.Location = new Point(0, 0);
        toolStripUser.Name = "toolStripUser";
        toolStripUser.RenderMode = ToolStripRenderMode.System;
        toolStripUser.Size = new Size(965, 31);
        toolStripUser.TabIndex = 0;
        // 
        // userInsert
        // 
        userInsert.AutoSize = false;
        userInsert.BackgroundImageLayout = ImageLayout.Zoom;
        userInsert.DisplayStyle = ToolStripItemDisplayStyle.Image;
        userInsert.Font = new Font("Ubuntu", 14F, FontStyle.Regular, GraphicsUnit.Point);
        userInsert.Image = (Image)resources.GetObject("userInsert.Image");
        userInsert.ImageTransparentColor = Color.Magenta;
        userInsert.Name = "userInsert";
        userInsert.Size = new Size(32, 32);
        userInsert.Text = "Добавить";
        userInsert.Click += userInsert_Click;
        // 
        // userUpdate
        // 
        userUpdate.AutoSize = false;
        userUpdate.DisplayStyle = ToolStripItemDisplayStyle.Image;
        userUpdate.Font = new Font("Ubuntu", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
        userUpdate.Image = (Image)resources.GetObject("userUpdate.Image");
        userUpdate.ImageTransparentColor = Color.Magenta;
        userUpdate.Name = "userUpdate";
        userUpdate.Size = new Size(32, 32);
        userUpdate.Text = "Изменить";
        userUpdate.Click += userUpdate_Click;
        // 
        // userDelete
        // 
        userDelete.AutoSize = false;
        userDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
        userDelete.Font = new Font("Ubuntu", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
        userDelete.Image = (Image)resources.GetObject("userDelete.Image");
        userDelete.ImageTransparentColor = Color.Magenta;
        userDelete.Name = "userDelete";
        userDelete.Size = new Size(32, 32);
        userDelete.Text = "Удалить";
        userDelete.Click += userDelete_Click;
        // 
        // uLogOut
        // 
        uLogOut.Alignment = ToolStripItemAlignment.Right;
        uLogOut.DisplayStyle = ToolStripItemDisplayStyle.Text;
        uLogOut.Image = (Image)resources.GetObject("uLogOut.Image");
        uLogOut.ImageTransparentColor = Color.Magenta;
        uLogOut.Name = "uLogOut";
        uLogOut.Size = new Size(57, 28);
        uLogOut.Text = "log out";
        uLogOut.TextImageRelation = TextImageRelation.TextAboveImage;
        uLogOut.ToolTipText = "Выйти (сменить пользователя)";
        uLogOut.Click += LogOut_Click;
        // 
        // uCurrentUserName
        // 
        uCurrentUserName.Alignment = ToolStripItemAlignment.Right;
        uCurrentUserName.AutoSize = false;
        uCurrentUserName.Enabled = false;
        uCurrentUserName.Name = "uCurrentUserName";
        uCurrentUserName.Size = new Size(128, 24);
        uCurrentUserName.TextAlign = ContentAlignment.MiddleRight;
        uCurrentUserName.ToolTipText = "Выполнен вход в базу данных под данным пользователем";
        // 
        // toolStripSeparatorUserOne
        // 
        toolStripSeparatorUserOne.Name = "toolStripSeparatorUserOne";
        toolStripSeparatorUserOne.Size = new Size(6, 31);
        // 
        // labelCountItemsUser
        // 
        labelCountItemsUser.Name = "labelCountItemsUser";
        labelCountItemsUser.Size = new Size(95, 28);
        labelCountItemsUser.Text = "Элементов: 0";
        // 
        // toolStripSeparatorUserTwo
        // 
        toolStripSeparatorUserTwo.Name = "toolStripSeparatorUserTwo";
        toolStripSeparatorUserTwo.Size = new Size(6, 31);
        // 
        // textBoxFindUser
        // 
        textBoxFindUser.AutoSize = false;
        textBoxFindUser.Font = new Font("Ubuntu", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxFindUser.Name = "textBoxFindUser";
        textBoxFindUser.Size = new Size(169, 25);
        textBoxFindUser.TextChanged += textBoxFindUser_TextChanged;
        // 
        // comboBoxFindUser
        // 
        comboBoxFindUser.AutoSize = false;
        comboBoxFindUser.BackColor = SystemColors.Window;
        comboBoxFindUser.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxFindUser.FlatStyle = FlatStyle.System;
        comboBoxFindUser.Font = new Font("Ubuntu", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
        comboBoxFindUser.Name = "comboBoxFindUser";
        comboBoxFindUser.Size = new Size(170, 25);
        // 
        // tabControlMain
        // 
        tabControlMain.Alignment = TabAlignment.Left;
        tabControlMain.Controls.Add(tabPageUser);
        tabControlMain.Controls.Add(tabPageLicenseData);
        tabControlMain.Dock = DockStyle.Fill;
        tabControlMain.Font = new Font("Ubuntu", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point);
        tabControlMain.Location = new Point(0, 0);
        tabControlMain.Margin = new Padding(0);
        tabControlMain.Multiline = true;
        tabControlMain.Name = "tabControlMain";
        tabControlMain.Padding = new Point(0, 0);
        tabControlMain.SelectedIndex = 0;
        tabControlMain.Size = new Size(997, 653);
        tabControlMain.TabIndex = 3;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 16F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Window;
        ClientSize = new Size(997, 653);
        Controls.Add(tabControlMain);
        Font = new Font("Ubuntu", 9.163635F, FontStyle.Regular, GraphicsUnit.Point);
        KeyPreview = true;
        MinimumSize = new Size(800, 350);
        Name = "MainForm";
        ShowIcon = false;
        Text = "accounting";
        tabPageLicenseData.ResumeLayout(false);
        toolStripMain.ResumeLayout(false);
        toolStripMain.PerformLayout();
        tabPageUser.ResumeLayout(false);
        toolStripUser.ResumeLayout(false);
        toolStripUser.PerformLayout();
        tabControlMain.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TabPage tabPageLicenseData;
    private ListView listViewLicenseData;
    private ColumnHeader columnUser;
    private ColumnHeader columnProgram;
    private ColumnHeader columnDateValid;
    private ColumnHeader columnLicenseKey;
    private ToolStrip toolStripMain;
    private ToolStripButton licenseDataInsert;
    private ToolStripButton licenseDataUpdate;
    private ToolStripButton licenseDataDelete;
    private ToolStripButton lLogOut;
    private ToolStripLabel lCurrentUserName;
    private ToolStripTextBox textBoxFindLicense;
    private ToolStripComboBox comboBoxFindLicense;
    private ToolStrip miniToolStrip;
    private TabPage tabPageUser;
    private ListView listViewUser;
    private ColumnHeader columnUserFirstName;
    private ColumnHeader columnUserMiddleName;
    private ColumnHeader columnUserLastName;
    private ColumnHeader columnUserLogin;
    private ColumnHeader columnUserEmail;
    private ColumnHeader columnLicenses;
    private ToolStrip toolStripUser;
    private ToolStripButton userInsert;
    private ToolStripButton userUpdate;
    private ToolStripButton userDelete;
    private ToolStripButton uLogOut;
    private ToolStripLabel uCurrentUserName;
    private ToolStripSeparator toolStripSeparatorUserTwo;
    private ToolStripTextBox textBoxFindUser;
    private ToolStripComboBox comboBoxFindUser;
    private TabControl tabControlMain;
    private ColumnHeader columnPrice;
    private ToolStripLabel labelCountItemsUser;
    private ToolStripLabel labelCountItemsLicenseData;
    private ToolStripSeparator toolStripSeparatorLicenseOne;
    private ToolStripSeparator toolStripSeparatorUserOne;
    private ToolStripSeparator toolStripSeparatorLicenseTwo;
}
