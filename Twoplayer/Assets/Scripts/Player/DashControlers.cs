using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Twoplayers.Player 
{
    public class DashControlers : MonoBehaviour
    {
        float _kuvvet = 500;

        //scripst eriþim
        PlayerControler _players;
        JoistickControlers _controls;
        void Start()
        {
           _players = GetComponent<PlayerControler>();
            _controls =GetComponent<JoistickControlers>();
            InvokeRepeating("_Dash", 1f, 3f);
        }

      public void _Dash() 
        {
            _controls.speed = 0;
            _controls._rotSpeed = 0;
            _players.transform.position = transform.up * Time.deltaTime * _kuvvet;
            _controls.speed = 5f;
            _controls._rotSpeed = 80f;
        }
    }
}

