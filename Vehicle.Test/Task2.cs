using NUnit.Framework;
using System;
using System.Linq;

namespace Vehicle.Test
{
    public class Tests
    {
        private string[] _nameTypes;
        [SetUp]
        public void Setup()
        {
            _nameTypes = new string[] {
                nameof(Car),
                nameof(Motosycle),
                nameof(Bike),
                nameof(Bus)
            };


        }

        [Test]
        public void Get_Instances_Car_class_ResultTrue()
        {
            var result = InstanceService<Car>.GetInstances();

            Assert.IsTrue(result.All(r=> r is Car));
        }

        [Test]
        public void Get_Instances_Vehicle_class_ResultTrue()
        {
            var result = InstanceService<Vehicle>.GetInstances();
            Assert.IsTrue(result.All(r => _nameTypes.Contains(r.GetType().Name)));
        }
    }
}