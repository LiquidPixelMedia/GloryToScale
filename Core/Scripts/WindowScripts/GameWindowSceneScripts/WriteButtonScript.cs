using Godot;
using System;

public partial class WriteButtonScript : TextureButton
{
    GlobalInfo GlobalInfo { get; set; }
    GlobalAudio GlobalAudio { get; set; }



    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;

    [Export] public Node2D Watch { get; set; }
    [Export] public Node2D Read { get; set; }
    [Export] public Node2D Listen { get; set; }
    [Export] public Node2D Write { get; set; }



    public override void _Ready()
	{
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
    }

	public override void _Process(double delta)
	{
        if (GlobalInfo.CurrentScene == 0 && GlobalInfo.Day1IsWasOnListenScreen && GlobalInfo.CurrentDay == 1 && GlobalInfo.Day1NumberOfWords >= 5)
		{
			Visible = true;
		}
		else if (GlobalInfo.CurrentScene == 0 && GlobalInfo.Day2IsWasOnListenScreen && GlobalInfo.CurrentDay == 2 && GlobalInfo.Day2NumberOfWords >= 5)
		{
            Visible = true;
        }
		else if (GlobalInfo.CurrentScene == 0 && GlobalInfo.Day3IsWasOnListenScreen && GlobalInfo.CurrentDay == 3 && GlobalInfo.Day3NumberOfWords >= 5)
		{
            Visible = true;
        }
		else
		{
			Visible = false;
		}
    }



	public void WriteButtonPressed()
	{
        FadeAnimationPlayerScript.FadePlayRevers();

        GlobalAudio.ClickSound.Play();

        FadeAnimationPlayerScript.AnimationFinished += AfterFadeAnimationFinished;

        GlobalInfo.CurrentScene = 4;
    }

    private void AfterFadeAnimationFinished(StringName AnimationName)
    {
        FadeAnimationPlayerScript.AnimationFinished -= AfterFadeAnimationFinished;

        Watch.Visible = false;
        Read.Visible = false;
        Listen.Visible = false;
        Write.Visible = true;
    }
}
