using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public GameObject button;
    public GameObject crossTurnText;
    public GameObject circleTurnText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PieceSpawn.gameStarted)
        {
            button.SetActive(false);
        }
    }

    public void ButtonClicked()
    {

        if (PieceSpawn.crossTurn)
        {
            crossTurnText.SetActive(false);
            circleTurnText.SetActive(true);
            PieceSpawn.crossTurn = false;
        }
        else
        {
            crossTurnText.SetActive(true);
            circleTurnText.SetActive(false);
            PieceSpawn.crossTurn = true;
        }


    }
}
