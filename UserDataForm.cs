using accounting.Models;

namespace accounting;

public partial class UserDataForm : Form
{
    private UserData _userData;

    private Point lastPoint;

    public UserData UserData
    {
        get { return _userData; }
        set
        {
            _userData = value;
            textBoxLastName.Text = _userData.LastName;
            textBoxMiddleName.Text = _userData.MiddleName;
            textBoxFirstName.Text = _userData.FirstName;
            textBoxLogin.Text = _userData.Login;
        }
    }

    public UserDataForm()
    {
        InitializeComponent();
    }

    private void buttonDone_Click(object sender, EventArgs e)
    {
        UserData.LastName = textBoxLastName.Text;
        UserData.MiddleName = textBoxMiddleName.Text;
        UserData.FirstName = textBoxFirstName.Text;
        UserData.Login = textBoxLogin.Text;
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
}
