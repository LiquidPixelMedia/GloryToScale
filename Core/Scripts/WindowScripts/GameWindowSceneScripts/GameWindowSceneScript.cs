using Godot;
using System;

public partial class GameWindowSceneScript : Control
{
    [Export] public Control PauseGUI;

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;


    [Export] public Node2D Read { get; set; }
    [Export] public Node2D Watch { get; set; }
    [Export] public Node2D Listen { get; set; }
    [Export] public Node2D Write { get; set; }


    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;

        PauseGUI.VisibilityChanged += OnPauseVisibilityChange;
        VisibilityChanged += OnVisibilityChange;
    }



    public override void _Process(double delta)
    {
        if (Read.Visible || Watch.Visible || Listen.Visible || Write.Visible)
        {
            Visible = false;
        }
        else
        {
            Visible = true;
        }
    }



    private void OnPauseVisibilityChange()
    {
        if (PauseGUI.Visible == false)
        {
            FadeAnimationPlayerScript.FadePlay();
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
