using Godot;
using System;

public partial class StartCutSceneWindowSceneScript : VideoStreamPlayer
{
    GlobalInfo GlobalInfo { get; set; }

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");

        FadeAnimationPlayerScript.FadePlay();
    }



    public void StartCutSceneVideoPlayerScript()
	{
        FadeAnimationPlayerScript.FadePlayRevers();
        FadeAnimationPlayerScript.AnimationFinished += OnFadeAnimationPlayerFinished;
    }



    private void OnFadeAnimationPlayerFinished(StringName AnimationName)
    {
        FadeAnimationPlayerScript.AnimationFinished -= OnFadeAnimationPlayerFinished;

        GetTree().ChangeSceneToFile("res://Core/Scenes/WindowScenes/TutorialWindowScene/TutorialWindowScene.tscn");
    }
}
