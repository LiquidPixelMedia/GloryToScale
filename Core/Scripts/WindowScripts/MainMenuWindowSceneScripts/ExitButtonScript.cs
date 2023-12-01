using Godot;
using System;

public partial class ExitButtonScript : Button
{
    GlobalAudio GlobalAudio { get; set; }

    [Export] public TextureRect ExitButtonNormal;
    [Export] public TextureRect ExitButtonHover;

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
        ExitButtonNormal.Visible = true;
    }



    public void ExitButtonPressed()
    {
        FadeAnimationPlayerScript.FadePlayRevers();
        FadeAnimationPlayer.AnimationFinished += QuitGame;
    }

    public void ExitButtonMouseEntered()
    {
        ExitButtonNormal.Visible = false;
        ExitButtonHover.Visible = true;

        GlobalAudio.MonitorSound.Play();
    }

    public void ExitButtonMouseExited()
    {
        ExitButtonNormal.Visible = true;
        ExitButtonHover.Visible = false;

        GlobalAudio.MonitorSound.Stop();
    }



    private void QuitGame(StringName AnimationName)
    {
        GetTree().Quit(0);
    }
}
