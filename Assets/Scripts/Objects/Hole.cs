using UnityEngine;

public class Hole : MonoBehaviour
{

    public bool is_hole_active { get; set; }
    public bool is_hole_occupied {  get; set; }
    [SerializeField] SpriteRenderer holeSpriteRenderer;

    void Start()
    {
        is_hole_active = true;
        is_hole_occupied = false;
    }

    private void ChangeColor()
    {
        if (!is_hole_active)
        {
            holeSpriteRenderer.color = Color.black;
        }

        else
        {
            holeSpriteRenderer.color = Color.white;
        }
    }

}
