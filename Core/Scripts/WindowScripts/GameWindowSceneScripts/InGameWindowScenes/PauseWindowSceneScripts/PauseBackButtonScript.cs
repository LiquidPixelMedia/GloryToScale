using Godot;
using System;

public partial class PauseBackButtonScript : Button
{
    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
    }



    public void BackToMenuButtonPressed()
	{
        FadeAnimationPlayerScript.FadePlayRevers();

        FadeAnimationPlayerScript.AnimationFinished += ChangeSceneToMainMenu;

    }



    private void ChangeSceneToMainMenu(StringName AnimationName)
    {
        FadeAnimationPlayerScript.AnimationFinished -= ChangeSceneToMainMenu;

        GetTree().ChangeSceneToFile("res://Core/Scenes/WindowScenes/MainMenuWindowScene/MainMenuWindowScene.tscn");
    }
}
