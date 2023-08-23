using System.ComponentModel;
using System.Data;

namespace MinimalDriverDataAccess.Extensions
{
    public static class DataTableExtensions
    {
        public static DataTable ToDataTable<T>(this List<T> list)
        {
            DataTable dataTable = new DataTable();
            PropertyDescriptorCollection propertyDescriptorCollection = TypeDescriptor.GetProperties(typeof(T));

            foreach(PropertyDescriptor propertyDescriptor in propertyDescriptorCollection)
            {
                Type type = propertyDescriptor.PropertyType;

                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    type = Nullable.GetUnderlyingType(type);
                }

                dataTable.Columns.Add(propertyDescriptor.Name, type);
            }

            object[] values = new object[propertyDescriptorCollection.Count];
            foreach (T listItem in list)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = propertyDescriptorCollection[i].GetValue(listItem);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
    }
}
