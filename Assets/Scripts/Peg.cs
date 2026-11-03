using UnityEngine;
using System.Collections.Generic;

public class Peg : MonoBehaviour
{
    public List<Sprite> Sprites;
    public Sounds Sounds;
    private int currentSpriteNumber = 0;
    private SpriteRenderer spriteRenderer;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag ("Ball"))
        {
            OnBallHit();
        }
    }

    private void OnBallHit()
    {
        // if no more sprites to show
            // disappear
            if (NoMoreSprites())
            {
                Sounds.PlayPegDestroySound();
                Destroy(gameObject);
            }
            //else
            else
            {
                Sounds.PlayPegHitSound();
                ShowNextSprite();
            }
            // show next sprite
    }
    private void ShowNextSprite()
    {

        
        currentSpriteNumber++;
        spriteRenderer.sprite = Sprites[currentSpriteNumber];
    }

    private bool NoMoreSprites()
    {
        if (currentSpriteNumber == 2)
        {
            // bye bye
            return true;
        }

        return false;
    }
}

