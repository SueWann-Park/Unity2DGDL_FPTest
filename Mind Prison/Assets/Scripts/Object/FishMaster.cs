using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMaster : MonoBehaviour
{
    Sprite yellow;
    Sprite green;
    List<Transform> groups;

    // Start is called before the first frame update
//    void Start()
//    {
//        green = /***************** TO BE FILLED ****************/
//        yellow = /***************** TO BE FILLED ****************/
//        groups = new /***************** TO BE FILLED ****************/

//        StartCoroutine(/***************** TO BE FILLED ****************/);
//    }

//    IEnumerator LazyMaker()
//    {
//        for(; ;)
//        {
//            MakeFishes();
//            yield return new WaitForSeconds(5);
//        }
//    }

//    void MakeFishes()
//    {
//        if (groups.Count >= 5)
//            return;

//        // Initialize variables
//        int numFishes = /********** TO BE FILLED *********/
//        int dir = Random.Range(0, 2); // 0 : right, 1: left
//        int x = dir == 0 ? 20 : -20;
//        int y = Random.Range(-6, 9);
//        float moveCoff = Random.Range(0.025f, 0.05f);



//        // Each group's parent object
//        GameObject group = new GameObject(); 
//        groups.Add(group.transform);

//        group.transform.parent = /********** TO BE FILLED *********/
//        group.name = "Group" + /********** TO BE FILLED *********/.ToString();

//        group.transform.localScale = new Vector3(   dir == 1 ? -1 : 1   , 1, 1);
//        group.transform.position = new Vector2(x, y);



//        List<Coroutine> fishMoves = new List<Coroutine>();
//        for(int i = 0; i < numFishes; i++)
//        {
//            GameObject fish = /********** TO BE FILLED *********/
//            fish.name = "Fish" + /****** TO BE FILLED *****/.ToString();
//            fish.AddComponent<SpriteRenderer>().sprite = /********** TO BE FILLED *********/
//            fish.transform.parent = /********** TO BE FILLED *********/

//            fish.transform.localPosition = new Vector2(Random.Range(-2f, 2f), Random.Range(-1f, 1f));
//            fish.transform.localScale = Vector3.one;

//            Coroutine fishMove = StartCoroutine(/********** TO BE FILLED *********/);
//            fishMoves.Add(fishMove);
//        }

//        StartCoroutine(/********** TO BE FILLED *********/);
//    }



//    // Don't modify this function.
//    IEnumerator TwiggleFish(Transform t)
//    {
//        // y = c1 * sin(x * c2) + c3;
//        float[] coffs = new float[6];
//        for(int i =  0; i < 6; i++)
//        {
//            coffs[i] = Random.Range(-0.8f, 0.8f);
//        }
//        // Get random coefficients for sin function

//        for(; ;)
//        {
//            t.localPosition = new Vector3(coffs[0] * Mathf.Sin(Time.time * coffs[1]) + coffs[2],
//                0.8f * coffs[3] * Mathf.Sin(Time.time * coffs[4]) + 0.6f * coffs[5]);
//            yield return new WaitForFixedUpdate();
//        }
//    }



//    IEnumerator MoveGroup(Transform t, float moveCoff, List<Coroutine> fishMoves)
//    {
//        float accum = 0;
//        for(int z = 0; ;z++)
//        {
//            t.position += /********** TO BE FILLED *********/
//            accum += /********** TO BE FILLED *********/


//            if (accum >= 40)
//            {
//                /********** TO BE FILLED *********/
//            }

//            yield return new WaitForFixedUpdate();
//        }

//        for(int i = 0; i < fishMoves.Count; i++)
//        {
//            StopCoroutine(/********** TO BE FILLED *********/);
//        }

//        groups.Remove(/********** TO BE FILLED *********/);
//    }
}
