using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUpGaragem : MonoBehaviour, IInteractable
{
    public GameObject DoorNew;
    public GameObject character;
    private   PuzzleGaragem puzzle;
    public static bool UpGarageEnableEngrenagem = false;
    [SerializeField]private UIController uIController;
    
    public void Interact()
    {
        NewPositionGaragem();
    }
    void Start()
    {
        puzzle =  FindObjectOfType<PuzzleGaragem>() as PuzzleGaragem;
    }
    public void NewPositionGaragem()
    {
        if (puzzle.Enablepuzzle)
        {
            if(UpGarageEnableEngrenagem)
            {
                 Debug.Log("Parabens Vc Abriu  uma porta");
                character.transform.position = new Vector3(DoorNew.transform.position.x, DoorNew.transform.position.y, DoorNew.transform.position.z);
            }else
            {
                uIController.MessageItenToTake.gameObject.SetActive(true);
                //Debug.Log("Rotacione com a manivela a Engrenagem");
            }
           
        }
       
    }
}
