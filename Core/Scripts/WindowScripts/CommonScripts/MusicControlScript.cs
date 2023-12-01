using Godot;
using System;

public partial class MusicControlScript : HSlider
{
	public override void _Ready()
	{
		Value = AudioServer.GetBusVolumeDb(AudioServer.GetBusIndex("Music"));
    }



	public void MusicVolumeSliderValueChanged(float NewValue)
	{
		AudioServer.SetBusVolumeDb(AudioServer.GetBusIndex("Music"), NewValue);
	}
}
