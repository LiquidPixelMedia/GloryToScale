using Godot;
using System;

public partial class EndGameWindowSceneScript : Control
{
    GlobalInfo GlobalInfo { get; set; }

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;

    [Export] public VideoStreamPlayer YesVideo { get; set; }
    [Export] public VideoStreamPlayer NoVideo { get; set; }


    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");

        FadeAnimationPlayerScript.FadePlay();

        if (GlobalInfo.FinalSelection >= 2)
        {
            NoVideo.Visible = true;
            NoVideo.Play();
        }
        else
        {
            YesVideo.Visible = true;
            YesVideo.Play();
        }
    }

    public void OnFinished()
    {
        FadeAnimationPlayerScript.FadePlayRevers();

        FadeAnimationPlayerScript.AnimationFinished += AfterFinished;
    }

    private void AfterFinished(StringName AnimationName)
    {
        FadeAnimationPlayerScript.AnimationFinished -= AfterFinished;

        GetTree().ChangeSceneToFile("res://Core/Scenes/WindowScenes/MainMenuWindowScene/MainMenuWindowScene.tscn");
    }
}
