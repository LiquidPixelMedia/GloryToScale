using Godot;
using System;

public partial class WatchButtonScript : Button
{
    GlobalInfo GlobalInfo { get; set; }
    GlobalAudio GlobalAudio { get; set; }

    [Export] public TextureRect WatchButtonNormal;
    [Export] public TextureRect WatchButtonHover;

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;



    public Node2D WatchScene;



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
        WatchScene = GetNode<Node2D>("/root/GameWindowScene/GameLayer/Watch");

        WatchButtonNormal.Visible = true;
    }



    public void WatchButtonPressed()
    {
        FadeAnimationPlayerScript.FadePlayRevers();

        if (GlobalInfo.CurrentDay == 1 && GlobalInfo.Day1PictureSpriteVisible)
        {
            GlobalInfo.Day1IsWasOnWatchScreen = true;
        }
        else if (GlobalInfo.CurrentDay == 2 && GlobalInfo.Day2PictureSpriteVisible)
        {
            GlobalInfo.Day2IsWasOnWatchScreen = true;
        }
        else if (GlobalInfo.CurrentDay == 3 && GlobalInfo.Day3PictureSpriteVisible)
        {
            GlobalInfo.Day3IsWasOnWatchScreen = true;
        }

        FadeAnimationPlayer.AnimationFinished += WatchSceneScript;

        GlobalInfo.CurrentScene = 1;
    }

    public void WatchButtonMouseEntered()
    {
        WatchButtonNormal.Visible = false;
        WatchButtonHover.Visible = true;

        GlobalAudio.MonitorSound.Play();
    }

    public void WatchButtonMouseExited()
    {
        WatchButtonNormal.Visible = true;
        WatchButtonHover.Visible = false;

        GlobalAudio.MonitorSound.Stop();
    }



    private void WatchSceneScript(StringName AnimationName)
    {
        FadeAnimationPlayer.AnimationFinished -= WatchSceneScript;

        WatchScene.Visible = true;
    }
}
