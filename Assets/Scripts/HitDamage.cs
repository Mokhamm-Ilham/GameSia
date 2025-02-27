using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDamage : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update

    public Color originalColor;

    public Color hitColor = Color.red;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log(spriteRenderer.color)
        spriteRenderer.color = hitColor;
    }

    void OnCollisionExit2D(Collision2D collision){
        spriteRenderer.color = Color.white;
        
    }
}
