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

        // bu dei�kenler joistickleri de�i�kenlere atamak i�in 
        internal Vector2 movement;  
        //internal Vector2 rotation;
        //internal Vector3 _movement;
        private void Start()
        {
             rb = GetComponent<Rigidbody2D>();
        }
        // h�z de�i�kenlerim 
        internal float speed = 2f;
        private float _dashSpeed = 8;
        private float _dashDuration = 0.5f;
        private bool _isDashing;
        private bool _isPres = false;

        private void Update()
        {

            // joistick haraket tan�t�m 
            movement.x = Input.GetAxis("Horizontal");/*joystick.Horizontal;*/
            movement.y = Input.GetAxis("Vertical");/*joystick.Vertical;*/
            rb.velocity = new Vector2(movement.x * speed, movement.y * speed);

            if (_isPres == true)
            {

                StartCoroutine(Dashs());

            }

            // dash yapabilmek i�in haraket kodlar� yenilendi
            //_movement = new Vector3(movement.x, movement.y, 0);
            //transform.position += _movement * Time.deltaTime * speed;


            // joistick Rotation i�in 
            //rotation.x = rotjoistick.Horizontal;
            //rotation.y = rotjoistick.Vertical;
            //transform.Rotate(new Vector3(0, 0, rotation.x) * _rotSpeed * Time.deltaTime);
        }
        private IEnumerator Dashs()
        {
            _isDashing = true;
            rb.velocity = new Vector2(movement.x * _dashSpeed, movement.y * _dashSpeed);
            yield return new WaitForSeconds(_dashDuration);
            _isDashing = false;
        }
        public void Pres() 
        {

          _isPres = true;
        }
        public void StopPres()
        {

            _isPres = false;
        
        }

    }
}

