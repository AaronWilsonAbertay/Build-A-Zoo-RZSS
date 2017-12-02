﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node {

    public int nodePosX;
    public int nodePosZ;
    public GameObject vis;
    public MeshRenderer tileRenderer;
    public bool isWalkable;
   public LevelEditor.Level_Object placedObj;

    public LevelEditor.Level_Object fenceObj;
    public LevelEditor.Level_Object animalObj;

    public List<LevelEditor.Level_Object> stackedObjs = new List<LevelEditor.Level_Object>();
    public LevelEditor.Level_WallObj wallObj;
    public LevelEditor.Level_Wall wall;
}
