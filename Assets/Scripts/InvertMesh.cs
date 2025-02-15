using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertMesh : MonoBehaviour
{
    public GameObject[] spheres;

    private void Awake()
    {
        Debug.Log("log");
        foreach (GameObject sphere in spheres)
        {
            InvertSpheresMesh(sphere);
        }
    }

    private void InvertSpheresMesh(GameObject sphere)
    {
        MeshFilter meshFilter = sphere.GetComponent<MeshFilter>();
        Mesh mesh = meshFilter.mesh;

        Vector3[] normals = mesh.normals;

        for (int i = 0; i < normals.Length; i++)
        {
            normals[i] = -normals[i];
        }
        meshFilter.sharedMesh.normals = normals;

        int[] triangles = meshFilter.sharedMesh.triangles;

        for (int i = 0; i < triangles.Length; i += 3)
        {
            int temp = triangles[i];
            triangles[i] = triangles[i + 2];
            triangles[i + 2] = temp;
        }

        meshFilter.sharedMesh.triangles = triangles;
    }
}