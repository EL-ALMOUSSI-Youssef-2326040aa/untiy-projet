using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmeJoueur : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider infoObjet)
    {
        // Si l'épée touche un objet avec le tag "Ennemi"
        if (infoObjet.CompareTag("Ennemi"))
        {
            infoObjet.GetComponent<EnnemiPatrouille>().RecevoirDegats();
        }
    }
}
