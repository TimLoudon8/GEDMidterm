using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceItemCommand : ICommand
{
    Vector3 position;
    Transform item;

    public PlaceItemCommand(Vector3 position, Transform item)
    {
        // Initializing
        this.position = position;
        this.item = item;
    }

    public void Execute()
    {
        // Does the thing
        ItemPlacer.PlaceItem(item);
    }

    public void Undo()
    {
        // Undoes the thing
        ItemPlacer.RemoveItem(position);
    }
}
