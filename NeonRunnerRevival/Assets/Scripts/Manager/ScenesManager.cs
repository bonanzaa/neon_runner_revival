using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace NeonRunnerRevival
{
    public class ScenesManager : MonoBehaviour
    {
        public int GetCurrentSceneIndex()
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            return index;
        }
        public void ResetScene(int index)
        {
            SceneManager.LoadScene(GetCurrentSceneIndex());
        }
        public void QuitGame()
        {
            Debug.Log("Quitting Game");
            Application.Quit();
        }
    }
}
