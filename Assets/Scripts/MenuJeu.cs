using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuJeu : MonoBehaviour
{
    public void LancerJeu()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitterJeu()
    {
        Application.Quit();
    }
}
