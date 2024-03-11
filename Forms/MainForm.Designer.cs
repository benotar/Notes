using HW_UsersControls.Controls;

namespace HW_UsersControls.Forms;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        textNoteTextBox = new TextBox();
        noteLabel = new Label();
        nameNoteTextBox = new TextBox();
        nameNoteLabel = new Label();
        saveNoteButton = new Button();
        listNotesButton = new Button();
        SuspendLayout();
        // 
        // textNoteTextBox
        // 
        textNoteTextBox.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        textNoteTextBox.Location = new Point(12, 120);
        textNoteTextBox.Multiline = true;
        textNoteTextBox.Name = "textNoteTextBox";
        textNoteTextBox.Size = new Size(689, 393);
        textNoteTextBox.TabIndex = 0;
        // 
        // noteLabel
        // 
        noteLabel.AutoSize = true;
        noteLabel.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
        noteLabel.ForeColor = SystemColors.Desktop;
        noteLabel.Location = new Point(263, 31);
        noteLabel.Name = "noteLabel";
        noteLabel.Size = new Size(166, 23);
        noteLabel.TabIndex = 1;
        noteLabel.Text = "Нова нотатка";
        // 
        // nameNoteTextBox
        // 
        nameNoteTextBox.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        nameNoteTextBox.Location = new Point(210, 88);
        nameNoteTextBox.Name = "nameNoteTextBox";
        nameNoteTextBox.Size = new Size(491, 26);
        nameNoteTextBox.TabIndex = 2;
        // 
        // nameNoteLabel
        // 
        nameNoteLabel.AutoSize = true;
        nameNoteLabel.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
        nameNoteLabel.ForeColor = SystemColors.Desktop;
        nameNoteLabel.Location = new Point(12, 88);
        nameNoteLabel.Name = "nameNoteLabel";
        nameNoteLabel.Size = new Size(192, 23);
        nameNoteLabel.TabIndex = 3;
        nameNoteLabel.Text = "Введіть назву:";
        // 
        // saveNoteButton
        // 
        saveNoteButton.Font = new Font("Courier New", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        saveNoteButton.Location = new Point(181, 521);
        saveNoteButton.Name = "saveNoteButton";
        saveNoteButton.Size = new Size(166, 27);
        saveNoteButton.TabIndex = 4;
        saveNoteButton.Text = "Зберегти";
        saveNoteButton.TextAlign = ContentAlignment.BottomCenter;
        saveNoteButton.UseVisualStyleBackColor = true;
        saveNoteButton.Click += SaveButtonClick;
        // 
        // listNotesButton
        // 
        listNotesButton.Font = new Font("Courier New", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        listNotesButton.Location = new Point(385, 521);
        listNotesButton.Name = "listNotesButton";
        listNotesButton.Size = new Size(166, 27);
        listNotesButton.TabIndex = 5;
        listNotesButton.Text = "Список нотаток";
        listNotesButton.TextAlign = ContentAlignment.BottomCenter;
        listNotesButton.UseVisualStyleBackColor = true;
        listNotesButton.Click += ShowListNotesButtonCkick;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Khaki;
        ClientSize = new Size(713, 558);
        Controls.Add(listNotesButton);
        Controls.Add(saveNoteButton);
        Controls.Add(nameNoteLabel);
        Controls.Add(nameNoteTextBox);
        Controls.Add(noteLabel);
        Controls.Add(textNoteTextBox);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "My Notes";
        ResumeLayout(false);
        PerformLayout();
    }


    #endregion

    private TextBox textNoteTextBox;
    private Label noteLabel;
    private TextBox nameNoteTextBox;
    private Label nameNoteLabel;
    private Button saveNoteButton;
    private Button listNotesButton;
}
