public class ObjectPoolBehavior : IObjectPool
{
    public int poolSize;
    public PoolableBehavior Prefab;
    public bool AutoInit;
    public bool DetachOnGet;
    public int childIndex;
}
