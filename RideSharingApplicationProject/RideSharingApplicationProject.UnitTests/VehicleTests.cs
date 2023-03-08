namespace RideSharingApplicationProject.UnitTests
{
    public class VehicleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        //public void FunctionName_Scenario_BehaviourExpected()
        public void AddPassenger_EmptyVehicle_VehicleWithOnePassenger()
        {
            //Arrange
            Vehicle v = new Sedan(4, new Driver("Juan", DateTime.Now, "00", "01"));

            //Act
            v.AddPassenger(new Passenger("Pedro", DateTime.Now, "00"));

            //Assert
            Assert.AreEqual(v.CurrentNumberOfPassengers, 1);
        }

        [Test]
        public void AddPassenger_FullVehicle_StillFullVehicleWithSamePassengers()
        {
            //Arrange
            Vehicle v = new Sedan(4, new Driver("Juan", DateTime.Now, "00", "01"));
            Passenger[] p = new Passenger[4];
            p[0] = new Passenger("Bogart", DateTime.Now, "00");
            p[1] = new Passenger("Nana", DateTime.Now, "00");
            p[2] = new Passenger("Mikel", DateTime.Now, "00");
            p[3] = new Passenger("Zilong", DateTime.Now, "00");
            foreach (Passenger passenger in p)
                v.AddPassenger(passenger);

            //Act
            v.AddPassenger(null);

            //Asssert
            Passenger[] after = v.Passengers;
            for(int i=0; i < after.Length; i++)
                Assert.That(after[i], Is.EqualTo(p[i]));
            Assert.That(v.MaxCapacity, Is.EqualTo(v.CurrentNumberOfPassengers));
        }
    }
}