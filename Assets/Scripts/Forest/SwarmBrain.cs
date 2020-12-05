using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmBrain : MonoBehaviour
{
    //While there is hive, patrol hive
    //While there is no hive, pursue player
    private bool hasHive = true;
    private Patrol patrol;
    private Bot bot;

    // Start is called before the first frame update
    void Start()
    {
        patrol = GetComponent<Patrol>();
        bot = GetComponent<Bot>();
        HivePickUp.HivePickedUp += HiveTaken;
    }

    void HiveTaken()
    {
        hasHive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(hasHive)
        {
            patrol.PatrolWaypoints();
        }
        else
        {
            bot.Pursue();
        }
    }
}
