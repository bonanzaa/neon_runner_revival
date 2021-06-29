﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NeonRunnerRevival.Assets.Scripts.Manager
{
    class InputHandler : MonoBehaviour
    {
        private PlayerControls _controls;
        public InputHandler Instance;
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
            _sceneManager.ResetScene(_sceneManager.GetCurrentSceneIndex());
        }
    }
}
