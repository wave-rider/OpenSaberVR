using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

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

    void EnsureControllers()
    {
        LeftController = GameObject.FindWithTag("LeftController");
        RightController = GameObject.FindWithTag("RightController");
    }
    void OnMenuLoaded()
    {
        EnsureControllers();
        LeftController.GetComponent<Saber>().SetSaberVisibility(false);
        LeftController.GetComponent<XRRayInteractor>().enabled = true;
        LeftController.GetComponent<LineRenderer>().enabled = true;
        LeftController.GetComponent<XRInteractorLineVisual>().enabled = true;

        RightController.GetComponent<Saber>().SetSaberVisibility(false);
        RightController.GetComponent<XRRayInteractor>().enabled = true;
        RightController.GetComponent<LineRenderer>().enabled = true;
        RightController.GetComponent<XRInteractorLineVisual>().enabled = true;
    }
    void OnSaberLoaded()
    {
        EnsureControllers();
        LeftController.GetComponent<Saber>().SetSaberVisibility(true);
        LeftController.GetComponent<XRRayInteractor>().enabled = false;
        LeftController.GetComponent<LineRenderer>().enabled = false;
        LeftController.GetComponent<XRInteractorLineVisual>().enabled = false;

        RightController.GetComponent<Saber>().SetSaberVisibility(true);
        RightController.GetComponent<XRRayInteractor>().enabled = false;
        RightController.GetComponent<LineRenderer>().enabled = false;
        RightController.GetComponent<XRInteractorLineVisual>().enabled = false;
    }

    private void Start()
    {
        if (!IsSceneLoaded("Menu"))
        {
            StartCoroutine(LoadScene("Menu", LoadSceneMode.Additive));
        }
        //EnsureControllers();
        OnMenuLoaded();
    }

    internal IEnumerator LoadScene(string sceneName, LoadSceneMode mode)
    {
        if (sceneName == "OpenSaber")
        {
            //OnSaberLoaded();
            OnSaberLoaded();
        }
        else if (sceneName == "Menu")
        {
            //OnMenuLoaded();
            OnMenuLoaded();
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
