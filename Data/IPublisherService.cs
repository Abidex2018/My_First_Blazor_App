using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_First_Blazor_App.Data
{
    public interface IPublisherService
    {
        List<Publisher> GetPublishers();
        Publisher GetPublisherById(string pubId);
        bool SavePublisher(Publisher publisher);
        void DeletePublisher(string pubId);
    }
}
