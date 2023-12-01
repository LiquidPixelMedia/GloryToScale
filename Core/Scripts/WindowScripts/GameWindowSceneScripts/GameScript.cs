using Godot;
using System;

public partial class GameScript : Node
{
    GlobalInfo GlobalInfo { get; set; }



    [Export] public Area2D MouseArea { get; set; }

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;

    [Export] public TextureRect Day1 { get; set; }
    [Export] public TextureRect Day2 { get; set; }
    [Export] public TextureRect Day3 { get; set; }

    bool IsFirstDay = false;
    bool IsSecondDay = false;
    bool IsThirdDay = false;



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
    }

    public override void _Process(double delta)
    {
        MouseArea.Position = GetViewport().GetMousePosition();

        if (GlobalInfo.CurrentDay == 1 && !IsFirstDay && GlobalInfo.CurrentScene == 0)
        {
            IsFirstDay = true;
            FadeAnimationPlayerScript.DayAnimationPlay();
            Day1.Visible = true;

            FadeAnimationPlayerScript.AnimationFinished += OnFadeAnimationFinished;
        }
        else if (GlobalInfo.CurrentDay == 2 && !IsSecondDay && GlobalInfo.CurrentScene == 0)
        {
            IsSecondDay = true;
            FadeAnimationPlayerScript.DayAnimationPlay();
            Day2.Visible = true;

            FadeAnimationPlayerScript.AnimationFinished += OnFadeAnimationFinished;
        }
        else if (GlobalInfo.CurrentDay == 3 && !IsThirdDay && GlobalInfo.CurrentScene == 0)
        {
            IsThirdDay = true;
            FadeAnimationPlayerScript.DayAnimationPlay();
            Day3.Visible = true;

            FadeAnimationPlayerScript.AnimationFinished += OnFadeAnimationFinished;
        }
    }

    private void OnFadeAnimationFinished(StringName AnimationName)
    {
        FadeAnimationPlayerScript.AnimationFinished -= OnFadeAnimationFinished;

        FadeAnimationPlayerScript.DayAnimationPlayRevers();

        FadeAnimationPlayerScript.AnimationFinished += OnFadeReverseAnimationFinished;
    }

    private void OnFadeReverseAnimationFinished(StringName AnimationName)
    {
        FadeAnimationPlayerScript.AnimationFinished -= OnFadeReverseAnimationFinished;

        FadeAnimationPlayerScript.FadePlay();

        FadeAnimationPlayerScript.AnimationFinished += OnFinished;

        Day1.Visible = false;
        Day2.Visible = false;
        Day3.Visible = false;
    }

    private void OnFinished(StringName AnimationName)
    {
        FadeAnimationPlayerScript.AnimationFinished -= OnFinished;
    }
}
