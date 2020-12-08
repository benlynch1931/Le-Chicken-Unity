using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Animator anim;
    private Chicken chicken;
    private Vector3 horizontal;
    private Vector3 vertical;
    private Direction north = new Direction("north");
    private Direction south = new Direction("south");
    private Direction east = new Direction("east");
    private Direction west = new Direction("west");
    private float scalar;

    // Start is called before the first frame update
    void Start()
    {
       anim = GetComponent<Animator>();
       chicken = GetComponent<Chicken>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        scalar = moveSpeed * Time.deltaTime;

        if(Input.GetAxisRaw("Horizontal") > 0.5f )
        {
            chicken.Move(east, scalar);
        }
        if(Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            chicken.Move(west, scalar);
        }

        if(Input.GetAxisRaw("Vertical") > 0.5f )
        {
            chicken.Move(north, scalar);
        }
        if(Input.GetAxisRaw("Vertical") < -0.5f)
        {
            chicken.Move(south, scalar);
        }

        if (Input.touchCount > 0)
        {
          chicken.Move(east, scalar);
        }
    }
}
