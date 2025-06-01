using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Large_Number_of_Rows_DataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<DataItem> DataItems { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataItems = GenerateLargeData(10_000); // Generate a large dataset 100K
            largeDataGrid.ItemsSource = DataItems;
        }

        private ObservableCollection<DataItem> GenerateLargeData(int count)
        {
            var data = new ObservableCollection<DataItem>();
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                data.Add(new DataItem
                {
                    Id = i + 1,
                    Name = $"Item {i + 1}",
                    Value = random.Next(1, 1000),
                    Description = $"This is a sample description for item {i + 1}.",
                    RiskRating = new RiskRating((RiskLevel)random.Next(1, 5)) // Randomly assign a risk level
                });
            }
            return data;
        }
    }

    public class DataItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }

        public RiskRating RiskRating { get; set; }
    }
}