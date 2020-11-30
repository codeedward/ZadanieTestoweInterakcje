using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
     public virtual bool CanInteract(Transform position) 
     { 
        Debug.Log("Interactable:CanInteract");
        return false; 
     }
     
     public virtual void Interact() 
     {
        Debug.Log("Interactable:Interact");
     }
}



