using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : Interactable
{
     public int InteractionDistance = 2;
     public override bool CanInteract(Transform position)
     {
          var treePosition = gameObject.transform;
          var dist = Vector3.Distance(position.position, treePosition.position);
          return dist < InteractionDistance;
     }
     public override void Interact() 
     {
          Debug.Log("Interacted with the Tree");
     }
}



