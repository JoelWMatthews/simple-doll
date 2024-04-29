using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollController : MonoBehaviour
{
    public Material Skin;

    public Material Shirt;

    public Material Pants;

    public Material FaceBottom;

    public void SetSkinColor(string hex)
    {
        Skin.color = HexToColor(hex);
    }

    public void SetShirtColor(string hex)
    {
        Shirt.color = HexToColor(hex);
    }

    public void SetPantsColor(string hex)
    {
        Pants.color = HexToColor(hex);
    }

    public void SetFaceColor(string hex)
    {
        FaceBottom.color = HexToColor(hex);
    }
    
    Color HexToColor(string hex)
    {
        hex = hex.Replace("#", "");
        byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
        byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
        byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
        return new Color32(r, g, b, 255);
    }
}
