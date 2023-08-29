
namespace Builders
{
    public interface IEmbed
    {
        string setTitle(string title);
        string setDescription(string description);
        string setImage(string img);
        string[] setFooter(string text, string? iconURL);
    }

    public abstract class Embed
    {
        private string _title = "";
        private string _description = "";

        public string Title
        {
            get { return _title; }
            set
            {
                if (value.Length > 100 || value.Length <= 0)
                {
                    throw new Exception("Embed title must be at length between 0 to 100");
                }
                else
                {
                    this._title = value;
                }
            }
        }

        public string Description
        {
            get 
            {
                return this._description;
            }
            set
            {
                if (value.Length > 500 || value.Length <= 0)
                {
                    throw new Exception("Embed description must be at length between 0 to 500");
                }
                else
                {
                    this._description = value;
                }
            }
        }

        public string ImageURL = "";
        public string[] Footer = new string[2]; // Changed to 2

        public abstract void JSON();
    }

    public class EmbedBuilder : Embed, IEmbed
    {
        public EmbedBuilder()
        {
            // Constructor code if needed
        }

        public override void JSON()
        {
            Console.WriteLine("Embeded override");
        }

        public override string ToString()
        {
            return "hello world";
        }

        public string setTitle(string title)
        {
            Title = title;
            return title;
        }

        public string setDescription(string description)
        {
            Description = description;
            return description;
        }

        public string setImage(string url)
        {
            ImageURL = url;
            return ImageURL;
        }

        public string[] setFooter(string text, string? iconURL)
        {
            Footer[0] = text;
            Footer[1] = iconURL ?? "";
            return Footer;
        }
    }
}

