using Npgsql;
using accounting.Models;

namespace accounting;

public partial class MainForm : Form
{
    public NpgsqlConnection _connection;

    private LoginForm loginForm;

    private bool userDirectSort = true;
    private bool licenseDataDirectSort = true;

    private void UpdateUserName()
    {
        uCurrentUserName.Text = _connection.UserName;
        lCurrentUserName.Text = _connection.UserName;
    }

    public MainForm()
    {
        InitializeComponent();

        loginForm = new LoginForm();
        if (loginForm.ShowDialog() == DialogResult.OK)
        {
            _connection = loginForm.connection;
            UpdateUserName();
            for (int i = 0; i < listViewUser.Columns.Count; ++i)
            {
                comboBoxFindUser.Items.Add(listViewUser.Columns[i].Text);
            }
            comboBoxFindUser.SelectedItem = comboBoxFindUser.Items[0];
            for (int i = 0; i < listViewLicenseData.Columns.Count; ++i)
            {
                comboBoxFindLicense.Items.Add(listViewLicenseData.Columns[i].Text);
            }
            comboBoxFindLicense.SelectedItem = comboBoxFindLicense.Items[0];
        }
    }

    private void LogOut_Click(object sender, EventArgs e)
    {
        loginForm.Activate();

        if (loginForm.ShowDialog() == DialogResult.OK)
        {
            _connection = loginForm.connection;
            UpdateUserName();
        }
    }


    private void updateLabelCountItemsUser()
    {
        labelCountItemsUser.Text = string.Format("Элементов: " + listViewUser.Items.Count.ToString());
    }

    private void updateLabelCountItemsLicenseData()
    {
        labelCountItemsLicenseData.Text = string.Format("Элементов: " + listViewLicenseData.Items.Count.ToString());
    }

    private void userSelect()
    {
        listViewUser.Tag = "";
        userDirectSort = true;
        var users = UserData.Select(_connection);
        listViewUser.Items.Clear();
        for (int i = 0; i < users.Count; i++)
        {
            var item = listViewUser.Items.Add(users[i].FirstName.ToString());
            item.Tag = users[i];
            item.SubItems.Add(users[i].MiddleName.ToString());
            item.SubItems.Add(users[i].LastName.ToString());
            item.SubItems.Add(users[i].Login.ToString());
            item.SubItems.Add(users[i].Email.ToString());
            item.SubItems.Add(users[i].Licenses.ToString());
        }
        updateLabelCountItemsUser();
    }

