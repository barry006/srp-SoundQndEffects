using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshColliderUpdate : MonoBehaviour
{
    SkinnedMeshRenderer skinnedMeshRenderer;
    private Mesh bakedMesh;

    private void Awake()
    {
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        bakedMesh = new Mesh();
    }
    private void OnDestroy()
    {
        Destroy(bakedMesh);
    }
    void Update()
    {
            UpdateCollider();

    }

    public void UpdateCollider()
    { 
            skinnedMeshRenderer.BakeMesh(bakedMesh);
            GetComponent<MeshCollider>().sharedMesh = null;
            GetComponent<MeshCollider>().sharedMesh = bakedMesh;           
            //Destroy(colliderMesh);           
    }
}
