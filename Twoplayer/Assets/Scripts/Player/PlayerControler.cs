using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Twoplayers.Player 
{

    public class PlayerControler : MonoBehaviour
    {
        // fizik 
        Rigidbody2D _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

    }   


}

