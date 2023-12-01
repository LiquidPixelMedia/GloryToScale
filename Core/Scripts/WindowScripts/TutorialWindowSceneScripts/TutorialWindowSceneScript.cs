using Godot;
using System;

public partial class TutorialWindowSceneScript : Node
{
    GlobalAudio GlobalAudio { get; set; }



    public override void _Ready()
	{
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");

        GlobalAudio.Music.StreamPaused = false;
    }
}
