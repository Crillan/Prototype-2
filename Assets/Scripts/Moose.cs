using UnityEngine;

public class Moose : AnimalBehavior {
    private float runSpeed = 10.0f;

    // Update is called once per frame
    void Update() {
        Move(runSpeed);
    }

    public override void FoodResponse() {
        Debug.Log("Nom Nom Nom!");
    }
}