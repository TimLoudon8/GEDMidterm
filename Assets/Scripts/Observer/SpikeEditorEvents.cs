using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpikeEditorEvents
{
    public abstract Color SpikeEditorColour();
}

public class YellowMat : SpikeEditorEvents
{
    public override Color SpikeEditorColour()
    {
        return Color.yellow;
    }
}

public class GreenMat : SpikeEditorEvents
{
    public override Color SpikeEditorColour()
    {
        return Color.green;
    }
}
