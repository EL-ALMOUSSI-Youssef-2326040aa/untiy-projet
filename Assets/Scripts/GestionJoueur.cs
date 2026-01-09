using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GestionJoueur : MonoBehaviour
{
    public TextMeshProUGUI texteChronoUI;
    public GameObject ecranVictoire;
    public GameObject ecranDefaite;

    public float altitudeChute = -10f;

    private float tempsEcoule = 0f;
    private bool jeuEstLance = false;
    private bool partieTerminee = false;

    void Start()
    {
        // C'EST ICI QUE TU APPUIES SUR LECTURE
        Time.timeScale = 1;

        if (ecranVictoire != null) ecranVictoire.SetActive(false);
        if (ecranDefaite != null) ecranDefaite.SetActive(false);
        if (texteChronoUI != null) texteChronoUI.text = "Trouve la pièce !";

        DemarrerLeJeu();
    }

    void Update()
    {
        if (partieTerminee) return;

        if (jeuEstLance)
        {
            tempsEcoule += Time.deltaTime;
            if (texteChronoUI != null) texteChronoUI.text = "Temps : " + tempsEcoule.ToString("F2") + "s";
        }

        if (transform.position.y < altitudeChute)
        {
            PerdreLaPartie();
        }
    }

    public void DemarrerLeJeu()
    {
        jeuEstLance = true;
        tempsEcoule = 0f;
    }

    public void GagnerLaPartie()
    {
        if (partieTerminee) return;

        partieTerminee = true;
        jeuEstLance = false;

        if (ecranVictoire != null) ecranVictoire.SetActive(true);
        Time.timeScale = 0;
    }

    public void PerdreLaPartie()
    {
        if (partieTerminee) return;

        partieTerminee = true;
        jeuEstLance = false;

        if (ecranDefaite != null) ecranDefaite.SetActive(true);
        Time.timeScale = 0;
    }

    public void RetourAuMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}