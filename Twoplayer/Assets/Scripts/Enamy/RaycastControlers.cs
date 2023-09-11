using System.Collections;
using System.Collections.Generic;
using Twoplayers.Enamy;
using Twoplayers.Player;
using UnityEngine;

public class RaycastControlers : MonoBehaviour
{
    private float distance = 10;
    private float speed =30;

    Enamycontrolers enamycontrolers;
  

    private void Start()
    {
        enamycontrolers = new Enamycontrolers();
      
    }
    public void RayCast()
    {
        transform.Rotate(Vector3.forward * speed*Time.deltaTime);
        RaycastHit2D hit = Physics2D.Raycast(transform.position,transform.right,distance);
        if (hit.collider != null)
        {
            Debug.Log("koþul gerçekleþmedi");
            Debug.DrawLine(transform.position, hit.point, Color.red);
            if (hit.collider.tag == "Player")
            {

                enamycontrolers.GoEnamy();
            }

        }
        else
        {
            Debug.Log("what dedim");
            Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
        }

    }
    private void Update()
    {
        RayCast();
    }
}
