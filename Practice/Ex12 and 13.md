## E12: Working with SpatialPatternLearning
1.	Fork the neocortexapi repository.
2.	Clone the forked repository to local machine.
3.	Execute the SpatialPatternLearning() method.
4.	Adjust the maxSPLearningCycles to 5, 10, 15, and observe the experimentation and analysis of spatial pattern learning over multiple cycles
5.	Show active columns with the python script.

## E13: Working with MultisequenceExperiment
1.	Add the Neocortexapi NuGet package to your project.
2.	Include the necessary files for the NeoCortexApiSample namespace.
3.	Run the RunMultiSequenceLearningExperiment() method.
4.	Perform the experiment by modifying the learning sequence list to include "S1 and S2."
5.	Show active columns with the python script.

## Step by Step Process
## <ins>E12: Working with SpatialPatternLearning</ins>
- Open [NeoCortexApi](https://github.com/ddobric/neocortexapi) in your browser.
- Fork the Repository and set an name for your forked repository.
![Screenshot 2023-12-16 010008](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/791eb946-eb13-4e3d-88d0-f9ffc4d7b3e4)

![Screenshot 2023-12-16 010053](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/93733399-7edf-4532-a6d5-8b37e84ca40a)

- Clone the forked repository to your local machine using the command: `git clone [repository HTTPS link]`.
- Open `NeoCortexApi.sln`located in `/source/NeoCortexApi.sln`.
- Select the NeoCortexApiSample project from the dropdown menu.
  ![Screenshot 2023-12-16 010714](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/66a018c7-a2e0-4121-93a2-6ef182258f99)

- Open Program.cs of NeoCortexApiSample.
- In Program.cs, uncomment the following lines:
  ```csharp
  SpatialPatternLearning experiment = new SpatialPatternLearning();
  experiment.Run();
  ```
  ![Screenshot 2023-12-16 011022](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/48cba37b-5602-4c1f-8cd6-43e39d275b85)
- Run the Code
- Copy the Active SDR values
- Open the Python Script folder in Visual Studio Code.
  ![image](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/5ab8739e-faf1-4026-a750-40c927063b2b)

- Paste the copied data to sampleOne.txt ( `\Python\ColumnActivityDiagram/sampleOne.txt`)
  ![image](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/0d5b4d89-68c1-42ce-9084-594b4bb104cc)

- In the Visual Studio Code terminal, run the following command:
  ```csharp
  python draw_figure.py -fn sampleOne.txt -gn test1 -mc 19 -ht 8 -yt yaxis -xt xaxis -min 50 -max 4000 -st 'single column' -fign CortialColumn
  ```
  ![image](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/f7d1e741-38d7-4f80-8484-91b6eda42745)

- An image will be generated and can be viewed in a browser.

   ![image](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/0cc8546e-aac6-4f6c-a632-7df14bae0dce)




## <ins>E13: Working with MultisequenceExperiment</ins>
- Create a Console Application.
- Add the `NeoCortexApi` NuGet package from the NuGet Package Manager.
  ![image](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/cb0f7082-afbe-453c-b37a-816c382d4293)

- Copy the `Program.cs` and `MultisequenceLearning.cs` files to the Console Application to resolve dependency issues. theses files are present in `\source\Samples\NeoCortexApiSample`
  ![image](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/6d86b9ee-5ff2-4697-b488-aaf736f66fbe)

- In `Program.cs`, uncomment the following line:
  ```csharp
  RunMultiSequenceLearningExperiment();
  ```
  ![image](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/07dd9e66-f016-47c1-819d-7c54585508a9)

- Run the Console Application.
- Copy the generated SDR values.
  ![image](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/4787551a-731a-4d85-877d-82b7a21f9b84)

- Open the Python Script folder in Visual Studio Code.
  ![image](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/5ab8739e-faf1-4026-a750-40c927063b2b)

- Paste the copied data to sampleOne.txt ( `\Python\ColumnActivityDiagram/sampleOne.txt`)
  ![image](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/0d5b4d89-68c1-42ce-9084-594b4bb104cc)

- In the Visual Studio Code terminal, run the following command:
  ```Csharp
  python draw_figure.py -fn sampleOne.txt -gn test1 -mc 19 -ht 8 -yt yaxis -xt xaxis -min 50 -max 4000 -st 'single column' -fign CortialColumn
  ```
  ![image](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/f7d1e741-38d7-4f80-8484-91b6eda42745)

- An image will be generated and can be viewed in a browser.

   ![image](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/0cc8546e-aac6-4f6c-a632-7df14bae0dce)


  
