using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NeonRunnerRevival.Assets.Scripts.Movement;

namespace NeonRunnerRevival
{
    public class PlayerGroundCheck : MonoBehaviour
    {
        private PlayerMovement _playerMovement;
        public bool Grounded = true;
        private float _timeToDie;

        void Start()
        {
            _playerMovement = GetComponent<PlayerMovement>();
        }

        public void PlayerFalling(){
            if(!Grounded){
                StartCoroutine(GroundCheck());
            }
        }

        public IEnumerator GroundCheck(){
            float timer = 0f;

            if(_playerMovement.Dashing){
                _timeToDie = 0.2f;
            }else{
                print("Player DIED!!!");
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
            //Destroy(this.gameObject);
                print("PLAYE HAS DIED!!!");
            yield break;
        }
    }
}
