using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction
{
    private Vector3 vector;

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


}
