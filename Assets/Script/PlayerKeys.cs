using UnityEngine;

public class PlayerKeys : MonoBehaviour
{
    public int grayKeys = 0;
    public int blueKeys = 0;
    public int purpleKeys = 0;

    public int GetKeys(KeyColor color)
    {
        switch (color)
        {
            case KeyColor.Gray: return grayKeys;
            case KeyColor.Blue: return blueKeys;
            case KeyColor.Purple: return purpleKeys;
        }
        return 0;
    }
    public int TotalKeys()
    {
        return grayKeys + blueKeys + purpleKeys;
    }

    public void AddKey(KeyColor color, int amount)
    {
        switch (color)
        {
            case KeyColor.Gray: grayKeys += amount; break;
            case KeyColor.Blue: blueKeys += amount; break;
            case KeyColor.Purple: purpleKeys += amount; break;
        }
    }

    public void UseKeys(KeyColor color, int amount)
    {
        switch (color)
        {
            case KeyColor.Gray: grayKeys -= amount; break;
            case KeyColor.Blue: blueKeys -= amount; break;
            case KeyColor.Purple: purpleKeys -= amount; break;
        }
    }
}


public enum KeyColor
{
    Gray,
    Blue,
    Purple
}
