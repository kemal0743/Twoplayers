using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
namespace Twoplayers.Player 
{
    public class JoistickControlers : MonoBehaviour
    {
        // joistick//
        [SerializeField] FixedJoystick joystick;
        //[SerializeField] FixedJoystick rotjoistick;
        internal Rigidbody2D rb;
        DashControlers dashControlers;

        // bu deiþkenler joistickleri deðiþkenlere atamak için 
        internal Vector2 movement;  
        //internal Vector2 rotation;
        internal Vector3 _movement;
        private void Start()
        {
             rb = GetComponent<Rigidbody2D>();
            dashControlers = GetComponent<DashControlers>();
        }
        // hýz deðiþkenlerim 
        internal float speed = 5f;
        internal float _rotSpeed = 80f;
        private float dashSpeed = 20;
        private float dashDuration = 0.5f;
        private bool isDashing;

        private void Update()
        {

            // joistick haraket tanýtým 
            movement.x = joystick.Horizontal;
            movement.y = joystick.Vertical;
            rb.velocity = new Vector2(movement.x * speed, movement.y * speed);

            if(Input.GetKey(KeyCode.Space)) 
            {


                StartCoroutine(Dashs());
            
            }

            
            // dash yapabilmek için haraket kodlarý yenilendi
            //_movement = new Vector3(movement.x, movement.y, 0);
            //transform.position += _movement * Time.deltaTime * speed;


            // joistick Rotation için 
            //rotation.x = rotjoistick.Horizontal;
            //rotation.y = rotjoistick.Vertical;
            //transform.Rotate(new Vector3(0, 0, rotation.x) * _rotSpeed * Time.deltaTime);
        }
        private IEnumerator Dashs()
        {

            isDashing = true;
            rb.velocity = new Vector2(movement.x * dashSpeed, movement.y * dashSpeed);
            yield return new WaitForSeconds(dashDuration);
            isDashing = false;


        }
    }
}

