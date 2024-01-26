using UnityEngine;

[RequireComponent(typeof(SpriteRenderer), typeof(Animator))]
public class ClothingItemBehaviour : MonoBehaviour
{
    [field: SerializeField] public ClothingItemData Data { get; set; }

    private void Start()
    {
        UpdateVisuals();
    }

    public void UpdateVisuals()
    {
        var renderer = GetComponent<SpriteRenderer>();
        name = Data.ItemName;

        if (Data.Sprite != null)
            renderer.sprite = Data.Sprite;

        transform.localScale = Vector3.one;

    }
}