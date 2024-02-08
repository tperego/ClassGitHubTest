using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseTracker : MonoBehaviour
{

    [SerializeField] private Camera mainCamera;
    private Vector3 raycastHit;

    private void Update()
    {
        

        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
           
            transform.position = raycastHit.point;
        }



        Debug.Log(Input.mousePosition);
        // Debug.Log(Vector3.Distance(sphere.transform.position, cursorPosition));
        //Debug.Log(mainCamera.ScreenToWorldPoint(Input.mousePosition));
        //Vector3 mouseWorldPostiion = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        //mouseWorldPostiion.z = 0f;
        //transform.position = mouseWorldPostiion;
    }
}
