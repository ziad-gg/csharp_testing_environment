using Builders;

namespace Project
{
    class Frame
    {
        static void Main(string[] args)
        {
            EmbedBuilder embed = new EmbedBuilder();
            embed.setTitle("Hello, world!");
            embed.setDescription("This is an example description.");
            embed.setImage("https://example.com/image.jpg");

            string[] footer = embed.setFooter("Footer text", "https://example.com/icon.png");
            Console.WriteLine($"Title: {embed.Title}");
            Console.WriteLine($"Description: {embed.Description}");
            Console.WriteLine($"Image URL: {embed.ImageURL}");
            Console.WriteLine($"Footer Text: {footer[0]}");
            Console.WriteLine($"Footer Icon URL: {footer[1]}");

           int me = Bla(1);
           me.GetType();
        }

        static T Bla<T>(T type) {
           return type; 
        }
    }
}
