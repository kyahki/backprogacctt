# Back Propagation Neural Network Activity

## Problem Overview

The 4-input AND gate outputs `1` only when **all inputs are 1**, otherwise the output is `0`. The network must learn this pattern through training. A 4-input AND gate has a total of **16 unique input-output combinations**:

| Input A | Input B | Input C | Input D | Output |
|---------|---------|---------|---------|--------|
| 0       | 0       | 0       | 0       | 0      |
| 0       | 0       | 0       | 1       | 0      |
| 0       | 0       | 1       | 0       | 0      |
| 0       | 0       | 1       | 1       | 0      |
| 0       | 1       | 0       | 0       | 0      |
| 0       | 1       | 0       | 1       | 0      |
| 0       | 1       | 1       | 0       | 0      |
| 0       | 1       | 1       | 1       | 0      |
| 1       | 0       | 0       | 0       | 0      |
| 1       | 0       | 0       | 1       | 0      |
| 1       | 0       | 1       | 0       | 0      |
| 1       | 0       | 1       | 1       | 0      |
| 1       | 1       | 0       | 0       | 0      |
| 1       | 1       | 0       | 1       | 0      |
| 1       | 1       | 1       | 0       | 0      |
| 1       | 1       | 1       | 1       | 1      |

## Neural Network Design

The network is designed with the following structure:
- **Input Layer:** 4 neurons (representing the 4 inputs).
- **Hidden Layer:** The **minimum number of hidden neurons** required is **2**.
- **Output Layer:** 1 neuron (representing the AND gate output).

## Training Process

### Training Data
The network is trained on the 16 input-output combinations shown above.

### Minimum Number of Hidden Neurons
Through experimentation, it was found that **2 hidden neurons** are sufficient to model the 4-input AND gate. Using fewer neurons results in the network failing to learn the patterns.

### Minimum Number of Training Epochs
The network requires approximately **300-500 epochs** to converge, depending on:
- The learning rate.

## How to Run
1. Clone the repository.
2. Build and run the C# program.
3. Observe the training progress and final output.

