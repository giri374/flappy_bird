using UnityEngine;

public class TailAnimator : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] tailSprites;
    public float animationSpeed = 0.15f;
    private int SpriteIndex = 0;
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("AnimateTail", 0f, animationSpeed);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void AnimateTail()
    {
        if (tailSprites.Length == 0) return; // Check if there are any sprites to animate
        spriteRenderer.sprite = tailSprites[SpriteIndex];
        SpriteIndex = (SpriteIndex + 1) % tailSprites.Length; // Loop through the sprites
    }
}
