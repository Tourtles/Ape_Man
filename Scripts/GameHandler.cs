using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameHandler : MonoBehaviour
{
    public TextMeshProUGUI PelletsText;
    public int pellets;

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D Col)
    {
        if(Col.gameObject.tag == "Pellets")
        {
            //Debug.Log("Pellets Collected!");
            pellets = pellets + 1;
            //Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
            PelletsText.text = "Pellets : " + pellets;
        }
    }
}