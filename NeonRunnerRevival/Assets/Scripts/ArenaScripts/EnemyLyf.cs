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
