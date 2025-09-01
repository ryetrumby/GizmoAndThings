using UnityEngine;

[System.Serializable]
public class Pawn : MonoBehaviour
{
    public Vector3 direction = Vector3.forward;
    public float length = 8f;
    void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "Pawn", true);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1f, 0f, 0f);
        Gizmos.DrawRay(transform.position, direction.normalized * length);
    }
}
