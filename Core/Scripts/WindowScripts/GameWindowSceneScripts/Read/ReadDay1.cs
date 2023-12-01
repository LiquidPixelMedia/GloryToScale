using Godot;
using System;

public partial class ReadDay1 : Node2D
{
    GlobalInfo GlobalInfo { get; set; }
    GlobalAudio GlobalAudio { get; set; }

    bool IsNewsPictureAreaEntered = false;
    [Export] public Sprite2D NewsPictureSpriteHover { get; set; }

    bool IsTextPriceAreaEntered = false;
    bool IsTextSalesmoreAreaEntered = false;
    bool IsTextDistributiusAreaEntered = false;
    bool IsTextHungryAreaEntered = false;



    public override void _Ready()
    {
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
    }



    public override void _Process(double Delta)
    {
        if (GlobalInfo.CurrentDay == 1 && Visible && GetParent<Node2D>().Visible)
        {
            if (Input.IsActionJustPressed("MouseWheelDown") && Position.Y > -1421)
            {
                Position = new Vector2(Position.X, (float)(Position.Y - 1 * 20000 * Delta));
            }

            if (Input.IsActionJustPressed("MouseWheelUp") && Position.Y < 0)
            {
                Position = new Vector2(Position.X, (float)(Position.Y + 1 * 20000 * Delta));
            }



            if (IsNewsPictureAreaEntered)
            {
                NewsPictureSpriteHover.Visible = true;
            }
            else
            {
                NewsPictureSpriteHover.Visible = false;
            }

            if (IsNewsPictureAreaEntered && Input.IsActionJustPressed("LeftMouse") && !GlobalInfo.Day1PictureSpriteVisible)
            {
                GlobalInfo.Day1PictureSpriteVisible = true;

                GlobalAudio.ClickSound.Play();
            }

            if (IsTextPriceAreaEntered && Input.IsActionJustPressed("LeftMouse") && !GlobalInfo.Day1TextInOutCountrySpriteVisible)
            {
                GlobalInfo.Day1TextInOutCountrySpriteVisible = true;
                GlobalInfo.Day1NumberOfWords += 1;

                GlobalAudio.PencileSound.Play();
            }

            if (IsTextSalesmoreAreaEntered && Input.IsActionJustPressed("LeftMouse") && !GlobalInfo.Day1TextSalesmoreSpriteVisible)
            {
                GlobalInfo.Day1TextSalesmoreSpriteVisible = true;
                GlobalInfo.Day1NumberOfWords += 1;

                GlobalAudio.PencileSound.Play();
            }

            if (IsTextDistributiusAreaEntered && Input.IsActionJustPressed("LeftMouse") && !GlobalInfo.Day1TextEveryoneSpriteVisible)
            {
                GlobalInfo.Day1TextEveryoneSpriteVisible = true;
                GlobalInfo.Day1NumberOfWords += 1;

                GlobalAudio.PencileSound.Play();
            }

            if (IsTextHungryAreaEntered && Input.IsActionJustPressed("LeftMouse") && !GlobalInfo.Day1TextNoOneSpriteVisible)
            {
                GlobalInfo.Day1TextNoOneSpriteVisible = true;
                GlobalInfo.Day1NumberOfWords += 1;

                GlobalAudio.PencileSound.Play();
            }
        }
    }



    private void PictureAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsNewsPictureAreaEntered = true;
        }
    }

    private void PictureAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsNewsPictureAreaEntered = false;
        }
    }



    private void PriceAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextPriceAreaEntered = true;
        }
    }

    private void PriceAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextPriceAreaEntered = false;
        }
    }



    private void SalesmoreAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextSalesmoreAreaEntered = true;
        }
    }

    private void SalesmoreAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextSalesmoreAreaEntered = false;
        }
    }



    private void DistributiusAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextDistributiusAreaEntered = true;
        }
    }

    private void DistributiusAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextDistributiusAreaEntered = false;
        }
    }



    private void HungryAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextHungryAreaEntered = true;
        }
    }

    private void HungryAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextHungryAreaEntered = false;
        }
    }
}
