using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class JsonDataClass 
{
    public List<positionList> position_main;
    public List<sizeList> size_main;
    public List<positionList> position_w1;
    public List<sizeList> size_w1;
}

[Serializable]
public class positionList
{
    public int x;
    public int y;
}

[Serializable]
public class sizeList
{
    public int width;
    public int length;
}