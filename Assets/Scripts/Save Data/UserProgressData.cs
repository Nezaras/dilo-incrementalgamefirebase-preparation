using System.Collections.Generic;

[System.Serializable]
public class UserProgressData
{
    public double Gold = 0;
    public List<int> ResourcesLevels = new List<int>();

    public object ResourceLevels { get; internal set; }
}
