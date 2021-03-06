﻿using Microsoft.Azure.Devices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Services
{
    public class ServiceClientService
    {
        private ServiceClient serviceClient;

        public ServiceClientService(string connectionstring)
        {
            serviceClient = ServiceClient.CreateFromConnectionString(connectionstring);
        }

        public async Task<CloudToDeviceMethodResult> InvokeMethodAsync(string targetDevice, string methodName, string payload)
        {
            var methodInvocation = new CloudToDeviceMethod(methodName);
            methodInvocation.SetPayloadJson(payload);

            var response = await serviceClient.InvokeDeviceMethodAsync(targetDevice, methodInvocation);
            return response;
        }
    }
}
