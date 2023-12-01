using Godot;
using System;

public partial class WatchDay1 : Node2D
{
    GlobalInfo GlobalInfo { get; set; }
    GlobalAudio GlobalAudio { get; set; }

    [Export] public Sprite2D BoyHover { get; set; }
    [Export] public Sprite2D GirlHover { get; set; }
    [Export] public Sprite2D CarHover { get; set; }
    [Export] public Sprite2D PosterHover { get; set; }

    bool IsBoyAreaEntered = false;
    bool IsGirlAreaEntered = false;
    bool IsCarAreaEntered = false;
    bool IsPosterAreaEntered = false;



    public override void _Ready()
    {
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
    }

    public override void _Process(double Delta)
    {
        if (GlobalInfo.CurrentDay == 1 && Visible && GetParent<Node2D>().Visible)
        {
            if (GlobalInfo.ImageIsOpened && IsBoyAreaEntered)
            {
                BoyHover.Visible = true;
            }
            else
            {
                BoyHover.Visible = false;
            }

            if (GlobalInfo.ImageIsOpened && IsGirlAreaEntered)
            {
                GirlHover.Visible = true;
            }
            else
            {
                GirlHover.Visible = false;
            }

            if (GlobalInfo.ImageIsOpened && IsCarAreaEntered)
            {
                CarHover.Visible = true;
            }
            else
            {
                CarHover.Visible = false;
            }

            if (GlobalInfo.ImageIsOpened && IsPosterAreaEntered)
            {
                PosterHover.Visible = true;
            }
            else
            {
                PosterHover.Visible = false;
            }



            if (GlobalInfo.ImageIsOpened && IsBoyAreaEntered && !GlobalInfo.Day1TextChildrenSpriteVisible && Input.IsActionJustPressed("LeftMouse"))
            {
                GlobalInfo.Day1TextChildrenSpriteVisible = true;
                GlobalInfo.Day1NumberOfWords += 1;

                GlobalAudio.PencileSound.Play();
            }

            if (GlobalInfo.ImageIsOpened && IsGirlAreaEntered && !GlobalInfo.Day1TextNotHungrySpriteVisible && Input.IsActionJustPressed("LeftMouse"))
            {
                GlobalInfo.Day1TextNotHungrySpriteVisible = true;
                GlobalInfo.Day1NumberOfWords += 1;

                GlobalAudio.PencileSound.Play();
            }

            if (GlobalInfo.ImageIsOpened && IsCarAreaEntered && !GlobalInfo.Day1TextToysSpriteVisible && Input.IsActionJustPressed("LeftMouse"))
            {
                GlobalInfo.Day1TextToysSpriteVisible = true;
                GlobalInfo.Day1NumberOfWords += 1;

                GlobalAudio.PencileSound.Play();
            }

            if (GlobalInfo.ImageIsOpened && IsPosterAreaEntered && !GlobalInfo.Day1TextDidYouKnowSpriteVisible && Input.IsActionJustPressed("LeftMouse"))
            {
                GlobalInfo.Day1TextDidYouKnowSpriteVisible = true;
                GlobalInfo.Day1NumberOfWords += 1;

                GlobalAudio.PencileSound.Play();
            }
        }
    }



    private void BoyAreaAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsBoyAreaEntered = true;
        }
    }

    private void BoyAreaAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsBoyAreaEntered = false;
        }
    }



    private void GirlAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsGirlAreaEntered = true;
        }
    }

    private void GirlAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsGirlAreaEntered = false;
        }
    }



    private void CarAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsCarAreaEntered = true;
        }
    }

    private void CarAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsCarAreaEntered = false;
        }
    }



    private void PosterAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsPosterAreaEntered = true;
        }
    }

    private void PosterAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsPosterAreaEntered = false;
        }
    }
}
