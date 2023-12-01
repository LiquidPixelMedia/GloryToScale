using Godot;
using System;

public partial class ResumeButtonScript : Button
{
    GlobalInfo GlobalInfo { get; set; }

    [Export] public Control PauseGUI;

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
    }



    public void ResumeButtonPressed()
	{
        FadeAnimationPlayerScript.FadePlayRevers();

        FadeAnimationPlayer.AnimationFinished += ChangeSceneToGame;

        GlobalInfo.CurrentScene = 0;
    }



    private void ChangeSceneToGame(StringName AnimationName)
    {
        PauseGUI.Visible = false;
        
        FadeAnimationPlayer.AnimationFinished -= ChangeSceneToGame;
    }
}
