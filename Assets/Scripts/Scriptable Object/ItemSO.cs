
using UnityEngine;


namespace Inventory.Model
{
    [CreateAssetMenu(fileName = "ItemSO", menuName = "Scriptable Objects/ItemSO")]

    public class ItemSO : ScriptableObject
    {

        [field: SerializeField]
        public bool IsStackable { get; set; }
        public int ID => GetInstanceID();

        [field: SerializeField]
        public int MaxStackSize { get; set; } = 1;
        [field: SerializeField]
        public string Name { get; set; }
        [field: SerializeField]
        [TextArea]
        public string Description { get; set; }
        [field: SerializeField]
        public Sprite ItemImage { get; set; }

    }
}