using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace TownOfUs.Modules.Wiki
{
    public class IngameWikiMinigame : Minigame
    {
        public Transform Homepage;
        public PassiveButton HomepageModifiersBtn;
        public PassiveButton HomepageRolesBtn;
        public PassiveButton CloseButton;
        public PassiveButton OutsideCloseButton;

        public Transform SearchScreen;
        public PassiveButton SearchScreenBackBtn;
        public TextBoxTMP SearchTextbox;
        public Scroller SearchScroller;
        public Transform SearchItemTemplate;
        public SpriteRenderer SearchPageIcon;
        public TextMeshPro SearchPageText;

        public Transform DetailScreen;
        public TextMeshPro DetailDescription;
        public PassiveButton ToggleAbilitiesBtn;
        public Transform AbilityTemplate;
        public Scroller AbilityScroller;
        public PassiveButton DetailScreenBackBtn;
        public SpriteRenderer DetailScreenIcon;
        public TextMeshPro DetailScreenItemName;
    }
   
}