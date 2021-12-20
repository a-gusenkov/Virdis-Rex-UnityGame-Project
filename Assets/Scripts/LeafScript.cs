using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafScript : MonoBehaviour
{
    private Levels scoreKeeper;
    
    public int score = 0;
    public AudioSource leafSound;
    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = FindObjectOfType<Levels>();
        //sound
        if (leafSound == null){
            leafSound = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        //plays sound then destroys upon collision
        AudioSource.PlayClipAtPoint(GetComponent<AudioSource>().clip, transform.position);
        Destroy (gameObject);
        scoreKeeper.AddPoints();    
    }
    

}
