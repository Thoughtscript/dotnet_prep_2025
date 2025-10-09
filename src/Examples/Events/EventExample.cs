// Really helpful and clean Pub Sub example: 
// https://github.com/ggagnaux/CSharp-Publisher-Subscriber-Demo/tree/master/PublisherSubscriberDemo
namespace CustomEvents
{
    class EventExample
    {
        public static void Run()
        {
            Console.WriteLine("============== ExampleVisibility ==============");
            CustomEventPublisher customEventPublisher = new CustomEventPublisher();
            CustomEventSubscriber customEventSubscriber = new CustomEventSubscriber(customEventPublisher);
            customEventSubscriber.SubscribeToPublisher();
            customEventPublisher.Send();
        }
    }
}