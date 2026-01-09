using UnityEngine;
using System.Collections;

public class EnnemiPatrouille : MonoBehaviour
{
    public Collider solDeJeu; 

    public float vitesse = 14f;
    public float tempsAttente = 0.2f;

    private Vector3 destination;
    private bool enAttente = false;

    void Start()
    {
        ChoisirNouvelleDestination();
    }

    void Update()
    {
        if (enAttente) return;

        transform.position = Vector3.MoveTowards(transform.position, destination, vitesse * Time.deltaTime);

        if (Vector3.Distance(transform.position, destination) < 0.5f)
        {
            StartCoroutine(AttendreEtRepartir());
        }
    }

    IEnumerator AttendreEtRepartir()
    {
        enAttente = true;
        yield return new WaitForSeconds(tempsAttente);
        ChoisirNouvelleDestination();
        enAttente = false;
    }

    void ChoisirNouvelleDestination()
    {
        if (solDeJeu == null) return;

        Bounds limites = solDeJeu.bounds;
        
        float xAleatoire = Random.Range(limites.min.x, limites.max.x);
        float zAleatoire = Random.Range(limites.min.z, limites.max.z);

        destination = new Vector3(xAleatoire, transform.position.y, zAleatoire);
        transform.LookAt(destination);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GestionJoueur gestion = FindObjectOfType<GestionJoueur>();
            if(gestion != null) gestion.GagnerLaPartie();
            
            Destroy(gameObject);
        }
    }
    
    void OnDrawGizmos()
    {
        if (solDeJeu != null)
        {
            Gizmos.color = new Color(1, 0, 0, 0.3f);
            Gizmos.DrawCube(solDeJeu.bounds.center, solDeJeu.bounds.size);
        }
    }
}