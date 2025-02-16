using ComputerVisionTest;

string subkey = "yourkey";
string endpnt = "https://nilayazurecompvisioninstance.cognitiveservices.azure.com/";
ImageAnalyser IA = new ImageAnalyser(subkey, endpnt);

// Pass an Image to analyse.
string? imagePath = @"C:\Projects\ComputerVisionTest\images\nilaytest.jpg";// ImageSelectionHelper.SelectImage(Directory.GetFiles("images"));
string? read_txt_from_image = "https://raw.githubusercontent.com/nilayarangil/AzureComputerVisionTests/refs/heads/master/images/notes1.jpg";

// The user is allowed to not pick an image, in which case we just exit
if (string.IsNullOrWhiteSpace(imagePath)) return;

// Have Computer Vision analyze the image            
List<string> detectedItems = IA.DetectItemsAsync(imagePath).Result;

//Extract text from Image
ComputerVisionTest.ExtractTextFromNotes.ReadFileUrl(read_txt_from_image, subkey, endpnt).Wait();