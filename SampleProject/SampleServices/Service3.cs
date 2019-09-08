using SampleProject.SampleServices.Abstraction;

namespace SampleProject.SampleServices
{
    public class Service3 : IService3
    {
        private readonly IService1 _service1;
        private readonly IService2 _service2;

        public Service3(IService1 service1, IService2 service2)
        {
            _service1 = service1;
            _service2 = service2;
        }
    }
}