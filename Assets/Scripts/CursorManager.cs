using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public Texture2D cursorTexture; // Aquí asigna la imagen o asset que deseas utilizar como cursor
    public Vector2 hotSpot = Vector2.zero; // Punto caliente del cursor

    void Start()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, CursorMode.Auto);
    }
}

