using Godot;
using System;

public partial class ChangeToMainMenuScript : AnimationPlayer
{
	public void SplashScreenAnimationFinished(StringName AnimationName)
	{
		GetTree().ChangeSceneToFile("res://Core/Scenes/WindowScenes/MainMenuWindowScene/MainMenuWindowScene.tscn");
	}
}
