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

        // bu deiþkenler joistickleri deðiþkenlere atamak için 
        private Vector2 movement;  
        internal Vector2 rotation;

        // hýz deðiþkenlerim 
        internal float speed = 5f;
        internal float _rotSpeed = 80f;

       
        private void Update()
        {

            // joistick haraket tanýtým 
            movement.x = joystick.Horizontal;
            movement.y = joystick.Vertical;
            Vector3 _movement = new Vector3(movement.x, movement.y, 0);
            transform.position += _movement * Time.deltaTime * speed;


            // joistick Rotation için 
            rotation.x = rotjoistick.Horizontal;
            rotation.y = rotjoistick.Vertical;
            transform.Rotate(new Vector3(0, 0, rotation.x) * _rotSpeed * Time.deltaTime);
        }
    }
}

