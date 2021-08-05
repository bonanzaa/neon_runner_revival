using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NeonRunnerRevival.Assets.Scripts.Manager;

namespace NeonRunnerRevival
{
    public class TurretRangeDetector : MonoBehaviour
    {

        public float DetectionRange = 10f;
        public bool ExtendedDetectionRange = false;
        public float ForgetRange = 15f;
        private bool _searching = false;
        private bool _shooting = false;
        private bool _playerInRange = false;
        private float _distance;
        private Vector3 _playerPos;
        [SerializeField]
        private GameObject _turret;

        private void Update()
        {
            DistanceCheck();
        }

        private void DistanceCheck()
        {
            UpdatePlayerPos();
            if (!ExtendedDetectionRange)
            {
                StartCoroutine(RangeDetection());
            }
            else
            {
                StartCoroutine(ExtendedRangeDetection());
            }
        }

        private void UpdatePlayerPos()
        {
            _playerPos = PlayerTracker.Instance.Player.transform.position;
        }

        private IEnumerator RangeDetection(){
            while(true && _playerPos != null){

                _distance = (_playerPos - transform.position).magnitude;
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
            while(true && _playerPos != null){
                _distance = (_playerPos - transform.position).magnitude;

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
            while(_shooting && _playerPos != null){

                // rotating the turret, to face the player
                Vector2 Direction = _playerPos - transform.position;
                float angle = Mathf.Atan2(Direction.y, Direction.x);
                _turret.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle * Mathf.Rad2Deg - 90));

                yield return new WaitForSeconds(Time.deltaTime);
            }
            yield break;
        }
 

        void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, DetectionRange);
            
            if(ExtendedDetectionRange){
                Gizmos.color = Color.green;
                Gizmos.DrawWireSphere(transform.position, ForgetRange);
            }
        }


    }
}
