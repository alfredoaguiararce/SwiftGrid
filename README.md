# SwiftGrid

![https://img.shields.io/badge/License-MIT-yellow.svg](https://img.shields.io/badge/License-MIT-yellow.svg)

SwiftGrid is a C# library for fast and efficient data table creation and manipulation. It provides a simple yet powerful way to convert collections of objects into DataTables, making data handling in C# a breeze.

## Features ✨

- Convert `IEnumerable` collections into DataTables with ease.
- Handle data transformation efficiently.
- Suitable for structured data management tasks.
- Minimal setup required.

## Installation 📦

To use SwiftGrid in your C# project, you can install it via NuGet Package Manager:

```powershell
dotnet add package SwiftGrid
```

## **Usage 🚀**

Here's how to use SwiftGrid in your C# code:

```csharp
csharpCopy code
using SwiftGrid;
// ...
var data = new List<Person>
{
    new Person { Id = 1, Name = "John", Age = 30 },
    new Person { Id = 2, Name = "Jane", Age = 25 }
};

DataTable dataTable = data.ToDataTable();

```

## **Contributing 🤝**

Contributions are welcome! If you find any issues or have ideas for improvements, please open an issue or create a pull request.

## **License 📄**

This project is licensed under the MIT License.

## **Acknowledgments 🙏**

Special thanks to the open-source community for their valuable contributions.

## **Contact 📧**

For questions or feedback, feel free to contact me at [alfredoaguiararce@gmail.com](mailto:alfredoaguiararce@gmail.com).

Happy coding! 🎉