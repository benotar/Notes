using HW_UsersControls.Classes;
using HW_UsersControls.Data;
using Microsoft.EntityFrameworkCore;

namespace HW_UsersControls.Forms;

public partial class MainForm : Form
{
    //public List<Note> _notes;

    DataContext _db;

    public MainForm(DbContextOptions<DataContext> options)
    {
        _db = new(options);
        _db.Database.EnsureCreated();

        InitializeComponent();
    }

    private void SaveButtonClick(object sender, EventArgs e)
    {
        if (nameNoteTextBox.Text == string.Empty || textNoteTextBox.Text == string.Empty)
        {
            MessageBox.Show("Відсутні дані!");

            return;
        }

        Note tempNote = new Note()
        {
            Name = nameNoteTextBox.Text,
            Text = textNoteTextBox.Text,
            CreateTime = DateTime.Now
        };

        _db.Notes.Add(tempNote);

        _db.SaveChanges();

        MessageBox.Show("Успішно збережено!");

        nameNoteTextBox.Text = string.Empty;

        textNoteTextBox.Text = string.Empty;
    }


    private void ShowListNotesButtonCkick(object sender, EventArgs e)
    {
        ListNotesForm listNotes = new ListNotesForm(_db);

        listNotes.Show();
    }
}
