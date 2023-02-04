using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene5P2Door5Rigth : MonoBehaviour , IInteractable
{
    public GameObject DoorNew;
    [SerializeField]private string messagemKeyOne;

    public GameObject character;
     
    [SerializeField]private UIController[] uIControllers;

    private void Start() 
    {
        uIControllers[0].MessageItenToTake.text= messagemKeyOne;
        uIControllers[1].MessageItenToTake.text= messagemKeyOne;
    }
    public void Interact()
    {
        NewPositionLareira();
    }
     public void NewPositionLareira()
    {
        if (Key3.enabledKey)
        {
            Debug.Log("Parabens Vc Abriu uma porta.");
            character.transform.position = new Vector3(DoorNew.transform.position.x, DoorNew.transform.position.y, DoorNew.transform.position.z);
            uIControllers[0].MessageItenToTake.gameObject.SetActive(true);
        }
        else
        {
            uIControllers[1].MessageItenToTake.gameObject.SetActive(true);
            Debug.Log("Voce nao Tem a Chave.");
        }
    }
}
