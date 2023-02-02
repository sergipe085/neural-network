public class Neuron {
    private Neuron child = new Neuron();
    private float limiarOfActivation = -10f;
    private float neuronWeight = 0.5f;

    public void ReceiveInputs(NeuronInput[] inputs) {
        ProcessInputs(inputs);
    }

    private void ProcessInputs(NeuronInput[] neuronInputs) {
        float linearCombinator = 0.0f;
        foreach(NeuronInput neuronInput in neuronInputs) {
            linearCombinator += neuronInput.input * neuronInput.weight;
        }

        float activactionPotential = limiarOfActivation + linearCombinator;

        ActivationFunction activationFunction = new SimetricSlopeActivactionFunction(-10f, 10f);
        float output = activationFunction.GetOutput(activactionPotential);

        CompileOutput(output);
    }

    private float Activate(float potential) {
        return Math.Clamp(potential, -50f, 35f);
    }

    private void CompileOutput(float output) {
        child.ReceiveInputs(new NeuronInput[] { 
            new NeuronInput() { input = output, weight = neuronWeight }
        });
    }
}

public struct NeuronInput {
    public float input;
    public float weight;
}