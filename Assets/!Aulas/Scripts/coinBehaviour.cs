using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBehaviour : MonoBehaviour
{

    public GameObject ScoreObj;
    public GameObject CoinSound;


    private void Start()
    {
        ScoreObj = GameObject.Find("Score");
        CoinSound = GameObject.Find("CoinSound");
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        //  Debug.Log("GameObject1 collided with " + col.name);


        if (col.gameObject.name == "Character")
        {

            ScoreObj.GetComponent<ScoreScript>().ScoreValue++;
            CoinSound.GetComponent<AudioSource>().Play();
            Destroy(gameObject);

        }

    }



}
