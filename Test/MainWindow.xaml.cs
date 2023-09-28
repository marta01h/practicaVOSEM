using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary1;

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void SerializeButton_Click(object sender, RoutedEventArgs e)
        {
            var data = new { Name = "John", Age = 30 };
            string serializedData = DataSerializer.Serialize(data);

            // Удалите фигурные скобки из JSON-строки
            serializedData = serializedData.TrimStart('{').TrimEnd('}');

            ResultTextBlock.Text = $"Serialized Data: {serializedData}";
        }


        private void DeserializeButton_Click(object sender, RoutedEventArgs e)
        {
            string serializedData = "{'Name':'Alice','Age':25}";
            var deserializedData = DataSerializer.Deserialize<dynamic>(serializedData);
            ResultTextBlock.Text = $"Deserialized Data: Name: {deserializedData.Name}, Age: {deserializedData.Age}";
        }
    }
}
