using Godot;
using System;

public partial class PauseWindowSceneScript : Control
{
    [Export] public Control OptionsGUI;

    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;



    public override void _Ready()
	{
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;

        VisibilityChanged += OnVisibilityChange;
        OptionsGUI.VisibilityChanged += OnOptionsGUIVisibilityChange;
    }



	private void OnVisibilityChange()
	{
		if (Visible == true)
		{
            FadeAnimationPlayerScript.FadePlay();
        }
	}

    private void OnOptionsGUIVisibilityChange()
    {
        if (OptionsGUI.Visible == false)
        {
            FadeAnimationPlayerScript.FadePlay();
        }
    }
}
