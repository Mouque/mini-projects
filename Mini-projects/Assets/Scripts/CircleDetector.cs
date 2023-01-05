using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDetector : MonoBehaviour
{
    [SerializeField]
    Transform point1, point2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DetectPiece();
    }

    void DetectPiece()
    {
        RaycastHit2D hit1 = Physics2D.Raycast(point1.position, Vector2.left, 1f);
        RaycastHit2D hit2 = Physics2D.Raycast(point2.position, Vector2.right, 1f);

        if (hit1.collider != null && hit2.collider != null)
        {
            if (hit1.transform.CompareTag("Circle") && hit2.transform.CompareTag("Circle"))
            {
                Debug.Log("Circle ganhou");
            }
        }


    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawRay(point1.position, Vector2.left * 1f);
        Gizmos.DrawRay(point2.position, Vector2.right * 1f);
    }
}
