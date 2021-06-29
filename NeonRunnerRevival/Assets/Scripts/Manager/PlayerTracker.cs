using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeonRunnerRevival.Assets.Scripts.Manager
{
    class PlayerTracker : MonoBehaviour
    {
        public static PlayerTracker Instance;
        public PlayerMarker Player;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void CashPlayerReference(PlayerMarker player)
        {

            Player = player;
        }

    }
}
