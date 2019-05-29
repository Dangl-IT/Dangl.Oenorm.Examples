# Dangl.Oenorm.Examples

> A more detailed feature description is available [on my website](https://www.dangl-it.com/products/oenorm-library/).

> This project requires **Visual Studio 2017** or newer. Otherwise, the Dotnet CLI is also supported. For **Visual Studio 2015 and older**, please
> switch to the `vs2013` branch of this repository: [https://github.com/Dangl-IT/Dangl.Oenorm.Examples/tree/vs2013](https://github.com/Dangl-IT/Dangl.Oenorm.Examples/tree/vs2013)

This is a _demonstration_ library intended to show the usage of the Dangl.Oenorm project.
To build this solution, you need to copy the packages from the evaluation bundle into the `./localPackages` folder, relative to the root of this project:

You can find a summary article at our website: [https://www.dangl-it.com/articles/convert-between-oenorm-2063-and-gaeb-files-with-danglava-dangloenorm-and-danglgaeb/](https://www.dangl-it.com/articles/convert-between-oenorm-2063-and-gaeb-files-with-danglava-dangloenorm-and-danglgaeb/)

> If you are already a customer with support contract, please see any of the packages documentation on how to set up the official NuGet feed for **DanglIT** packages.

These packages are not included in this repository.
This project is intended to demonstrate the usage of the Dangl.Oenorm library.
[Please get in touch with me if you are interested in the libraries](https://www.dangl-it.com/contact/?message=I%27m+interested+in+Dangl.GAEB+%26+Dangl.AVA.+Please+contact+me.).

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
