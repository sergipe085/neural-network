public class LogisticActivactionFunction : ActivationFunction
{
    private float inflectionRotation = 45f;

    public LogisticActivactionFunction(float _inflectionRotation) : base() {
        inflectionRotation = _inflectionRotation;
    }

    public override float GetOutput(float activationPotential) {
        return 1f / (float)(1 + Math.Pow(CONSTANTS.PLANK, inflectionRotation * activationPotential));
    }
}