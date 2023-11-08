using UnityEngine;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    private void OnTriggerEnter(Collider Other) 
    {
        Debug.Log(idObj);
    }
}
