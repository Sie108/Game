using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
public class MonoEventBehavior : MonoBehaviour
{
    public UnityEvent startEvent, destroyEvent;

    void Start()
    {
        startEvent.Invoke();
    }

    private void OnDestroy()
    {
        destroyEvent.Invoke();
    }
}