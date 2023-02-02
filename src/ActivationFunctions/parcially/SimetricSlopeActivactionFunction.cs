public class SimetricSlopeActivactionFunction : ActivationFunction
{
    private float downLomit = 10.0f;
    private float upLimit = 10.0f;

    public SimetricSlopeActivactionFunction(float _downLimit, float _upLimit) : base() {
        downLomit = _downLimit;
        upLimit = _upLimit;
    }

    public override float GetOutput(float activationPotential) {
        return Math.Clamp(activationPotential, downLomit, upLimit);
    }
}