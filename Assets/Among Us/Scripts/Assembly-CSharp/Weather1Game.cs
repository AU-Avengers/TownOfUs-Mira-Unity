public class Weather1Game : Minigame
{
    public UnityEngine.Tilemaps.Tilemap BarrierMap;
    public UnityEngine.Tilemaps.Tile fillTile;
    public UnityEngine.Tilemaps.Tile controlTile;
    public UnityEngine.Tilemaps.Tile barrierTile;
    public UnityEngine.SpriteRenderer pulseCircle1;
    public UnityEngine.SpriteRenderer pulseCircle2;
    public UnityEngine.AudioClip NodeMove;
    public Controller control;
    public bool inControl;
    public UnityEngine.Vector3Int controlTilePos;
    public float moveCooldown;
}
