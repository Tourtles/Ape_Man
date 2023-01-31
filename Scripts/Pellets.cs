using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellets : MonoBehaviour
{
    public GameHandler GH;
    public AudioClip pelletsSound;
    // Start is called before the first frame update
    void Start()
    {
        GH  = GameObject.Find("Pellets").GetComponent<GameHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        
        Destroy(gameObject);
    }

}