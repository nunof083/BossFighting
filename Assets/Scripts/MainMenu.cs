using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None; // j'ai fait �a parce que j'ai un script qui lock le curseur dans le jeu
        // d�sactiver la sc�ne de jeu au d�marrage
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(1)); // index 1 pour la deuxi�me sc�ne
        foreach (GameObject go in SceneManager.GetActiveScene().GetRootGameObjects())
        {
            go.SetActive(false);
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(1); // index 1 pour charger la deuxi�me sc�ne (j'aurais pu mettre le nom de la sc�ne comme une string)
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player has quit the game.");
    }
}
