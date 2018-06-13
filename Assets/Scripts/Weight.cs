using UnityEngine;

public class Weight : MonoBehaviour 
{
    public float distanceFromChainEnd = -0.7f;

	public void ConnectRopeEnd(Rigidbody2D endRB)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        joint.connectedBody = endRB;
        joint.autoConfigureConnectedAnchor = false;
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = new Vector2(0f, distanceFromChainEnd);
    }
}
