using Godot;
using System;

public partial class WatchScript : Node2D
{
    GlobalInfo GlobalInfo { get; set; }


    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;


    [Export] public Sprite2D PictureNotFound { get; set; }


    bool IsUpLeftAreaEntered = false;
    bool IsUpRightAreaEntered = false;
    bool IsDownLeftAreaEntered = false;
    bool IsDownRightAreaEntered = false;

    [Export] public Sprite2D UpLeftHover { get; set; }
    [Export] public Sprite2D UpRightHover { get; set; }
    [Export] public Sprite2D DownLeftHover { get; set; }
    [Export] public Sprite2D DownRightHover { get; set; }

    [Export] public Node2D Day1 { get; set; }
    [Export] public Node2D Day2 { get; set; }
    [Export] public Node2D Day3 { get; set; }

    [Export] public Sprite2D Day1Background { get; set; }
    [Export] public Sprite2D Day2Background { get; set; }
    [Export] public Sprite2D Day3Background { get; set; }



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");

        VisibilityChanged += OnVisibilityChange;
    }



    public override void _Process(double Delta)
    {
        if (Visible)
        {
            if (GlobalInfo.CurrentDay == 1)
            {
                if (GlobalInfo.Day1PictureSpriteVisible)
                {
                    PictureNotFound.Visible = false;

                    Day1.Visible = true;
                    Day2.Visible = false;
                    Day3.Visible = false;
                }
                else
                {
                    PictureNotFound.Visible = true;

                    Day1.Visible = false;
                    Day2.Visible = false;
                    Day3.Visible = false;
                }
            }
            else if (GlobalInfo.CurrentDay == 2)
            {
                if (GlobalInfo.Day2PictureSpriteVisible)
                {
                    PictureNotFound.Visible = false;

                    Day1.Visible = false;
                    Day2.Visible = true;
                    Day1.Visible = false;
                }
                else
                {
                    PictureNotFound.Visible = true;

                    Day1.Visible = false;
                    Day2.Visible = false;
                    Day3.Visible = false;
                }
            }
            else if (GlobalInfo.CurrentDay == 3)
            {
                if (GlobalInfo.Day3PictureSpriteVisible)
                {
                    PictureNotFound.Visible = false;

                    Day1.Visible = false;
                    Day2.Visible = false;
                    Day3.Visible = true;
                }
                else
                {
                    PictureNotFound.Visible = true;

                    Day1.Visible = false;
                    Day2.Visible = false;
                    Day3.Visible = false;
                }
            }



            if (!GlobalInfo.ImageIsOpened && IsUpLeftAreaEntered)
            {
                UpLeftHover.Visible = true;
            }
            else
            {
                UpLeftHover.Visible = false;
            }

            if (!GlobalInfo.ImageIsOpened && IsUpRightAreaEntered)
            {
                UpRightHover.Visible = true;
            }
            else
            {
                UpRightHover.Visible = false;
            }

            if (!GlobalInfo.ImageIsOpened && IsDownLeftAreaEntered)
            {
                DownLeftHover.Visible = true;
            }
            else
            {
                DownLeftHover.Visible = false;
            }

            if (!GlobalInfo.ImageIsOpened && IsDownRightAreaEntered)
            {
                DownRightHover.Visible = true;
            }
            else
            {
                DownRightHover.Visible = false;
            }



            if (!GlobalInfo.ImageIsOpened && IsUpLeftAreaEntered && Input.IsActionJustPressed("RightMouse"))
            {
                switch (GlobalInfo.CurrentDay)
                {
                    case 1:
                        Day1Background.Position = new Vector2(226f, 156f);
                        Day1Background.Scale = new Vector2(Day1Background.Scale.X * 1.9f, Day1Background.Scale.Y * 1.9f);
                        break;

                    case 2:
                        Day2Background.Position = new Vector2(226f, 156f);
                        Day2Background.Scale = new Vector2(Day2Background.Scale.X * 1.9f, Day2Background.Scale.Y * 1.9f);
                        break;

                    case 3:
                        Day3Background.Position = new Vector2(226f, 156f);
                        Day3Background.Scale = new Vector2(Day2Background.Scale.X * 1.9f, Day3Background.Scale.Y * 1.9f);
                        break;
                }

                GlobalInfo.ImageIsOpened = true;
            }
            else if (!GlobalInfo.ImageIsOpened && IsUpRightAreaEntered && Input.IsActionJustPressed("RightMouse"))
            {
                switch (GlobalInfo.CurrentDay)
                {
                    case 1:
                        Day1Background.Position = new Vector2(-1096f, 156f);
                        Day1Background.Scale = new Vector2(Day1Background.Scale.X * 1.9f, Day1Background.Scale.Y * 1.9f);
                        break;

                    case 2:
                        Day2Background.Position = new Vector2(-1096f, 156f);
                        Day2Background.Scale = new Vector2(Day2Background.Scale.X * 1.9f, Day2Background.Scale.Y * 1.9f);
                        break;

                    case 3:
                        Day3Background.Position = new Vector2(-1096f, 156f);
                        Day3Background.Scale = new Vector2(Day3Background.Scale.X * 1.9f, Day3Background.Scale.Y * 1.9f);
                        break;
                }

                GlobalInfo.ImageIsOpened = true;
            }
            else if (!GlobalInfo.ImageIsOpened && IsDownLeftAreaEntered && Input.IsActionJustPressed("RightMouse"))
            {
                switch (GlobalInfo.CurrentDay)
                {
                    case 1:
                        Day1Background.Position = new Vector2(226f, -538f);
                        Day1Background.Scale = new Vector2(Day1Background.Scale.X * 1.9f, Day1Background.Scale.Y * 1.9f);
                        break;

                    case 2:
                        Day2Background.Position = new Vector2(226f, -538f);
                        Day2Background.Scale = new Vector2(Day2Background.Scale.X * 1.9f, Day2Background.Scale.Y * 1.9f);
                        break;

                    case 3:
                        Day3Background.Position = new Vector2(226f, -538f);
                        Day3Background.Scale = new Vector2(Day3Background.Scale.X * 1.9f, Day3Background.Scale.Y * 1.9f);
                        break;
                }

                GlobalInfo.ImageIsOpened = true;
            }
            else if (!GlobalInfo.ImageIsOpened && IsDownRightAreaEntered && Input.IsActionJustPressed("RightMouse"))
            {
                switch (GlobalInfo.CurrentDay)
                {
                    case 1:
                        Day1Background.Position = new Vector2(-1096f, -538f);
                        Day1Background.Scale = new Vector2(Day1Background.Scale.X * 1.9f, Day1Background.Scale.Y * 1.9f);
                        break;

                    case 2:
                        Day2Background.Position = new Vector2(-1096f, -538f);
                        Day2Background.Scale = new Vector2(Day2Background.Scale.X * 1.9f, Day2Background.Scale.Y * 1.9f);
                        break;

                    case 3:
                        Day3Background.Position = new Vector2(-1096f, -538f);
                        Day3Background.Scale = new Vector2(Day3Background.Scale.X * 1.9f, Day3Background.Scale.Y * 1.9f);
                        break;
                }

                GlobalInfo.ImageIsOpened = true;
            }
            else if (GlobalInfo.ImageIsOpened && Input.IsActionJustPressed("RightMouse"))
            {
                switch (GlobalInfo.CurrentDay)
                {
                    case 1:
                        Day1Background.Position = new Vector2(226f, 156f);
                        Day1Background.Scale = new Vector2(0.765f, 0.713f);
                        break;

                    case 2:
                        Day2Background.Position = new Vector2(226f, 156f);
                        Day2Background.Scale = new Vector2(0.765f, 0.713f);
                        break;

                    case 3:
                        Day3Background.Position = new Vector2(226f, 156f);
                        Day3Background.Scale = new Vector2(0.765f, 0.713f);
                        break;
                }

                GlobalInfo.ImageIsOpened = false;
            }
        }
    }



    private void UpLeftAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsUpLeftAreaEntered = true;
        }
    }

    private void UpLeftAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsUpLeftAreaEntered = false;
        }
    }



    private void UpRightAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsUpRightAreaEntered = true;
        }
    }

    private void UpRightAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsUpRightAreaEntered = false;
        }
    }



    private void DownLeftAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsDownLeftAreaEntered = true;
        }
    }

    private void DownLeftAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsDownLeftAreaEntered = false;
        }
    }



    private void DownRightAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsDownRightAreaEntered = true;
        }
    }

    private void DownRightAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsDownRightAreaEntered = false;
        }
    }



    private void OnVisibilityChange()
    {
        if (Visible == true)
        {
            FadeAnimationPlayerScript.FadePlay();
        }
    }
}
