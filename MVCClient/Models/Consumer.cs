using System.Collections.Generic;

namespace MVCClient.Model
{
    public class ConsumerViewModel
    {
        public List<Consumer> consumers { get; set; }
        public ConsumerViewModel()
        {
            consumers = new List<Consumer>();
        }
    }

    public class Consumer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
    }
}