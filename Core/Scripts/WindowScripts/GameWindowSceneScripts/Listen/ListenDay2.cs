using Godot;
using System;

public partial class ListenDay2 : Node2D
{
    GlobalInfo GlobalInfo { get; set; }
    GlobalAudio GlobalAudio { get; set; }

    bool IsChoice1AreaEntered = false;
    bool IsChoice2AreaEntered = false;
    bool IsChoice3AreaEntered = false;

    [Export] public VideoStreamPlayer Choice1Video { get; set; }
    [Export] public VideoStreamPlayer Choice2Video { get; set; }
    [Export] public VideoStreamPlayer Choice3Video { get; set; }

    [Export] public Sprite2D LastFrameChoice1 { get; set; }
    [Export] public Sprite2D LastFrameChoice2 { get; set; }
    [Export] public Sprite2D LastFrameChoice3 { get; set; }
    [Export] public Sprite2D Choice1Hover { get; set; }
    [Export] public Sprite2D Choice2Hover { get; set; }
    [Export] public Sprite2D Choice3Hover { get; set; }



    public override void _Ready()
	{
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
    }

	public override void _Process(double delta)
	{
        if ((!Choice1Video.Visible && !Choice2Video.Visible && !Choice3Video.Visible && !LastFrameChoice1.Visible && !LastFrameChoice2.Visible && !LastFrameChoice3.Visible) && GlobalInfo.CurrentScene == 3 && GlobalInfo.CurrentDay == 2 && Visible && GetParent<Node2D>().Visible)
        {
            if (IsChoice1AreaEntered && Input.IsActionJustPressed("LeftMouse"))
            {
                Choice1Video.Visible = true;
                Choice1Video.Play();
                GlobalInfo.IsVideoPlayingNow = true;

                GlobalAudio.ClickSound.Play();
                GlobalAudio.Music.StreamPaused = true;
            }

            if (IsChoice2AreaEntered && Input.IsActionJustPressed("LeftMouse"))
            {
                Choice2Video.Visible = true;
                Choice2Video.Play();
                GlobalInfo.IsVideoPlayingNow = true;

                GlobalAudio.ClickSound.Play();
                GlobalAudio.Music.StreamPaused = true;
            }

            if (IsChoice3AreaEntered && Input.IsActionJustPressed("LeftMouse"))
            {
                Choice3Video.Visible = true;
                Choice3Video.Play();
                GlobalInfo.IsVideoPlayingNow = true;

                GlobalAudio.ClickSound.Play();
                GlobalAudio.Music.StreamPaused = true;
            }
        }
	}



    private void Choice1AreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice1AreaEntered = true;
            Choice1Hover.Visible = true;
        }
    }

    private void Choice1AreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice1AreaEntered = false;
            Choice1Hover.Visible = false;
        }
    }



    private void Choice2AreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice2AreaEntered = true;
            Choice2Hover.Visible = true;
        }
    }

    private void Choice2AreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice2AreaEntered = false;
            Choice2Hover.Visible = false;
        }
    }



    private void Choice3AreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice3AreaEntered = true;
            Choice3Hover.Visible = true;
        }
    }

    private void Choice3AreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice3AreaEntered = false;
            Choice3Hover.Visible = false;
        }
    }



    private void AfterVideoChoice1()
    {
        Choice1Video.Visible = false;
        LastFrameChoice1.Visible = true;

        GlobalInfo.Day2IsWasOnListenScreen = true;
        GlobalInfo.IsVideoPlayingNow = false;

        GlobalAudio.Music.StreamPaused = false;
    }

    private void AfterVideoChoice2()
    {
        Choice2Video.Visible = false;
        LastFrameChoice2.Visible = true;

        GlobalInfo.Day2IsWasOnListenScreen = true;
        GlobalInfo.IsVideoPlayingNow = false;

        GlobalAudio.Music.StreamPaused = false;
    }

    private void AfterVideoChoice3()
    {
        Choice3Video.Visible = false;
        LastFrameChoice3.Visible = true;

        GlobalInfo.Day2IsWasOnListenScreen = true;
        GlobalInfo.IsVideoPlayingNow = false;

        GlobalAudio.Music.StreamPaused = false;
    }
}
