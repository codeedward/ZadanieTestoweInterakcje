using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Interactable
{
     public int InteractionDistance = 3;
     public override bool CanInteract(Transform position)
     {
          var rockPosition = gameObject.transform;
          var dist = Vector3.Distance(position.position, rockPosition.position);
          return dist < InteractionDistance;
     }
     public override void Interact() 
     {
          Debug.Log("Interacted with the Rock");
     }
}



