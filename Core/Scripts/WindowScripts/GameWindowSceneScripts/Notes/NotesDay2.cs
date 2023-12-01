using Godot;
using System;

public partial class NotesDay2 : Node2D
{
	GlobalInfo GlobalInfo { get; set; }



	[Export] public Sprite2D TextTheProtestersSprite { get; set; }
    [Export] public Sprite2D TextPitchforksSprite { get; set; }
    [Export] public Sprite2D TextOnlyTheDregsSprite { get; set; }
    [Export] public Sprite2D TextPeopleHaveAlmostSprite { get; set; }
    [Export] public Sprite2D TextDwellersSprite { get; set; }
    [Export] public Sprite2D TextOnlyThanksSprite { get; set; }
    [Export] public Sprite2D TextInTheHandsSprite { get; set; }
    [Export] public Sprite2D TextKnowledgeSprite { get; set; }

    public override void _Ready()
    {
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
    }

    public override void _Process(double Delta)
    {
        if (GlobalInfo.CurrentDay == 2 && Visible)
        {
            if (GlobalInfo.Day2TextTheProtestersSpriteVisible)
            {
                TextTheProtestersSprite.Visible = true;
            }

            if (GlobalInfo.Day2TextPitchforksSptiteVisible)
            {
                TextPitchforksSprite.Visible = true;
            }

            if (GlobalInfo.Day2TextOnlyTheDregsSpriteVisible)
            {
                TextOnlyTheDregsSprite.Visible = true;
            }

            if (GlobalInfo.Day2TextPeopleHaveSptiteVisible)
            {
                TextPeopleHaveAlmostSprite.Visible = true;
            }

            if (GlobalInfo.Day2TextDwellersArmedSpriteVisible)
            {
                TextDwellersSprite.Visible = true;
            }

            if (GlobalInfo.Day2TextOnlyThanksSpriteVisible)
            {
                TextOnlyThanksSprite.Visible = true;
            }

            if (GlobalInfo.Day2TextInTheHandsOfPeopleSpriteVisible)
            {
                TextInTheHandsSprite.Visible = true;
            }

            if (GlobalInfo.Day2TextKnowledgeSpriteVisible)
            {
                TextKnowledgeSprite.Visible = true;
            }
        }
    }
}
