using NeonRunnerRevival.Assets.Scripts.Manager;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeonRunnerRevival
{
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] private float _speed;
        private Rigidbody2D _rigidBody;
        private void Start()
        {
            _rigidBody = GetComponent<Rigidbody2D>();
        }
        private void FixedUpdate()
        {
            Move(UpdatePlayerPosition());
        }

        private void Move(Vector3 goal)
        {
            Vector3 playerPos = goal;
            Vector2 direction = (playerPos - transform.position).normalized;

            float angle = Mathf.Atan2(direction.y, direction.x);

            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle * Mathf.Rad2Deg + 90));

            _rigidBody.velocity = direction *_speed * Time.deltaTime;
        }

        private Vector3 UpdatePlayerPosition()
        {
            if(PlayerTracker.Instance != null){
                return PlayerTracker.Instance.Player.transform.position;
            }else{
                return Vector3.zero;
            }
        }
    }
}
