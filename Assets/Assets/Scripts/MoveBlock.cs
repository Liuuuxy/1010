using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
    public GameObject player;
    private float distance = 1;
    //private bool isMouseDown = false;
    // Update is called once per frame
    

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = camare2D.ScreenPointToRay (Input.mousePosition);
             if (Physics.Raycast(ray))
             {
            Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
                Vector3 playerPos = Camera.main.ScreenToWorldPoint(mousePos);
                player.transform.position = playerPos;
           // }
            
        }
        /*if(Input.GetMouseButtonDown(0))
        {
            isMouseDown = true;
        }
        if(Input.GetMouseButtonUp(0))
        {
            isMouseDown = false;
            lastMousePosition = Vector3.zero;
        }
        if(isMouseDown)
        {
            if (lastMousePosition != Vector3.zero)
            {
                Vector3 offset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - lastMousePosition;
                this.transform.position += offset;
            }
            lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }*/
    }
}
