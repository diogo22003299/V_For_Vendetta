using UnityEngine;

public class HideOnCloset : Interactible
{
    [SerializeField] private Movement playerMovement;
    [SerializeField] private SpriteRenderer playerRender;

    public override void Interact()
    {
        playerMovement.enabled = !playerMovement.enabled;
        playerRender.enabled = !playerRender.enabled;
    }
}
