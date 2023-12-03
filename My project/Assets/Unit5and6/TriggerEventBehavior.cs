using UnityEngine;
using UnityEngine.Events;
public class TriggerEventsBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private Collider colliderObj;

    private void Start()
    {
        colliderObj = GetComponent<Collider>();
        colliderObj.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}

