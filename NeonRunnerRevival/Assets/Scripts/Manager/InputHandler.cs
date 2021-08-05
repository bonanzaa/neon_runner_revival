using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeonRunnerRevival.Assets.Scripts.Manager
{
    class InputHandler : MonoBehaviour
    {
        private PlayerControls _controls;
        [NonSerialized] public InputHandler Instance;

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
            _controls = new PlayerControls();
        }
        public PlayerControls GetInputReference()
        {
            return _controls;
        }
    }
}
