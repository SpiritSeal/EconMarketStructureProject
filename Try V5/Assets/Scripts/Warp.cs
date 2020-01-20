using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {
    public bool inRange = false;
    public AreaManager aMan;
    public int AreaNumber;
    public bool Warping;
//    public GameObject w1;
//    public GameObject w2;

    void Start()
    {
        aMan = FindObjectOfType<AreaManager>();

    }
    void OnTriggerStay2D(Collider2D collision)
    {
        Warping = true;
        Debug.Log("Warp1");
    }

    public Transform warpTarget;
    IEnumerator OnTriggerEnter2D(Collider2D other)
    {
        aMan.AreaCode = AreaNumber;
        Warping = true;
        Debug.Log("Warp2");
        ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();
        yield return StartCoroutine (sf.FadeToBlack () );
        other.gameObject.transform.position = warpTarget.position;
        Camera.main.transform.position = warpTarget.position;
        yield return StartCoroutine (sf.FadeToClear () );
        Warping = false;
        Debug.Log("Warp3");



        if (other.gameObject.name == "Male1" && inRange == false == false)
        {
            /*            if (gameObject.CompareTag("W0"))
                        {
                            AreaNumber = 0;
                        }
                        if (gameObject.CompareTag("W1"))
                        {
                            AreaNumber = 1;
                        }
                        if (gameObject.CompareTag("W2"))
                        {
                            AreaNumber = 2;
                        }
                        if (gameObject.CompareTag("W3"))
                        {
                            AreaNumber = 3;
                        }
                        if (gameObject.CompareTag("W4"))
                        {
                            AreaNumber = 4;
                        }
                        if (gameObject.CompareTag("W5"))
                        {
                            AreaNumber = 5;
                        }
                        if (gameObject.CompareTag("W6"))
                        {
                            AreaNumber = 5;
                        }
                        if (gameObject.CompareTag("W7"))
                        {
                            AreaNumber = 7;
                        }*/

            inRange = true;
            aMan.AreaCode = 4;
            aMan.AreaCode = AreaNumber;
        }
        
    }


    void Update()
    {
        if (true)
        {
            if (Input.GetKeyDown("0"))
            {
                aMan.AreaCode = 0;
            }
            if (Input.GetKeyDown("1"))
            {
                aMan.AreaCode = 1;
            }
            if (Input.GetKeyDown("2"))
            {
                aMan.AreaCode = 2;
            }
            if (Input.GetKeyDown("3"))
            {
                aMan.AreaCode = 3;
            }
            if (Input.GetKeyDown("4"))
            {
                aMan.AreaCode = 4;
            }
            if (Input.GetKeyDown("5"))
            {
                aMan.AreaCode = 5;
            }
            if (Input.GetKeyDown("6"))
            {
                aMan.AreaCode = 6;
            }
            if (Input.GetKeyDown("7"))
            {
                aMan.AreaCode = 7;
            }
        }
    }
}
