using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlayer
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void RandomMove(GameState state)
    {

        int numPawns = state.Pawns.Length;
        int randomNum = Random.Range(0, numPawns);

        Pawn pawn = state.Pawns[randomNum];
        Place[] connections = pawn.CurrentPlace.Connections;
        int numConnections = connections.Length;
        if (numConnections > 0)
        {
            randomNum = Random.Range(0, numConnections);
            Place randomPlace = connections[randomNum];
            GameManager.Instance.Move(pawn, randomPlace);
        }
        else
        {
            Debug.LogWarning("Couldn't find a valid move.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
