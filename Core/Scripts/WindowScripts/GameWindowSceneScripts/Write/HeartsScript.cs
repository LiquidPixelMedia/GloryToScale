using Godot;
using System;

public partial class HeartsScript : Node2D
{
    GlobalInfo GlobalInfo { get; set; }
    GlobalAudio GlobalAudio { get; set; }



    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;

    [Export] public Node2D Write { get; set; }

    [Export] public AnimatedSprite2D HeartDay1 { get; set; }
    [Export] public AnimatedSprite2D HeartDay2 { get; set; }
    [Export] public AnimatedSprite2D HeartDay3 { get; set; }

    [Export] public Sprite2D NothingSprite { get; set; }

    bool IsNextButtonAreaMouseEntered = false;
    [Export] public Sprite2D NextButtonHover { get; set; }

    [Export] public Sprite2D Day1YesSprite { get; set; }
    [Export] public Sprite2D Day1NoSprite { get; set; }

    [Export] public Sprite2D Day2YesSprite { get; set; }
    [Export] public Sprite2D Day2NoSprite { get; set; }
    [Export] public Sprite2D Day3YesSprite { get; set; }
    [Export] public Sprite2D Day3NoSprite { get; set; }


    public override void _Ready()
	{
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");

        VisibilityChanged += OnVisibilityChange;
    }

	public override void _Process(double delta)
	{
        if (IsNextButtonAreaMouseEntered && Visible && Input.IsActionJustPressed("LeftMouse"))
        {
            FadeAnimationPlayerScript.FadePlayRevers();

            GlobalAudio.ClickSound.Play();
            GlobalAudio.Music.StreamPaused = true;

            FadeAnimationPlayerScript.AnimationFinished += OnFadeAnimationFinished;
        }
	}



    private void NextButtonAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsNextButtonAreaMouseEntered = true;
            NextButtonHover.Visible = true;
        }
    }

    private void NextButtonAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsNextButtonAreaMouseEntered = false;
            NextButtonHover.Visible = false;
        }
    }



    private void OnVisibilityChange()
    {
        if (Visible == true)
        {
            GlobalAudio.Music.StreamPaused = true;
            FadeAnimationPlayerScript.FadePlay();
            
            if (GlobalInfo.CurrentDay == 1)
            {
                if (Day1YesSprite.Visible)
                {
                    HeartDay1.Play("Empty");

                    NothingSprite.Visible = true;
                }
                else if (Day1NoSprite.Visible)
                {
                    HeartDay1.Play("Painting");
                    GlobalInfo.FinalSelection += 1;

                    GlobalAudio.HeartsSound.Play();

                    NothingSprite.Visible = false;
                }
            }
            else if (GlobalInfo.CurrentDay == 2)
            {
                if (Day2YesSprite.Visible)
                {
                    HeartDay2.Play("Empty");

                    NothingSprite.Visible = true;
                }
                else if (Day2NoSprite.Visible)
                {
                    HeartDay2.Play("Painting");
                    GlobalInfo.FinalSelection += 1;

                    GlobalAudio.HeartsSound.Play();

                    NothingSprite.Visible = false;
                }
            }
            else if (GlobalInfo.CurrentDay == 3)
            {
                if (Day3YesSprite.Visible)
                {
                    HeartDay3.Play("Empty");

                    NothingSprite.Visible = true;
                }
                else if (Day3NoSprite.Visible)
                {
                    HeartDay3.Play("Painting");
                    GlobalInfo.FinalSelection += 1;

                    GlobalAudio.HeartsSound.Play();

                    NothingSprite.Visible = false;
                }
            }
        }
    }

    private void OnFadeAnimationFinished(StringName AnimationName)
    {
        FadeAnimationPlayerScript.AnimationFinished -= OnFadeAnimationFinished;

        Visible = false;
        Write.Visible = false;

        if (GlobalInfo.CurrentDay != 3)
        {
            GlobalInfo.CurrentDay += 1;
            GlobalInfo.CurrentScene = 0;
        }
        else
        {
            GlobalAudio.Music.StreamPaused = false;
            GetTree().ChangeSceneToFile("res://Core/Scenes/WindowScenes/EndGameWindowScene/EndGameWindowScene.tscn");
        }
    }
}
