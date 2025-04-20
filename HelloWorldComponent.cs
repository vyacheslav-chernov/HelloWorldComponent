using System;
using System.Runtime.InteropServices;

namespace HelloWorldComponent
{
    [ComVisible(true)]
    [Guid("12345678-1234-1234-1234-123456789012")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IHelloWorldComponent
    {
        [DispId(1)]
        string HelloWorld();
    }

    [ComVisible(true)]
    [Guid("87654321-4321-4321-4321-210987654321")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("HelloWorldComponent.HelloWorld")]
    public class HelloWorldComponent : IHelloWorldComponent
    {
        public string HelloWorld()
        {
            return "Hello World from C# Component!";
        }
    }
} 