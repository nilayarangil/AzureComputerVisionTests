<!-----



Conversion time: 0.475 seconds.


Using this Markdown file:

1. Paste this output into your source file.
2. See the notes and action items below regarding this conversion run.
3. Check the rendered output (headings, lists, code blocks, tables) for proper
   formatting and use a linkchecker before you publish this page.

Conversion notes:

* Docs to Markdown version 1.0β44
* Sun Feb 16 2025 10:20:51 GMT-0800 (PST)
* Source doc: Untitled document
----->



# **Computer Vision Test**

This project demonstrates how to use the Azure Computer Vision API to analyze images and extract useful information such as tags, objects, and descriptions.


## **Prerequisites**

Before running this project, ensure you have the following:



* **.NET SDK** installed on your system
* **Azure Cognitive Services - Computer Vision API key**
* **Azure Cognitive Services endpoint**
* **An image file for testing**


## **Setup**

Clone this repository: \
git clone https://github.com/yourusername/ComputerVisionTest.git



1. cd ComputerVisionTest
2. Open the project in your preferred IDE (Visual Studio, VS Code, etc.).

Replace the placeholder values in `program.cs` with your actual Azure subscription key and endpoint: \
string subkey = "yourkey";



3. string endpnt = "https://yourazureendpoint.cognitiveservices.azure.com/";
4. Ensure you have an image file at the specified path or modify the path in `program.cs` accordingly: \
string? imagePath = @"C:\Projects\ComputerVisionTest\images\test.jpg";


## **Usage**

To run the application:

dotnet run


### **Features**



* Uses **Azure Computer Vision API** to analyze images
* Detects objects, tags, categories, and descriptions
* Displays results in the console


## **Code Structure**



* `Program.cs`: Entry point of the application
* `ImageAnalyser.cs`: Handles image processing and API calls


## **Output Example**

After running the application, you should see output like:

Analyzing C:\Projects\ComputerVisionTest\images\test.jpg...

Description:

A scenic view of a mountain (Confidence: 95%)

Objects:

Tree (Confidence: 90%) at (50,100):(150,300)

Tags:

Mountain (Confidence: 95%)

Cloud (Confidence: 89%)

<!-----



Conversion time: 0.404 seconds.


Using this Markdown file:

1. Paste this output into your source file.
2. See the notes and action items below regarding this conversion run.
3. Check the rendered output (headings, lists, code blocks, tables) for proper
   formatting and use a linkchecker before you publish this page.

Conversion notes:

* Docs to Markdown version 1.0β44
* Sun Feb 16 2025 12:52:24 GMT-0800 (PST)
* Source doc: Untitled document
----->



# **ExtractTextFromNotes**


## **Overview**

This project demonstrates how to use the Azure Cognitive Services Computer Vision API to extract text from an image file using a URL. The implementation is written in C# and utilizes the `Microsoft.Azure.CognitiveServices.Vision.ComputerVision` package.


## **Prerequisites**

To run this project, you will need:



* **Azure Subscription**: Sign up at[ Azure Portal](https://portal.azure.com/) if you don’t have an account.
* **Computer Vision Resource**: You need an Azure Computer Vision resource with an endpoint and API key.
* **.NET Core SDK**: Install the latest version from[ here](https://dotnet.microsoft.com/download/dotnet).


## **Installation**



1. Clone this repository or copy the `ExtractTextFromNotes.cs` file into your project.

Install necessary NuGet packages: \
dotnet add package Microsoft.Azure.CognitiveServices.Vision.ComputerVision



2. dotnet add package Newtonsoft.Json
3. Update your `appsettings.json` or environment variables with:
    * `AzureComputerVisionKey`: Your API key
    * `AzureComputerVisionEndpoint`: Your endpoint


## **Usage**

Modify your `Main` method to call `ReadFileUrl` with appropriate parameters:

using System;

using System.Threading.Tasks;

namespace ComputerVisionTest

{

    class Program

    {

        static async Task Main(string[] args)

        {

            string imageUrl = "YOUR_IMAGE_URL_HERE";

            string key = "YOUR_AZURE_COMPUTER_VISION_KEY";

            string endpoint = "YOUR_AZURE_COMPUTER_VISION_ENDPOINT";

            

            await ExtractTextFromNotes.ReadFileUrl(imageUrl, key, endpoint);

        }

    }

}


## **How It Works**



1. The `ReadFileUrl` method sends a request to Azure Computer Vision API with an image URL.
2. It retrieves an operation ID and waits for processing to complete.
3. The extracted text is then printed to the console.


## **Example Output**

----------------------------------------------------------

READ FILE FROM URL

Extracting text from URL file example.png...

Hello, this is a sample text extracted from an image.

## **License**

This project is licensed under the MIT License.
