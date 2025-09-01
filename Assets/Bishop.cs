using UnityEngine;

[System.Serializable]
public class Bishop : MonoBehaviour
{
    public Vector3 diagonal1 = new Vector3(1, 0, 1);
    public Vector3 diagonal2 = new Vector3(1, 0, -1);
    public float length = 12f;
    void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "Bishop", true);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1f, 0f, 1f);
        Gizmos.DrawRay(transform.position, diagonal1.normalized * length);
        Gizmos.DrawRay(transform.position, diagonal1.normalized * -length);
        Gizmos.DrawRay(transform.position, diagonal2.normalized * length);
        Gizmos.DrawRay(transform.position, diagonal2.normalized * -length);
    }
}
