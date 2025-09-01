using UnityEngine;

[System.Serializable]
public class Knight : MonoBehaviour
{
    public float forwardLength = 2f;
    public float sideLength = 1f;
    Vector3[] points;
    Vector3[] points2;
    Vector3[] points3;
    Vector3[] points4;
    void OnDrawGizmos()
    {
        // Gives Knight Sprite
        Gizmos.DrawIcon(transform.position, "Knight", true);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0f, 1f, 0f);
        // Fetches points to draw L
        Vector3 startPoint = transform.position;
        
        Vector3 cornerPoint = startPoint + transform.forward * forwardLength; // forward
        Vector3 endPoint = cornerPoint + transform.right * sideLength; // forward right
        Vector3 endPoint2 = cornerPoint - transform.right * sideLength; // forward left
        
        Vector3 cornerPoint2 = startPoint - transform.forward * forwardLength; // backwards
        Vector3 endPoint3 = cornerPoint2 + transform.right * sideLength; // back right
        Vector3 endPoint4 = cornerPoint2 - transform.right * sideLength; // back left

        Vector3 cornerPoint3 = startPoint + transform.right * forwardLength; // right
        Vector3 endPoint5 = cornerPoint3 + transform.forward * sideLength; // right up
        Vector3 endPoint6 = cornerPoint3 - transform.forward * sideLength; // right down

        Vector3 cornerPoint4 = startPoint - transform.right * forwardLength; // left
        Vector3 endPoint7 = cornerPoint4 + transform.forward * sideLength; // left up
        Vector3 endPoint8 = cornerPoint4 - transform.forward * sideLength; // left down

        // Creating arrays to use in Line Strips
        points = new Vector3[4]
        {
            startPoint,
            cornerPoint,
            endPoint,
            endPoint2
        };

        points2 = new Vector3[4]
        {
            startPoint,
            cornerPoint2,
            endPoint3,
            endPoint4
        };

        points3 = new Vector3[4]
        {
            startPoint,
            cornerPoint3,
            endPoint5,
            endPoint6
        };

        points4 = new Vector3[4]
        {
            startPoint,
            cornerPoint4,
            endPoint7,
            endPoint8
        };

        // Drawing L
        Gizmos.DrawLineStrip(points, false);
        Gizmos.DrawLineStrip(points2, false);
        Gizmos.DrawLineStrip(points3, false);
        Gizmos.DrawLineStrip(points4, false);
    }
}
