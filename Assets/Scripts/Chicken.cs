using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    // Start is called before the first frame update
 

    public void Move(Direction direction, float scalar)
    {
        transform.Translate(direction.GetVector()*scalar);
    }


}
