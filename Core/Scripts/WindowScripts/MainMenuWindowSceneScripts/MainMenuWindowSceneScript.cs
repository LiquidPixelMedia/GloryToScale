using Godot;
using System;

public partial class MainMenuWindowSceneScript : Node
{
    GlobalInfo GlobalInfo { get; set; }



    public override void _Ready()
	{
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");

        GlobalInfo.FinalSelection = 0;

        GlobalInfo.CurrentDay = 1;
        GlobalInfo.CurrentScene = 0;

        GlobalInfo.ImageIsOpened = false;
        GlobalInfo.IsVideoPlayingNow = false;

        GlobalInfo.Day1NumberOfWords = 0;

        GlobalInfo.Day1IsWasOnReadScreen = false;
        GlobalInfo.Day1IsWasOnWatchScreen = false;
        GlobalInfo.Day1IsWasOnListenScreen = false;

        GlobalInfo.Day1PictureSpriteVisible = false;
        GlobalInfo.Day1TextToysSpriteVisible = false;
        GlobalInfo.Day1TextInOutCountrySpriteVisible = false;
        GlobalInfo.Day1TextNotHungrySpriteVisible = false;
        GlobalInfo.Day1TextSalesmoreSpriteVisible = false;
        GlobalInfo.Day1TextNoOneSpriteVisible = false;
        GlobalInfo.Day1TextDidYouKnowSpriteVisible = false;
        GlobalInfo.Day1TextChildrenSpriteVisible = false;
        GlobalInfo.Day1TextEveryoneSpriteVisible = false;



        GlobalInfo.Day2NumberOfWords = 0;

        GlobalInfo.Day2IsWasOnReadScreen = false;
        GlobalInfo.Day2IsWasOnWatchScreen = false;
        GlobalInfo.Day2IsWasOnListenScreen = false;

        GlobalInfo.Day2PictureSpriteVisible = false;
        GlobalInfo.Day2TextTheProtestersSpriteVisible = false;
        GlobalInfo.Day2TextPitchforksSptiteVisible = false;
        GlobalInfo.Day2TextOnlyTheDregsSpriteVisible = false;
        GlobalInfo.Day2TextPeopleHaveSptiteVisible = false;
        GlobalInfo.Day2TextDwellersArmedSpriteVisible = false;
        GlobalInfo.Day2TextOnlyThanksSpriteVisible = false;
        GlobalInfo.Day2TextInTheHandsOfPeopleSpriteVisible = false;
        GlobalInfo.Day2TextKnowledgeSpriteVisible = false;



        GlobalInfo.Day3NumberOfWords = 0;

        GlobalInfo.Day3IsWasOnReadScreen = false;
        GlobalInfo.Day3IsWasOnWatchScreen = false;
        GlobalInfo.Day3IsWasOnListenScreen = false;

        GlobalInfo.Day3PictureSpriteVisible = false;
        GlobalInfo.Day3TextAndWhyDoSpriteVisible = false;
        GlobalInfo.Day3TextWhatAReliefSpriteVisible = false;
        GlobalInfo.Day3TextThanksToMrOverseerSpriteVisible = false;
        GlobalInfo.Day3TextWhoIsBeingSpriteVisible = false;
        GlobalInfo.Day3TextLooksLikeMrBloodhoundSpriteVisible = false;
        GlobalInfo.Day3TextThisMustacheLooksSpriteVisible = false;
        GlobalInfo.Day3TextMaybeOnlyMustachioedSpriteVisible = false;
        GlobalInfo.Day3TextWhatIsAPoliticianSpriteVisible = false;
    }
}
