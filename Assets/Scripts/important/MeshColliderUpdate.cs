using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshColliderUpdate : MonoBehaviour
{
   // private float time = 0;
    SkinnedMeshRenderer skinnedMeshRenderer;
    //MeshColliderUpdate colliderMesh;
    private Mesh bakedMesh;
   
    void Start()
    {
        
        //colliderMesh = GetComponent<MeshCollider>();
    }

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
       // time += Time.deltaTime;
       // if (time >= 0)
      //  {
           // time = 0;
            UpdateCollider();
       // }
    }

    public void UpdateCollider()
    {
        
            
            
            skinnedMeshRenderer.BakeMesh(bakedMesh);
            GetComponent<MeshCollider>().sharedMesh = null;
            GetComponent<MeshCollider>().sharedMesh = bakedMesh;
            
        
            //Destroy(colliderMesh);
           


    }
}


// You must use on the *SkinnedMesh* , and puthe the *mesh collider* too on the (( Mesh Avatar )) ... i think you got the ideia.
//Vous devez utiliser sur le SkinnedMesh , et mettre le collisionneur de maillage aussi sur le (( Mesh Avatar )) ... je pense que vous avez l'ideia.
