using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{

    public GameObject DoorNew;
    public GameObject character;
  
    public void Interact()
    {
        newPosition();
        Debug.Log(" Porta Aberta");
    }
    public void newPosition()
    {
        character.transform.position = new Vector3(DoorNew.transform.position.x, DoorNew.transform.position.y, DoorNew.transform.position.z);
    }
    
}
