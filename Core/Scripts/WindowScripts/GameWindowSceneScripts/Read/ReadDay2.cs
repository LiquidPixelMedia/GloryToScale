using Godot;
using System;

public partial class ReadDay2 : Node2D
{
	GlobalInfo GlobalInfo { get; set; }
    GlobalAudio GlobalAudio { get; set; }

    bool IsNewsPictureAreaEntered = false;
    [Export] public Sprite2D NewsPictureSpriteHover { get; set; }

	bool IsTextMrKnowledgeAreaEntered = false; 
	bool IsTextMrLawruleAreaEntered = false; 
	bool IsTextArmedToTheTeethAreaEntered = false; 
	bool IsTextSlumsAreaEntered = false;



	public override void _Ready()
    {
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
    }

	public override void _Process(double Delta)
	{
        if (GlobalInfo.CurrentDay == 2 && Visible && GetParent<Node2D>().Visible)
        {
            if (Input.IsActionJustPressed("MouseWheelDown") && Position.Y > -1663)
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

            if (IsNewsPictureAreaEntered && Input.IsActionJustPressed("LeftMouse") && !GlobalInfo.Day2PictureSpriteVisible)
            {
                GlobalInfo.Day2PictureSpriteVisible = true;

                GlobalAudio.ClickSound.Play();
            }

            if (IsTextMrKnowledgeAreaEntered && Input.IsActionJustPressed("LeftMouse") && !GlobalInfo.Day2TextKnowledgeSpriteVisible)
            {
                GlobalInfo.Day2TextKnowledgeSpriteVisible = true;
                GlobalInfo.Day2NumberOfWords += 1;

                GlobalAudio.PencileSound.Play();
            }

            if (IsTextMrLawruleAreaEntered && Input.IsActionJustPressed("LeftMouse") && !GlobalInfo.Day2TextOnlyThanksSpriteVisible)
            {
                GlobalInfo.Day2TextOnlyThanksSpriteVisible = true;
                GlobalInfo.Day2NumberOfWords += 1;

                GlobalAudio.PencileSound.Play();
            }

            if (IsTextArmedToTheTeethAreaEntered && Input.IsActionJustPressed("LeftMouse") && !GlobalInfo.Day2TextDwellersArmedSpriteVisible)
            {
                GlobalInfo.Day2TextDwellersArmedSpriteVisible = true;
                GlobalInfo.Day2NumberOfWords += 1;

                GlobalAudio.PencileSound.Play();
            }

            if (IsTextSlumsAreaEntered && Input.IsActionJustPressed("LeftMouse") && !GlobalInfo.Day2TextOnlyTheDregsSpriteVisible)
            {
                GlobalInfo.Day2TextOnlyTheDregsSpriteVisible = true;
                GlobalInfo.Day2NumberOfWords += 1;

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



    private void MrKnowledgeAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextMrKnowledgeAreaEntered = true;
        }
    }

    private void MrKnowledgeAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextMrKnowledgeAreaEntered = false;
        }
    }



    private void MrLawruleAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextMrLawruleAreaEntered = true;
        }
    }

    private void MrLawruleAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextMrLawruleAreaEntered = false;
        }
    }



    private void ArmedToTheTeethAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextArmedToTheTeethAreaEntered = true;
        }
    }

    private void ArmedToTheTeethAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextArmedToTheTeethAreaEntered = false;
        }
    }



    private void SlumsAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextSlumsAreaEntered = true;
        }
    }

    private void SlumsAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsTextSlumsAreaEntered = false;
        }
    }
}
