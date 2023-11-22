using UnityEngine;

public class ColorIDBehavior : IDContainerBehaviour
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake() 
    {
        idObj = colorIDDataListObj.currentColor;
    }
}
