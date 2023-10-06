using System.Data;
namespace SwiftGrid.Test;
[TestFixture]
public class SwiftGridTests
{
    [Test]
    public void ToDataTable_ConvertsIEnumerableToDataTable()
    {
        // Arrange
        var data = new List<Person>
        {
            new Person { Id = 1, Name = "John", Age = 30 },
            new Person { Id = 2, Name = "Jane", Age = 25 },
        };

        // Act
        DataTable dataTable = data.ToDataTable();

        // Assert
        Assert.IsNotNull(dataTable);
        Assert.That(dataTable.Columns.Count, Is.EqualTo(3)); // 3 properties in Person class
        Assert.That(dataTable.Rows.Count, Is.EqualTo(2)); // 2 items in the list
    }

    [Test]
    public void ToDataTable_ThrowsExceptionForEmptySource()
    {
        // Arrange
        var data = new List<Person>();

        // Act and Assert
        Assert.Throws<InvalidOperationException>(() => data.ToDataTable());
    }

    [Test]
    public void ToDataTable_ThrowsExceptionForNonPropertyClass()
    {
        // Arrange
        var data = new List<NonPropertyClass>
        {
            new NonPropertyClass()
        };

        // Act and Assert
        Assert.Throws<InvalidOperationException>(() => data.ToDataTable());
    }
}

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public class NonPropertyClass
{
    // This class has no properties
}
