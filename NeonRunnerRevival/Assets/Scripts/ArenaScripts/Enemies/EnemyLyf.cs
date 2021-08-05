using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

namespace NeonRunnerRevival.Assets.Scripts.ArenaScripts
{
    class EnemyLyf : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private bool _isCluster;

        private float _explosionRange = 3f;
        public void TakeDamage(int damage)
        {
            _health -= damage;
            if (_health <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            if (_isCluster)
            {
                Explode();
            }
            else
            {
                Destroy(gameObject);
            }
        }
        //copied from neon runner
        private void Explode()
        {
            var hitColliders = Physics2D.OverlapCircleAll(transform.position, _explosionRange);

            foreach (var hit in hitColliders)
            {
                if(hit.TryGetComponent(out PlayerMarker playerMarker))
                {
                    //playerHealth, not marker, take damage or whatever it's called
                    Debug.Log($"Hit {hit.name} boom boom change to Player Health");
                }
            }
            Destroy(gameObject);
        }

        [Button]
        public void TakeDamage()
        {
            _health -= 1;
            if (_health <= 0)
            {
                Die();
            }
        }

    }
}