    private void userInsert_Click(object sender, EventArgs e)
    {
        try
        {
            UserDataForm userDataForm = new UserDataForm { UserData = new UserData() };
            if (userDataForm.ShowDialog() == DialogResult.OK) UserData.Insert(_connection, userDataForm.UserData);
            userSelect();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void userUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            UserDataForm userDataForm = new UserDataForm { UserData = (UserData)listViewUser.SelectedItems[0].Tag };
            if (userDataForm.ShowDialog() == DialogResult.OK) UserData.Update(_connection, userDataForm.UserData);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        userSelect();
    }

    private void userDelete_Click(object sender, EventArgs e)
    {
        try
        {
            UserData.Delete(_connection, ((UserData)listViewUser.SelectedItems[0].Tag).Id);
            userSelect();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void tabPageUser_Enter(object sender, EventArgs e)
    {
        try
        {
            userSelect();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void listViewUser_ColumnClick(object sender, ColumnClickEventArgs e)
    {
        try
        {
            if (listViewUser.Tag.ToString() == e.Column.ToString()) userDirectSort = (userDirectSort) ? false : true;
            else userDirectSort = true;
            listViewUser.Tag = e.Column.ToString();

            var users = UserData.Select(_connection, userDirectSort ? e.Column : e.Column + 6);
            listViewUser.Items.Clear();
            for (int i = 0; i < users.Count; i++)
            {
                var item = listViewUser.Items.Add(users[i].FirstName.ToString());
                item.Tag = users[i];
                item.SubItems.Add(users[i].MiddleName.ToString());
                item.SubItems.Add(users[i].LastName.ToString());
                item.SubItems.Add(users[i].Login.ToString());
                item.SubItems.Add(users[i].Email.ToString());
                item.SubItems.Add(users[i].Licenses.ToString());
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void licenseDataSelect()
    {
        licenseDataDirectSort = true;
        listViewLicenseData.Tag = "";
        var licenses = LicenseData.Select(_connection);
        listViewLicenseData.Items.Clear();
        for (int i = 0; i < licenses.Count; i++)
        {
            var item = listViewLicenseData.Items.Add(licenses[i].User.ToString());
            item.Tag = licenses[i];
            item.SubItems.Add(licenses[i].Program.ToString());
            item.SubItems.Add(licenses[i].Purchased.ToShortDateString() + " - " + licenses[i].Purchased.AddDays(licenses[i].AvailableLicense).ToShortDateString());
            item.SubItems.Add(licenses[i].LicenseKey.ToString());
            item.SubItems.Add(licenses[i].Price.ToString());
        }
        updateLabelCountItemsLicenseData();
    }

    private void licenseDataInsert_Click(object sender, EventArgs e)
    {
        try
        {

            LicenseDataForm licenseDataForm = new LicenseDataForm(_connection) { LicenseData = new LicenseData() };
            if (licenseDataForm.ShowDialog() == DialogResult.OK) LicenseData.Insert(_connection, licenseDataForm.LicenseData);
            licenseDataSelect();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void licenseDataUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            LicenseDataForm licenseDataForm = new LicenseDataForm(_connection) { LicenseData = (LicenseData)listViewLicenseData.SelectedItems[0].Tag };
            if (licenseDataForm.ShowDialog() == DialogResult.OK) LicenseData.Update(_connection, licenseDataForm.LicenseData);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        licenseDataSelect();
    }

    private void licenseDataDelete_Click(object sender, EventArgs e)
    {
        try
        {
            LicenseData.Delete(_connection, ((LicenseData)listViewLicenseData.SelectedItems[0].Tag).Id);
            licenseDataSelect();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void tabPageLicenseData_Enter(object sender, EventArgs e)
    {
        try
        {
            licenseDataSelect();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void listViewLicenseData_ColumnClick(object sender, ColumnClickEventArgs e)
    {
        try
        {
            if (listViewLicenseData.Tag.ToString() == e.Column.ToString()) licenseDataDirectSort = (licenseDataDirectSort) ? false : true;
            else licenseDataDirectSort = true;
            listViewLicenseData.Tag = e.Column.ToString();

            var licenses = LicenseData.Select(_connection, licenseDataDirectSort ? e.Column : e.Column + 5);
            listViewLicenseData.Items.Clear();
            for (int i = 0; i < licenses.Count; i++)
            {
                var item = listViewLicenseData.Items.Add(licenses[i].User.ToString());
                item.Tag = licenses[i];
                item.SubItems.Add(licenses[i].Program.ToString());
                item.SubItems.Add(licenses[i].Purchased.ToShortDateString() + " - " + licenses[i].Purchased.AddDays(licenses[i].AvailableLicense).ToShortDateString());
                item.SubItems.Add(licenses[i].LicenseKey.ToString());
                item.SubItems.Add(licenses[i].Price.ToString());
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void textBoxFindUser_TextChanged(object sender, EventArgs e)
    {
        try
        {

            userSelect();
            if (textBoxFindUser.Text == "") return;

            listViewUser.Visible = false;
            foreach (ListViewItem item in listViewUser.Items)
            {
                if (!item.SubItems[comboBoxFindUser.SelectedIndex].Text.ToLower().Contains(textBoxFindUser.Text.ToLower()))
                {
                    listViewUser.Items.Remove(item);
                }
            }
            updateLabelCountItemsUser();
            listViewUser.Visible = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void textBoxFindLicense_TextChanged(object sender, EventArgs e)
    {
        try
        {
            licenseDataSelect();
            if (textBoxFindLicense.Text == "") return;

            listViewLicenseData.Visible = false;
            foreach (ListViewItem item in listViewLicenseData.Items)
            {
                if (!item.SubItems[comboBoxFindLicense.SelectedIndex].Text.ToLower().Contains(textBoxFindLicense.Text.ToLower()))
                {
                    listViewLicenseData.Items.Remove(item);
                }
            }
            updateLabelCountItemsLicenseData();
            listViewLicenseData.Visible = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
