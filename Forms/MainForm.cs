using HW_UsersControls.Classes;

namespace HW_UsersControls.Forms;

public partial class MainForm : Form
{
    public List<Note> _notes; 
    public MainForm()
    {
        _notes = new List<Note>();
        InitializeComponent();
    }

    private void SaveButtonClick(object sender, EventArgs e)
    {
        if (nameNoteTextBox.Text == string.Empty || textNoteTextBox.Text == string.Empty)
        {
            MessageBox.Show("Not all data is entered!");

            return;
        }

        Note tempNote = new Note()
        {
            Name = nameNoteTextBox.Text,
            Text = textNoteTextBox.Text,
            CreateTime = DateTime.Now
        };

        _notes.Add(tempNote);

        MessageBox.Show("Saved successfully!");

        nameNoteTextBox.Text = string.Empty;

        textNoteTextBox.Text = string.Empty;
    }


    private void ShowListNotesButtonCkick(object sender, EventArgs e)
    {
        ListNotesForm listNotes = new ListNotesForm(_notes);

        listNotes.Show();
    }
}
