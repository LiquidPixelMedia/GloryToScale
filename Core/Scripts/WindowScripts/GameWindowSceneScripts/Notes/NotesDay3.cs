using Godot;
using System;

public partial class NotesDay3 : Node2D
{
	GlobalInfo GlobalInfo { get; set; }



	[Export] public Sprite2D TextAndWhySprite { get; set; }
    [Export] public Sprite2D TextWhatAReliefSprite { get; set; }
    [Export] public Sprite2D TextThanksToMrOverseerSprite { get; set; }
    [Export] public Sprite2D TextWhoIsBeingSprite { get; set; }
    [Export] public Sprite2D TextLooksLikeSprite { get; set; }
    [Export] public Sprite2D TextThisMustacheSprite { get; set; }
    [Export] public Sprite2D TextMaybeOnlyMustachioedSprite { get; set; }
    [Export] public Sprite2D TextWhatIsAPoliticianSprite { get; set; }

    public override void _Ready()
    {
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
    }

    public override void _Process(double Delta)
    {
        if (GlobalInfo.CurrentDay == 3 && Visible)
        {
            if (GlobalInfo.Day3TextAndWhyDoSpriteVisible)
            {
                TextAndWhySprite.Visible = true; 
            }

            if (GlobalInfo.Day3TextWhatAReliefSpriteVisible)
            {
                TextWhatAReliefSprite.Visible = true;
            }

            if (GlobalInfo.Day3TextThanksToMrOverseerSpriteVisible)
            {
                TextThanksToMrOverseerSprite.Visible = true;
            }

            if (GlobalInfo.Day3TextWhoIsBeingSpriteVisible)
            {
                TextWhoIsBeingSprite.Visible = true;
            }

            if (GlobalInfo.Day3TextThisMustacheLooksSpriteVisible)
            {
                TextThisMustacheSprite.Visible = true;
            }

            if (GlobalInfo.Day3TextMaybeOnlyMustachioedSpriteVisible)
            {
                TextMaybeOnlyMustachioedSprite.Visible = true;
            }

            if (GlobalInfo.Day3TextWhatIsAPoliticianSpriteVisible)
            {
                TextWhatIsAPoliticianSprite.Visible = true;
            }

            if(GlobalInfo.Day3TextLooksLikeMrBloodhoundSpriteVisible)
            {
                TextLooksLikeSprite.Visible = true;
            }
        }
    }
}
