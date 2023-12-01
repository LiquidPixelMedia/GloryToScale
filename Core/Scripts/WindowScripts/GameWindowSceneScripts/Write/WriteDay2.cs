using Godot;
using System;

public partial class WriteDay2 : Node2D
{
	GlobalInfo GlobalInfo { get; set; }
    GlobalAudio GlobalAudio { get; set; }



    [Export] public AnimationPlayer FadeAnimationPlayer;
    public FadeControlScript FadeAnimationPlayerScript;

    int NumberOfChoices = 0;
    int NumberOfYes = 0;
    int NumberOfNo = 0;

    bool IsWrited = false;

	[Export] public Sprite2D TextTheProtestersSprite { get; set; }
    [Export] public Sprite2D TextPitchforksSprite { get; set; }
    [Export] public Sprite2D TextOnlyTheDregsSprite { get; set; }
    [Export] public Sprite2D TextPeopleHaveAlmostSprite { get; set; }
    [Export] public Sprite2D TextDwellersSprite { get; set; }
    [Export] public Sprite2D TextOnlyThanksSprite { get; set; }
    [Export] public Sprite2D TextInTheHandsSprite { get; set; }
    [Export] public Sprite2D TextKnowledgeSprite { get; set; }

    bool IsChoice1CheckBoxEntered = false;
    [Export] public Sprite2D Choice1CheckBoxSprite { get; set; }

    bool IsChoice2CheckBoxEntered = false;
    [Export] public Sprite2D Choice2CheckBoxSprite { get; set; }

    bool IsChoice3CheckBoxEntered = false;
    [Export] public Sprite2D Choice3CheckBoxSprite { get; set; }

    bool IsChoice4CheckBoxEntered = false;
    [Export] public Sprite2D Choice4CheckBoxSprite { get; set; }

    bool IsChoice5CheckBoxEntered = false;
    [Export] public Sprite2D Choice5CheckBoxSprite { get; set; }

    bool IsChoice6CheckBoxEntered = false;
    [Export] public Sprite2D Choice6CheckBoxSprite { get; set; }

    bool IsChoice7CheckBoxEntered = false;
    [Export] public Sprite2D Choice7CheckBoxSprite { get; set; }

    bool IsChoice8CheckBoxEntered = false;
    [Export] public Sprite2D Choice8CheckBoxSprite { get; set; }

    bool IsWriteArticleAreaEntered = false;
    [Export] public Sprite2D WriteArticle { get; set; }
    [Export] public Sprite2D WriteArticleHover { get; set; }
    
    [Export] public Sprite2D YesSprite { get; set; }
    [Export] public Sprite2D NoSprite { get; set; }

    bool IsPublishArticleAreaEntered = false;
    [Export] public Node2D PublishArticleNode2D { get; set; }
    [Export] public Sprite2D PublishArticle { get; set; }
    [Export] public Sprite2D PublishArticleHover { get; set; }

    [Export] public Node2D Hearts { get; set; }



    public override void _Ready()
    {
        FadeAnimationPlayerScript = (FadeControlScript)FadeAnimationPlayer;
        GlobalInfo = GetNode<GlobalInfo>("/root/GlobalInfo");
        GlobalAudio = GetNode<GlobalAudio>("/root/GlobalAudio");
    }

