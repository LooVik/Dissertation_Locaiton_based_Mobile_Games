using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FoodFunctions : MonoBehaviour
{
    public GameObject Foods;
    public int scores = 0;


    private void RandomPosition()
    {
        Vector3 randomSpawn = new Vector3(Random.Range(-10f, 10f), 1, Random.Range(-10f, 10));
        Instantiate(Foods, randomSpawn, Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Apple Eaten");
            Destroy(gameObject);
            RandomPosition();
            ScoreChecker.instance.AddScore(scores);
        }
    }

}
