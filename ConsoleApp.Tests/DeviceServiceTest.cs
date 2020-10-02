using SharedLibrary.Services;
using System;
using Xunit;

namespace ConsoleApp.Tests
{
    public class DeviceServiceTest
    {
        [Theory]
        [InlineData("DeviceApp", "SetInterval", "5", "200")]
        [InlineData("DeviceApp", "SetIntervall", "5", "501")]
        public void SetTelemetryServiceInterval_ShouldChangeInterval(string targetDevice, string methodName, string payload, string expected)
        {
            var service = new ServiceClientService("HostName=ec-win20-danarv.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=CANM5ASxGzkLx7EqULb6HKQBe1qsQ9I5Vem4lngcwLo=");
            var response = service.InvokeMethodAsync(targetDevice, methodName, payload);

            Assert.Equal(expected, response.Result.Status.ToString());
        }
    }
}
