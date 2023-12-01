using Godot;
using System;

public partial class WatchDay3 : Node2D
{
    GlobalInfo GlobalInfo { get; set; }
    GlobalAudio GlobalAudio { get; set; }

    [Export] public Sprite2D CloneHover { get; set; }
    [Export] public Sprite2D MustachoHover { get; set; }
    [Export] public Sprite2D PoliticianHover { get; set; }

    bool IsCloneAreaEntered = false;
    bool IsMustachoAreaEntered = false;
    bool IsPoliticianAreaEntered = false;



    public override void _Ready()
    {
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
    }

    public override void _Process(double delta)
	{
        if (GlobalInfo.CurrentDay == 3 && Visible)
        {
            if (GlobalInfo.ImageIsOpened && IsCloneAreaEntered && GetParent<Node2D>().Visible)
            {
                CloneHover.Visible = true;
            }
            else
            {
                CloneHover.Visible = false;
            }

            if (GlobalInfo.ImageIsOpened && IsMustachoAreaEntered)
            {
                MustachoHover.Visible = true;
            }
            else
            {
                MustachoHover.Visible = false;
            }

            if (GlobalInfo.ImageIsOpened && IsPoliticianAreaEntered)
            {
                PoliticianHover.Visible = true;
            }
            else
            {
                PoliticianHover.Visible = false;
            }
        }



        if (GlobalInfo.ImageIsOpened && IsCloneAreaEntered && Visible && Input.IsActionJustPressed("LeftMouse"))
        {
            GlobalInfo.Day3TextMaybeOnlyMustachioedSpriteVisible = true;
            GlobalInfo.Day3NumberOfWords += 1;

            GlobalAudio.PencileSound.Play();
        }

        if (GlobalInfo.ImageIsOpened && IsMustachoAreaEntered && Visible && Input.IsActionJustPressed("LeftMouse"))
        {
            GlobalInfo.Day3TextThisMustacheLooksSpriteVisible = true;
            GlobalInfo.Day3NumberOfWords += 1;

            GlobalAudio.PencileSound.Play();
        }

        if (GlobalInfo.ImageIsOpened && IsPoliticianAreaEntered && Visible && Input.IsActionJustPressed("LeftMouse"))
        {
            GlobalInfo.Day3TextWhatIsAPoliticianSpriteVisible = true;
            GlobalInfo.Day3NumberOfWords += 1;

            GlobalAudio.PencileSound.Play();
        }
    }



    private void CloneAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsCloneAreaEntered = true;
        }
    }

    private void CloneAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsCloneAreaEntered = false;
        }
    }



    private void MustachoAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsMustachoAreaEntered = true;
        }
    }

    private void MustachoAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsMustachoAreaEntered = false;
        }
    }



    private void PoliticianAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsPoliticianAreaEntered = true;
        }
    }

    private void PoliticianAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsPoliticianAreaEntered = false;
        }
    }
}
