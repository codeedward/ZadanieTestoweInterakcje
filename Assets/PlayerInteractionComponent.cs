using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionComponent : MonoBehaviour
{
    private Interactable InteractableObject;
    public readonly string InteractableTag = "Interactable";

    void OnTriggerEnter(Collider other) 
    {        
        if(other.tag == InteractableTag) {
            //Debug.Log("Reported enter:" + other.gameObject.name);
            InteractableObject = other.gameObject.GetComponent<Interactable>();
        }
    }

    void OnTriggerExit(Collider other) 
    {        
        if(other.tag == InteractableTag) {
            //Debug.Log("Reported exit:" + other.gameObject.name);
            InteractableObject = null;
        }
    }

    public void InteractWithInteractable()
    {
        if(InteractableObject != null)
        {   
            var canInteract = InteractableObject.CanInteract(gameObject.transform);
            if(canInteract)
            {   
                InteractableObject.Interact();
            }
        }
    }

    void Update()
    {
      if (Input.GetKeyUp(KeyCode.E))
      {
          InteractWithInteractable();
      }
    }
}