using System.Collections;
using System.Collections.Generic;
using Twoplayers.Enamy;
using Twoplayers.Player;
using UnityEngine;

public class RaycastControlers : MonoBehaviour
{
    private float distance = 10;
    private float speed =30;

    private GameObject enamys;
    private GameObject player;


    private void Start()
    {
        enamys = GameObject.Find("enamy");
        player = GameObject.Find("Player");
      
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
                enamys.transform.position = Vector2.Lerp(enamys.transform.position, player.transform.position, 10 * Time.deltaTime);
            }

        }
        else
        {
           
            Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
        }

    }
  
    private void Update()
    {
        RayCast();
       
    }
}
