using HW_UsersControls.Classes;
using HW_UsersControls.Controls;
using HW_UsersControls.Data;

namespace HW_UsersControls.Forms;

public partial class ListNotesForm : Form
{
    //private List<Note> _notes;

    DataContext _db;

    private int _nextY = 10;

    public ListNotesForm(DataContext db)
    {
        _db = db;

        InitializeComponent();
    }

    private void ListNotesFormLoad(object sender, EventArgs e)
    {
        RenderNotes();
    }
    
    private void RenderNotes()
    {
        if (_db is null)
        {
            return;
        }

        for (int i = 0; i < _db.Notes.Count(); i++)
        {
            RenderNote(i);
        }
    }


    private void RenderNote(int index)
    {
        Note note = _db.Notes.ToList()[index];

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
