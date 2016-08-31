using UnityEngine;
using System.Collections;

public class TravelPath : MonoBehaviour
{

    public float dayDuration = 10f; //Full cycle in minutes


    // Use this for initialization
    void Start()
    {
        dayDuration = dayDuration * 60f; //to get minutes from seconds
    }

    public void FixedUpdate()
    {
       
    }


    // Update is called once per frame
    void Update()
    {

    }
}
