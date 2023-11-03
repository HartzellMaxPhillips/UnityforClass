using UnityEngine;

[CreateAssetMenu(fileName = "New Int Data", menuName = "Int Data")]
public class IntData : MonoBehaviour
{
    [SerializeField] private int value;
    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }
}
