using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVICS : MonoBehaviour
{

    public GameObject doll;
    public GameObject VICS;
    public Transform spawnPoint; 

    private bool vicspresent;   
    
    // Start is called before the first frame update
    void Start()
    {
           vicspresent = false;     
    }

    // Update is called once per frame
    void Update()
    {
                
    }

     public void spawnvics(){

        if(vicspresent == false){
            Instantiate(VICS, spawnPoint.position, spawnPoint.rotation);
            vicspresent = true;
        } else {
            Debug.Log("there is already a vics");
        }
        
    }
}
