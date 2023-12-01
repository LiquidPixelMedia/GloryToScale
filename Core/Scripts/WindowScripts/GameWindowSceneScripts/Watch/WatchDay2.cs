using Godot;
using System;

public partial class WatchDay2 : Node2D
{
    GlobalInfo GlobalInfo { get; set; }
    GlobalAudio GlobalAudio { get; set; }

    [Export] public Sprite2D PosterGloryHover { get; set; }
    [Export] public Sprite2D ForkHover { get; set; }
    [Export] public Sprite2D FaceHover { get; set; }
    [Export] public Sprite2D BloomHover { get; set; }

    bool IsPosterGloryAreaEntered = false;
    bool IsForkAreaEntered = false;
    bool IsFaceAreaEntered = false;
    bool IsBloomAreaEntered = false;



    public override void _Ready()
    {
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
    }

    public override void _Process(double delta)
	{
        if (GlobalInfo.CurrentDay == 2 && Visible && GetParent<Node2D>().Visible)
        {
            if (GlobalInfo.ImageIsOpened && IsPosterGloryAreaEntered)
            {
                PosterGloryHover.Visible = true;
            }
            else
            {
                PosterGloryHover.Visible = false;
            }

            if (GlobalInfo.ImageIsOpened && IsForkAreaEntered)
            {
                ForkHover.Visible = true;
            }
            else
            {
                ForkHover.Visible = false;
            }

            if (GlobalInfo.ImageIsOpened && IsFaceAreaEntered)
            {
                FaceHover.Visible = true;
            }
            else
            {
                FaceHover.Visible = false;
            }

            if (GlobalInfo.ImageIsOpened && IsBloomAreaEntered)
            {
                BloomHover.Visible = true;
            }
            else
            {
                BloomHover.Visible = false;
            }
        }



        if (GlobalInfo.ImageIsOpened && IsPosterGloryAreaEntered && !GlobalInfo.Day2TextInTheHandsOfPeopleSpriteVisible && Input.IsActionJustPressed("LeftMouse"))
        {
            GlobalInfo.Day2TextInTheHandsOfPeopleSpriteVisible = true;
            GlobalInfo.Day2NumberOfWords += 1;

            GlobalAudio.PencileSound.Play();
        }

        if (GlobalInfo.ImageIsOpened && IsForkAreaEntered && !GlobalInfo.Day2TextPitchforksSptiteVisible && Input.IsActionJustPressed("LeftMouse"))
        {
            GlobalInfo.Day2TextPitchforksSptiteVisible = true;
            GlobalInfo.Day2NumberOfWords += 1;

            GlobalAudio.PencileSound.Play();
        }

        if (GlobalInfo.ImageIsOpened && IsFaceAreaEntered && !GlobalInfo.Day2TextTheProtestersSpriteVisible && Input.IsActionJustPressed("LeftMouse"))
        {
            GlobalInfo.Day2TextTheProtestersSpriteVisible = true;
            GlobalInfo.Day2NumberOfWords += 1;

            GlobalAudio.PencileSound.Play();
        }

        if (GlobalInfo.ImageIsOpened && IsBloomAreaEntered && !GlobalInfo.Day2TextPeopleHaveSptiteVisible && Input.IsActionJustPressed("LeftMouse"))
        {
            GlobalInfo.Day2TextPeopleHaveSptiteVisible = true;
            GlobalInfo.Day2NumberOfWords += 1;

            GlobalAudio.PencileSound.Play();
        }
    }



    private void PosterGloryAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsPosterGloryAreaEntered = true;
        }
    }

    private void PosterGloryAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsPosterGloryAreaEntered = false;
        }
    }



    private void ForkAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsForkAreaEntered = true;
        }
    }

    private void ForkAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsForkAreaEntered = false;
        }
    }



    private void FaceAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsFaceAreaEntered = true;
        }
    }

    private void FaceAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsFaceAreaEntered = false;
        }
    }



    private void BloomAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsBloomAreaEntered = true;
        }
    }

    private void BloomAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsBloomAreaEntered = false;
        }
    }
}
