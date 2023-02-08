using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondC : MonoBehaviour , IInteractable
{
    public static bool enabledIten = true;
    void Start()
    {
        enabledIten = true;
    }
       public void Interact()
    {
         if(enabledIten)
         {
            gameObject.SetActive(false);// Desativa objeto 
         }
    }
}
