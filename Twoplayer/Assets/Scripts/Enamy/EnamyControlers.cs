using System.Collections;
using System.Collections.Generic;
using Twoplayers.Player;
using UnityEngine;
using UnityEngine.UI;

namespace Twoplayers.Enamy 
{

    public class Enamycontrolers : MonoBehaviour
    {
        [Header(" scripts")]
        [SerializeField] PlayerControler _players;
        [SerializeField] GameObject _player;

        [SerializeField] GameObject _tarretPanel;

        [SerializeField] Text EnamyText;

        private void Start()
        {
            _player = GameObject.Find("Player");
            EnamyText = _player.GetComponent<Text>();
        }

        [Header(" takip etme hýzý ")]
        float _Speed = 0.1f;

        [Header("belirlenen mesafe")]
        [SerializeField] float distanceBetween;
        private float _distance;
    

        private void Update()
        {
            AýControl();
        }

        private void AýControl()
        {
            _distance = Vector2.Distance(transform.position, _players.transform.position);
            if(_distance < distanceBetween ) 
            {
               Fallow();
                _tarretPanel.SetActive(false);
            }
            else 
            {
                _tarretPanel.SetActive(true);

                GotoBack();

            }

        }

        private void Fallow() 
        {
            transform.position = Vector2.MoveTowards(this.transform.position, _players.transform.position, _Speed * Time.deltaTime);
        }
        private void GotoBack()
        {
            transform.position = Vector2.Lerp(transform.position, Vector2.zero, 1f * Time.deltaTime);
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.collider.tag == ("Wall")) 
            {

                
            
            }
                
        }
    }
}

