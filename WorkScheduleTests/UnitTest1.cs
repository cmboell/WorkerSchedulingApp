using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WorkerSchedulingApp.Models;
using WorkerSchedulingApp.Controllers;
namespace WorkScheduleTests
{
    //unit tests for the app 
    public class UnitTest1
    {
    
        [Fact]
        public void IndexActionMethod_ReturnsViewResult()
        {
            // arrange
            var rep = new Mock<IRepository<Worker>>();
            var controller = new WorkerController(rep.Object);

            // act
            var result = controller.Index();

            // assert
            Assert.IsType<ViewResult>(result);
        }
            [Fact]
        public void ActionMethodReturnsViewResultForHomeController()
        {
            // arrange
            var unit = new Mock<IWorkScheduleUnitOfWork>();
            var positions = new Mock<IRepository<Position>>();
            var days = new Mock<IRepository<Day>>();
            unit.Setup(r => r.Positions).Returns(positions.Object);
            unit.Setup(r => r.Days).Returns(days.Object);

            var http = new Mock<IHttpContextAccessor>();

            var controller = new HomeController(unit.Object, http.Object);

            // act
            var result = controller.Index(0);

            // assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void IndexActionMethodThatReturnsViewResultForWorkerController()
        {
            // arrange
            var rep = new Mock<IRepository<Worker>>();
            var controller = new WorkerController(rep.Object);

            // act
            var result = controller.Index();

            // assert
            Assert.IsType<ViewResult>(result);

        }
    }
}
