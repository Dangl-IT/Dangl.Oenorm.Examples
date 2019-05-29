# Dangl.Oenorm.Examples

**This branch is for older Visual Studio versions, 2015 and older. For Visual Studio 2017 and newer, please switch to the master branch of this repository.**  
**Please us the Dangl.Oenorm.Examples.VS2013.sln solution file.**

> A more detailed feature description is available [on my website](https://www.dangl-it.com/products/oenorm-library/).

> This project requires **Visual Studio 2017** or newer. Otherwise, the Dotnet CLI is also supported.

This is a _demonstration_ library intended to show the usage of the Dangl.Oenorm project.
To build this solution, you need to copy the packages from the evaluation bundle into the `./localPackages` folder, relative to the root of this project:

You can find a summary article at our website: [https://www.dangl-it.com/articles/convert-between-oenorm-2063-and-gaeb-files-with-danglava-dangloenorm-and-danglgaeb/](https://www.dangl-it.com/articles/convert-between-oenorm-2063-and-gaeb-files-with-danglava-dangloenorm-and-danglgaeb/)

> If you are already a customer with support contract, please see any of the packages documentation on how to set up the official NuGet feed for **DanglIT** packages.

These packages are not included in this repository.
This project is intended to demonstrate the usage of the Dangl.Oenorm library.
[Please get in touch with me if you are interested in the libraries](https://www.dangl-it.com/contact/?message=I%27m+interested+in+Dangl.GAEB+%26+Dangl.AVA.+Please+contact+me.).

## Running in Debug

To directly run the example, please configure the following arguments in Visual Studio command line arguments for debugging:

    -i "$(SolutionDir)\ExampleFiles\GAEBXML_DE.X86" -o "$(SolutionDir)\GaebExport.onlv"

Please replace `$(SolutionDir)` with the absolute path to the solution.

## .NET Core support

All modules for GAEB, Oenorm, Excel and other formats support both .NET Framework as well as .NET Core.

## CLI Interface

The console application is launched via

    dotnet Dangl.Oenorm.Examples.dll -i <InputFile> -o <OutputFile>

| Parameter | Description |
|-----------|-------------|
| -i | Path to an input GAEB file |
| -o | Path of the output file with extension. Will overwrite existing files |

## GAEB Example Files

You can find examples of GAEB files in the `ExampleFiles` folder in the solution root directory. They are available in German **DE** or English **EN** language and come in
all three formats - GAEB 90, GAEB 2000 and GAEB XML.