    public override void _Process(double Delta)
    {
		if (GlobalInfo.CurrentDay == 2 && Visible && GetParent<Node2D>().Visible)
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



			if (IsChoice1CheckBoxEntered && TextTheProtestersSprite.Visible && Input.IsActionJustPressed("LeftMouse") && Visible)
			{
				Choice1CheckBoxSprite.Visible = !Choice1CheckBoxSprite.Visible;

				if (Choice1CheckBoxSprite.Visible)
				{
					NumberOfNo += 1;
					NumberOfChoices += 1;

                    GlobalAudio.PencilShortySound.Play();
                }
				else
				{
					NumberOfNo -= 1;
					NumberOfChoices -= 1;

                    GlobalAudio.EraserSound.Play();
                }
			}

			if (IsChoice2CheckBoxEntered && TextPitchforksSprite.Visible && Input.IsActionJustPressed("LeftMouse") && Visible)
			{
				Choice2CheckBoxSprite.Visible = !Choice2CheckBoxSprite.Visible;

				if (Choice2CheckBoxSprite.Visible)
				{
					NumberOfNo += 1;
					NumberOfChoices += 1;

                    GlobalAudio.PencilShortySound.Play();
                }
				else
				{
					NumberOfNo -= 1;
					NumberOfChoices -= 1;

                    GlobalAudio.EraserSound.Play();
                }
			}

			if (IsChoice3CheckBoxEntered && TextOnlyTheDregsSprite.Visible && Input.IsActionJustPressed("LeftMouse") && Visible)
			{
				Choice3CheckBoxSprite.Visible = !Choice3CheckBoxSprite.Visible;

				if (Choice3CheckBoxSprite.Visible)
				{
					NumberOfYes += 1;
					NumberOfChoices += 1;

                    GlobalAudio.PencilShortySound.Play();
                }
				else
				{
					NumberOfYes -= 1;
					NumberOfChoices -= 1;

                    GlobalAudio.EraserSound.Play();
                }
			}

			if (IsChoice4CheckBoxEntered && TextPeopleHaveAlmostSprite.Visible && Input.IsActionJustPressed("LeftMouse") && Visible)
			{
				Choice4CheckBoxSprite.Visible = !Choice4CheckBoxSprite.Visible;

				if (Choice4CheckBoxSprite.Visible)
				{
					NumberOfNo += 1;
					NumberOfChoices += 1;

                    GlobalAudio.PencilShortySound.Play();
                }
				else
				{
					NumberOfNo -= 1;
					NumberOfChoices -= 1;

                    GlobalAudio.EraserSound.Play();
                }
			}

			if (IsChoice5CheckBoxEntered && TextDwellersSprite.Visible && Input.IsActionJustPressed("LeftMouse") && Visible)
			{
				Choice5CheckBoxSprite.Visible = !Choice5CheckBoxSprite.Visible;

				if (Choice5CheckBoxSprite.Visible)
				{
					NumberOfYes += 1;
					NumberOfChoices += 1;

                    GlobalAudio.PencilShortySound.Play();
                }
				else
				{
					NumberOfYes -= 1;
					NumberOfChoices -= 1;

                    GlobalAudio.EraserSound.Play();
                }
			}

			if (IsChoice6CheckBoxEntered && TextOnlyThanksSprite.Visible && Input.IsActionJustPressed("LeftMouse") && Visible)
			{
				Choice6CheckBoxSprite.Visible = !Choice6CheckBoxSprite.Visible;

				if (Choice6CheckBoxSprite.Visible)
				{
					NumberOfYes += 1;
					NumberOfChoices += 1;

                    GlobalAudio.PencilShortySound.Play();
                }
				else
				{
					NumberOfYes -= 1;
					NumberOfChoices -= 1;

                    GlobalAudio.EraserSound.Play();
                }
			}

			if (IsChoice7CheckBoxEntered && TextInTheHandsSprite.Visible && Input.IsActionJustPressed("LeftMouse") && Visible)
			{
				Choice7CheckBoxSprite.Visible = !Choice7CheckBoxSprite.Visible;

				if (Choice7CheckBoxSprite.Visible)
				{
					NumberOfNo += 1;
					NumberOfChoices += 1;

                    GlobalAudio.PencilShortySound.Play();
                }
				else
				{
					NumberOfNo -= 1;
					NumberOfChoices -= 1;

                    GlobalAudio.EraserSound.Play();
                }
			}

			if (IsChoice8CheckBoxEntered && TextKnowledgeSprite.Visible && Input.IsActionJustPressed("LeftMouse") && Visible)
			{
				Choice8CheckBoxSprite.Visible = !Choice8CheckBoxSprite.Visible;

				if (Choice8CheckBoxSprite.Visible)
				{
					NumberOfYes += 1;
					NumberOfChoices += 1;

                    GlobalAudio.PencilShortySound.Play();
                }
				else
				{
					NumberOfYes -= 1;
					NumberOfChoices -= 1;

                    GlobalAudio.EraserSound.Play();
                }
			}



			if (NumberOfChoices == 5)
			{
				WriteArticle.Visible = true;
			}
			else
			{
				WriteArticle.Visible = false;
			}

			if (WriteArticle.Visible && IsWriteArticleAreaEntered && Input.IsActionJustPressed("LeftMouse") && Visible)
			{
                GlobalAudio.ClickSound.Play();

                if (NumberOfNo > NumberOfYes)
				{
					YesSprite.Visible = false;
					NoSprite.Visible = true;
				}
				else if (NumberOfNo < NumberOfYes)
				{
					YesSprite.Visible = true;
					NoSprite.Visible = false;
				}
			}



			if (YesSprite.Visible || NoSprite.Visible)
			{
				PublishArticleNode2D.Visible = true;
			}
			else
			{
				PublishArticleNode2D.Visible = false;
			}

			if (PublishArticleNode2D.Visible && IsPublishArticleAreaEntered && Input.IsActionJustPressed("LeftMouse") && Visible)
			{
				FadeAnimationPlayerScript.FadePlayRevers();

                GlobalAudio.ClickSound.Play();

                FadeAnimationPlayerScript.AnimationFinished += OnAnimationFinished;
			}
		}
    }



    private void Choice1CheckBoxAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice1CheckBoxEntered = true;
        }
    }

    private void Choice1CheckBoxAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice1CheckBoxEntered = false;
        }
    }



    private void Choice2CheckBoxAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice2CheckBoxEntered = true;
        }
    }

    private void Choice2CheckBoxAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice2CheckBoxEntered = false;
        }
    }



    private void Choice3CheckBoxAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice3CheckBoxEntered = true;
        }
    }

    private void Choice3CheckBoxAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice3CheckBoxEntered = false;
        }
    }



    private void Choice4CheckBoxAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice4CheckBoxEntered = true;
        }
    }

    private void Choice4CheckBoxAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice4CheckBoxEntered = false;
        }
    }



    private void Choice5CheckBoxAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice5CheckBoxEntered = true;
        }
    }

    private void Choice5CheckBoxAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice5CheckBoxEntered = false;
        }
    }



    private void Choice6CheckBoxAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice6CheckBoxEntered = true;
        }
    }

    private void Choice6CheckBoxAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice6CheckBoxEntered = false;
        }
    }



    private void Choice7CheckBoxAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice7CheckBoxEntered = true;
        }
    }

    private void Choice7CheckBoxAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice7CheckBoxEntered = false;
        }
    }



    private void Choice8CheckBoxAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice8CheckBoxEntered = true;
        }
    }

    private void Choice8CheckBoxAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsChoice8CheckBoxEntered = false;
        }
    }



    private void WriteArticleAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsWriteArticleAreaEntered = true;
            WriteArticleHover.Visible = true;
        }
    }

    private void WriteArticleAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsWriteArticleAreaEntered = false;
            WriteArticleHover.Visible = false;
        }
    }



    private void PublishArticleAreaMouseEntered(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsPublishArticleAreaEntered = true;

            PublishArticle.Visible = false; 
            PublishArticleHover.Visible = true;
        }
    }

    private void PublishArticleAreaMouseExited(Area2D Area)
    {
        if (Area.HasMeta("IsMouse") && Area.GetMeta("IsMouse").AsBool() == true)
        {
            IsPublishArticleAreaEntered = false;

            PublishArticle.Visible = true;
            PublishArticleHover.Visible = false;
        }
    }



    private void OnAnimationFinished(StringName AnimationName)
    {
        FadeAnimationPlayerScript.AnimationFinished -= OnAnimationFinished;

        Hearts.Visible = true;
    }
}
