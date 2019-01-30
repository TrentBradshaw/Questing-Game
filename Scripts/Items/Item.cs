using UnityEngine;

[CreateAssetMenu(fileName ="New Item", menuName ="Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";    // Init the name of the item
    public Sprite icon = null;              //Init the Icon sprite
    public bool isDefaultItem = false;      // Init whether item is a default one or not
    
    public virtual void Use ()
    {
        Debug.Log("Using " + name);
    }
}
