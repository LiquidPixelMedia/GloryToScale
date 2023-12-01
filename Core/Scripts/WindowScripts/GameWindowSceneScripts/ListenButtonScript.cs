using Godot;
using System;

public partial class ListenButtonScript : Button
{
    GlobalInfo GlobalInfo { get; set; }
    GlobalAudio GlobalAudio { get; set; }


    [Export] public TextureRect ListenButtonNormal;
    [Export] public TextureRect ListenButtonHover;

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;



    public Node2D ListenScene;



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
        ListenScene = GetNode<Node2D>("/root/GameWindowScene/GameLayer/Listen");

        ListenButtonNormal.Visible = true;
    }



    public void ListenButtonPressed()
    {
        FadeAnimationPlayerScript.FadePlayRevers();

        FadeAnimationPlayer.AnimationFinished += ListenSceneScript;

        GlobalInfo.CurrentScene = 3;
    }

    public void ListenButtonMouseEntered()
    {
        ListenButtonNormal.Visible = false;
        ListenButtonHover.Visible = true;

        GlobalAudio.MonitorSound.Play();
    }

    public void ListenButtonMouseExited()
    {
        ListenButtonNormal.Visible = true;
        ListenButtonHover.Visible = false;

        GlobalAudio.MonitorSound.Stop();
    }



    private void ListenSceneScript(StringName AnimationName)
    {
        FadeAnimationPlayer.AnimationFinished -= ListenSceneScript;

        ListenScene.Visible = true;
    }
}
