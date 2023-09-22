# EmbeddingTest

This repo is a minimum reproducable example that demonstrates the incompatibility with embedding unmanaged resources within the Stride engine.

Project built for Windows x64 (the embedded native assemblies target windows x64)
Stride 4.1.0.1898

Usage:

- Run `cd EmbeddingTest.Windows`
- Run `dotnet publish -c Release`
- Run `.\Bin\Windows\Release\win-x64\publish\EmbeddingTest.Windows.exe`

Notice it doesn't run, this is due to the lack of support for Costura.Fody.

Now let's see if it works without Fody. Delete FodyWeavers.xml, publish again using the steps above, and notice it runs perfectly fine.
