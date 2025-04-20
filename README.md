# HelloWorld Component for 1C:Enterprise 7.7

This is a simple external component for 1C:Enterprise 7.7 that demonstrates how to create and use COM components.

## Building the Component

1. Open the solution in Visual Studio
2. Build the project in Release mode
3. The output will be `HelloWorldComponent.dll`

## Release Process

The component is automatically built and released when you push a tag starting with 'v' (e.g., v1.0.0) to GitHub. The release will include the compiled DLL.

To create a new release:

```bash
git tag v1.0.0
git push origin v1.0.0
```

## Registering the Component

To register the component, run the following command as Administrator:

```
regasm HelloWorldComponent.dll /codebase
```

## Using in 1C:Enterprise 7.7

In your 1C:Enterprise 7.7 code, you can use the component like this:

```1c
Перем Компонента;

Процедура Тест()
    ЗагрузитьВнешнююКомпоненту("C:\Path\To\HelloWorldComponent.dll");
    Сообщить(Компонента.HelloWorld());
КонецПроцедуры
```

## Notes

- Make sure the component is registered in the system
- The component must be accessible to the 1C:Enterprise process
- The GUIDs in the code are examples - you should generate your own unique GUIDs for production use
- The path to the DLL must be absolute 