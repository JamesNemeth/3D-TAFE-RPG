using System.Collections;
using UnityEngine;

public class Interact : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            Ray interactionRay;
            interactionRay = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            RaycastHit hitInfo;
            if(Physics.Raycast(interactionRay, out hitInfo, 10))
            {
                switch(hitInfo.collider.tag)
                {
                    case "NPC":
                        Debug.Log("NPC Interaction");
                    break;
                    case "Item":
                        Debug.Log("Picked up Item");
                    break;

                }
                /*
                if (hitInfo.collider.CompareTag("NPC"))
                {
                    Debug.Log("NPC Interaction");
                }
                if (hitInfo.collider.CompareTag("Item"))
                {
                    Debug.Log("Pick up Item");
                }
                */
            }
        }
    }
}
