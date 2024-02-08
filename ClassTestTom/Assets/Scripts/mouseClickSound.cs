using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using UnityEngine.EventSystems;
using FMODUnity;


public class mouseClickSound : MonoBehaviour
{

    [SerializeField] private FMODUnity.StudioEventEmitter fmodEvent;
    [SerializeField] private GameObject sphere;
 


    private void OnMouseEnter()
    {

        fmodEvent.Play();
    }


    private void OnMouseExit()
    {
        
        fmodEvent.Stop();
    }
   

   
}
