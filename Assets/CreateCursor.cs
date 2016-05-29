using UnityEngine;
using System.Collections;

public class CreateCursor : MonoBehaviour
{

    /// <summary>
    /// Create Cursor
    /// </summary>
    void Start()
    {
        GameObject Par = GameObject.Find("Cursor");
        float s = 1 /16;
        Color B = Color.black;
        Color W = Color.white;
        Color T = new Color32(0,0,0,0);
        Pixel[] Pixels = new Pixel[]
        {// (0, 0) is top left Not center
            //new Pixel(0,0, B)
        };
        //foreach()
    }
    private class Pixel
    {
        Pixel(float x, float z, Color color)
        {
            this.position = new Vector3(x,0, z);
            this.color = color;
        }
        Vector3 position { get; set; }
        Color color { get; set; }

    }
    /// <summary>
    /// Creates Gameobject Plane
    /// </summary>
    /// <returns></returns>
    public GameObject CreatePlane()
    {
        GameObject square = GameObject.CreatePrimitive(PrimitiveType.Plane);
        Mesh M = square.GetComponent<MeshFilter>().mesh;

        //Create Vertices (start: bottom left / direction: clockwise)
        M.vertices = new Vector3[]
        {
            new Vector3(-.5f, 0, -.5f),
            new Vector3(-.5f, 0, .5f),
            new Vector3(.5f, 0, .5f),
            new Vector3(.5f, 0, -.5f)
        };

        //Triangles
        M.triangles = new int[] 
        {
            0,1,2, 
            0,3,2
        };

        //Uvs
        M.uv = new Vector2[]
        {
            new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(1,1),
            new Vector2(0,1)
        };
        return square;
    }

}
