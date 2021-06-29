using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NeonRunnerRevival.Assets.Scripts;

namespace NeonRunnerRevival
{
    public class PauseMenu : MonoBehaviour
    {
        [SerializeField] private GameObject _pauseMenu;
        [SerializeField] private ScenesManager _scenesManager;

        private PlayerControls _controls;
        private bool _isPauseMenuActive = false;
        private void OnEnable()
        {
            _controls = new PlayerControls();
            _controls.Menu.MenuInteractions1.performed += OnMenuOpened;
            _controls.Menu.MenuInteractions1.Enable();
        }
        private void OnDisable()
        {
            _controls.Menu.MenuInteractions1.performed -= OnMenuOpened;
            _controls.Menu.MenuInteractions1.Disable();
        }
        private void OnMenuOpened(UnityEngine.InputSystem.InputAction.CallbackContext context)
        {               
            StopTimeForMenu();
        }
        public void ResumeGame()
        {
            Time.timeScale = 1;
            _pauseMenu.SetActive(false);
            _isPauseMenuActive = false;
        }
        public void ReloadScene()
        {
            _scenesManager.ResetScene(_scenesManager.GetCurrentSceneIndex());
            Debug.Log("You're reloading");
        }
        public void QuitGame()
        {
            _scenesManager.QuitGame();
            Debug.Log("Quitting");
        }

        private void StopTimeForMenu()
        {
            if (!_isPauseMenuActive)
            {
                Time.timeScale = 0;
                _pauseMenu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                _pauseMenu.SetActive(false);
            }
            _isPauseMenuActive = !_isPauseMenuActive;
        }
    }
}
