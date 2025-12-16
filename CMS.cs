using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class CMS
{
    public static List<CMSData> all = new List<CMSData>();

    private static bool isInit;

    public static void Init()
    {
        if(isInit)return;
        isInit = true;
        
        Add();
    }

    private static void Add()
    {
        var type = ReflectionUtil.Find<CMSData>();
        foreach (var t in type)
        {
            all.Add(Activator.CreateInstance(t) as CMSData);
        }
    }
    
    public static T Get<T>(string id) where T : CMSData
    {
        CMSData found = all.FirstOrDefault(e => e.id == id && e is T);
        
        if (found == null) throw new Exception("no id" + id);
        
        return found as T;
    }
    
}

public class CMSData
{
    public string id;

    public List<CMSComponent> components = new List<CMSComponent>();
    
    
    public bool HasTag<T>()
    {
        return components.Any(n => n is T);
    }
    
    public T GetTag<T>() where T : CMSComponent
    {
        return components.OfType<T>().FirstOrDefault();
    }
}


[Serializable]
public class CMSComponent
{
    
}

