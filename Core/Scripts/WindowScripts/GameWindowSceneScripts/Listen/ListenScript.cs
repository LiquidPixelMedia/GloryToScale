using Godot;
using System;

public partial class ListenScript : Node2D
{
    GlobalInfo GlobalInfo { get; set; }

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;

    [Export] public Node2D Day1 { get; set; }
    [Export] public Node2D Day2 { get; set; }
    [Export] public Node2D Day3 { get; set; }

    [Export] public Sprite2D RecordNotFound { get; set; }



    public override void _Ready()
	{
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");

        VisibilityChanged += OnVisibilityChange;
    }



	public override void _Process(double Delta)
	{
        if (GlobalInfo.CurrentDay == 1)
        {
            if (GlobalInfo.Day1PictureSpriteVisible && GlobalInfo.Day1IsWasOnWatchScreen)
            {
                RecordNotFound.Visible = false;

                Day1.Visible = true;
                Day2.Visible = false;
                Day3.Visible = false;
            }
            else
            {
                RecordNotFound.Visible = true;

                Day1.Visible = false;
                Day2.Visible = false;
                Day3.Visible = false;
            }
        }
        else if (GlobalInfo.CurrentDay == 2)
        {
            if (GlobalInfo.Day2PictureSpriteVisible && GlobalInfo.Day2IsWasOnWatchScreen)
            {
                RecordNotFound.Visible = false;

                Day1.Visible = false;
                Day2.Visible = true;
                Day3.Visible = false;
            }
            else
            {
                RecordNotFound.Visible = true;

                Day1.Visible = false;
                Day2.Visible = false;
                Day3.Visible = false;
            }
        }
        else if (GlobalInfo.CurrentDay == 3)
        {
            if (GlobalInfo.Day3PictureSpriteVisible && GlobalInfo.Day3IsWasOnWatchScreen)
            {
                RecordNotFound.Visible = false;

                Day1.Visible = false;
                Day2.Visible = false;
                Day3.Visible = true;
            }
            else
            {
                RecordNotFound.Visible = true;

                Day1.Visible = false;
                Day2.Visible = false;
                Day3.Visible = false;
            }
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
