using System;

[Serializable]
public class AddsScoreTag : Tag
{
    public int howMuch;
}

public class Tag : CMSComponent
{
}