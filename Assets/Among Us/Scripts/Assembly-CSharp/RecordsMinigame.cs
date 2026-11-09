public class RecordsMinigame : Minigame
{
    public UnityEngine.GameObject FoldersContent;
    public UnityEngine.SpriteRenderer[] Folders;
    public UnityEngine.GameObject DrawerContent;
    public UnityEngine.Transform Drawer;
    public UnityEngine.SpriteRenderer DrawerFolder;
    public UnityEngine.GameObject ShelfContent;
    public UnityEngine.SpriteRenderer[] Books;
    public UnityEngine.Sprite[] BookCovers;
    public UnityEngine.SpriteRenderer targetBook;
    public UnityEngine.AudioClip recordFilePlace;
    public UnityEngine.AudioClip recordBookPlace;
    public UnityEngine.AudioClip grabDocument;
    public UnityEngine.AudioClip drawerOpen;
    public UnityEngine.AudioClip drawerClose;
    public UnityEngine.Transform bookInputPrompt;
    public ControllerButtonBehaviourComplex slideFolderHotkey;
}
