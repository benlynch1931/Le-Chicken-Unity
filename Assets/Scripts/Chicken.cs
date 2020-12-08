using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    // Start is called before the first frame update
 

    public void Move(Vector3 direction)
    {
        transform.Translate(direction);
        // transform.localRotation = Quaternion.Euler(0, 0, 0);
    }


}
