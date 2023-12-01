using Godot;
using System;

public partial class ReadButtonScript : Button
{
    GlobalInfo GlobalInfo { get; set; }
    GlobalAudio GlobalAudio { get; set; }

    [Export] public TextureRect ReadButtonNormal;
    [Export] public TextureRect ReadButtonHover;

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;



    public Node2D ReadScene;



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
        ReadScene = GetNode<Node2D>("/root/GameWindowScene/GameLayer/Read");

        ReadButtonNormal.Visible = true;
    }



    public void ReadButtonPressed()
    {
        FadeAnimationPlayerScript.FadePlayRevers();

        if (GlobalInfo.CurrentDay == 1)
        {
            GlobalInfo.Day1IsWasOnReadScreen = true;
        }
        else if (GlobalInfo.CurrentDay == 2)
        {
            GlobalInfo.Day2IsWasOnReadScreen = true;
        }
        else if (GlobalInfo.CurrentDay == 3)
        {
            GlobalInfo.Day3IsWasOnReadScreen = true;
        }

        FadeAnimationPlayer.AnimationFinished += ReadSceneScript;

        GlobalInfo.CurrentScene = 2;
    }

    public void ReadButtonMouseEntered()
    {
        ReadButtonNormal.Visible = false;
        ReadButtonHover.Visible = true;

        GlobalAudio.MonitorSound.Play();
    }

    public void ReadButtonMouseExited()
    {
        ReadButtonNormal.Visible = true;
        ReadButtonHover.Visible = false;

        GlobalAudio.MonitorSound.Stop();
    }



    private void ReadSceneScript(StringName AnimationName)
    {
        FadeAnimationPlayer.AnimationFinished -= ReadSceneScript;
        ReadScene.Visible = true;
    }
}
