using SampleProject.SampleServices.Abstraction;

namespace SampleProject.SampleServices
{
    public class Service2 : IService2
    {
        private readonly IService1 _service1;

        public Service2(IService1 service1)
        {
            _service1 = service1;
        }
    }
}