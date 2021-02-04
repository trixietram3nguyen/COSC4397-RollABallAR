using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int points = 0;
    //transform contain the position, rotation, and scales so each object has Transform, check in unity
    public List<Transform> spawnPoints;
    public GameObject templateObjective;
    //showing the score
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObjective();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //add points everytime the player hit the object
    public void ObtainPoints(int x)
    {
        points = points + x;
        UpdateScore();
    }

    public void SpawnObjective()
    {
        foreach (var spawnPoint in spawnPoints)
        {
            //Instantiate clone the original object and return the clone
            GameObject cubePoint = Instantiate(templateObjective);
            cubePoint.transform.position = spawnPoint.position;
            cubePoint.GetComponent<Objective>().point = Random.Range(1, 1000);
            cubePoint.GetComponent<Objective>().gm = this;
        }
    }

    public void UpdateScore()
    {
        score.text = points.ToString();
    }
}
