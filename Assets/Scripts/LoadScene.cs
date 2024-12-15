using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    public void LoadMenu() {
        LoadLevelByName("Menu");
    }

    public void LoadLocation() {
        LoadLevelByName("Location");
    }

    private void LoadLevelByName(string name) {
        SceneManager.LoadScene(name);
    }
}
