using System;
using System.Collections.Generic;

[Serializable]
public class UpgradeOfScore : CMSData
{
    public int adds = 25;
    public UpgradeOfScore()
    {
        id = "ScoreUpgrade";
        components.Add(new AddsScoreTag { howMuch = adds });
    }
}

[Serializable]
public class UpgradeOFHp : CMSData
{
    public int adds = 25;
    
    public UpgradeOFHp() { id = "HPUpgrade"; }
}

[Serializable]
public class UpgradeOfPower : CMSData
{
    public int adds = 25;
    
    public UpgradeOfPower() { id = "PowerUpgrade"; }
}