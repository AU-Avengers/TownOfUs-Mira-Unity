namespace AmongUs.QuickChat
{
    public class QuickChatMenuPhrasesPage : AmongUs.QuickChat.AbstractQuickChatMenuPage
    {
        public AmongUs.QuickChat.QuickChatMenuScroller scroller;
        public AmongUs.QuickChat.QuickChatMenuPhrasesPagePhraseButton phraseButtonTemplate;
        public AmongUs.QuickChat.QuickChatMenuPhrasesPageCrewmateButton crewmateButtonTemplate;
        public UnityEngine.Material defaultButtonTextMaterial;
        public ControllerButtonBehavior favoriteButton;
        public AmongUs.QuickChat.AbstractQuickChatMenuPhrasesPageButton[] dynamicButtons;
        public AmongUs.QuickChat.QuickChatTag[] tags;
        public AmongUs.QuickChat.QuickChatPhrase[] phrases;
        public UnityEngine.Material buttonTextMaterial;
    }
}
