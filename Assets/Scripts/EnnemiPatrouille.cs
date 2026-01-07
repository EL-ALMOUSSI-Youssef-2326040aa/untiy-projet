using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiPatrouille : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float vitesse = 3f;
    private Transform destinationActuelle;

    void Start()
    {
        destinationActuelle = pointA;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destinationActuelle.position, vitesse * Time.deltaTime);

        if (Vector3.Distance(transform.position, destinationActuelle.position) < 0.1f)
        {
            if (destinationActuelle == pointA) destinationActuelle = pointB;
            else destinationActuelle = pointA;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<GestionJoueur>().Mourir();
        }
    }
    
    public void RecevoirDegats()
    {
        Destroy(gameObject);
    }
}
