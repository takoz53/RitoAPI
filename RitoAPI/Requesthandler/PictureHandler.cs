using System.Drawing;
using System.Resources;

namespace RitoAPI.Requesthandler
{
    public class PictureHandler
    {
        public Bitmap LoadPicture(string championName)
        {
            if (championName.Contains("'"))
                championName = championName.Replace("'", "");
            if (championName.Contains(" "))
                championName = championName.Replace(" ", "");

            // Treat special cases
            if (championName == "ChoGath")
                championName = "Chogath";
            else if (championName == "Dr.Mundo")
                championName = "DrMundo";
            else if (championName == "Fiddlesticks")
                championName = "FiddleSticks";
            else if (championName == "KaiSa")
                championName = "Kaisa";
            else if (championName == "KhaZix")
                championName = "Khazix";
            else if (championName == "LeBlanc")
                championName = "Leblanc";
            else if (championName == "Wukong")
                championName = "MonkeyKing";
            else if (championName == "Nunu&Willump")
                championName = "Nunu";
            else if (championName == "VelKoz")
                championName = "Velkoz";

            object resource = Resources.Resources.ResourceManager.GetObject(championName);
            var picture = (Bitmap) resource;
            return picture;
        }
    }
}
