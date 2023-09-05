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
        [SerializeField] FixedJoystick rotjoistick;

        // bu dei�kenler joistickleri de�i�kenlere atamak i�in 
        private Vector2 movement;  
        internal Vector2 rotation;

        // h�z de�i�kenlerim 
        internal float speed = 5f;
        internal float _rotSpeed = 80f;

       
        private void Update()
        {

            // joistick haraket tan�t�m 
            movement.x = joystick.Horizontal;
            movement.y = joystick.Vertical;
            Vector3 _movement = new Vector3(movement.x, movement.y, 0);
            transform.position += _movement * Time.deltaTime * speed;


            // joistick Rotation i�in 
            rotation.x = rotjoistick.Horizontal;
            rotation.y = rotjoistick.Vertical;
            transform.Rotate(new Vector3(0, 0, rotation.x) * _rotSpeed * Time.deltaTime);
        }
    }
}

