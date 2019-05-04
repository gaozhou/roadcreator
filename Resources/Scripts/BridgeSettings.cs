﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BridgeSettings
{

    public Material[] bridgeMaterials;
    public float yOffsetFirstStep = 0.25f;
    public float yOffsetSecondStep = 0.5f;
    public float widthPercentageFirstStep = 0.6f;
    public float widthPercentageSecondStep = 0.6f;
    public float extraWidth = 0.2f;

    // Custom mesh
    public GameObject bridgeMesh;
    public int sections = 1;
    public float yScale = 1;
    public float xOffset = 0;
    public bool adaptToTerrain = false;

}
