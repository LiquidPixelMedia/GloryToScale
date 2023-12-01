using Godot;
using System;

public partial class NotesScript : Node2D
{
    GlobalInfo GlobalInfo { get; set; }

    bool IsNotesOpened = false;
    bool IsNotesEntered = false;

    [Export] public Node2D Watch { get; set; }
    [Export] public Node2D Read { get; set; }
    [Export] public Node2D Listen { get; set; }
    [Export] public Node2D Write { get; set; }

    [Export] public Node2D Day1 { get; set; }
    [Export] public Node2D Day2 { get; set; }
    [Export] public Node2D Day3 { get; set; }

    [Export] public AnimationPlayer NotesAnimationPlayer { get; set; }



    public override void _Ready()
    {
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");

        NotesAnimationPlayer.PlayBackwards("OpenCloseNotes");
    }

    public override void _Process(double Delta)
    {
        if (GlobalInfo.CurrentDay == 1)
        {
            Day1.Visible = true;
            Day2.Visible = false;
            Day3.Visible = false;
        }
        else if (GlobalInfo.CurrentDay == 2)
        {
            Day1.Visible = false;
            Day2.Visible = true;
            Day1.Visible = false;
        }
        else if (GlobalInfo.CurrentDay == 3)
        {
            Day1.Visible = false;
            Day2.Visible = false;
            Day3.Visible = true;
        }



        if (IsNotesEntered && !IsNotesOpened && Input.IsActionJustPressed("LeftMouse"))
        {
            IsNotesOpened = true;

            NotesAnimationPlayer.Play("OpenCloseNotes");
        }
        else if (IsNotesEntered && IsNotesOpened && Input.IsActionJustPressed("LeftMouse"))
        {
            IsNotesOpened = false;

            NotesAnimationPlayer.PlayBackwards("OpenCloseNotes");
        }

        if (Watch.Visible || Read.Visible)
        {
            Visible = true;
        }
        else
        {
            Visible = false;
        }
    }



    private void NotesOpenCloseAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsNotesEntered = true;
        }
    }

    private void NotesOpenCloseAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsNotesEntered = false;
        }
    }
}
