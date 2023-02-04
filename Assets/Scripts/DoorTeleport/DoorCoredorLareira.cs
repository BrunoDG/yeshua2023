using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCoredorLareira : MonoBehaviour , IInteractable
{
     public GameObject DoorNew;
    public GameObject character;
    [SerializeField]private string messagemDoorLaraeiraUp;
    [SerializeField]private UIController uIController;
     private void Start()
    {
         uIController.MessageItenToTake.text= messagemDoorLaraeiraUp;
    }
    public void Interact()
    {
        NewPositionLareira();
    }
     public void NewPositionLareira()
    {
        if (Key3.enabledKey)
        {
            
            Debug.Log("Parabens Vc Abriu  uma porta .");
            character.transform.position = new Vector3(DoorNew.transform.position.x, DoorNew.transform.position.y, DoorNew.transform.position.z);
        }
        else
        {
            uIController.MessageItenToTake.gameObject.SetActive(true);
            //Debug.Log("Voce nao Tem a Chave.");
        }
    }
}
