using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeFish : MonoBehaviour
{
    public int halfX = 20;

    /* Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpdatePosition());
    }

    float xCoff;
    float yCoff1;
    float yCoff2;
    float startY;
    IEnumerator UpdatePosition()
    {
        SetRandomValues();

        for (; ;)
        {
            transform.position = /********** TO BE FILLED *********/
    /*
            if (transform.position.x > 30)
            {
                /********** TO BE FILLED *********/
                /********** TO BE FILLED *********/
            }

            /***************** TO BE FILLED ****************//*
        }
    }

    private void SetRandomValues()
    {
        xCoff = Random.Range(0.005f, 0.015f);
        yCoff1 = Random.Range(0.5f, 1f);
        yCoff2 = Random.Range(0.5f, 2f);
        startY = /********** TO BE FILLED *********/
    /*}
}
*/