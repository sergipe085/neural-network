public class BipolarDegreeActivactionFunction : ActivationFunction
{
    public override float GetOutput(float activationPotential) {
        return Math.Sign(activationPotential);
    }
}