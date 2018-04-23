using System;
using System.Data;
using System.Collections.Generic;

namespace MvcApp_Q367963 {
    public class InMemoryModel {
        const int DataItemsCount = 10;

        public static DataTable GetDataTableModel() {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ProductID", typeof(int));
            dataTable.Columns.Add("ProductName", typeof(string));

            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["ProductID"] };

            Random randomizer = new Random();

            for (int index = 0; index < DataItemsCount; index++) {
                dataTable.Rows.Add(
                    index,
                    "Name_" + index.ToString()
                );
            }

            return dataTable;
        }
    }
}

