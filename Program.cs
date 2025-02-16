// See https://aka.ms/new-console-template for more information
using ComputerVisionTest;

string subkey = "yourkey";
string endpnt = "https://nilayazurecompvisioninstance.cognitiveservices.azure.com/";
ImageAnalyser IA = new ImageAnalyser(subkey, endpnt);

// Let the user pick which file to analyze
string? imagePath = @"C:\Projects\ComputerVisionTest\images\nilaytest.jpg";// ImageSelectionHelper.SelectImage(Directory.GetFiles("images"));

// The user is allowed to not pick an image, in which case we just exit
if (string.IsNullOrWhiteSpace(imagePath)) return;

// Have Computer Vision analyze the image            
List<string> detectedItems = IA.DetectItemsAsync(imagePath).Result;

IEnumerable<string> itemsToMention = detectedItems.Distinct().Take(5);
string message = $"Summary: {string.Join(", ", itemsToMention)}";
Console.WriteLine(message);

