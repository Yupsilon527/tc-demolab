using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTransitioner : MonoBehaviour
{

    public static RoomTransitioner main;
    private void Awake()
    {
        main = this;
    }

    public RoomComponent StartingRoom;
    public Vector2 StartingPosition;
    private void Start()
    {
        TransitionRoom(StartingRoom, StartingPosition);
    }

    RoomComponent CurrentRoom;
    public void TransitionRoom(RoomComponent newRoom, Vector2 pointPosition)
    {
        CurrentRoom = newRoom;
        transform.position = newRoom.transform.position + (Vector3)pointPosition;
        GridNav.main = newRoom.grid;
        Camera.main.transform.position = newRoom.transform.position;
    }

    void OnDrawGizmosSelected()
    {
        if (StartingRoom != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(StartingRoom.transform.position + (Vector3)StartingPosition, .33f);
        }
    }
}