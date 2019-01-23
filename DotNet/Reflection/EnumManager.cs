using System;
using System.Data;
using System.Reflection;

namespace DotNet.Reflection
{ 
    public static class EnumManager<TEnum>
    {
        private static DataTable GetDataTable()
        {
            Type t = typeof (TEnum);
            FieldInfo[] fieldInfos = t.GetFields();

            DataTable table=new DataTable();
            table.Columns.Add("Name", Type.GetType("System.String"));
            table.Columns.Add("Value", Type.GetType("System.Int32"));

            foreach (FieldInfo field in fieldInfos)
            {
                if (field.IsSpecialName)
                {
                    DataRow row = table.NewRow();
                    row[0] = field.Name;
                    row[1] = Convert.ToInt32(field.GetRawConstantValue());
                    table.Rows.Add(row);
                }
            }

            return table;
        }

        //public static void SetDropDownList(ListControl list)
        //{
        //    list.DataSource = GetDataTable();
        //    list.DataTextField = "Name";
        //    list.DataValueField = "Value";
        //    list.DataBind();
        //} 
    }
}