﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mesh : MonoBehaviour {

    /* --- Components --- */
    public Transform hull;

    /* --- Variables --- */
    public float depth;

    /* --- Unity --- */
    // Runs once before the first frame
    void Awake() {
        tag = GameRules.meshTag;
    }

    // Runs every frame.
    void Update() {
        Render();
        SetDepth();
    }

    /* --- Rendering --- */
    // The parameters to be rendered every frame
    public virtual void Render() {
        // Determined by the particular type of mesh.
    }

    /* --- Depth --- */
    // Sets the depth of this mesh
    void SetDepth() {
        depth = -(transform.position.y + hull.localPosition.y);
    }

    // Compare the depth of the meshes.
    public static int Compare(Mesh meshA, Mesh meshB) {
        print(meshA); print(meshB);
        return meshA.depth.CompareTo(meshB.depth);
    }

}
