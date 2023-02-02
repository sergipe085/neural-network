public class DegreeActivactionFunction : ActivationFunction
{
    public override float GetOutput(float activationPotential) {
        return activationPotential >= 0 ? 1 : 0;
    }
}