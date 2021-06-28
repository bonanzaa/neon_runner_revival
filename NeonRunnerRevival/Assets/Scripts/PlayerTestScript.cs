using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NeonRunnerRevival.Assets.Scripts.Movement;

namespace NeonRunnerRevival
{
    public class PlayerTestScript : MonoBehaviour
    {
        private PlayerMovement _playerMovement;
        public bool Grounded = true;
        private float _timeToDie;

        void Start()
        {
            _playerMovement = GetComponent<PlayerMovement>();
        }

        public void PlayerFalling(){
            if(Grounded == false){
                StartCoroutine(GroundCheck());
            }
        }

        public IEnumerator GroundCheck(){
            float timer = 0f;

            if(_playerMovement.Dashing){
                _timeToDie = 0.15f;
            }else{
                _timeToDie = 0.01f;
            }

            while(timer < _timeToDie){
                if(Grounded){
                    yield break;
                }else{
                    timer += Time.deltaTime;
                    yield return new WaitForSeconds(Time.deltaTime);
                }
            }
            if(!Grounded)
            Destroy(this.gameObject);
        }
    }
}
