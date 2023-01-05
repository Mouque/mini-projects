using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceSpawn : MonoBehaviour
{

    public bool isOccupied;
    static public bool crossTurn;
    static public bool gameStarted;
    public GameObject crossPrefab;
    public GameObject circlePrefab;

    Collider2D coll;
    // Start is called before the first frame update
    void Start()
    {
        crossTurn = true;
        isOccupied = false;
        gameStarted = false;
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (!isOccupied)
        {
            if (crossTurn)
            {
                coll.enabled = false;
                Instantiate(crossPrefab, gameObject.transform);
                crossTurn = false;
            }
            else
            {
                coll.enabled = false;
                Instantiate(circlePrefab, gameObject.transform);
                crossTurn = true;
            }
            isOccupied = true;
        }
        gameStarted = true;

    }


}
