using UnityEngine;

[System.Serializable]
public class King : MonoBehaviour
{
    public Vector3 vertical = Vector3.forward;
    public Vector3 horizontal = Vector3.right;
    public Vector3 diagonal1 = new Vector3(1, 0, 1);
    public Vector3 diagonal2 = new Vector3(1, 0, -1);
    public float length = 1.5f;
    void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "King", true);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1f, 1f, 0f);
        Gizmos.DrawRay(transform.position, vertical.normalized * length);
        Gizmos.DrawRay(transform.position, vertical.normalized * -length);
        Gizmos.DrawRay(transform.position, horizontal.normalized * length);
        Gizmos.DrawRay(transform.position, horizontal.normalized * -length);
        Gizmos.DrawRay(transform.position, diagonal1.normalized * length);
        Gizmos.DrawRay(transform.position, diagonal1.normalized * -length);
        Gizmos.DrawRay(transform.position, diagonal2.normalized * length);
        Gizmos.DrawRay(transform.position, diagonal2.normalized * -length);
    }
}
