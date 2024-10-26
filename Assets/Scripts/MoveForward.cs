using UnityEngine;

public class MoveForward : MonoBehaviour {

    protected virtual void Move(float moveSpeed) {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}