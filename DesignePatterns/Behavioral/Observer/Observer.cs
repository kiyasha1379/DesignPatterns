

namespace DesignePatterns.Behavioral.Observer
{
    public class NewsAgency
    {
        public event Action<string> NewsPublished;

        public void PublishNews(string news)
        {
            Console.WriteLine($"[Agency] Published: {news}");
            NewsPublished?.Invoke(news); // notify observer
        }
    }

    // Observer 
    public class Subscriber
    {
        public string Name { get; }
        public Subscriber(string name) => Name = name;

        public void ReceiveNews(string news)
        {
            Console.WriteLine($"[{Name}] received news: {news}");
        }
    }
}
