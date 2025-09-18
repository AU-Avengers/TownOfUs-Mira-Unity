using UnityEngine;

namespace TownOfUs.Modules.Localization
{
    public class TmpMiraTranslator : MonoBehaviour, IMiraTranslation
    {
        public string stringName;
        
        public string defaultStr;
        
        public bool parseStr;
        
        public bool resetWithoutDefault;

        public void ResetText()
        {
        }

        public void Start()
        {
        }

        public void OnDestroy()
        {
        }
    }
   
}