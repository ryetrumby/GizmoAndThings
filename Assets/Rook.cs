using UnityEngine;

[System.Serializable]
public class Rook : MonoBehaviour
{
    public Vector3 vertical = Vector3.forward;
    public Vector3 horizontal = Vector3.right;
    public float length = 12f;
    void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "Rook", true);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0f, 1f, 1f);
        Gizmos.DrawRay(transform.position, vertical.normalized * length);
        Gizmos.DrawRay(transform.position, vertical.normalized * -length);
        Gizmos.DrawRay(transform.position, horizontal.normalized * length);
        Gizmos.DrawRay(transform.position, horizontal.normalized * -length);
    }
}