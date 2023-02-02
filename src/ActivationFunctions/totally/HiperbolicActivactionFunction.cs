public class HiperbolicActivactionFunction : ActivationFunction
{
    private float inflectionRotation = 45f;

    public HiperbolicActivactionFunction(float _inflectionRotation) : base() {
        inflectionRotation = _inflectionRotation;
    }

    public override float GetOutput(float activationPotential) {
        return (float)(1f - Math.Pow(CONSTANTS.PLANK, -inflectionRotation * activationPotential)) / 
               (float)(1f + Math.Pow(CONSTANTS.PLANK, -inflectionRotation * activationPotential));
    }
}