using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeFish : MonoBehaviour
{
    
    public int halfX = 20;

    // Start is called before the first frame update
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
            transform.position = new Vector3(transform.position.x + xCoff,Mathf.Sin(Time.time), 0); 

            if (transform.position.x > 30)
            {
                transform.position= new Vector3(-30, 0, 0);
                
            }

            yield return new WaitForFixedUpdate();
        }
    }
    
    private void SetRandomValues()
    {
        xCoff = Random.Range(0.05f, 0.15f);
        yCoff1 = Random.Range(0.5f, 1f);
        yCoff2 = Random.Range(0.5f, 2f);
        //startY = 
    }
}
