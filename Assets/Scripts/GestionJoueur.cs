using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionJoueur : MonoBehaviour
{
    public bool aLaCle = false;
    public int score = 0;
    
    public GameObject ecranDefaite;
    public TextMeshProUGUI texteScoreUI; // La case pour glisser ton texte

    void Start()
    {
        // Au démarrage, on affiche 0
        MettreAJourTexte();
    }

    public void Mourir()
    {
        Debug.Log("Le joueur est mort !");
        if(ecranDefaite != null)
        {
            ecranDefaite.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void AjouterScore(int points)
    {
        score = score + points;
        MettreAJourTexte(); // On met à jour l'affichage
    }

    // Petite fonction pour éviter de répéter le code
    void MettreAJourTexte()
    {
        if (texteScoreUI != null)
        {
            texteScoreUI.text = "Score : " + score;
        }
        else 
        {
            Debug.Log("Oubli : Tu n'as pas relié le TexteScoreUI dans l'Inspector !");
        }
    }
}
