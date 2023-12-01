using Godot;
using System;

public partial class NotesDay1 : Node2D
{
    GlobalInfo GlobalInfo { get; set; }



    [Export] public Sprite2D TextToysSprite { get; set; }
    [Export] public Sprite2D TextInOutCountrySprite { get; set; }
    [Export] public Sprite2D TextNotHungrySprite { get; set; }
    [Export] public Sprite2D TextSalesmoreSprite { get; set; }
    [Export] public Sprite2D TextNoOneSprite { get; set; }
    [Export] public Sprite2D TextDidYouKnowSprite { get; set; }
    [Export] public Sprite2D TextChildrenSprite { get; set; }
    [Export] public Sprite2D TextEveryoneSprite { get; set; }



    public override void _Ready()
    {
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
    }



    public override void _Process(double Delta)
    {
        if (GlobalInfo.CurrentDay == 1 && Visible)
        {
            if (GlobalInfo.Day1TextToysSpriteVisible)
            {
                TextToysSprite.Visible = true;
            }

            if (GlobalInfo.Day1TextInOutCountrySpriteVisible)
            {
                TextInOutCountrySprite.Visible = true;
            }

            if (GlobalInfo.Day1TextNotHungrySpriteVisible)
            {
                TextNotHungrySprite.Visible = true;
            }

            if (GlobalInfo.Day1TextSalesmoreSpriteVisible)
            {
                TextSalesmoreSprite.Visible = true;
            }

            if (GlobalInfo.Day1TextNoOneSpriteVisible)
            {
                TextNoOneSprite.Visible = true;
            }

            if (GlobalInfo.Day1TextDidYouKnowSpriteVisible)
            {
                TextDidYouKnowSprite.Visible = true;
            }

            if (GlobalInfo.Day1TextChildrenSpriteVisible)
            {
                TextChildrenSprite.Visible = true;
            }

            if (GlobalInfo.Day1TextEveryoneSpriteVisible)
            {
                TextEveryoneSprite.Visible = true;
            }
        }
    }
}