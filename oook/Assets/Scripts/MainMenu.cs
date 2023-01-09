using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene("Level1");// в кавычках название сцены на которую осуществляется переход
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("You was exit the game");
    }
    
}

/*public class OpenWeb : MonoBehaviour
{
    public void UrlOpen(string url)
    {
        Application.OpenURL(url);
    }
}
*/