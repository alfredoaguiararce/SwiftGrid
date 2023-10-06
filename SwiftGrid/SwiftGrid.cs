using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

public static class SwiftGrid
{
    /// <summary>
    /// Converts an IEnumerable collection of objects into a DataTable.
    /// </summary>
    /// <typeparam name="T">The type of objects in the collection.</typeparam>
    /// <param name="source">The IEnumerable collection to convert.</param>
    /// <returns>A DataTable containing the data from the IEnumerable collection.</returns>
    public static DataTable ToDataTable<T>(this IEnumerable<T> source)
    {

        // If the list its empty prevent errors.
        if (source.Count() == 0) throw new InvalidOperationException("The source must contain items to a DataTable.");

        // Create a new DataTable to hold the data
        DataTable dataTable = new DataTable();

        // If the source collection is null or empty, return an empty DataTable
        if (source == null || !source.Any())
            return dataTable;

        // Get the properties of the objects in the collection
        var properties = typeof(T).GetProperties();

        // If there are no properties, throw an exception
        if (properties.Length == 0) throw new InvalidOperationException("The source must contain objects with properties to convert to a DataTable.");

        // Create DataTable columns based on the object properties
        foreach (var property in properties)
        {
            dataTable.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
        }

        // Populate the DataTable with data from the collection
        foreach (var item in source)
        {
            DataRow row = dataTable.NewRow();
            foreach (var property in properties)
            {
                // Set the column value to the property value, handling nulls
                row[property.Name] = property.GetValue(item) ?? DBNull.Value;
            }
            dataTable.Rows.Add(row);
        }

        return dataTable;
    }
}
