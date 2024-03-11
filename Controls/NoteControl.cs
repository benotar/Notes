namespace HW_UsersControls.Controls;

public partial class NoteControl : UserControl
{
    public NoteControl()
    {
        InitializeComponent();
    }

    private void ControlDoubleClick(object sender, EventArgs e)
    {
        string name = NameNoteLabel.Text;
        string createDate = CreateDateLabel.Text;
        string text = TextNoteLabel.Text;

        string message = $"Назва: {name}\n\n"
            + $"Дата створення: {createDate}\n\n"
            + "Нотатка: " + text + ".";

        MessageBox.Show(message);
    }
}
