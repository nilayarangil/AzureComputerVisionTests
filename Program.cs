// See https://aka.ms/new-console-template for more information
using ComputerVisionTest;

Console.WriteLine("Hello, World!");
string subkey = "computer vision instance key";
string endpnt = "https://nilayazurecompvisioninstance.cognitiveservices.azure.com/";
ImageAnalyser IA = new ImageAnalyser(subkey, endpnt);

// Let the user pick which file to analyze
string? imagePath = @"C:\Projects\ComputerVisionTest\images\nilaytest.jpg";// ImageSelectionHelper.SelectImage(Directory.GetFiles("images"));

// The user is allowed to not pick an image, in which case we just exit
if (string.IsNullOrWhiteSpace(imagePath)) return;

// Have Computer Vision analyze the image            
List<string> detectedItems = IA.DetectItemsAsync(imagePath).Result;

IEnumerable<string> itemsToMention = detectedItems.Distinct().Take(5);
string message = $"Nothing to bark at, but here's some things I saw: {string.Join(", ", itemsToMention)}";
Console.WriteLine(message);

