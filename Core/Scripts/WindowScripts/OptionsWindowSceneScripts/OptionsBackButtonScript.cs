using Godot;
using System;

public partial class OptionsBackButtonScript : Button
{
    GlobalAudio GlobalAudio { get; set; }

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
    }



    public void BackToMenuButtonPressed()
	{
        FadeAnimationPlayerScript.FadePlayRevers();

        GlobalAudio.ClickSound.Play();

        FadeAnimationPlayerScript.AnimationFinished += ChangeSceneToMainMenu;

    }



    private void ChangeSceneToMainMenu(StringName AnimationName)
    {
        FadeAnimationPlayerScript.AnimationFinished -= ChangeSceneToMainMenu;

        GetTree().ChangeSceneToFile("res://Core/Scenes/WindowScenes/MainMenuWindowScene/MainMenuWindowScene.tscn");
    }
}
