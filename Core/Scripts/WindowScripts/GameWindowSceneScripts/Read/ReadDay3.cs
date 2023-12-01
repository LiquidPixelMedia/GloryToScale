using Godot;
using System;

public partial class ReadDay3 : Node2D
{
	GlobalInfo GlobalInfo { get; set; }
    GlobalAudio GlobalAudio { get; set; }

    bool IsNewsPictureAreaEntered = false;
    [Export] public Sprite2D NewsPictureSpriteHover { get; set; }

	bool IsTextSentencesAreaEntered = false; 
	bool IsTextMrMustacheousAreaEntered = false; 
	bool IsTextMrOverseerAreaEntered = false;
	bool IsTextMinistryAreaEntered = false;
	bool IsTextMrBloodhoundAreaEntered = false;



	public override void _Ready()
    {
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
    }

	public override void _Process(double Delta)
	{
        if (GlobalInfo.CurrentDay == 3 && Visible && GetParent<Node2D>().Visible)
        {
            if (Input.IsActionJustPressed("MouseWheelDown") && Position.Y > -1831)
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

            if (IsNewsPictureAreaEntered && Input.IsActionJustPressed("LeftMouse") && !GlobalInfo.Day3PictureSpriteVisible)
            {
                GlobalInfo.Day3PictureSpriteVisible = true;

                GlobalAudio.ClickSound.Play();
            }

            if (IsTextSentencesAreaEntered && Input.IsActionJustPressed("LeftMouse") && !GlobalInfo.Day3TextAndWhyDoSpriteVisible)
            {
                GlobalInfo.Day3TextAndWhyDoSpriteVisible = true;
                GlobalInfo.Day3NumberOfWords += 1;

                GlobalAudio.PencileSound.Play();
            }

            if (IsTextMrMustacheousAreaEntered && Input.IsActionJustPressed("LeftMouse") && !GlobalInfo.Day3TextWhatAReliefSpriteVisible)
            {
                GlobalInfo.Day3TextWhatAReliefSpriteVisible = true;
                GlobalInfo.Day3NumberOfWords += 1;

                GlobalAudio.PencileSound.Play();
            }

            if (IsTextMrOverseerAreaEntered && Input.IsActionJustPressed("LeftMouse") && !GlobalInfo.Day3TextThanksToMrOverseerSpriteVisible)
            {
                GlobalInfo.Day3TextThanksToMrOverseerSpriteVisible = true;
                GlobalInfo.Day3NumberOfWords += 1;

                GlobalAudio.PencileSound.Play();
            }

            if (IsTextMinistryAreaEntered && Input.IsActionJustPressed("LeftMouse") && !GlobalInfo.Day3TextWhoIsBeingSpriteVisible)
            {
                GlobalInfo.Day3TextWhoIsBeingSpriteVisible = true;
                GlobalInfo.Day3NumberOfWords += 1;

                GlobalAudio.PencileSound.Play();
            }

            if (IsTextMrBloodhoundAreaEntered && Input.IsActionJustPressed("LeftMouse") && !GlobalInfo.Day3TextLooksLikeMrBloodhoundSpriteVisible)
            {
                GlobalInfo.Day3TextLooksLikeMrBloodhoundSpriteVisible = true;
                GlobalInfo.Day3NumberOfWords += 1;

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


	private void SentencesAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextSentencesAreaEntered = true;
        }
    }


    private void SentencesAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextSentencesAreaEntered = false;
        }
    }



    private void MrMustacheousAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextMrMustacheousAreaEntered = true;
        }
    }

    private void MrMustacheousAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextMrMustacheousAreaEntered = false;
        }
    }



    private void MrOverseerAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextMrOverseerAreaEntered = true;
        }
    }

    private void MrOverseerAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextMrOverseerAreaEntered = false;
        }
    }



    private void MinistryAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextMinistryAreaEntered = true;
        }
    }

    private void MinistryAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextMinistryAreaEntered = false;
        }
    }



	    private void MrBloodhoundAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextMrBloodhoundAreaEntered = true;
        }
    }

    private void MrBloodhoundAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextMrBloodhoundAreaEntered = false;
        }
    }
}
