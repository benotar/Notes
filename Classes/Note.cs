﻿namespace HW_UsersControls.Classes;

public class Note
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public string Text { get; set; } = string.Empty;

    public DateTime CreateTime { get; set; }
}
