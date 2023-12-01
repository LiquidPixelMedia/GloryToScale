using Godot;
using System;

public partial class OptionsButtonScript : Button
{
    GlobalAudio GlobalAudio { get; set; }

    [Export] public TextureRect OptionsButtonNormal;
    [Export] public TextureRect OptionsButtonHover;

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
        OptionsButtonNormal.Visible = true;
    }



    public void OptionsButtonPressed()
    {
        FadeAnimationPlayerScript.FadePlayRevers();

        FadeAnimationPlayer.AnimationFinished += ChangeToOptionsWindowScene;
    }

    public void OptionsButtonMouseEntered()
    {
        OptionsButtonNormal.Visible = false;
        OptionsButtonHover.Visible = true;

        GlobalAudio.MonitorSound.Play();
    }

    public void OptionsButtonMouseExited()
    {
        OptionsButtonNormal.Visible = true;
        OptionsButtonHover.Visible = false;

        GlobalAudio.MonitorSound.Stop();
    }



    private void ChangeToOptionsWindowScene(StringName AnimationName)
    {
        FadeAnimationPlayer.AnimationFinished -= ChangeToOptionsWindowScene;

        GetTree().ChangeSceneToFile("res://Core/Scenes/WindowScenes/OptionsWindowScene/OptionsWindowScene.tscn");
    }
}
