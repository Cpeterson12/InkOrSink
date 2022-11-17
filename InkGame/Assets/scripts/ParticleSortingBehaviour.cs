using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ParticleSortingBehaviour : MonoBehaviour
{
    public GameObject particleMan;
    public ParticleSystem particleStm;
    void Start()
    {
        particleStm.GetComponent<ParticleSystemRenderer>().sortingLayerName = "Player";
    }
    
    void Update()
    {
        
    }
}
