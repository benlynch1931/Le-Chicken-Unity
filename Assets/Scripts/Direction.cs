using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour
{
    private Vector3 vector;

    // private static readonly Direction North = new Direction(x:0, y:1, z:0);
    // private static readonly Direction South = new Direction(x:0, y:-1, z:0);
    // private static readonly Direction East = new Direction(x:1, y:0, z:0);
    // private static readonly Direction West = new Direction(x:-1, y:0, z:0);

    // public static readonly List<Direction> Directions = new List<Direction> { North, South, East, West }

    // public Direction(int x, int y, int z)
    // {
    //   vector = new Vector3(x, y, z);
    // }

    public Direction(string name)
    {
      if (name == "north")
      {
        vector = new Vector3(0f, 1f, 0f);
      } else if (name == "east")
      {
        vector = new Vector3(1f, 0f, 0f);
      } else if (name == "south")
      {
        vector = new Vector3(0f, -1f, 0f);
      } else if (name == "west")
      {
        vector = new Vector3(-1f, 0f, 0f);
      }
    }

    public Vector3 GetVector()
    {
      return vector;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
