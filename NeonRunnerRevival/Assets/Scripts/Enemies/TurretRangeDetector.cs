using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeonRunnerRevival
{
    public class TurretRangeDetector : MonoBehaviour
    {
        public Transform Playerpos;
        public float DetectionRange = 10f;
        public bool ExtendedRange = false;
        public float ForgetRange = 15f;
        private bool _searching = false;
        private bool _shooting = false;
        private bool _playerInRange = false;
        private float _distance;

        private void Start() {
            if(!ExtendedRange){
                StartCoroutine(RangeDetection());
            }else{
                StartCoroutine(ExtendedRangeDetection());
            }
        }

        private IEnumerator RangeDetection(){
            while(true){

                _distance = (Playerpos.position - transform.position).magnitude;
                switch(_distance < DetectionRange){

                    case(false):
                    if(_searching){
                        break;
                    }
                    _shooting = false;
                    _searching = true;
                    StartCoroutine(Searching());
                    break;

                    case(true):
                    if(_shooting){
                        break;
                    }
                    _searching = false;
                    _shooting = true;
                    StartCoroutine(Shooting());
                    break;

                }
                yield return new WaitForSeconds(Time.deltaTime);
            }
        }

        private IEnumerator ExtendedRangeDetection(){
            while(true && Playerpos != null){
                _distance = (Playerpos.position - transform.position).magnitude;

                if(_distance < DetectionRange && !_playerInRange){
                    _playerInRange = true;
                    _searching = false;
                    _shooting = true;
                    StartCoroutine(Shooting());
                }else if(_playerInRange && _distance > ForgetRange){
                    _playerInRange = false;
                    _searching = true;
                    _shooting = false;
                    StartCoroutine(Searching());
                }

                yield return new WaitForSeconds(Time.deltaTime);
            }
        }


        private IEnumerator Searching(){
            print("Searching");
            // idle state
            // Execute some animations here or make enemies patrol the area
            while(_searching){
                yield return new WaitForSeconds(Time.deltaTime);
            }
            yield break;
        }

        private IEnumerator Shooting(){
            print("Shooting");
            // that's where the shooting happens
            while(_shooting && Playerpos != null){

                // rotating the turret, to face the player
                Vector2 Direction = Playerpos.position - transform.position;
                float angle = Mathf.Atan2(Direction.y, Direction.x);
                transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle * Mathf.Rad2Deg - 90));

                yield return new WaitForSeconds(Time.deltaTime);
            }
            yield break;
        }
 

        void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, DetectionRange);
            
            if(ExtendedRange){
                Gizmos.color = Color.green;
                Gizmos.DrawWireSphere(transform.position, ForgetRange);
            }
        }


    }
}
