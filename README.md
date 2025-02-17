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
```
git clone https://github.com/yourusername/ComputerVisionTest.git
```


1. cd ComputerVisionTest
2. Open the project in your preferred IDE (Visual Studio, VS Code, etc.).

Replace the placeholder values in `program.cs` with your actual Azure subscription key and endpoint: \
string subkey = "yourkey";

3. string endpnt = "https://yourazureendpoint.cognitiveservices.azure.com/";
4. Ensure you have an image file at the specified path or modify the path in `program.cs` accordingly: \
string? imagePath = @"C:\Projects\ComputerVisionTest\images\test.jpg";


## **Usage**

To run the application:
```
dotnet run
```

### **Features**



* Uses **Azure Computer Vision API** to analyze images
* Detects objects, tags, categories, and descriptions
* Displays results in the console


## **Code Structure**



* `Program.cs`: Entry point of the application
* `ImageAnalyser.cs`: Handles image processing and API calls

## **How It Works**

### 

```
    public ImageAnalyser(string subscriptionKey, string endpoint)
```

* **Parameters:**
    * `subscriptionKey`: Azure API subscription key for authentication.
    * `endpoint`: URL of the Azure Computer Vision service.
* Initializes a `ComputerVisionClient` with the provided credentials.

## **Methods**


### **1. <code>DetectItemsAsync</code> Method**

```
    public async Task<List<string>> DetectItemsAsync(string filePath)
```

* **Parameter:** `filePath` (local path of the image file).
* **Returns:** A list of detected image elements such as captions, objects, and tags.
* **Process:**
    1. Reads the image from the file.
    2. Calls Azure's Computer Vision API to analyze the image.
    3. Extracts detected captions, objects, tags, and categories.
    4. Returns a list of extracted text elements.
 
  ## **Input Example**
![Alt text](https://raw.githubusercontent.com/nilayarangil/AzureComputerVisionTests/refs/heads/master/images/nilaytest.jpg)

### **2. <code>ListVisionCaptions</code> Method**

```
     private IEnumerable<string> ListVisionCaptions(ImageAnalysis imageAnalysis)
```
* **Extracts captions** generated by the Vision API.
* **Prints** the captions with confidence scores.
* **Returns:** A list of captions.

### **3. <code>ListVisionCategories</code> Method**
```
    private IEnumerable<string> ListVisionCategories(ImageAnalysis imageAnalysis)
```

* Extracts **categories** associated with the image.
* Prints category names and confidence scores.
* Returns a list of detected **categories**.

### **4. <code>ListVisionObjects</code> Method**

```
 private IEnumerable<string> ListVisionObjects(ImageAnalysis imageAnalysis)
```
* Extracts **detected objects** in the image.
* Prints object name, confidence score, and bounding box.
* Returns a list of detected **objects**.

### **5. <code>ListVisionTags</code> Method**
```
       private IEnumerable<string> ListVisionTags(ImageAnalysis imageAnalysis)
```
* Extracts **tags** related to the image.
* Prints tag names and confidence scores.
* Returns a list of detected **tags**.

## **Output Example**

After running the application, you should see output like:

![Alt text](https://raw.githubusercontent.com/nilayarangil/AzureComputerVisionTests/refs/heads/master/images/imageoutput.jpg)
##  **Key Features**

* Uses **Azure's Computer Vision API** to analyze images.
* Extracts multiple attributes: **Captions, Tags, Categories, Objects**.
* Displays confidence levels for each detected element.
* Supports **local image file processing**.
  
<!-----
Using this Markdown file:

1. Paste this output into your source file.
2. See the notes and action items below regarding this conversion run.
3. Check the rendered output (headings, lists, code blocks, tables) for proper
   formatting and use a linkchecker before you publish this page.

Conversion notes:
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
```
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
```
## **How It Works**


### **1. Initialize the Computer Vision Client**

## **Example Input**
![Alt text](https://raw.githubusercontent.com/nilayarangil/AzureComputerVisionTests/refs/heads/master/images/notes1.jpg)

```
ComputerVisionClient client =

  new ComputerVisionClient(new ApiKeyServiceClientCredentials(key))

  { Endpoint = endpoint };

```

* Creates an instance of `ComputerVisionClient` using the provided API key and endpoint.


### **2. Send Image URL for OCR Processing**
```
var textHeaders = await client.ReadAsync(urlFile);

```

* Sends a request to Azure's **Read API** to extract text from the image at the given URL.


### **3. Retrieve Operation ID**
```
string operationLocation = textHeaders.OperationLocation;

Thread.Sleep(2000);

const int numberOfCharsInOperationId = 36;

string operationId = operationLocation.Substring(operationLocation.Length - numberOfCharsInOperationId);
```


* Extracts the **Operation ID** from the response to track the OCR process.
* Introduces a **2-second delay** (`Thread.Sleep(2000)`) to allow the service time to process the request.


### **4. Wait for OCR Completion**
```
do

{

    results = await client.GetReadResultAsync(Guid.Parse(operationId));

}

while ((results.Status == OperationStatusCodes.Running ||

    results.Status == OperationStatusCodes.NotStarted));
```

* The method repeatedly checks the status of the OCR process until it is **completed**.


### **5. Extract and Display Recognized Text**

```
var textUrlFileResults = results.AnalyzeResult.ReadResults;

foreach (ReadResult page in textUrlFileResults)

{

    foreach (Line line in page.Lines)

    {

        Console.WriteLine(line.Text);

    }

}
```


* Iterates through the extracted text results and prints each detected line.
  
## **Example Output**

----------------------------------------------------------

READ FILE FROM URL

Extracting text from URL file notes1.jpg...

![Alt text](https://raw.githubusercontent.com/nilayarangil/AzureComputerVisionTests/refs/heads/master/images/output.jpg)

## **Summary**

This method:

1. **Sends an image URL** to Azure's Read API.
2. **Extracts an operation ID** to track the OCR process.
3. **Waits** for the operation to complete.
4. **Retrieves and prints** the extracted text.
