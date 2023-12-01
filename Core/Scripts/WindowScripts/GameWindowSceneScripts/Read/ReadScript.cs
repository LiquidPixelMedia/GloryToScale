using Godot;
using System;

public partial class ReadScript : Node2D
{
    GlobalInfo GlobalInfo { get; set; }

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;

    [Export] public Node2D Day1 { get; set; }
    [Export] public Node2D Day2 { get; set; }
    [Export] public Node2D Day3 { get; set; }



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");

        VisibilityChanged += OnVisibilityChange;
    }

    public override void _Process(double delta)
    {
        if (GlobalInfo.CurrentDay == 1)
        {
            Day1.Visible = true;
            Day2.Visible = false;
            Day3.Visible = false;
        }
        else if (GlobalInfo.CurrentDay == 2)
        {
            Day1.Visible = false;
            Day2.Visible = true;
            Day1.Visible = false;
        }
        else if (GlobalInfo.CurrentDay == 3)
        {
            Day1.Visible = false;
            Day2.Visible = false;
            Day3.Visible = true;
        }
    }



    private void OnVisibilityChange()
    {
        if (Visible == true)
        {
            FadeAnimationPlayerScript.FadePlay();
        }
    }
}
