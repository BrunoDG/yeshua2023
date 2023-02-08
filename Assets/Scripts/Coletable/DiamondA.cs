using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondA : MonoBehaviour , IInteractable
{
  
    public static bool enabledIten = true;
    void Start()
    {
        enabledIten = true;
    }

   
    public void Interact()
    {
         if(enabledIten) // checa  o item  se e  true
         {
            gameObject.SetActive(false); // Desativa objeto 
         }
        
    }
}
