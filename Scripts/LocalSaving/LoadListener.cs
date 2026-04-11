using UnityEngine;

public class LoadListener<T> : MonoBehaviour
{
    private ILoadable<T> _loadable;
    
    void Start()
    {
        _loadable = GetComponent<ILoadable<T>>();
        _loadable.OnLoadPointReached += Loadable_OnLoadPointReached;
    }

    private T Loadable_OnLoadPointReached()
    {
        return SaveSystem.Load<T>();
    }
    
    void OnDestroy()
    {
        _loadable.OnLoadPointReached -= Loadable_OnLoadPointReached;
    }
}
