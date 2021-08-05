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

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            transform.position = Vector2.MoveTowards(this.transform.position, UpdatePlayerPosition(), _speed * Time.deltaTime);
        }

        private Vector3 UpdatePlayerPosition()
        {
            return PlayerTracker.Instance.Player.transform.position;
        }
    }
}
