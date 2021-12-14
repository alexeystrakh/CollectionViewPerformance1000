using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace CollectionViewPerfXamarin.ViewModels
{
    public class MainPageViewModel : NotifyPropertyChangedBase
    {
        private readonly Random _random = new Random();

        public string Test { get; } = "Hello 1";

        public ObservableCollection<DataItem> Items { get; } = new ObservableCollection<DataItem>();

        public MainPageViewModel()
        {
            for (int i = 0; i < 1000; i++)
            {
                Items.Add(new DataItem { Key = $"Item {i}", });
            }

            RandomizeData();
        }

        private async Task RandomizeData()
        {

            while (true)
            {
                foreach (var item in Items)
                {
                    item.Col1 = _random.Next(-100, 100) / 100d;
                    item.Col2 = _random.Next(-100, 100) / 100d;
                    item.Col3 = _random.Next(-100, 100) / 100d;
                    item.Col4 = _random.Next(-100, 100) / 100d;
                    item.Col5 = _random.Next(-100, 100) / 100d;
                    item.Col6 = _random.Next(-100, 100) / 100d;
                    item.Col7 = _random.Next(-100, 100) / 100d;
                    item.Col8 = _random.Next(-100, 100) / 100d;
                    item.Col9 = _random.Next(-100, 100) / 100d;
                    item.Col10 = _random.Next(-100, 100) / 100d;
                    item.Col11 = _random.Next(-100, 100) / 100d;
                    item.Col12 = _random.Next(-100, 100) / 100d;
                    item.Col13 = _random.Next(-100, 100) / 100d;
                    item.Col14 = _random.Next(-100, 100) / 100d;
                    item.Col15 = _random.Next(-100, 100) / 100d;
                    item.Col16 = _random.Next(-100, 100) / 100d;
                    item.Col17 = _random.Next(-100, 100) / 100d;
                    item.Col18 = _random.Next(-100, 100) / 100d;
                    item.Col19 = _random.Next(-100, 100) / 100d;
                    item.Col20 = _random.Next(-100, 100) / 100d;
                }

                await Task.Delay(500);
            }
        }
    }

    public class DataItem : NotifyPropertyChangedBase
    {
        private double _col1;
        private double _col2;
        private double _col3;
        private double _col4;
        private double _col5;
        private double _col6;
        private double _col7;
        private double _col8;
        private double _col9;
        private double _col10;
        private double _col11;
        private double _col12;
        private double _col13;
        private double _col14;
        private double _col15;
        private double _col16;
        private double _col17;
        private double _col18;
        private double _col19;
        private double _col20;

        public string Key { get; set; }
        public double Col1 { get => _col1; set => RaiseAndUpdate(ref _col1, value); }
        public double Col2 { get => _col2; set => RaiseAndUpdate(ref _col2, value); }
        public double Col3 { get => _col3; set => RaiseAndUpdate(ref _col3, value); }
        public double Col4 { get => _col4; set => RaiseAndUpdate(ref _col4, value); }
        public double Col5 { get => _col5; set => RaiseAndUpdate(ref _col5, value); }
        public double Col6 { get => _col6; set => RaiseAndUpdate(ref _col6, value); }
        public double Col7 { get => _col7; set => RaiseAndUpdate(ref _col7, value); }
        public double Col8 { get => _col8; set => RaiseAndUpdate(ref _col8, value); }
        public double Col9 { get => _col9; set => RaiseAndUpdate(ref _col9, value); }
        public double Col10 { get => _col10; set => RaiseAndUpdate(ref _col10, value); }
        public double Col11 { get => _col11; set => RaiseAndUpdate(ref _col11, value); }
        public double Col12 { get => _col12; set => RaiseAndUpdate(ref _col12, value); }
        public double Col13 { get => _col13; set => RaiseAndUpdate(ref _col13, value); }
        public double Col14 { get => _col14; set => RaiseAndUpdate(ref _col14, value); }
        public double Col15 { get => _col15; set => RaiseAndUpdate(ref _col15, value); }
        public double Col16 { get => _col16; set => RaiseAndUpdate(ref _col16, value); }
        public double Col17 { get => _col17; set => RaiseAndUpdate(ref _col17, value); }
        public double Col18 { get => _col18; set => RaiseAndUpdate(ref _col18, value); }
        public double Col19 { get => _col19; set => RaiseAndUpdate(ref _col19, value); }
        public double Col20 { get => _col20; set => RaiseAndUpdate(ref _col20, value); }
    }
}