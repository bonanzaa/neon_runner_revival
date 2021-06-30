using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeonRunnerRevival.Assets.Scripts.Manager
{
    [RequireComponent(typeof (ScenesManager))]
    class InputHandler : MonoBehaviour
    {
        private PlayerControls _controls;
        [NonSerialized] public InputHandler Instance;
        private ScenesManager _sceneManager;

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
            _sceneManager = GetComponent<ScenesManager>();
        }

        private void OnEnable()
        {
            _controls.TreadmillControls.DEBUG_RESET.performed += OnDebugReset;
            _controls.TreadmillControls.DEBUG_RESET.Enable();
        }
        private void OnDisable()
        {
            _controls.TreadmillControls.DEBUG_RESET.performed -= OnDebugReset;
            _controls.TreadmillControls.DEBUG_RESET.Disable();
        }
        public PlayerControls GetInputReference()
        {
            return _controls;
        }

        public void OnDebugReset(UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
            _sceneManager.ReloadScene();
        }
    }
}
