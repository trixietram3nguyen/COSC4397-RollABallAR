using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public int point = 1;
    //Game manager class is to keep track with the points
    //If the player hit the cube then they will do something with the points
    public GameManager gm;   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //if the player hit the object in this case the cube
        if(other.gameObject.GetComponent<Player>())
        {
            //So everytime the player hit the cube, then it will call ObtainPoints function to add points
            gm.ObtainPoints(point);
            //make the object disappear when the player hit it
            this.gameObject.SetActive(false);
        }
    }
}
