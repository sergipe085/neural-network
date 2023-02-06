class PerceptronNetwork {
    private float[] sinapseWeights = new float[4];

    public void InitializeTrain() {
        Random random = new Random();
        for(int i = 0; i < sinapseWeights.Length; i++) {
            sinapseWeights[i] = (float)random.NextDouble();
        }

        float learningRate = 0.3f;

        int epochCounter = 0;

        while (true) {
            bool error = false;
            for (int i = 0; i < amostra.GetLength(0); i++) {

                float u = 0.0f;

                for (int j = 0; j < amostra.GetLength(1); j++) {
                    u += amostra[i, j] * sinapseWeights[j];
                }

                DegreeActivactionFunction degreeActivactionFunction = new DegreeActivactionFunction();
                float y = degreeActivactionFunction.GetOutput(u);

                if (y != esperado[i]) {
                    error = true;

                    for (int j = 0; j < sinapseWeights.Length; j++) {
                        sinapseWeights[j] = sinapseWeights[j] + learningRate * (esperado[i] - y) * amostra[i, j];
                    }
                }
            } 

            epochCounter++;
            Console.WriteLine($"Epoch Done {epochCounter}");
            foreach(float i in sinapseWeights) {
                Console.Write($"{i}  ");
            }
            Console.WriteLine("");

            if (!error) {
                break;
            }
        }

        Console.WriteLine("TRAINNED");
        InitializeOperation();
    }

    private float[,] amostra = new float[4, 4] {
        { -1, 0.1f, 0.4f, 0.7f },
        { -1, 0.3f, 0.7f, 0.2f },
        { -1, 0.6f, 0.9f, 0.8f },
        { -1, 0.5f, 0.7f, 0.1f },
    };

    private float[] esperado = new float[4] {
        1, -1, -1, 1
    };

    private void InitializeOperation() {
        Console.WriteLine("OPERATION INIITALIZED");

        float[,] inputs        = new float[4, 4] {
            { -1, 0.2f, 0.5f, 0.8f },
            { -1, 0.8f, 0.9f, 0.1f },
            { -1, 0.7f, 0.4f, 0.8f },
            { -1, 0.7f, 0.2f, 0.3f },
        };

        inputs = amostra;

        for (int i = 0; i < inputs.GetLength(0); i++) {
            float u = 0.0f;

            for (int j = 0; j < inputs.GetLength(0); j++) {
                u += inputs[i, j] * sinapseWeights[j];
            }

            DegreeActivactionFunction degreeActivactionFunction = new DegreeActivactionFunction();
            float y = degreeActivactionFunction.GetOutput(u);

            Console.WriteLine(y);
        }
    }
}