using Godot;
using System;

public partial class PauseButtonScript : Button
{
    GlobalInfo GlobalInfo { get; set; }
    GlobalAudio GlobalAudio { get; set; }


    [Export] public Control PauseScene;

    [Export] public TextureRect PauseButtonNormal;
    [Export] public TextureRect PauseButtonHover;

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");

        PauseButtonNormal.Visible = true;
        PauseScene.Visible = false;
    }



    public void PauseButtonPressed()
    {
        FadeAnimationPlayerScript.FadePlayRevers();

        FadeAnimationPlayer.AnimationFinished += PauseSceneScript;

        GlobalInfo.CurrentScene = 5;
    }

    public void PauseButtonMouseEntered()
    {
        PauseButtonNormal.Visible = false;
        PauseButtonHover.Visible = true;

        GlobalAudio.MonitorSound.Play();
    }

    public void PauseButtonMouseExited()
    {
        PauseButtonNormal.Visible = true;
        PauseButtonHover.Visible = false;

        GlobalAudio.MonitorSound.Stop();
    }



    private void PauseSceneScript(StringName AnimationName)
    {
        PauseScene.Visible = true;

        FadeAnimationPlayer.AnimationFinished -= PauseSceneScript;
    }
}
