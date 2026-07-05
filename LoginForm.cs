using System.Data;
using Npgsql;

namespace accounting;

public partial class LoginForm : Form
{
    public NpgsqlConnection connection;

    private Point lastPoint;

    public LoginForm()
    {
        InitializeComponent();
    }

    private void buttonDone_Click(object sender, EventArgs e)
    {
        connection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=" + textBoxLogin.Text + ";Password=" + textBoxPassword.Text + ";Database=accounting;");
        try
        {
            connection.Open();
        }
        catch
        {
            statusLabel.Text = "Неверный логин или пароль";
            DialogResult = DialogResult.None;
        }
        if (connection.State == ConnectionState.Open) connection.Close();
    }

    private void labelClose_Click(object sender, EventArgs e)
    {
        connection = null;
        DialogResult = DialogResult.Cancel;
    }

    private void labelClose_MouseEnter(object sender, EventArgs e)
    {
        labelClose.ForeColor = Color.Red;
    }

    private void labelClose_MouseLeave(object sender, EventArgs e)
    {
        labelClose.ForeColor = Color.Black;
    }

    private void LoginForm_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            Left += e.X - lastPoint.X;
            Top += e.Y - lastPoint.Y;
        }
    }

    private void LoginForm_MouseDown(object sender, MouseEventArgs e)
    {
        lastPoint = new Point(e.X, e.Y);
    }
}
