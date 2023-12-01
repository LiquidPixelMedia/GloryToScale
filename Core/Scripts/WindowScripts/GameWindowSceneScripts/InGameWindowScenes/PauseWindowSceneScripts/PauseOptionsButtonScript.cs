using Godot;
using System;

public partial class PauseOptionsButtonScript : Button
{
    [Export] public Control OptionsGUI;

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
    }



    public void OptionsButtonPressed()
	{
        FadeAnimationPlayerScript.FadePlayRevers();

        FadeAnimationPlayer.AnimationFinished += ChangeSceneToOptions;
    }



    private void ChangeSceneToOptions(StringName AnimationName)
    {
        OptionsGUI.Visible = true;

        FadeAnimationPlayer.AnimationFinished -= ChangeSceneToOptions;
    }
}
