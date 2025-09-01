using UnityEngine;

public class ChessBoard: MonoBehaviour
{
    public int minX;
    public int maxX;
    public int minY;
    public int maxY;


    void OnDrawGizmos()
    {
        Gizmos.color = Color.white;

        Vector3 pos0 = new Vector3();
        Vector3 pos1 = new Vector3();
        for (int i = -minX; i < maxX; i++)
        {
            pos0.x = i;
            pos0.z = -minY;
            pos1.x = i;
            pos1.z = maxY;
            Gizmos.DrawLine(pos0, pos1);
            /*for (int j = 0; j < 100; j++) {

            }*/
        }

        for (int i = -minY; i < maxY; i++)
        {
            pos0.x = -minX;
            pos0.z = i;
            pos1.x = maxX;
            pos1.z = i;
            Gizmos.DrawLine(pos0, pos1);
        }
    }
}
