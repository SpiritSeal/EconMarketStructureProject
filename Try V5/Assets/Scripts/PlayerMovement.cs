using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed;
    public float moveSpeed_Archive;
    Rigidbody2D rbody;
    Animator anim;
    Warp wrp;

    private DialogueM dMan;

	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator> ();
        dMan = FindObjectOfType<DialogueM>();
        wrp = FindObjectOfType<Warp>();
        moveSpeed_Archive = moveSpeed;
}
//    private void On
    // Update is called once per frame
    void Update () {
        if (wrp.Warping)
        {
            moveSpeed = 0;
            Debug.Log("Recieved");
        }
        if (dMan.dialogueActive || wrp.Warping)
        {
            moveSpeed = 0;
        }
        else
        {
            if(Input.GetKey("left shift"))
            {
                moveSpeed = moveSpeed_Archive + 2;
            }
            else
            {
                moveSpeed = moveSpeed_Archive;
            }

        }

        Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (movement_vector != Vector2.zero) {
            anim.SetBool("Is_Walking", true);
            anim.SetFloat("Input_x", movement_vector.x);
            anim.SetFloat("Input_y", movement_vector.y);
        } else
        {
            anim.SetBool("Is_Walking", false);
        }

        rbody.MovePosition(rbody.position + movement_vector * Time.deltaTime * moveSpeed);
	}
}
