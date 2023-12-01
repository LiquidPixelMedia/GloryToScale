using Godot;
using System;

public partial class GlobalAudio : Node
{
	bool IsPlaying = false;

	public AudioStreamPlayer Music;
    
    public AudioStreamPlayer MonitorSound;
    public AudioStreamPlayer ClickSound;
    public AudioStreamPlayer HeartsSound;
    public AudioStreamPlayer PencileSound;
    public AudioStreamPlayer EraserSound;
    public AudioStreamPlayer PencilShortySound;



    public override void _Ready()
	{
        Music = new AudioStreamPlayer();

        MonitorSound = new AudioStreamPlayer();
        ClickSound = new AudioStreamPlayer();
        HeartsSound = new AudioStreamPlayer();
        PencileSound = new AudioStreamPlayer();
        EraserSound = new AudioStreamPlayer();
        PencilShortySound = new AudioStreamPlayer();

        MonitorSound.MaxPolyphony = 5;
        ClickSound.MaxPolyphony = 5;
        HeartsSound.MaxPolyphony = 5;
        PencileSound.MaxPolyphony = 5;
        EraserSound.MaxPolyphony = 5;
        PencilShortySound.MaxPolyphony= 5;

        Music.Stream = GD.Load<AudioStreamMP3>("res://Core/Audio/Music/Music.mp3");

        MonitorSound.Stream = GD.Load<AudioStreamMP3>("res://Core/Audio/Sounds/Monitor.mp3");
        ClickSound.Stream = GD.Load<AudioStreamMP3>("res://Core/Audio/Sounds/Click.mp3");
        HeartsSound.Stream = GD.Load<AudioStreamMP3>("res://Core/Audio/Sounds/Hearts.mp3");
        PencileSound.Stream = GD.Load<AudioStreamMP3>("res://Core/Audio/Sounds/Pencile.mp3");
        EraserSound.Stream = GD.Load<AudioStreamMP3>("res://Core/Audio/Sounds/Eraser.mp3");
        PencilShortySound.Stream = GD.Load<AudioStreamMP3>("res://Core/Audio/Sounds/PencilShorty.mp3");

        Music.Bus = "Music";

        MonitorSound.Bus = "Sounds";
        ClickSound.Bus = "Sounds";
        HeartsSound.Bus = "Sounds";
        PencileSound.Bus = "Sounds";
        EraserSound.Bus = "Sounds";
        PencilShortySound.Bus = "Sounds";

        AudioServer.SetBusVolumeDb(AudioServer.GetBusIndex("Music"), -20f);
        PencileSound.VolumeDb = -10f;
        PencilShortySound.VolumeDb = -10f;
        EraserSound.VolumeDb = -10f;

        AddChild(Music);

        AddChild(MonitorSound);
        AddChild(ClickSound);
        AddChild(HeartsSound);
        AddChild(PencileSound);
        AddChild(EraserSound);
        AddChild(PencilShortySound);
    }

	public override void _Process(double delta)
	{
		if (HasNode("/root/MainMenuWindowScene") && !IsPlaying)
		{
			Music.Play();
			IsPlaying = true;
        }
	}
}
