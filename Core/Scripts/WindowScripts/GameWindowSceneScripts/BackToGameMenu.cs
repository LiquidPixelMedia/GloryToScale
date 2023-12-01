using Godot;
using System;

public partial class BackToGameMenu : TextureButton
{
    GlobalInfo GlobalInfo { get; set; }
    GlobalAudio GlobalAudio { get; set; }



    [Export] public Node2D ReadScene;
    [Export] public Node2D ListenScene;
    [Export] public Node2D WatchScene;
    [Export] public Node2D WriteScene;

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
    }

    public override void _Process(double Delta)
    {
        if ((ReadScene.Visible ||  ListenScene.Visible || WatchScene.Visible) && !GlobalInfo.IsVideoPlayingNow && !GlobalInfo.ImageIsOpened)
        {
            Visible = true;
        }
        else
        {
            Visible = false;
        }
    }


    public void BackButtonPressed()
	{
        FadeAnimationPlayerScript.FadePlayRevers();

        GlobalAudio.ClickSound.Play();

        if (ReadScene.Visible)
        {
            FadeAnimationPlayer.AnimationFinished += ReadSceneScript;
        }
        else if (ListenScene.Visible)
        {
            FadeAnimationPlayer.AnimationFinished += ListenSceneScript;
        }
        else if (WatchScene.Visible)
        {
            FadeAnimationPlayer.AnimationFinished += WatchSceneScript;
        }
        else if (WriteScene.Visible)
        {
            FadeAnimationPlayer.AnimationFinished += WriteSceneScript;
        }
    }



    private void ReadSceneScript(StringName AnimationName)
    {
        FadeAnimationPlayer.AnimationFinished -= ReadSceneScript;

        ReadScene.Visible = false;

        GlobalInfo.CurrentScene = 0;
    }

    private void ListenSceneScript(StringName AnimationName)
    {
        FadeAnimationPlayer.AnimationFinished -= ListenSceneScript;

        ListenScene.Visible = false;

        GlobalInfo.CurrentScene = 0;
    }

    private void WatchSceneScript(StringName AnimationName)
    {
        FadeAnimationPlayer.AnimationFinished -= WatchSceneScript;

        WatchScene.Visible = false;

        GlobalInfo.CurrentScene = 0;
    }

    private void WriteSceneScript(StringName AnimationName)
    {
        FadeAnimationPlayer.AnimationFinished -= WriteSceneScript;

        WriteScene.Visible = false;

        GlobalInfo.CurrentScene = 0;
    }
}
