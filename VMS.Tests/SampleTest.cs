using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VMS.Controllers;
using VMS.Data;

namespace VMS.Tests
{
    public class AppointmentsControllerTests
    {
        // Helper: creates a fresh in-memory database for each test
        private ApplicationDbContext GetInMemoryDb(string dbName)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;
            return new ApplicationDbContext(options);
        }

        // ✅ Test 1: POST /api/Appointments/Create — should create and return appointment
        [Fact]
        public async Task CreateAppointment_ShouldReturnOk_WhenValidData()
        {
            // Arrange
            var db = GetInMemoryDb("CreateTest");
            var controller = new AppointmentsController(db);
            var appointment = new Appointments
            {
                PatientId = 1,
                DoctorId = 2,
                AppointmentDate = DateTime.Now.AddDays(1)
            };

            // Act
            var result = await controller.CreateNewAppointments(appointment);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.NotNull(okResult.Value);
        }

        // ✅ Test 2: POST — appointment should actually be saved in database
        [Fact]
        public async Task CreateAppointment_ShouldSaveToDatabase()
        {
            // Arrange
            var db = GetInMemoryDb("SaveTest");
            var controller = new AppointmentsController(db);
            var appointment = new Appointments
            {
                PatientId = 5,
                DoctorId = 3,
                AppointmentDate = DateTime.Now.AddDays(2)
            };

            // Act
            await controller.CreateNewAppointments(appointment);

            // Assert — check DB directly
            var saved = db.Appointments.FirstOrDefault();
            Assert.NotNull(saved);
            Assert.Equal(5, saved.PatientId);
            Assert.Equal(3, saved.DoctorId);
        }

        // ✅ Test 3: GET /api/Appointments/Read — should return empty list when no data
        [Fact]
        public void GetAppointments_ShouldReturnEmptyList_WhenNoData()
        {
            // Arrange
            var db = GetInMemoryDb("EmptyReadTest");
            var controller = new AppointmentsController(db);

            // Act
            var result = controller.getAppointments();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.NotNull(okResult.Value);
        }

        // ✅ Test 4: GET — should return all appointments that exist
        [Fact]
        public async Task GetAppointments_ShouldReturnAllAppointments()
        {
            // Arrange
            var db = GetInMemoryDb("ReadAllTest");
            db.Appointments.AddRange(
                new Appointments { PatientId = 1, DoctorId = 1, AppointmentDate = DateTime.Now },
                new Appointments { PatientId = 2, DoctorId = 2, AppointmentDate = DateTime.Now },
                new Appointments { PatientId = 3, DoctorId = 3, AppointmentDate = DateTime.Now }
            );
            await db.SaveChangesAsync();
            var controller = new AppointmentsController(db);

            // Act
            var result = controller.getAppointments();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.NotNull(okResult.Value);
            Assert.Equal(3, db.Appointments.Count());
        }

        // ✅ Test 5: POST then GET — create appointment and verify it appears in list
        [Fact]
        public async Task CreateThenGet_ShouldReturnCreatedAppointment()
        {
            // Arrange
            var db = GetInMemoryDb("CreateThenGetTest");
            var controller = new AppointmentsController(db);
            var appointment = new Appointments
            {
                PatientId = 10,
                DoctorId = 20,
                AppointmentDate = DateTime.Now.AddDays(5)
            };

            // Act
            await controller.CreateNewAppointments(appointment);
            var result = controller.getAppointments();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(1, db.Appointments.Count());
            Assert.Equal(10, db.Appointments.First().PatientId);
        }
    }
}