using Godot;
using System;

public partial class PauseOptionsWindowSceneScripts : Control
{
    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;

        VisibilityChanged += OnVisibilityChange;
    }



    private void OnVisibilityChange()
    {
        if (Visible == true)
        {
            FadeAnimationPlayerScript.FadePlay();
        }
    }
}
