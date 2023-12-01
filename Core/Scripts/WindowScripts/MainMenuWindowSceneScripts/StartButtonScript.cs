using Godot;
using System;

public partial class StartButtonScript : Button
{
    GlobalAudio GlobalAudio { get; set; }

    [Export] public TextureRect StartButtonNormal;
    [Export] public TextureRect StartButtonHover;

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
        StartButtonNormal.Visible = true;
    }



    public void StartButtonPressed()
    {
        FadeAnimationPlayerScript.FadePlayRevers();
        FadeAnimationPlayer.AnimationFinished += ChangeToGameWindowScene;
        GlobalAudio.Music.StreamPaused = true;
    }

    public void StartButtonMouseEntered()
    {
        StartButtonNormal.Visible = false;
        StartButtonHover.Visible = true;

        GlobalAudio.MonitorSound.Play();
    }

    public void StartButtonMouseExited()
    {
        StartButtonNormal.Visible = true;
        StartButtonHover.Visible = false;

        GlobalAudio.MonitorSound.Stop();
    }



    private void ChangeToGameWindowScene(StringName AnimationName)
    {
        FadeAnimationPlayer.AnimationFinished -= ChangeToGameWindowScene;

        GetTree().ChangeSceneToFile("res://Core/Scenes/WindowScenes/StartCutSceneWindowScene/StartCutSceneWindowScene.tscn");
    }
}
