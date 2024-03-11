using HW_UsersControls.Classes;
using HW_UsersControls.Controls;

namespace HW_UsersControls.Forms;

public partial class ListNotesForm : Form
{
    private List<Note> _notes;

    private int _nextY = 10;

    public ListNotesForm(List<Note> notes)
    {
        _notes = notes;

        InitializeComponent();
    }

    private void ListNotesFormLoad(object sender, EventArgs e)
    {
        RenderNotes();
    }
    
    private void RenderNotes()
    {
        if (_notes is null)
        {
            return;
        }

        for (int i = 0; i < _notes.Count; i++)
        {
            RenderNote(i);
        }
    }


    private void RenderNote(int index)
    {
        Note note = _notes[index];

        NoteControl noteControl = new NoteControl();

        noteControl.Name = note.Name;
        noteControl.NameNoteLabel.Text = note.Name;
        noteControl.CreateDateLabel.Text = note.CreateTime.ToString();
        noteControl.TextNoteLabel.Text = note.Text;

        noteControl.Location = new Point(10, _nextY);


        Controls.Add(noteControl);

        _nextY = _nextY + 110;
    }
}
