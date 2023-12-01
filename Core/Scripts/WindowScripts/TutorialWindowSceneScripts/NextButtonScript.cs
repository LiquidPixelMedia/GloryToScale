using Godot;
using System;

public partial class NextButtonScript : TextureButton
{
    GlobalAudio GlobalAudio { get; set; }



    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
        
        VisibilityChanged += FadeOnReady;
    }



	public void NextButtonPressed()
	{
		FadeAnimationPlayerScript.FadePlayRevers();

        GlobalAudio.ClickSound.Play();

        FadeAnimationPlayer.AnimationFinished += ChangeToGameWindowScene;
	}



	private void ChangeToGameWindowScene(StringName AnimationName)
    {
        FadeAnimationPlayer.AnimationFinished -= ChangeToGameWindowScene;

        GetTree().ChangeSceneToFile("res://Core/Scenes/WindowScenes/GameWindowScene/GameWindowScene.tscn");
    }

	private void FadeOnReady()
    {
        VisibilityChanged -= FadeOnReady;
		FadeAnimationPlayerScript.FadePlay();
    }
}
