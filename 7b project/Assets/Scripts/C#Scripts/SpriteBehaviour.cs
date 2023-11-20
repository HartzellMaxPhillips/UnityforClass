using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviour : MonoBehaviour
{
    public SpriteRenderer rendererObj;

    // Start is called before the first frame update
    void Awake()
    {
        rendererObj = GetComponent<SpriteRenderer>();

        // Check if the SpriteRenderer is found
        if (rendererObj == null)
        {
            Debug.LogError("SpriteRenderer not found on GameObject: " + gameObject.name);
        }
    }

    public void ChangeRendererColor(ColorID obj) 
    {
        if (rendererObj != null)
        {
            rendererObj.color = obj.value;
        }
        else
        {
            Debug.LogError("SpriteRenderer is not initialized. Check the Start method.");
        }
    }
}