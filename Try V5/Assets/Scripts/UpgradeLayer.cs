using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeLayer : MonoBehaviour {
    public SpriteRenderer sprite;
    public GameObject GO;
    public int LayerInt;
    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        sprite.sortingOrder = LayerInt;
    }
}
