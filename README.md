# Large Number of Rows DataGrid

This project demonstrates a very poor performing WPF application.
I found the problem on a much more complex project. I had an application that was loading 7,000
rows of data and presented the data in an XCeedDataGrid. However, the same issue can be demonstrated with 
the native WPF data grid.

The problem boils down to having a DataGrid as a child of a ScrollViewer. Generally this is not necessary
since the DataGrid itself will present it's content inside a ScrollViewer. The solution is to remove the
ScrollViewer as the parent of the DataGrid.

You can see this problem by looking at MainWindow.xaml.
