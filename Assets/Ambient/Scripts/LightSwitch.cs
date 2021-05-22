using UnityEngine;

public class LightSwitch : Interactible
{
    [SerializeField] private GameObject lamp;

        public override void Interact()
    {
        lamp.SetActive(!lamp.activeSelf);
    }
}
