using Godot;
using System;

public partial class CreditsButtonScript : Button
{
    GlobalAudio GlobalAudio { get; set; }

    [Export] public TextureRect CreditsButtonNormal;
    [Export] public TextureRect CreditsButtonHover;

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
        CreditsButtonNormal.Visible = true;
    }



    public void CreditsButtonPressed()
    {
        FadeAnimationPlayerScript.FadePlayRevers();

        FadeAnimationPlayer.AnimationFinished += ChangeToCreditsWindowScene;
    }

    public void CreditsButtonMouseEntered()
    {
        CreditsButtonNormal.Visible = false;
        CreditsButtonHover.Visible = true;

        GlobalAudio.MonitorSound.Play();
    }

    public void CreditsButtonMouseExited()
    {
        CreditsButtonNormal.Visible = true;
        CreditsButtonHover.Visible = false;

        GlobalAudio.MonitorSound.Stop();
    }



    private void ChangeToCreditsWindowScene(StringName AnimationName)
    {
        FadeAnimationPlayer.AnimationFinished -= ChangeToCreditsWindowScene;

        GetTree().ChangeSceneToFile("res://Core/Scenes/WindowScenes/CreditsWindowScene/CreditsWindowScene.tscn");
    }
}
