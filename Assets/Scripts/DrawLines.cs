using UnityEngine;

public class DrawLines : MonoBehaviour
{
    Coords startPointX = new Coords(-160, 0);
    Coords endPointX = new Coords(160, 0);
    Coords startPointY = new Coords(0, -100);
    Coords endPointY = new Coords(0, 100);
    Coords[] pointArray =
    {
        new Coords(133.5f,-47.4f),
        new Coords(65.8f,2.7f),
        new Coords(15.2f,53.6f),
        new Coords(-14.7f,6.6f),
        new Coords(-11.2f,-20.8f),
        new Coords(-8.5f,-37.8f),
        new Coords(-122.7f,-70.1f),
        new Coords(-13.8f,52.2f),
        new Coords(-24.6f,65f),
        new Coords(-35.7f,67.4f),
        new Coords(-112.7f,39.4f),
        new Coords(-76.2f,21.4f),
        new Coords(-81.1f,-21.1f),
        new Coords(-92.5f,-34.7f),
    };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Coords.DrawLine(startPointX, endPointX, 1.5f, Color.red);
        Coords.DrawLine(startPointY, endPointY, 1.5f, Color.green);

        foreach (var p in pointArray)
        {
            Coords.DrawPoint(p, 5f, Color.yellow);
        }

        Coords.DrawLine(pointArray[0], pointArray[1], 1.5f, Color.white);
        Coords.DrawLine(pointArray[1], pointArray[2], 1.5f, Color.white);
        Coords.DrawLine(pointArray[1], pointArray[2], 1.5f, Color.white);
        Coords.DrawLine(pointArray[2], pointArray[3], 1.5f, Color.white);
        Coords.DrawLine(pointArray[3], pointArray[4], 1.5f, Color.white);
        Coords.DrawLine(pointArray[4], pointArray[5], 1.5f, Color.white);
        Coords.DrawLine(pointArray[2], pointArray[7], 1.5f, Color.white);
        Coords.DrawLine(pointArray[7], pointArray[8], 1.5f, Color.white);
        Coords.DrawLine(pointArray[8], pointArray[9], 1.5f, Color.white);
        Coords.DrawLine(pointArray[9], pointArray[10], 1.5f, Color.white);
        Coords.DrawLine(pointArray[10], pointArray[11], 1.5f, Color.white);
        Coords.DrawLine(pointArray[11], pointArray[12], 1.5f, Color.white);
        Coords.DrawLine(pointArray[12], pointArray[13], 1.5f, Color.white);
        Coords.DrawLine(pointArray[13], pointArray[6], 1.5f, Color.white);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
