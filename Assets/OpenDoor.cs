using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : Interactible
{
    SpriteRenderer sprite;

    void Start() 
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    public override void Interact()
    {
        sprite.color = new Color (255, 127, 127, 255);
    }

}
