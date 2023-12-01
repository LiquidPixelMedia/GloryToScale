using Godot;
using System;

public partial class FadeControlScript : AnimationPlayer
{
    [Export] public ColorRect FadeColor;



    public override void _Ready()
    {
        FadeColor.Visible = true;
        FadePlay();
        AnimationFinished += (StringName AnimationName) => FadeColor.Visible = false;
    }



    public void DayAnimationPlay()
    {
        FadeColor.Visible = true;
        Play("DayAnimation");
    }

    public void DayAnimationPlayRevers()
    {
        FadeColor.Visible = true;
        PlayBackwards("DayAnimation");
    }

    public void FadePlay()
    {
        FadeColor.Visible = true;
        Play("MainMenuAnimation");
    }

    public void FadePlayRevers()
    {
        FadeColor.Visible = true;
        PlayBackwards("MainMenuAnimation");
    }
}
