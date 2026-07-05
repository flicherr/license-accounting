using accounting.Models;
using Npgsql;

namespace accounting;

public partial class LicenseDataForm : Form
{
    private LicenseData _licenseData;
    private NpgsqlConnection Connection;

    private Point lastPoint;

    private void updateDescPrg()
    {
        List<ProgramData> programs = new List<ProgramData>((List<ProgramData>)comboBoxProgram.Tag);
        textBoxDescPrg.Text = string.Format(programs[comboBoxProgram.SelectedIndex].ProductDescription + ".\r\n\r\nОтносится к категории \"" + programs[comboBoxProgram.SelectedIndex].Category + "\" (" + programs[comboBoxProgram.SelectedIndex].DescriptionCategory + ".)");
    }

    public LicenseData LicenseData
    {
        get { return _licenseData; }
        set
        {
            _licenseData = value;

            var users = UserData.Select(Connection);
            for (int i = 0; i < users.Count; ++i)
            {
                comboBoxUser.Items.Add(string.Format(users[i].FirstName + " " + users[i].MiddleName + " " + users[i].LastName[0].ToString() + "."));
                if (_licenseData.UserId == users[i].Id)
                {
                    comboBoxUser.SelectedIndex = i;
                    comboBoxUser.Tag = users[i];
                }
            }
            var programs = ProgramData.Select(Connection);
            for (int i = 0; i < programs.Count; ++i)
            {
                comboBoxProgram.Items.Add(string.Format(programs[i].Title + " (" + programs[i].Developer + ")"));
                if (_licenseData.ProgramId == programs[i].Id)
                {
                    comboBoxProgram.SelectedIndex = i;
                    comboBoxProgram.Tag = programs;
                    updateDescPrg();
                }
            }
            dateTimePickerPurchased.Value = LicenseData.Purchased;
            textBoxLicenseKey.Text = LicenseData.LicenseKey;
        }
    }

    public LicenseDataForm(NpgsqlConnection connection)
    {
        InitializeComponent();
        Connection = connection;
    }

    private void buttonDone_Click(object sender, EventArgs e)
    {
        var users = UserData.Select(Connection);
        for (int i = 0; i < users.Count; ++i)
        {
            if (string.Format(users[i].FirstName + " " + users[i].MiddleName + " " + users[i].LastName[0].ToString() + ".") == (string)comboBoxUser.SelectedItem)
            {
                LicenseData.UserId = users[i].Id;
                LicenseData.User = users[i].FirstName + " " + users[i].MiddleName + " " + users[i].LastName[0].ToString() + ".";
            }
        }
        var programs = ProgramData.Select(Connection);
        for (int i = 0; i < programs.Count; ++i)
        {
            if (string.Format(programs[i].Title + " (" + programs[i].Developer + ")") == (string)comboBoxProgram.SelectedItem)
            {
                LicenseData.ProgramId = programs[i].Id;
                LicenseData.Program = programs[i].Title + " (" + programs[i].Developer + ")";
            }
        }
        LicenseData.Purchased = dateTimePickerPurchased.Value;
        LicenseData.LicenseKey = textBoxLicenseKey.Text;
    }

    private void toolStripLabelClose_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
    }

    private void toolStripLabelClose_MouseEnter(object sender, EventArgs e)
    {
        toolStripLabelClose.ForeColor = Color.Red;
    }

    private void toolStripLabelClose_MouseLeave(object sender, EventArgs e)
    {
        toolStripLabelClose.ForeColor = Color.White;
    }

    private void panelmain_MouseDown(object sender, MouseEventArgs e)
    {
        lastPoint = new Point(e.X, e.Y);
    }

    private void panelmain_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            Left += e.X - lastPoint.X;
            Top += e.Y - lastPoint.Y;
        }
    }

    private void comboBoxProgram_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBoxProgram.Tag != null && (comboBoxProgram.SelectedIndex >= 0 && comboBoxProgram.SelectedIndex < comboBoxProgram.Items.Count)) updateDescPrg();
    }
}
