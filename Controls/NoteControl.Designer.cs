namespace HW_UsersControls.Controls;

partial class NoteControl
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        NameNoteLabel = new Label();
        TextNoteLabel = new Label();
        CreateDateLabel = new Label();

        NameNoteLabel.Font = new Font("Courier New", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        CreateDateLabel.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        TextNoteLabel.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);

        NameNoteLabel.Location = new Point(5, 5);
        CreateDateLabel.Location = new Point(NameNoteLabel.Location.X, NameNoteLabel.Location.Y + 50);
        TextNoteLabel.Location = new Point(CreateDateLabel.Location.X + 150, CreateDateLabel.Location.Y);

        TextNoteLabel.Size = new Size(500 - CreateDateLabel.Right, TextNoteLabel.Height - 5);
        TextNoteLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;

        SuspendLayout();
        // 
        // NoteControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        Name = "NoteControl";
        Size = new Size(500, 80);
        DoubleClick += ControlDoubleClick;
        Controls.Add(NameNoteLabel);
        Controls.Add(CreateDateLabel);
        Controls.Add(TextNoteLabel);
        ResumeLayout(false);
    }

    public Label NameNoteLabel {get; set;}
    public Label CreateDateLabel { get; set; }
    public Label TextNoteLabel { get; set; }
    #endregion
}
