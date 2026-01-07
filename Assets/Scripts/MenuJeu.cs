using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuJeu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rejouer()
    {
        Time.timeScale = 1; // On remet le temps normal
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Recharge la scène
    }

    public void QuitterJeu()
    {
        Debug.Log("Quitter le jeu");
        Application.Quit();
    }
}
