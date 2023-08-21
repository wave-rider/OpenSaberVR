using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandling : MonoBehaviour
{
    GameObject LeftController;
    GameObject RightController;

    GameObject LeftSaber;
    GameObject LeftShaft;
    GameObject LeftModel;

    GameObject RightSaber;
    GameObject RightShaft;
    GameObject RightModel;
    
    private void Start()
    {
        if (!IsSceneLoaded("Menu"))
        {
            StartCoroutine(LoadScene("Menu", LoadSceneMode.Additive));
        }

        //menusceneloaded?
    }

    internal IEnumerator LoadScene(string sceneName, LoadSceneMode mode)
    {
        if (sceneName == "OpenSaber")
        {
            //sabersceneloaded?
        }
        else if (sceneName == "Menu")
        {
           //menusceneloaded?
        }

        yield return SceneManager.LoadSceneAsync(sceneName, mode);
    }

    internal IEnumerator UnloadScene(string sceneName)
    {
        yield return SceneManager.UnloadSceneAsync(sceneName);
    }

    internal bool IsSceneLoaded(string sceneName)
    {
        var scene = SceneManager.GetSceneByName(sceneName);

        if (scene.name == null)
        {
            return false;
        }

        return true;
    }
}
