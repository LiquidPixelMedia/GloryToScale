using Godot;
using System;

public partial class PauseOptionsBackButtonScript : Button
{
    [Export] public Control OptionsGUI;

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
        OptionsGUI.Visible = false;

        FadeAnimationPlayerScript.AnimationFinished -= ChangeSceneToMainMenu;
    }
}
