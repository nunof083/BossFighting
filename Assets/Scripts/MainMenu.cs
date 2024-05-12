using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None; // j'ai fait ça parce que j'ai un script qui lock le curseur dans le jeu
        // désactiver la scène de jeu au démarrage
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(1)); // index 1 pour la deuxième scène
        foreach (GameObject go in SceneManager.GetActiveScene().GetRootGameObjects())
        {
            go.SetActive(false);
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(1); // index 1 pour charger la deuxième scène (j'aurais pu mettre le nom de la scène comme une string)
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player has quit the game.");
    }
}
