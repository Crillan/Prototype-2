public class Apple : MoveForward {
    private float throwSpeed = 20.0f;

    // Update is called once per frame
    void Update() {
        Move(throwSpeed);
    }
}