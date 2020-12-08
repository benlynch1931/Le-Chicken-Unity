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
        // if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        // {
        //     horizontal = new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f);
        //     chicken.Move(horizontal);
        // }
        if(Input.GetAxisRaw("Vertical") > 0.5f )
        {
            scalar = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
            chicken.Move(north, scalar);
        }
        if(Input.GetAxisRaw("Vertical") < -0.5f)
        {
            scalar = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
            chicken.Move(south, scalar);
        }
    }
}
