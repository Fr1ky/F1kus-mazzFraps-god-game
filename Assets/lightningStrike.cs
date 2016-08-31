using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class lightningStrike : MonoBehaviour
{

  public List <GameObject> targets;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.isTrigger && (collision.tag == "Peon" || collision.tag == "BurnableTree"))
        {           
                targets.Add(collision.gameObject);
            
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
       if (!collision.isTrigger && (collision.tag == "Peon" || collision.tag == "BurnableTree"))
        {
                targets.Remove(collision.gameObject);           
        }
    }
}
