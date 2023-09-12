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

        // bu deiþkenler joistickleri deðiþkenlere atamak için 
        internal Vector2 movement;  
        //internal Vector2 rotation;
        //internal Vector3 _movement;
        private void Start()
        {
             rb = GetComponent<Rigidbody2D>();
        }
        // hýz deðiþkenlerim 
        internal float speed = 2f;
        private float _dashSpeed = 8;
        private float _dashDuration = 0.5f;
        private bool _isDashing;
        private bool _isPres = false;

        private void Update()
        {

            // joistick haraket tanýtým 
            movement.x = Input.GetAxis("Horizontal");/*joystick.Horizontal;*/
            movement.y = Input.GetAxis("Vertical");/*joystick.Vertical;*/
            rb.velocity = new Vector2(movement.x * speed, movement.y * speed);

            if (_isPres == true)
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

