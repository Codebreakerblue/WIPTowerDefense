using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemySpeed = 10;

    private Transform target;
    private int waypointIndex = 0;

    void Start ()
    {
        target = Waypoints.points[0];
    }


}
