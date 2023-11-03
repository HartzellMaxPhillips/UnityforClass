using UnityEngine;

[CreateAssetMenu(fileName = "New Float Data", menuName = "FloatData")]

public class FloatData : ScriptableObject
{
    [SerializeField] public float value
        {
        get { return value; }
        set { this.value = value; }
    }
    public void UpdateValue(float num) 
    {
        value += num;
    }
}
